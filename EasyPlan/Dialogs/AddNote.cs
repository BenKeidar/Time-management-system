using System;
using System.Windows.Forms;

namespace Win1.Dialogs
{
    public partial class AddNote : Form
    {
        private string TableName = "Notes";
        private bool empty;
        public AddNote(bool e)
        {
            InitializeComponent();
            empty = e;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        private bool FilesAreValid()
        {
            if (titleBox.Text == "" || richTextBox.Text == "")
                return false;
            return true;
        }
        private string buildInsertQuery(int id)
        {
            string query = "insert into " + TableName + " values("
                + id + ",'"
                + titleBox.Text + "','"
                + richTextBox.Text 
                + "')";
            return query;
        }

        //This function gets the next unused ID for the new note.
        private int GetID()
        {
            string query = "SELECT MAX(Id) FROM " + TableName + ";";
            if (!empty)
                return Convert.ToInt32(DBhandler.GetEventId(query) + 1);
            else
                return 0;
        }
    }
}