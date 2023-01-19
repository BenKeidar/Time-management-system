namespace Win1.MyForms
{
    partial class Calendar
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
            Hourglass.HourglassOptions hourglassOptions2 = new Hourglass.HourglassOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UcheckBox = new System.Windows.Forms.CheckBox();
            this.WcheckBox = new System.Windows.Forms.CheckBox();
            this.PcheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.init = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.hg = new Hourglass.HgScheduler();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.weekBtn = new System.Windows.Forms.Button();
            this.monthBtn = new System.Windows.Forms.Button();
            this.dayBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(781, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(781, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 816);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.UcheckBox);
            this.panel2.Controls.Add(this.WcheckBox);
            this.panel2.Controls.Add(this.PcheckBox);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(9, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 565);
            this.panel2.TabIndex = 1;
            // 
            // UcheckBox
            // 
            this.UcheckBox.AutoSize = true;
            this.UcheckBox.BackColor = System.Drawing.Color.White;
            this.UcheckBox.Checked = true;
            this.UcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UcheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UcheckBox.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UcheckBox.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.UcheckBox.Location = new System.Drawing.Point(52, 91);
            this.UcheckBox.Name = "UcheckBox";
            this.UcheckBox.Size = new System.Drawing.Size(136, 25);
            this.UcheckBox.TabIndex = 4;
            this.UcheckBox.Text = "Urgent events";
            this.UcheckBox.UseVisualStyleBackColor = false;
            this.UcheckBox.CheckedChanged += new System.EventHandler(this.UcheckBox_CheckedChanged);
            // 
            // WcheckBox
            // 
            this.WcheckBox.AutoSize = true;
            this.WcheckBox.BackColor = System.Drawing.Color.White;
            this.WcheckBox.Checked = true;
            this.WcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WcheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WcheckBox.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WcheckBox.ForeColor = System.Drawing.Color.MediumOrchid;
            this.WcheckBox.Location = new System.Drawing.Point(52, 141);
            this.WcheckBox.Name = "WcheckBox";
            this.WcheckBox.Size = new System.Drawing.Size(125, 25);
            this.WcheckBox.TabIndex = 3;
            this.WcheckBox.Text = "Work events";
            this.WcheckBox.UseVisualStyleBackColor = false;
            this.WcheckBox.CheckedChanged += new System.EventHandler(this.WcheckBox_CheckedChanged);
            // 
            // PcheckBox
            // 
            this.PcheckBox.AutoSize = true;
            this.PcheckBox.BackColor = System.Drawing.Color.White;
            this.PcheckBox.Checked = true;
            this.PcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PcheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PcheckBox.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PcheckBox.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.PcheckBox.Location = new System.Drawing.Point(52, 192);
            this.PcheckBox.Name = "PcheckBox";
            this.PcheckBox.Size = new System.Drawing.Size(150, 25);
            this.PcheckBox.TabIndex = 2;
            this.PcheckBox.Text = "Personal events";
            this.PcheckBox.UseVisualStyleBackColor = false;
            this.PcheckBox.CheckedChanged += new System.EventHandler(this.PcheckBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win1.Properties.Resources.cal2;
            this.pictureBox1.Location = new System.Drawing.Point(52, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // init
            // 
            this.init.Interval = 500;
            this.init.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.hg);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(320, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 816);
            this.panel3.TabIndex = 5;
            // 
            // hg
            // 
            this.hg.BackColor = System.Drawing.Color.White;
            this.hg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hg.Location = new System.Drawing.Point(0, 66);
            this.hg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hg.Name = "hg";
            hourglassOptions2.EventArrangement = null;
            hourglassOptions2.EventClickHandling = null;
            hourglassOptions2.EventDeleteHandling = null;
            hourglassOptions2.EventDoubleClickHandling = null;
            hourglassOptions2.HeaderDateFormat = "dddd";
            hourglassOptions2.StartDate = new System.DateTime(2022, 12, 11, 21, 37, 57, 110);
            hourglassOptions2.ViewType = Hourglass.ViewTypes.Week;
            this.hg.Options = hourglassOptions2;
            this.hg.Size = new System.Drawing.Size(747, 750);
            this.hg.TabIndex = 1;
            this.hg.Theme = resources.GetString("hg.Theme");
            this.hg.OnAferRender += new System.EventHandler(this.hgScheduler1_OnAferRender);
            this.hg.OnEventRightClick += new Hourglass.HgScheduler.CalendarEventHandler(this.hg_OnEventRightClick);
            this.hg.OnEventEdit += new Hourglass.HgScheduler.EventCancelableEventHandler(this.hg_OnEventEdit);
            this.hg.OnEventMove += new Hourglass.HgScheduler.EventCancelableEventHandler(this.hg_OnEventMove);
            this.hg.OnEventResize += new Hourglass.HgScheduler.EventCancelableEventHandler(this.hg_OnEventResize);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.addBtn);
            this.panel4.Controls.Add(this.weekBtn);
            this.panel4.Controls.Add(this.monthBtn);
            this.panel4.Controls.Add(this.dayBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(747, 66);
            this.panel4.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.addBtn.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(6, 17);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(105, 42);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add event";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // weekBtn
            // 
            this.weekBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weekBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.weekBtn.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekBtn.ForeColor = System.Drawing.Color.White;
            this.weekBtn.Location = new System.Drawing.Point(593, 17);
            this.weekBtn.Name = "weekBtn";
            this.weekBtn.Size = new System.Drawing.Size(77, 42);
            this.weekBtn.TabIndex = 2;
            this.weekBtn.Text = "Week";
            this.weekBtn.UseVisualStyleBackColor = false;
            this.weekBtn.Click += new System.EventHandler(this.weekBtn_Click);
            // 
            // monthBtn
            // 
            this.monthBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBtn.BackColor = System.Drawing.Color.White;
            this.monthBtn.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.monthBtn.Location = new System.Drawing.Point(665, 17);
            this.monthBtn.Name = "monthBtn";
            this.monthBtn.Size = new System.Drawing.Size(77, 42);
            this.monthBtn.TabIndex = 1;
            this.monthBtn.Text = "Month";
            this.monthBtn.UseVisualStyleBackColor = false;
            this.monthBtn.Click += new System.EventHandler(this.monthBtn_Click);
            // 
            // dayBtn
            // 
            this.dayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dayBtn.BackColor = System.Drawing.Color.White;
            this.dayBtn.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.dayBtn.Location = new System.Drawing.Point(521, 17);
            this.dayBtn.Name = "dayBtn";
            this.dayBtn.Size = new System.Drawing.Size(77, 42);
            this.dayBtn.TabIndex = 0;
            this.dayBtn.Text = "Day";
            this.dayBtn.UseVisualStyleBackColor = false;
            this.dayBtn.Click += new System.EventHandler(this.dayBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 816);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Calendar";
            this.Opacity = 0D;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer init;
        private System.Windows.Forms.Panel panel3;
        private Hourglass.HgScheduler hg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button weekBtn;
        private System.Windows.Forms.Button monthBtn;
        private System.Windows.Forms.Button dayBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox UcheckBox;
        private System.Windows.Forms.CheckBox WcheckBox;
        private System.Windows.Forms.CheckBox PcheckBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}