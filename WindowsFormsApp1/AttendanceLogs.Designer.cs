﻿namespace WindowsFormsApp1
{
    partial class AttendanceLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceLogs));
            this.attendanceTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timeInGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timeOutGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addLogs = new System.Windows.Forms.Button();
            this.empCombo = new System.Windows.Forms.ComboBox();
            this.empLabel = new System.Windows.Forms.Label();
            this.backlabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.attendanceTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeInGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeOutGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendanceTab
            // 
            this.attendanceTab.Controls.Add(this.tabPage2);
            this.attendanceTab.Controls.Add(this.tabPage3);
            this.attendanceTab.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceTab.Location = new System.Drawing.Point(16, 116);
            this.attendanceTab.Name = "attendanceTab";
            this.attendanceTab.SelectedIndex = 0;
            this.attendanceTab.Size = new System.Drawing.Size(519, 285);
            this.attendanceTab.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.timeInGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(511, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Time In";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timeInGrid
            // 
            this.timeInGrid.AllowUserToAddRows = false;
            this.timeInGrid.AllowUserToDeleteRows = false;
            this.timeInGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timeInGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.timeInGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeInGrid.Location = new System.Drawing.Point(0, 0);
            this.timeInGrid.Name = "timeInGrid";
            this.timeInGrid.ReadOnly = true;
            this.timeInGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timeInGrid.Size = new System.Drawing.Size(511, 259);
            this.timeInGrid.TabIndex = 1;
            this.timeInGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timeInGrid_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.timeOutGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(511, 260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Time Out";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // timeOutGrid
            // 
            this.timeOutGrid.AllowUserToAddRows = false;
            this.timeOutGrid.AllowUserToDeleteRows = false;
            this.timeOutGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timeOutGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.timeOutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeOutGrid.Location = new System.Drawing.Point(0, 0);
            this.timeOutGrid.Name = "timeOutGrid";
            this.timeOutGrid.ReadOnly = true;
            this.timeOutGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timeOutGrid.Size = new System.Drawing.Size(511, 259);
            this.timeOutGrid.TabIndex = 0;
            this.timeOutGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timeOutGrid_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.addLogs);
            this.panel1.Controls.Add(this.empCombo);
            this.panel1.Controls.Add(this.empLabel);
            this.panel1.Location = new System.Drawing.Point(16, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 79);
            this.panel1.TabIndex = 1;
            // 
            // addLogs
            // 
            this.addLogs.BackColor = System.Drawing.Color.Maroon;
            this.addLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLogs.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLogs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addLogs.Location = new System.Drawing.Point(374, 30);
            this.addLogs.Name = "addLogs";
            this.addLogs.Size = new System.Drawing.Size(127, 23);
            this.addLogs.TabIndex = 50;
            this.addLogs.Text = "LOG";
            this.addLogs.UseVisualStyleBackColor = false;
            this.addLogs.Click += new System.EventHandler(this.addLogs_Click);
            // 
            // empCombo
            // 
            this.empCombo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empCombo.FormattingEnabled = true;
            this.empCombo.Location = new System.Drawing.Point(145, 31);
            this.empCombo.Name = "empCombo";
            this.empCombo.Size = new System.Drawing.Size(216, 27);
            this.empCombo.TabIndex = 34;
            // 
            // empLabel
            // 
            this.empLabel.AutoSize = true;
            this.empLabel.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.empLabel.Location = new System.Drawing.Point(14, 20);
            this.empLabel.Name = "empLabel";
            this.empLabel.Size = new System.Drawing.Size(133, 33);
            this.empLabel.TabIndex = 11;
            this.empLabel.Text = "Employee";
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backlabel.Location = new System.Drawing.Point(47, 90);
            this.backlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(32, 14);
            this.backlabel.TabIndex = 60;
            this.backlabel.Text = "back";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backBtn.Location = new System.Drawing.Point(22, 15);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 72);
            this.backBtn.TabIndex = 59;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(472, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 14);
            this.label7.TabIndex = 62;
            this.label7.Text = "PRINT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(442, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 67);
            this.button1.TabIndex = 61;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AttendanceLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 495);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.attendanceTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AttendanceLogs";
            this.Text = "Attendance Logs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AttendanceLogs_FormClosing);
            this.Load += new System.EventHandler(this.AttendanceLogs_Load);
            this.attendanceTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeInGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeOutGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl attendanceTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label empLabel;
        private System.Windows.Forms.ComboBox empCombo;
        private System.Windows.Forms.Button addLogs;
        private System.Windows.Forms.DataGridView timeInGrid;
        private System.Windows.Forms.DataGridView timeOutGrid;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}