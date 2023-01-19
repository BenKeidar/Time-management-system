using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using Win1.Models;

namespace Win1.MyForms
{
    public partial class Overview : Form
    {
        //This is the overview page.
        Dictionary<string, Color> colors = new Dictionary<string, Color>();
        public Overview()
        {
            InitializeComponent();
            colors.Add("Urgent", Color.PaleVioletRed);
            colors.Add("Work", Color.MediumOrchid);
            colors.Add("Personal", Color.DarkTurquoise);
        }

        //This function loads the form.
        private void Overview_Load(object sender, EventArgs e)
        {
            hgOverview.Options.StartDate = DateTime.Now;
            LoadDailyEvents();
            LoadNextNotifications();
            LoadTasksStatus();
        }
        private void LoadTheme()
        {    
        }

        //This function loads the daily events from the DB to a list.
        void LoadDailyEvents()
        {
            try
            {
                DateTime today = DateTime.Today;
                string todaysDate = today.ToString().Substring(0, 10);
                string query = "select * from Events Where Start LIKE '%"+ todaysDate + "%';";
                List<MyEvents> eventsArr = DBhandler.GetEvents(query);
                AddEvents(eventsArr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //This function inserts the events into the calendar.
        void AddEvents(List<MyEvents> ev)
        {
            hgOverview.RemoveAll();
            foreach (MyEvents e in ev)
            {
                hgOverview.AddEvent(new Hourglass.HourglassEvent
                {
                    Id = e.Id,
                    BackColor = colors[e.Category],
                    Start = e.Start,
                    End = e.End,
                    Text = e.Text,
                    Tooltip = e.Description,
                });
            }
            hgOverview.Render();
        }

        //This function loads the notifications of today from the DB to the gridView.
        void LoadNextNotifications()
        {
            try
            {
                DateTime today = DateTime.Today;
                string todaysDate = today.Day.ToString() + "/" +
                   today.Month.ToString() + "/" +
                   today.Year.ToString();
                string query = "select * from Notifications Where NotifyTime LIKE '%" + todaysDate + "%';";
                List<MyNotification> notificationsArr = DBhandler.GetNotifications(query);
                notificationsGV.Rows.Clear();
                if (notificationsArr.Count == 0)
                    notificationsGV.Rows.Add(0, today, "None");
                else
                {
                    for (int i = 0; i < notificationsArr.Count; i++)
                    {
                        notificationsGV.Rows.Add(notificationsArr[i].Id, notificationsArr[i].Ntime, notificationsArr[i].Nmessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        
        //This function loads the task progress status.
        void LoadTasksStatus()
        {
            if (!DBhandler.thereIsNoTasks)
            {
                string query = "SELECT MAX(Id) FROM Tasks;";
                string query2 = "SELECT Count(Done) FROM Tasks WHERE Done="+1+";";
                int total = Convert.ToInt32(DBhandler.GetEventId(query) + 1);
                int done = Convert.ToInt32(DBhandler.GetEventId(query2));
                SetProgress(total, done);
            }
            else
                SetProgress(0, 0);
        }

        //This function sets the task progress status.
        private void SetProgress(int total, int done)
        {
            double t = total, d = done;
            int res = 0;
            if(t != 0)
                Convert.ToInt32(d / t * 100);
            myProgressBar.Value = res;
            if (res <= 25)
            {
                SetColors(Color.Red, Color.DarkRed);
            }
            else if (res <= 50)
            {
                SetColors(Color.Orange, Color.OrangeRed);
            }
            else if (res <= 75)
            {
                SetColors(Color.Yellow, Color.Gold);
            }
            else if (done < total)
            {
                SetColors(Color.GreenYellow, Color.SpringGreen);
            }
            else
            {
                SetColors(Color.Green, Color.SpringGreen);
            }
            myProgressBar.Text = done.ToString() + "/" + total.ToString();
        }
        public void SetColors(Color a, Color b)
        {
            myProgressBar.ProgressColor = a;
            myProgressBar.ProgressColor2 = b;
        }
    }
}