using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Win1.Dialogs;
using Win1.Models;

namespace Win1.MyForms
{
    //This is to do list form.
    public partial class To_do_list : Form
    {
        private string TableName = "Tasks";
        int done = 0, total = 0;
        bool empty = true;
        public To_do_list()
        {
            InitializeComponent();
        }

        //This function loads the form.
        private void To_do_list_Load(object sender, EventArgs e)
        {
            this.tasksTableAdapter1.Fill(this.diaryDBDataSet11.Tasks);
            LoadTheme();
            LoadGV();
        }

        //This function sets the buttons colors.
        private void LoadTheme()
        {
            AddBtn.BackColor = ThemeColor.PrimaryColor;
            ClearBtn.BackColor = ThemeColor.PrimaryColor;
            DeleteBtn.BackColor = ThemeColor.PrimaryColor;
        }

        //This function loads the tasks from the DB to the gridView.
        private void LoadGV()
        { 
            string query = "select * from " + TableName + ";";
            List<MyTask> taskssArr = DBhandler.GetTasks(query);
            guna2DataGridView1.Rows.Clear();
            total = taskssArr.Count;
            if(total == 0)
            {
                DeleteBtn.Visible = false;
                ClearBtn.Visible = false;
                empty = true;
            }
            else
            {
                DeleteBtn.Visible = true;
                ClearBtn.Visible = true;
                empty = false;
                done = 0;
                for (int i = 0; i < total; i++)
                {
                    if (taskssArr[i].Done == 1)
                        done++;
                    guna2DataGridView1.Rows.Add(taskssArr[i].Done, taskssArr[i].Text, taskssArr[i].Id, taskssArr[i].Deadline);
                }
                setGVdesign();
                SetProgress();
            }
        }
        
        //This function sets the gridView design.
        public void setGVdesign()
        {
            for (int i = 0; i < total; i++)
            {
                if (NumOfDaysLeft(DateTime.Now, DateTime.Parse(guna2DataGridView1.Rows[i].Cells[3].Value.ToString())) < 2)
                {// If task is not done and has less than 2 days left -> it will be red.
                    for (int j = 0; j < 3; j++)
                    {
                        guna2DataGridView1.Rows[i].Cells[j].Style.BackColor = ColorTranslator.FromHtml("#fecbcc");
                    }
                }
                if (guna2DataGridView1.Rows[i].Cells[0].Value.ToString() == "1")
                {//If task is done -> it will be green.
                    for (int j = 0; j < 3; j++)
                    {
                        guna2DataGridView1.Rows[i].Cells[j].Style.Font = new Font("Montserrat", 12, FontStyle.Strikeout);
                        guna2DataGridView1.Rows[i].Cells[j].Style.BackColor = ColorTranslator.FromHtml("#caffcc");
                    }
                }
            }
        }
        
        //This function calculates the difference between two dates.
        int NumOfDaysLeft(DateTime StartDate, DateTime EndDate)
        {
            return Convert.ToInt32((EndDate - StartDate).TotalDays);
        }

        //This function called when the user edit a tasks text.
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int tempIndex = guna2DataGridView1.SelectedRows[0].Index;
            string query = buildUpdateQuery(tempIndex);
            DBhandler.ExecuteQuery(query);
            LoadGV();
        }

        //This function builds query to update a task.
        private string buildUpdateQuery(int i)
        {
            int x = 0;
            if (Convert.ToInt32(guna2DataGridView1.Rows[i].Cells[0].Value) == 0)
                x = 1;
            string query = "update " + TableName + " set Done="
                + x
                + " where Id=" + guna2DataGridView1.Rows[i].Cells[2].Value + ";";
            return query;
        }
        
        //This function called when the useer press the clear button to clear the tasks list.
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            string query = "delete from " + TableName + ";";
            DBhandler.ExecuteQuery(query);
            LoadGV();
        }

        //This function called when the user press on delete button to delete a task.
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int tempIndex = guna2DataGridView1.SelectedRows[0].Index;
            string query = "delete from " + TableName +
            " where Id='" + guna2DataGridView1.Rows[tempIndex].Cells[2].Value + "';";
            DBhandler.ExecuteQuery(query);
            LoadGV();
        }

        //This function called when the user press the Add task button and opens a new dialog to add a task.
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask(empty);
            addTask.ShowDialog();
            LoadGV();
        }

        //This function sets the task progress status.
        private void SetProgress()
        {
            double t = total, d = done;
            int res = Convert.ToInt32(d / t * 100);
            myProgressBar.Value = res;
            if(res <= 25)
            {
                SetColors(Color.Red, Color.DarkRed);
            }   
            else if(res <= 50)
            {
                SetColors(Color.Orange, Color.OrangeRed);
            }
            else if (res <= 75)
            {
                SetColors(Color.Yellow, Color.Gold);
            }
            else if(done < total)
            {
                SetColors(Color.GreenYellow, Color.SpringGreen);
            }
            else
            {
                SetColors(Color.Green, Color.SpringGreen);
            }
            precent.Text = done.ToString() + "/" + total.ToString();
        }
        public void SetColors(Color a, Color b)
        {
            myProgressBar.ProgressColor = a;
            myProgressBar.ProgressColor2 = b;
            precent.ForeColor = a;
        }
    }
}