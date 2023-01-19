using System.Windows.Forms;

namespace Win1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.shopBtn = new System.Windows.Forms.Button();
            this.notesBtn = new System.Windows.Forms.Button();
            this.notificationBtn = new System.Windows.Forms.Button();
            this.todoBtn = new System.Windows.Forms.Button();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.maximizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.desc1 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.shopBtn);
            this.panelMenu.Controls.Add(this.notesBtn);
            this.panelMenu.Controls.Add(this.notificationBtn);
            this.panelMenu.Controls.Add(this.todoBtn);
            this.panelMenu.Controls.Add(this.calendarBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 943);
            this.panelMenu.TabIndex = 0;
            // 
            // shopBtn
            // 
            this.shopBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.shopBtn.FlatAppearance.BorderSize = 0;
            this.shopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopBtn.Font = new System.Drawing.Font("Montserrat", 9F);
            this.shopBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.shopBtn.Image = global::Win1.Properties.Resources.overview;
            this.shopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shopBtn.Location = new System.Drawing.Point(0, 320);
            this.shopBtn.Name = "shopBtn";
            this.shopBtn.Size = new System.Drawing.Size(220, 60);
            this.shopBtn.TabIndex = 5;
            this.shopBtn.Text = "   Overview";
            this.shopBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.shopBtn.UseVisualStyleBackColor = true;
            this.shopBtn.Click += new System.EventHandler(this.overviewBtn_Click);
            // 
            // notesBtn
            // 
            this.notesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.notesBtn.FlatAppearance.BorderSize = 0;
            this.notesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notesBtn.Font = new System.Drawing.Font("Montserrat", 9F);
            this.notesBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.notesBtn.Image = global::Win1.Properties.Resources.notes;
            this.notesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notesBtn.Location = new System.Drawing.Point(0, 260);
            this.notesBtn.Name = "notesBtn";
            this.notesBtn.Size = new System.Drawing.Size(220, 60);
            this.notesBtn.TabIndex = 4;
            this.notesBtn.Text = "   Notes";
            this.notesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.notesBtn.UseVisualStyleBackColor = true;
            this.notesBtn.Click += new System.EventHandler(this.notesBtn_Click);
            // 
            // notificationBtn
            // 
            this.notificationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.notificationBtn.FlatAppearance.BorderSize = 0;
            this.notificationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationBtn.Font = new System.Drawing.Font("Montserrat", 9F);
            this.notificationBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.notificationBtn.Image = global::Win1.Properties.Resources.notifications;
            this.notificationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notificationBtn.Location = new System.Drawing.Point(0, 200);
            this.notificationBtn.Name = "notificationBtn";
            this.notificationBtn.Size = new System.Drawing.Size(220, 60);
            this.notificationBtn.TabIndex = 3;
            this.notificationBtn.Text = "    Notifications";
            this.notificationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.notificationBtn.UseVisualStyleBackColor = true;
            this.notificationBtn.Click += new System.EventHandler(this.notificationBtn_Click);
            // 
            // todoBtn
            // 
            this.todoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.todoBtn.FlatAppearance.BorderSize = 0;
            this.todoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todoBtn.Font = new System.Drawing.Font("Montserrat", 9F);
            this.todoBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.todoBtn.Image = global::Win1.Properties.Resources.todo;
            this.todoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.todoBtn.Location = new System.Drawing.Point(0, 140);
            this.todoBtn.Name = "todoBtn";
            this.todoBtn.Size = new System.Drawing.Size(220, 60);
            this.todoBtn.TabIndex = 2;
            this.todoBtn.Text = "   To do list";
            this.todoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.todoBtn.UseVisualStyleBackColor = true;
            this.todoBtn.Click += new System.EventHandler(this.todoBtn_Click);
            // 
            // calendarBtn
            // 
            this.calendarBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarBtn.FlatAppearance.BorderSize = 0;
            this.calendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarBtn.Font = new System.Drawing.Font("Montserrat", 9F);
            this.calendarBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.calendarBtn.Image = global::Win1.Properties.Resources.calendar;
            this.calendarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarBtn.Location = new System.Drawing.Point(0, 80);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(220, 60);
            this.calendarBtn.TabIndex = 1;
            this.calendarBtn.Text = "   Calendar";
            this.calendarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calendarBtn.UseVisualStyleBackColor = true;
            this.calendarBtn.Click += new System.EventHandler(this.calendarBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win1.Properties.Resources.LogoW;
            this.pictureBox1.Location = new System.Drawing.Point(63, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitle.Controls.Add(this.maximizeBtn);
            this.panelTitle.Controls.Add(this.closeBtn);
            this.panelTitle.Controls.Add(this.minimizeBtn);
            this.panelTitle.Controls.Add(this.closeFormBtn);
            this.panelTitle.Controls.Add(this.titleLbl);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1085, 80);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.maximizeBtn.FlatAppearance.BorderSize = 0;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.Font = new System.Drawing.Font("Montserrat", 15F);
            this.maximizeBtn.ForeColor = System.Drawing.Color.White;
            this.maximizeBtn.Location = new System.Drawing.Point(1010, 3);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(36, 38);
            this.maximizeBtn.TabIndex = 4;
            this.maximizeBtn.Text = "O";
            this.maximizeBtn.UseVisualStyleBackColor = false;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Montserrat", 15F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1043, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 38);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "O";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Montserrat", 15F);
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Location = new System.Drawing.Point(977, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(36, 38);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.Text = "O";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeFormBtn.FlatAppearance.BorderSize = 0;
            this.closeFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFormBtn.Font = new System.Drawing.Font("Montserrat", 15F);
            this.closeFormBtn.ForeColor = System.Drawing.Color.White;
            this.closeFormBtn.Location = new System.Drawing.Point(17, 18);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(36, 36);
            this.closeFormBtn.TabIndex = 1;
            this.closeFormBtn.Text = "X";
            this.closeFormBtn.UseVisualStyleBackColor = false;
            this.closeFormBtn.Click += new System.EventHandler(this.closeFormBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(485, 23);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(153, 39);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "EasyPlan";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.desc1);
            this.panelDesktop.Controls.Add(this.name1);
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1085, 863);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // desc1
            // 
            this.desc1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.desc1.AutoSize = true;
            this.desc1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc1.ForeColor = System.Drawing.Color.Black;
            this.desc1.Location = new System.Drawing.Point(349, 518);
            this.desc1.Name = "desc1";
            this.desc1.Size = new System.Drawing.Size(398, 39);
            this.desc1.TabIndex = 2;
            this.desc1.Text = "Time Management System";
            // 
            // name1
            // 
            this.name1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Montserrat ExtraBold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.ForeColor = System.Drawing.Color.Black;
            this.name1.Location = new System.Drawing.Point(423, 453);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(258, 65);
            this.name1.TabIndex = 1;
            this.name1.Text = "EasyPlan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Win1.Properties.Resources.LogoNew2;
            this.pictureBox2.Location = new System.Drawing.Point(309, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(465, 253);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1305, 943);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1323, 990);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panelTitle;
        private Label titleLbl;
        private Button maximizeBtn;
        private Button closeBtn;
        private Button minimizeBtn;
        private Button closeFormBtn;
        private Panel panelDesktop;
        private Button calendarBtn;
        private Button shopBtn;
        private Button notesBtn;
        private Button notificationBtn;
        private Button todoBtn;
        private Timer myTimer;
        private PictureBox pictureBox1;
        private Label name1;
        private PictureBox pictureBox2;
        private Label desc1;
    }
}

