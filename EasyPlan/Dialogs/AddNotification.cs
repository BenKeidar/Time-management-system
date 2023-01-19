using System;
using System.Windows.Forms;

namespace Win1.Dialogs
{
    public partial class AddNotification : Form
    {
        private string TableName = "Notifications";
        public bool empty;
        public AddNotification(bool e)
        {
            InitializeComponent();
            cancelBtn.ForeColor = ThemeColor.PrimaryColor;
            addBtn.BackColor = ThemeColor.PrimaryColor;
            dateLbl.ForeColor = ThemeColor.PrimaryColor;
            timeLbl.ForeColor = ThemeColor.PrimaryColor;
            massageLbl.ForeColor = ThemeColor.PrimaryColor;
            label1.ForeColor = ThemeColor.PrimaryColor;
            for(int i = 0; i < 24; i++)
                hourCB.Items.Add(i.ToString());
            for (int i = 0; i < 60; i++)
                minutesCB.Items.Add(i.ToString());
            empty = e;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (FilesAreValid()) {
                string timeToNotify = dateTimePicker1.Value.Day.ToString()   + "/"
                                    + dateTimePicker1.Value.Month.ToString() + "/"
                                    + dateTimePicker1.Value.Year.ToString()  + ","
                                    + hourCB.Text  + ":" + minutesCB.Text;
                DBhandler.notificationsInfo.Add(timeToNotify, textBox1.Text);
                string query = "";
                int id = GetID();
                query = buildInsertQuery(id, timeToNotify);
                DBhandler.ExecuteQuery(query);
                this.Hide();
            }
            else
                MessageBox.Show("Please fill all mandatory fields");
        }
        private bool FilesAreValid()
        {
            if (textBox1.Text == "" || hourCB.Text == "" || minutesCB.Text == "" || dateTimePicker1.Value.ToString() == "")
                return false;
            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //This function gets the next unused ID for the new notification.
        private int GetID()
        {
            if (empty)
                return 0;
            else
            {
                string query = "SELECT MAX(Id) FROM " + TableName + ";";
                return Convert.ToInt32(DBhandler.GetEventId(query) + 1);
            }
        }
        private string buildInsertQuery(int id, string notifyTime)
        {
            string query = "insert into " + TableName + " values("
                + id + ",'"
                + notifyTime + "','"
                + textBox1.Text
                + "')";
            return query;
        }
    }
}