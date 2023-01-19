using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Win1.Dialogs;
using Win1.Models;

namespace Win1.MyForms
{
    //This is the Calendar form.
    public partial class Calendar : Form
    {
        private string TableName = "Events";
        public bool empty = true;
        Button currentBtn;
        Dictionary<string, Color> colors = new Dictionary<string, Color>();
        Hourglass.HourglassEvent last;
        public Calendar()
        {
            InitializeComponent();
            currentBtn = weekBtn;
            colors.Add("Urgent", Color.PaleVioletRed);
            colors.Add("Work", Color.MediumOrchid);
            colors.Add("Personal", Color.DarkTurquoise);
        }

        //This function loads the form.
        private void Calendar_Load(object sender, EventArgs e)
        {
            hg.Options.StartDate = monthCalendar1.SelectionStart;
            hg.Render();
            LoadTheme();
            init.Start();
        }

        //This function sets the buttons colors.
        private void LoadTheme()
        {
            dayBtn.ForeColor = ThemeColor.PrimaryColor;
            weekBtn.BackColor = ThemeColor.PrimaryColor;
            monthBtn.ForeColor = ThemeColor.PrimaryColor;
            addBtn.BackColor = ThemeColor.PrimaryColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            init.Stop();
            RemoveUnusedData();
            LoadData();
        }

        private void hgScheduler1_OnAferRender(object sender, EventArgs e)
        {
            if(this.Opacity == 0)
                this.Opacity = 1;
            init.Start();
        }

        //This function called when the user press on the 'day' button to set the viewType to day.
        private void dayBtn_Click(object sender, EventArgs e)
        {
            changeBtn(dayBtn);
            addBtn.Visible = true;
        }

        //This function called when the user press on the 'week' button to set the viewType to week.
        private void weekBtn_Click(object sender, EventArgs e)
        {
            changeBtn(weekBtn);
            addBtn.Visible = true;
        }

        //This function called when the user press on the 'month' button to set the viewType to month.
        private void monthBtn_Click(object sender, EventArgs e)
        {
            changeBtn(monthBtn);
            addBtn.Visible = false;
        }

        //This function changes the calendar viewType.
        private void changeBtn(Button btn)
        {
            if (currentBtn != btn)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = ThemeColor.PrimaryColor;
                btn.BackColor = ThemeColor.PrimaryColor;
                btn.ForeColor = Color.White;
                currentBtn = btn;
                if(btn == dayBtn)
                    hg.Options.ViewType = Hourglass.ViewTypes.Day;
                else if(btn == weekBtn)
                    hg.Options.ViewType = Hourglass.ViewTypes.Week;
                else
                    hg.Options.ViewType = Hourglass.ViewTypes.Month;
                hg.Render();
            }
        }

        //This function deletes events that ended more than 30 days ago from the DB.
        void RemoveUnusedData()
        {
            try
            {
                var monthBack = new DateTime();
                if (DateTime.Now.Month == 1)
                    monthBack = new DateTime(DateTime.Now.Year - 1, 12, DateTime.Now.Day);
                else
                    monthBack = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, DateTime.Now.Day);
                string query = "delete from " + TableName +
                   " where Ending > '" + monthBack + "';";
                DBhandler.ExecuteQuery(query);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This function loads the events from the DB to a list and filters the list by the event types checkboxes.
        void LoadData()
        {
            try
            { 
                string query = "select * from " + TableName + ";";
                List<MyEvents> eventsArr = DBhandler.GetEvents(query);
                if (eventsArr.Count == 0)
                    empty = true;
                else
                {
                    empty = false;
                    if (!PcheckBox.Checked)
                        eventsArr = eventsArr.Where(r => r.Category != "Personal").ToList();
                    if (!WcheckBox.Checked)
                        eventsArr = eventsArr.Where(r => r.Category != "Work").ToList();
                    if (!UcheckBox.Checked)
                        eventsArr = eventsArr.Where(r => r.Category != "Urgent").ToList();
                    AddEvents(eventsArr);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //This function inserts the events into the calendar.
        void AddEvents(List<MyEvents> ev)
        {
            hg.RemoveAll();
            foreach (MyEvents e in ev)
            {
                hg.AddEvent(new Hourglass.HourglassEvent
                {
                    Id = e.Id,
                    BackColor = colors[e.Category],
                    Start = e.Start,
                    End = e.End,
                    Text = e.Text,
                    Tooltip = e.Description,
                });
            }
        }

        //This function changes the calendars start date to the date that picked by the user in the month calendar.
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            hg.Options.StartDate = monthCalendar1.SelectionStart;
            hg.Render();
        }

        //This function called when the user press the Add Event button and opens a new dialog to add event.
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var selection = hg.GetSelection();
                if(selection == null)
                {
                    MessageBox.Show("Please select time range on the calendar");
                }
                else
                {
                    AddEventForm addEventForm = new AddEventForm(selection.start.Value, selection.end.Value, empty);
                    addEventForm.ShowDialog();
                    LoadData();
                }

            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(this, "Please select time range on the calendar, " + ex.Message);
            } 
        }

        //This function called when there is a change in the status of urgent events.
        private void UcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        //This function called when there is a change in the status of work events.
        private void WcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        //This function called when there is a change in the status of private events.
        private void PcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void hg_OnEventRightClick(object Sender, Hourglass.HourglassEvent _event)
        {
            last = _event;
            contextMenuStrip1.Show(MousePosition);
        }

        private void hg_OnEventEdit(object Sender, Hourglass.RangeCalendarEvent e)
        {

        }

        //This function called when the user press on delete button to delete an event.
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete from " + TableName +
                   " where Id='" + last.Id + "';";
                DBhandler.ExecuteQuery(query);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This function builds query to update an event.
        private string buildUpdateQuery(Hourglass.RangeCalendarEvent e)
        {
            string query = "update " + TableName + " set Start='"
                + e.@event.Start.ToString() + "',Ending='"
                + e.@event.End.ToString() + 
                    "' where Id=" + e.@event.Id + ";";
            return query;
        }

        //This function updates the event after the user moved it.
        private void hg_OnEventMove(object Sender, Hourglass.RangeCalendarEvent e)
        {
            updateEvent(e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //This function updates the event after the user resized it.
        private void hg_OnEventResize(object Sender, Hourglass.RangeCalendarEvent e)
        {
            updateEvent(e);
        }

        //This function updates the event.
        void updateEvent(Hourglass.RangeCalendarEvent e)
        {
            try
            {
                string query = buildUpdateQuery(e);
                DBhandler.ExecuteQuery(query);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This function opens a dialog to edit an event.
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEventForm addEventForm = new AddEventForm(last.Id);
            addEventForm.ShowDialog();
            LoadData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}