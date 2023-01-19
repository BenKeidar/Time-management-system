namespace Win1.MyForms
{
    partial class To_do_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.myProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.precent = new System.Windows.Forms.Label();
            this.diaryDBDataSet = new Win1.DiaryDBDataSet();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new Win1.DiaryDBDataSetTableAdapters.TasksTableAdapter();
            this.diaryDBDataSet1 = new Win1.DiaryDBDataSet();
            this.tasksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.d = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tasksBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.diaryDBDataSet11 = new Win1.DiaryDBDataSet1();
            this.tasksBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter1 = new Win1.DiaryDBDataSet1TableAdapters.TasksTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.myProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearBtn
            // 
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(374, 31);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(165, 49);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear list";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(38, 31);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(165, 49);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add task";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // myProgressBar
            // 
            this.myProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myProgressBar.Controls.Add(this.precent);
            this.myProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.myProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.myProgressBar.ForeColor = System.Drawing.Color.White;
            this.myProgressBar.Location = new System.Drawing.Point(565, 111);
            this.myProgressBar.Minimum = 0;
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.myProgressBar.Size = new System.Drawing.Size(203, 203);
            this.myProgressBar.TabIndex = 4;
            this.myProgressBar.Text = "guna2CircleProgressBar1";
            // 
            // precent
            // 
            this.precent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.precent.AutoSize = true;
            this.precent.Font = new System.Drawing.Font("Impact", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precent.Location = new System.Drawing.Point(48, 63);
            this.precent.Name = "precent";
            this.precent.Size = new System.Drawing.Size(118, 71);
            this.precent.TabIndex = 0;
            this.precent.Text = "0/0";
            this.precent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diaryDBDataSet
            // 
            this.diaryDBDataSet.DataSetName = "DiaryDBDataSet";
            this.diaryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.diaryDBDataSet;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // diaryDBDataSet1
            // 
            this.diaryDBDataSet1.DataSetName = "DiaryDBDataSet";
            this.diaryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksBindingSource1
            // 
            this.tasksBindingSource1.DataMember = "Tasks";
            this.tasksBindingSource1.DataSource = this.diaryDBDataSet1;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 37;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.d,
            this.Task,
            this.ID,
            this.Deadline});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(38, 114);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.guna2DataGridView1.RowTemplate.Height = 34;
            this.guna2DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.Size = new System.Drawing.Size(496, 298);
            this.guna2DataGridView1.TabIndex = 6;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 37;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 34;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightCyan;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // d
            // 
            this.d.FillWeight = 50F;
            this.d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d.HeaderText = "Done";
            this.d.MinimumWidth = 6;
            this.d.Name = "d";
            this.d.ToolTipText = "a";
            // 
            // Task
            // 
            this.Task.HeaderText = "Task";
            this.Task.MinimumWidth = 6;
            this.Task.Name = "Task";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Deadline
            // 
            this.Deadline.FillWeight = 50F;
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.MinimumWidth = 6;
            this.Deadline.Name = "Deadline";
            // 
            // tasksBindingSource2
            // 
            this.tasksBindingSource2.DataMember = "Tasks";
            this.tasksBindingSource2.DataSource = this.diaryDBDataSet1;
            // 
            // tasksBindingSource3
            // 
            this.tasksBindingSource3.DataMember = "Tasks";
            this.tasksBindingSource3.DataSource = this.diaryDBDataSet1;
            // 
            // diaryDBDataSet11
            // 
            this.diaryDBDataSet11.DataSetName = "DiaryDBDataSet1";
            this.diaryDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksBindingSource4
            // 
            this.tasksBindingSource4.DataMember = "Tasks";
            this.tasksBindingSource4.DataSource = this.diaryDBDataSet11;
            // 
            // tasksTableAdapter1
            // 
            this.tasksTableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(206, 31);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(165, 49);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete task";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // To_do_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.myProgressBar);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "To_do_list";
            this.Text = "To_do_list";
            this.Load += new System.EventHandler(this.To_do_list_Load);
            this.myProgressBar.ResumeLayout(false);
            this.myProgressBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diaryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button AddBtn;
        private Guna.UI2.WinForms.Guna2CircleProgressBar myProgressBar;
        private DiaryDBDataSet diaryDBDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private DiaryDBDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private DiaryDBDataSet diaryDBDataSet1;
        private System.Windows.Forms.BindingSource tasksBindingSource1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.BindingSource tasksBindingSource2;
        private System.Windows.Forms.BindingSource tasksBindingSource3;
        private DiaryDBDataSet1 diaryDBDataSet11;
        private System.Windows.Forms.BindingSource tasksBindingSource4;
        private DiaryDBDataSet1TableAdapters.TasksTableAdapter tasksTableAdapter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.Label precent;
    }
}