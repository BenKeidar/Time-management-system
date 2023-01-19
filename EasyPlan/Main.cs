using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Win1.Dialogs;
using Win1.Models;

namespace Win1
{
    public partial class Main : Form
    {
        //This is the Main page that holds Home page and the side menu.
        private System.Windows.Forms.Button currentButton;
        private Random random;
        private Form activeForm;
        private int tempIndex;
        public string currenttime;
        public Main()
        {
            InitializeComponent();
            random = new Random();
            closeFormBtn.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            myTimer.Start();
            currenttime = "";
            LoadNotificationsData();
            name1.ForeColor = Color.FromArgb(65, 194, 200, 205);
            desc1.ForeColor = Color.FromArgb(65, 194, 200, 205);
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //This function selects a random color from the color list of ThemeColor class.
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        //This function called when the user prees on a menu button to set the design of the button that havs been pressed and the panels.
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (System.Windows.Forms.Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (System.Windows.Forms.Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    closeFormBtn.Visible = true;
                }
            }
        }

        //This function sets the previous button that pressed to the default design.
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(51, 51, 76);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        //This function close the previous form (if there is one) and open the new form according the button that has bee pressed.
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titleLbl.Text = childForm.Text;
        }

        //This function called when the user press the calendar button in the menu.
        private void calendarBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyForms.Calendar(), sender);
        }

        //This function called when the user press the to do list button in the menu.
        private void todoBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyForms.To_do_list(), sender);
        }

        //This function called when the user press the notifications button in the menu.
        private void notificationBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyForms.Notifications(), sender);
        }

        //This function called when the user press the notes button in the menu.
        private void notesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyForms.Notes(), sender);
        }

        //This function called when the user press the overview button in the menu.
        private void overviewBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyForms.Overview(), sender);
        }

        //This function called when the user press the 'X' button in to close the current form.
        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        //This function called when the user press the close button to close the app.
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This function called when the user press the maximize button to maximize the app.
        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        //This function called when the user press the minimize button to minimize the app.
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //This function resets the design of the home page after a form is closed.
        private void Reset()
        {
            DisableButton();
            titleLbl.Text = "EasyPlan";
            panelTitle.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            closeFormBtn.Visible = false;
        }
        
        //This function maximize the window when the mouse down after drag & drop to the top of the screen.
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //This function checks when a notify needs to be notified and opens notification box when needed.
        private void myTimer_Tick(object sender, EventArgs e)
        {
            string timeToNotify = DateTime.Now.Day.ToString() + "/"
                                + DateTime.Now.Month.ToString() + "/"
                                + DateTime.Now.Year.ToString() + ","
                                + DateTime.Now.Hour.ToString() + ":"
                                + DateTime.Now.Minute.ToString();
            if (DBhandler.notificationsInfo.ContainsKey(timeToNotify))
            {
                myTimer.Stop();
                NotificationBox notificationBox = new NotificationBox(timeToNotify, DBhandler.notificationsInfo[timeToNotify]);
                notificationBox.ShowDialog();
                DBhandler.notificationsInfo.Remove(timeToNotify);
                string query = "delete from Notifications"
                               + " where NotifyTime='" + timeToNotify + "';";
                DBhandler.ExecuteQuery(query);
                myTimer.Start();
                DBhandler.notificationNotified = true;
            }
        }
        
        //This function Loads the notifications from the DB to the Dictionary that holded by DBhandler static class.
        void LoadNotificationsData()
        {
            try
            {
                string query = "select * from Notifications;";
                List<MyNotification> notificationsArr = DBhandler.GetNotifications(query);
                DBhandler.notificationsInfo.Clear();
                if (notificationsArr.Count != 0)
                {
                    for (int i = 0; i < notificationsArr.Count; i++)
                    {
                        DBhandler.notificationsInfo.Add(notificationsArr[i].Ntime, notificationsArr[i].Nmessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}