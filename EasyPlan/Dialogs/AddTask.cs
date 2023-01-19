using System;
using System.Windows.Forms;

namespace Win1.Dialogs
{
    public partial class AddTask : Form
    {
        private string TableName = "Tasks";
        private bool empty;
        public AddTask(bool empty)
        {
            InitializeComponent();
            cancelBtn.ForeColor = ThemeColor.PrimaryColor;
            saveBtn.BackColor = ThemeColor.PrimaryColor;
            this.empty = empty;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (FilesAreValid())
            {
                string query = buildInsertQuery(GetID());
                DBhandler.ExecuteQuery(query);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please fill all mandatory fields");
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private bool FilesAreValid()
        {
            if (textBox.Text == "" || dateTimePicker1.Value.ToString() == "")
                return false;
            return true;
        }
        private string buildInsertQuery(int id)
        {
            string query = "insert into " + TableName + " values("
                + id + ",'"
                + textBox.Text + "','"
                + dateTimePicker1.Value.ToString() + "',"
                + 0
                + ")";
            return query;
        }

        //This function gets the next unused ID for the new task.
        private int GetID()
        {
            string query = "SELECT MAX(Id) FROM " + TableName + ";";
            if(!empty)
                return Convert.ToInt32(DBhandler.GetEventId(query) + 1);
            else
                return 0;
        }
    }
}