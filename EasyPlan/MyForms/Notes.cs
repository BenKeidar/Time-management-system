using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win1.Dialogs;
using Win1.Models;

namespace Win1.MyForms
{
    //This is the Notes form.
    public partial class Notes : Form
    {
        private string TableName = "Notes";
        bool empty = true, cellEdited = false;
        bool textEdited = false;
        int total = 0;
        int editedCellIndex = 0;
        public Notes()
        {
            InitializeComponent();
        }

        //This function loads the form.
        private void Notes_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LoadTheme();
            LoadGV();
        }

        //This function sets the buttons colors.
        private void LoadTheme()
        {
            addBtn.BackColor = ThemeColor.PrimaryColor;
            rmvBtn.BackColor = ThemeColor.PrimaryColor;
            saveBtn.BackColor = ThemeColor.PrimaryColor;
            closeBtn.BackColor = ThemeColor.PrimaryColor;
            saveBtn.Visible = false;
            closeBtn.Visible = false;
        }

        //This function loads the notes from the DB to the gridView.
        private void LoadGV()
        {
            string query = "select * from " + TableName + ";";
            List<Note> notessArr = DBhandler.GetNotes(query);
            notesGV.Rows.Clear();
            total = notessArr.Count;
            if (total == 0)
            {
                rmvBtn.Visible = false;
                empty = true;
            }
            else
            {
                rmvBtn.Visible = true;
                empty = false;
                for (int i = 0; i < total; i++)
                {
                    notesGV.Rows.Add(notessArr[i].Id, notessArr[i].Title, notessArr[i].Text);
                }
            }
        }

        //This function called when the user press the Add Note button and opens a new dialog to add a note.
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddNote addNote = new AddNote(empty);
            addNote.ShowDialog();
            LoadGV();
        }

        //This function called when the user press on delete button to delete a note.
        private void rmvBtn_Click(object sender, EventArgs e)
        {
            int tempIndex = notesGV.SelectedRows[0].Index;
            string query = "delete from " + TableName +
            " where Id='" + notesGV.Rows[tempIndex].Cells[0].Value + "';";
            DBhandler.ExecuteQuery(query);
            LoadGV();
        }

        //This function called when the user double click on a note to open it.
        private void notesGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int tempIndex = notesGV.SelectedRows[0].Index;
            noteTextBox.Text = notesGV.Rows[tempIndex].Cells[2].Value.ToString();
            saveBtn.Visible = false;
            closeBtn.Visible = true;
        }

        //This function called when the user change the note text.
        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {
            editedCellIndex = notesGV.SelectedRows[0].Index;
            if(noteTextBox.Text != "")
            {
                saveBtn.Visible = true;
                textEdited = true;
            }
        }

        //This function called when the user click on the close button to close a note.
        private void closeBtn_Click(object sender, EventArgs e)
        {
            noteTextBox.Text = "";
            closeBtn.Visible = false;
            saveBtn.Visible = false;
        }

        //This function called when the user click on the save button to save a note that has been changed.
        private void saveBtn_Click(object sender, EventArgs e)
        {
            update();
        }

        //This function builds query to update a note.
        private string buildUpdateQuery(int i, bool textEdited)
        {
            string query = "update " + TableName + " set Title='"
                + notesGV.Rows[i].Cells[1].Value.ToString();
            if (textEdited)
                query += "',Text='" + noteTextBox.Text; 
            query += "' where Id=" + notesGV.Rows[i].Cells[0].Value.ToString() + ";";
            return query;
        }

        //This function called when the user change the note title.
        private void notesGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            editedCellIndex = notesGV.SelectedRows[0].Index;
            saveBtn.Visible = true;
            cellEdited = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cellEdited)
            {
                foreach (DataGridViewRow row in notesGV.Rows)
                {
                    if (row.Index == editedCellIndex)
                        row.Selected = true;
                    else
                        row.Selected = false;
                }
                cellEdited = false;
            }
        }

        //This function updates the note.
        public void update()
        {
            string query = buildUpdateQuery(editedCellIndex, textEdited);
            DBhandler.ExecuteQuery(query);
            saveBtn.Visible = false;
            LoadGV();
            foreach (DataGridViewRow row in notesGV.Rows)
            {
                if (row.Index == editedCellIndex)
                    row.Selected = true;
                else
                    row.Selected = false;
            }
        }
    }
}