using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Win1.Dialogs
{
    public partial class AddEventForm : Form
    {
        private string TableName = "Events";
        public bool empty;
        DateTime start, end;
        string Id = "0";
        bool needToUpdate = false;
        
        //This constructor called when this dialog used to create a new event.
        public AddEventForm(DateTime s, DateTime e, bool empty)
        {
            InitializeComponent();
            start = s;
            end = e;
            cancelBtn.ForeColor = ThemeColor.PrimaryColor;
            saveBtn.BackColor = ThemeColor.PrimaryColor;
            this.empty = empty;
        }

        //This constructor called when this dialog used to edit an existing event.
        public AddEventForm(string id)
        {
            InitializeComponent();
            needToUpdate = true;
            Id = id;
            cancelBtn.ForeColor = ThemeColor.PrimaryColor;
            saveBtn.BackColor = ThemeColor.PrimaryColor;
            GetFields();
        }

        //This function used to get fields of an existing event that should be edited.
        void GetFields()
        {
            string query = "select * from " + TableName + " where Id='" + Id + "';";
            Dictionary<string, string> fields = DBhandler.GetEventFields(query);
            textBox.Text = fields["Text"];
            descBox.Text = fields["Description"];
            categoryBox.SelectedItem = fields["Type"];
            categoryBox.Text = fields["Type"];
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (FilesAreValid())
            {
                string query = "";
                if (needToUpdate)
                {
                    query = buildUpdateQuery();
                }
                else
                {
                    query = buildInsertQuery(GetID());
                }
                DBhandler.ExecuteQuery(query);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please fill all mandatory fields");
            }
        }
        private bool FilesAreValid()
        {
            if(textBox.Text == "" || categoryBox.Text == "")
                return false;
            return true;
        }
        private string buildInsertQuery(int id)
        {
            string query = "insert into " + TableName + " values("
                + id + ",'"
                + categoryBox.SelectedItem.ToString() + "','"
                + start + "','"
                + end + "','"
                + textBox.Text + "','"
                + descBox.Text 
                + "')";
            return query;
        }
        private string buildUpdateQuery()
        {
            string query = "update " + TableName + " set Text='"
                + textBox.Text + "',Description='"
                + descBox.Text + "',Type='"
                + categoryBox.Text +
                    "' where Id=" + Id + ";";
            return query;
        }

        //This function gets the next unused ID for the new event.
        private int GetID()
        {
            if(empty)
                return 0;
            else
            {
                string query = "SELECT MAX(Id) FROM " + TableName + ";";
                return Convert.ToInt32(DBhandler.GetEventId(query) + 1);
            }
        }
    }
}