using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win1.Dialogs;
using Win1.Models;

namespace Win1.MyForms
{
    //This is the Notes form.
    public partial class Notifications : Form
    {
        private string TableName = "Notifications";
        public bool empty = true;
        public Notifications()
        {
            InitializeComponent();
        }

        //This function loads the form.
        private void Notifications_Load(object sender, EventArgs e)
        {
            LoadTheme();
            timer1.Start();
            LoadData();
        }

        //This function sets the buttons colors.
        private void LoadTheme()
        {
            addBtn.BackColor = ThemeColor.PrimaryColor;
            deleteBtn.BackColor = ThemeColor.PrimaryColor;
        }
        
        //This function loads the notifications from the DB to the gridView.
        void LoadData()
        {
            try
            {
                string query = "select * from " + TableName + ";";
                List<MyNotification> notificationsArr = DBhandler.GetNotifications(query);
                notificationsGV.Rows.Clear();
                if (notificationsArr.Count == 0)
                    empty = true;
                else
                {
                    empty = false;
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

        //This function called when the user press the Add Notification button and opens a new dialog to add a notification.
        private void button1_Click(object sender, EventArgs e)
        {
            AddNotification addNotification = new AddNotification(empty);
            addNotification.ShowDialog();
            LoadData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DBhandler.notificationNotified)
            {
                DBhandler.notificationNotified = false;
                LoadData();
            }
        }


        //This function called when the user press the Delete Notification button and opens a new dialog to delete a notification.
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int tempIndex = notificationsGV.SelectedRows[0].Index;
            DBhandler.notificationsInfo.Remove(notificationsGV.Rows[tempIndex].Cells[1].Value.ToString());
            string query = "delete from " + TableName +
            " where Id='" + notificationsGV.Rows[tempIndex].Cells[0].Value + "';";
            DBhandler.ExecuteQuery(query);
            LoadData();
        }
    }
}