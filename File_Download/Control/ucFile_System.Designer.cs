namespace File_System
{
    partial class ucFile_System
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFile_System));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblUpdateSystem = new System.Windows.Forms.Label();
			this.txtFile_Name = new System.Windows.Forms.TextBox();
			this.chxFile_System = new System.Windows.Forms.CheckBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpload = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtFile_Serial_Key = new System.Windows.Forms.TextBox();
			this.btnDownload = new System.Windows.Forms.Button();
			this.lblFile_Name = new System.Windows.Forms.Label();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgvUpload_System = new System.Windows.Forms.DataGridView();
			this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.User_Serial_Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExcuteFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Enforce = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.yesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.popupNotifier1 = new Tulpep.NotificationWindow.PopupNotifier();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUpload_System)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.lblUpdateSystem);
			this.panel1.Controls.Add(this.txtFile_Name);
			this.panel1.Controls.Add(this.chxFile_System);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnUpload);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.txtFile_Serial_Key);
			this.panel1.Controls.Add(this.btnDownload);
			this.panel1.Controls.Add(this.lblFile_Name);
			this.panel1.Controls.Add(this.shapeContainer1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1327, 168);
			this.panel1.TabIndex = 0;
			// 
			// lblUpdateSystem
			// 
			this.lblUpdateSystem.AutoSize = true;
			this.lblUpdateSystem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lblUpdateSystem.Font = new System.Drawing.Font("Verdana", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUpdateSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.lblUpdateSystem.Location = new System.Drawing.Point(362, 15);
			this.lblUpdateSystem.Name = "lblUpdateSystem";
			this.lblUpdateSystem.Size = new System.Drawing.Size(553, 57);
			this.lblUpdateSystem.TabIndex = 26;
			this.lblUpdateSystem.Text = "Cập Nhật Phần Mềm";
			this.lblUpdateSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtFile_Name
			// 
			this.txtFile_Name.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtFile_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtFile_Name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFile_Name.Location = new System.Drawing.Point(135, 119);
			this.txtFile_Name.Name = "txtFile_Name";
			this.txtFile_Name.Size = new System.Drawing.Size(205, 16);
			this.txtFile_Name.TabIndex = 15;
			// 
			// chxFile_System
			// 
			this.chxFile_System.AutoSize = true;
			this.chxFile_System.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chxFile_System.Location = new System.Drawing.Point(820, 115);
			this.chxFile_System.Name = "chxFile_System";
			this.chxFile_System.Size = new System.Drawing.Size(112, 22);
			this.chxFile_System.TabIndex = 14;
			this.chxFile_System.Text = "checkBox1";
			this.chxFile_System.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(982, 109);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(115, 35);
			this.btnSave.TabIndex = 13;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(686, 108);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(115, 35);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpload
			// 
			this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnUpload.FlatAppearance.BorderSize = 0;
			this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpload.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpload.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
			this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpload.Location = new System.Drawing.Point(544, 108);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(114, 35);
			this.btnUpload.TabIndex = 13;
			this.btnUpload.Text = "Upload";
			this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUpload.UseVisualStyleBackColor = false;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.Location = new System.Drawing.Point(402, 108);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(115, 35);
			this.btnSearch.TabIndex = 13;
			this.btnSearch.Text = "Search";
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtFile_Serial_Key
			// 
			this.txtFile_Serial_Key.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtFile_Serial_Key.Location = new System.Drawing.Point(119, 53);
			this.txtFile_Serial_Key.Name = "txtFile_Serial_Key";
			this.txtFile_Serial_Key.Size = new System.Drawing.Size(205, 13);
			this.txtFile_Serial_Key.TabIndex = 9;
			this.txtFile_Serial_Key.Visible = false;
			// 
			// btnDownload
			// 
			this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDownload.FlatAppearance.BorderSize = 0;
			this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDownload.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDownload.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
			this.btnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDownload.Location = new System.Drawing.Point(1123, 108);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(135, 35);
			this.btnDownload.TabIndex = 5;
			this.btnDownload.Text = "Download";
			this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDownload.UseVisualStyleBackColor = false;
			this.btnDownload.Visible = false;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// lblFile_Name
			// 
			this.lblFile_Name.AutoSize = true;
			this.lblFile_Name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFile_Name.Location = new System.Drawing.Point(19, 120);
			this.lblFile_Name.Name = "lblFile_Name";
			this.lblFile_Name.Size = new System.Drawing.Size(94, 18);
			this.lblFile_Name.TabIndex = 0;
			this.lblFile_Name.Text = "File_Name";
			this.lblFile_Name.TextChanged += new System.EventHandler(this.lblFile_Name_TextChanged);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape5,
            this.rectangleShape4,
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
			this.shapeContainer1.Size = new System.Drawing.Size(1327, 168);
			this.shapeContainer1.TabIndex = 27;
			this.shapeContainer1.TabStop = false;
			// 
			// rectangleShape5
			// 
			this.rectangleShape5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.rectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.rectangleShape5.CornerRadius = 10;
			this.rectangleShape5.Location = new System.Drawing.Point(978, 107);
			this.rectangleShape5.Name = "rectangleShape5";
			this.rectangleShape5.Size = new System.Drawing.Size(121, 38);
			// 
			// rectangleShape4
			// 
			this.rectangleShape4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.rectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.rectangleShape4.CornerRadius = 10;
			this.rectangleShape4.Location = new System.Drawing.Point(682, 105);
			this.rectangleShape4.Name = "rectangleShape4";
			this.rectangleShape4.Size = new System.Drawing.Size(121, 38);
			// 
			// rectangleShape3
			// 
			this.rectangleShape3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.rectangleShape3.CornerRadius = 10;
			this.rectangleShape3.Location = new System.Drawing.Point(539, 106);
			this.rectangleShape3.Name = "rectangleShape3";
			this.rectangleShape3.Size = new System.Drawing.Size(121, 38);
			// 
			// rectangleShape2
			// 
			this.rectangleShape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.rectangleShape2.CornerRadius = 10;
			this.rectangleShape2.Location = new System.Drawing.Point(398, 106);
			this.rectangleShape2.Name = "rectangleShape2";
			this.rectangleShape2.Size = new System.Drawing.Size(121, 38);
			// 
			// rectangleShape1
			// 
			this.rectangleShape1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.rectangleShape1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this.rectangleShape1.CornerRadius = 5;
			this.rectangleShape1.Location = new System.Drawing.Point(132, 111);
			this.rectangleShape1.Name = "rectangleShape1";
			this.rectangleShape1.Size = new System.Drawing.Size(209, 30);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgvUpload_System);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 168);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1327, 252);
			this.panel2.TabIndex = 1;
			// 
			// dgvUpload_System
			// 
			this.dgvUpload_System.AllowUserToAddRows = false;
			this.dgvUpload_System.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgvUpload_System.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvUpload_System.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.FileName,
            this.UpdateTime,
            this.User_Serial_Key,
            this.ExcuteFile,
            this.Enforce});
			this.dgvUpload_System.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUpload_System.Location = new System.Drawing.Point(0, 0);
			this.dgvUpload_System.Name = "dgvUpload_System";
			this.dgvUpload_System.RowHeadersVisible = false;
			this.dgvUpload_System.Size = new System.Drawing.Size(1327, 252);
			this.dgvUpload_System.TabIndex = 1;
			// 
			// Check
			// 
			this.Check.HeaderText = "Check";
			this.Check.Name = "Check";
			// 
			// FileName
			// 
			this.FileName.HeaderText = "FileName";
			this.FileName.Name = "FileName";
			// 
			// UpdateTime
			// 
			this.UpdateTime.HeaderText = "UpdateTime";
			this.UpdateTime.Name = "UpdateTime";
			// 
			// User_Serial_Key
			// 
			this.User_Serial_Key.HeaderText = "UserID";
			this.User_Serial_Key.Name = "User_Serial_Key";
			// 
			// ExcuteFile
			// 
			this.ExcuteFile.HeaderText = "ExcuteFile";
			this.ExcuteFile.Name = "ExcuteFile";
			this.ExcuteFile.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ExcuteFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Enforce
			// 
			this.Enforce.HeaderText = "Enforce";
			this.Enforce.Name = "Enforce";
			this.Enforce.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(249, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 28;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yesToolStripMenuItem,
            this.noToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(92, 48);
			// 
			// yesToolStripMenuItem
			// 
			this.yesToolStripMenuItem.Name = "yesToolStripMenuItem";
			this.yesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.yesToolStripMenuItem.Text = "Yes";
			this.yesToolStripMenuItem.Click += new System.EventHandler(this.yesToolStripMenuItem_Click);
			// 
			// noToolStripMenuItem
			// 
			this.noToolStripMenuItem.Name = "noToolStripMenuItem";
			this.noToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.noToolStripMenuItem.Text = "No";
			this.noToolStripMenuItem.Click += new System.EventHandler(this.noToolStripMenuItem_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// popupNotifier1
			// 
			this.popupNotifier1.ContentFont = new System.Drawing.Font("Tahoma", 8F);
			this.popupNotifier1.ContentText = null;
			this.popupNotifier1.Image = null;
			this.popupNotifier1.IsRightToLeft = false;
			this.popupNotifier1.OptionsMenu = null;
			this.popupNotifier1.Size = new System.Drawing.Size(400, 100);
			this.popupNotifier1.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
			this.popupNotifier1.TitleText = null;
			// 
			// ucFile_System
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1327, 420);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ucFile_System";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUpload_System)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFile_Name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvUpload_System;
        //private DevExpress.XtraEditors.TextEdit txtFile_Name;
        private System.Windows.Forms.TextBox txtFile_Serial_Key;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Serial_Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExcuteFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enforce;
        private System.Windows.Forms.CheckBox chxFile_System;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFile_Name;
        private System.Windows.Forms.Label lblUpdateSystem;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem yesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private Tulpep.NotificationWindow.PopupNotifier popupNotifier1;
	}
}

