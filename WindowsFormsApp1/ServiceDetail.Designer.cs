﻿namespace WindowsFormsApp1
{
    partial class ServiceDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceDetail));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.servicesGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serviceCombo = new System.Windows.Forms.ComboBox();
            this.barberCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addOrd = new System.Windows.Forms.Button();
            this.tIDlabel = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.amtLabel = new System.Windows.Forms.Label();
            this.backlabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicesGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "Transaction ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 34);
            this.label1.TabIndex = 24;
            // 
            // servicesGrid
            // 
            this.servicesGrid.AllowUserToAddRows = false;
            this.servicesGrid.AllowUserToDeleteRows = false;
            this.servicesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.servicesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.servicesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesGrid.Location = new System.Drawing.Point(18, 305);
            this.servicesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.servicesGrid.Name = "servicesGrid";
            this.servicesGrid.ReadOnly = true;
            this.servicesGrid.RowHeadersVisible = false;
            this.servicesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesGrid.Size = new System.Drawing.Size(607, 210);
            this.servicesGrid.TabIndex = 25;
            this.servicesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.servicesGrid_CellClick);
            this.servicesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.servicesGrid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.serviceCombo);
            this.panel1.Controls.Add(this.barberCombo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addOrd);
            this.panel1.Location = new System.Drawing.Point(18, 529);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 113);
            this.panel1.TabIndex = 26;
            // 
            // serviceCombo
            // 
            this.serviceCombo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCombo.FormattingEnabled = true;
            this.serviceCombo.Location = new System.Drawing.Point(139, 55);
            this.serviceCombo.Margin = new System.Windows.Forms.Padding(4);
            this.serviceCombo.Name = "serviceCombo";
            this.serviceCombo.Size = new System.Drawing.Size(296, 32);
            this.serviceCombo.TabIndex = 55;
            // 
            // barberCombo
            // 
            this.barberCombo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barberCombo.FormattingEnabled = true;
            this.barberCombo.Location = new System.Drawing.Point(139, 12);
            this.barberCombo.Margin = new System.Windows.Forms.Padding(4);
            this.barberCombo.Name = "barberCombo";
            this.barberCombo.Size = new System.Drawing.Size(296, 32);
            this.barberCombo.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(504, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 18);
            this.label8.TabIndex = 66;
            this.label8.Text = "Add";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 34);
            this.label4.TabIndex = 24;
            this.label4.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 34);
            this.label3.TabIndex = 24;
            this.label3.Text = "Barber";
            // 
            // addOrd
            // 
            this.addOrd.BackColor = System.Drawing.Color.Transparent;
            this.addOrd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addOrd.BackgroundImage")));
            this.addOrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOrd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addOrd.Location = new System.Drawing.Point(458, 12);
            this.addOrd.Margin = new System.Windows.Forms.Padding(4);
            this.addOrd.Name = "addOrd";
            this.addOrd.Size = new System.Drawing.Size(129, 82);
            this.addOrd.TabIndex = 54;
            this.addOrd.UseVisualStyleBackColor = false;
            this.addOrd.Click += new System.EventHandler(this.addOrd_Click);
            // 
            // tIDlabel
            // 
            this.tIDlabel.AutoSize = true;
            this.tIDlabel.BackColor = System.Drawing.Color.Transparent;
            this.tIDlabel.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIDlabel.ForeColor = System.Drawing.Color.White;
            this.tIDlabel.Location = new System.Drawing.Point(244, 191);
            this.tIDlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tIDlabel.Name = "tIDlabel";
            this.tIDlabel.Size = new System.Drawing.Size(30, 34);
            this.tIDlabel.TabIndex = 24;
            this.tIDlabel.Text = "0";
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.Transparent;
            this.payBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payBtn.BackgroundImage")));
            this.payBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.payBtn.Location = new System.Drawing.Point(449, 21);
            this.payBtn.Margin = new System.Windows.Forms.Padding(4);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(127, 81);
            this.payBtn.TabIndex = 54;
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 34);
            this.label5.TabIndex = 55;
            this.label5.Text = "Total Amount :";
            // 
            // amtLabel
            // 
            this.amtLabel.AutoSize = true;
            this.amtLabel.BackColor = System.Drawing.Color.Transparent;
            this.amtLabel.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtLabel.ForeColor = System.Drawing.Color.White;
            this.amtLabel.Location = new System.Drawing.Point(204, 81);
            this.amtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amtLabel.Name = "amtLabel";
            this.amtLabel.Size = new System.Drawing.Size(30, 34);
            this.amtLabel.TabIndex = 56;
            this.amtLabel.Text = "0";
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.BackColor = System.Drawing.Color.Transparent;
            this.backlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backlabel.Location = new System.Drawing.Point(58, 146);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(39, 18);
            this.backlabel.TabIndex = 64;
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
            this.backBtn.Location = new System.Drawing.Point(24, 57);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(107, 89);
            this.backBtn.TabIndex = 63;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(495, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 65;
            this.label7.Text = "Pay";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.statusLabel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.amtLabel);
            this.panel2.Controls.Add(this.payBtn);
            this.panel2.Location = new System.Drawing.Point(24, 178);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 121);
            this.panel2.TabIndex = 67;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(129, 47);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(30, 34);
            this.statusLabel.TabIndex = 70;
            this.statusLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 34);
            this.label6.TabIndex = 55;
            this.label6.Text = "Status :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 41);
            this.panel3.TabIndex = 87;
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(10, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 24);
            this.label10.TabIndex = 84;
            this.label10.Text = "Barber Commission";
            // 
            // ServiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 656);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.backlabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.servicesGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tIDlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServiceDetail";
            this.Text = "ServiceDetail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServiceDetail_FormClosing);
            this.Load += new System.EventHandler(this.ServiceDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView servicesGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addOrd;
        private System.Windows.Forms.Label tIDlabel;
        private System.Windows.Forms.ComboBox barberCombo;
        private System.Windows.Forms.ComboBox serviceCombo;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label amtLabel;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
    }
}