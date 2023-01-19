using System;
using System.Windows.Forms;

namespace Win1.Dialogs
{
    public partial class NotificationBox : Form
    {
        public string soundPath;
        public System.Media.SoundPlayer player;
        public NotificationBox(string dateStr, string msg)
        {
            InitializeComponent();
            panel1.BackColor = ThemeColor.PrimaryColor;
            dateLbl.Text = dateStr;
            msgLbl.Text = msg;
            var parent = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory());
            string s = parent.ToString();
            this.soundPath = s.Substring(0, s.Length - 3) + "Sounds" + '\\' + "ac.wav";
            player = new System.Media.SoundPlayer();
            player.SoundLocation = soundPath;
            player.PlayLooping();
        }

        private void closeFormBtn_Click_1(object sender, EventArgs e)
        {
            player.Stop();
            this.Close();
        }
    }
}