using System;

namespace Kependudukan.view
{
    partial class dashboard
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
        /// 
        private void btnSubMenu1_Click(object sender, EventArgs e)
        {
            // Toggle submenu 1
            subPanel1.Visible = !subPanel1.Visible;

            // Jika submenu 1 dibuka, tutup submenu 2
            if (subPanel1.Visible)
            {
                subPanel2.Visible = false;
            }
        }

        private void btnSubMenu2_Click(object sender, EventArgs e)
        {
            // Toggle submenu 2
            subPanel2.Visible = !subPanel2.Visible;

            // Jika submenu 2 dibuka, tutup submenu 1
            if (subPanel2.Visible)
            {
                subPanel1.Visible = false;
            }
        }
        private void InitializeComponent()
        {
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.subPanel2 = new System.Windows.Forms.Panel();
            this.btnSubOption4 = new System.Windows.Forms.Button();
            this.btnSubOption3 = new System.Windows.Forms.Button();
            this.btnSubMenu2 = new System.Windows.Forms.Button();
            this.subPanel1 = new System.Windows.Forms.Panel();
            this.btnSubOption2 = new System.Windows.Forms.Button();
            this.btnSubOption1 = new System.Windows.Forms.Button();
            this.btnSubMenu1 = new System.Windows.Forms.Button();
            this.btnMain2 = new System.Windows.Forms.Button();
            this.btnMain1 = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.subPanel2.SuspendLayout();
            this.subPanel1.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.sidebarPanel.Controls.Add(this.subPanel2);
            this.sidebarPanel.Controls.Add(this.btnSubMenu2);
            this.sidebarPanel.Controls.Add(this.subPanel1);
            this.sidebarPanel.Controls.Add(this.btnSubMenu1);
            this.sidebarPanel.Controls.Add(this.btnMain2);
            this.sidebarPanel.Controls.Add(this.btnMain1);
            this.sidebarPanel.Controls.Add(this.logoPanel);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(250, 600);
            this.sidebarPanel.TabIndex = 0;
            // 
            // subPanel2
            // 
            this.subPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.subPanel2.Controls.Add(this.btnSubOption4);
            this.subPanel2.Controls.Add(this.btnSubOption3);
            this.subPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel2.Location = new System.Drawing.Point(0, 335);
            this.subPanel2.Name = "subPanel2";
            this.subPanel2.Size = new System.Drawing.Size(250, 80);
            this.subPanel2.TabIndex = 7;
            this.subPanel2.Visible = false;
            // 
            // btnSubOption4
            // 
            this.btnSubOption4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubOption4.FlatAppearance.BorderSize = 0;
            this.btnSubOption4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubOption4.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubOption4.Location = new System.Drawing.Point(0, 40);
            this.btnSubOption4.Name = "btnSubOption4";
            this.btnSubOption4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubOption4.Size = new System.Drawing.Size(250, 40);
            this.btnSubOption4.TabIndex = 1;
            this.btnSubOption4.Text = "Laporan Tahunan";
            this.btnSubOption4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubOption4.UseVisualStyleBackColor = true;
            // 
            // btnSubOption3
            // 
            this.btnSubOption3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubOption3.FlatAppearance.BorderSize = 0;
            this.btnSubOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubOption3.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubOption3.Location = new System.Drawing.Point(0, 0);
            this.btnSubOption3.Name = "btnSubOption3";
            this.btnSubOption3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubOption3.Size = new System.Drawing.Size(250, 40);
            this.btnSubOption3.TabIndex = 0;
            this.btnSubOption3.Text = "Laporan Bulanan";
            this.btnSubOption3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubOption3.UseVisualStyleBackColor = true;
            // 
            // btnSubMenu2
            // 
            this.btnSubMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenu2.FlatAppearance.BorderSize = 0;
            this.btnSubMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenu2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubMenu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu2.Location = new System.Drawing.Point(0, 290);
            this.btnSubMenu2.Name = "btnSubMenu2";
            this.btnSubMenu2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubMenu2.Size = new System.Drawing.Size(250, 45);
            this.btnSubMenu2.TabIndex = 6;
            this.btnSubMenu2.Text = "  Laporan";
            this.btnSubMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubMenu2.UseVisualStyleBackColor = true;
            this.btnSubMenu2.Click += new System.EventHandler(this.btnSubMenu2_Click);
            // 
            // subPanel1
            // 
            this.subPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.subPanel1.Controls.Add(this.btnSubOption2);
            this.subPanel1.Controls.Add(this.btnSubOption1);
            this.subPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel1.Location = new System.Drawing.Point(0, 200);
            this.subPanel1.Name = "subPanel1";
            this.subPanel1.Size = new System.Drawing.Size(250, 90);
            this.subPanel1.TabIndex = 5;
            this.subPanel1.Visible = false;
            // 
            // btnSubOption2
            // 
            this.btnSubOption2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubOption2.FlatAppearance.BorderSize = 0;
            this.btnSubOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubOption2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubOption2.Location = new System.Drawing.Point(0, 40);
            this.btnSubOption2.Name = "btnSubOption2";
            this.btnSubOption2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubOption2.Size = new System.Drawing.Size(250, 40);
            this.btnSubOption2.TabIndex = 1;
            this.btnSubOption2.Text = "Input Data Penduduk";
            this.btnSubOption2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubOption2.UseVisualStyleBackColor = true;
            // 
            // btnSubOption1
            // 
            this.btnSubOption1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubOption1.FlatAppearance.BorderSize = 0;
            this.btnSubOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubOption1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubOption1.Location = new System.Drawing.Point(0, 0);
            this.btnSubOption1.Name = "btnSubOption1";
            this.btnSubOption1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubOption1.Size = new System.Drawing.Size(250, 40);
            this.btnSubOption1.TabIndex = 0;
            this.btnSubOption1.Text = "Lihat Data Penduduk";
            this.btnSubOption1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubOption1.UseVisualStyleBackColor = true;
            // 
            // btnSubMenu1
            // 
            this.btnSubMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenu1.FlatAppearance.BorderSize = 0;
            this.btnSubMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenu1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubMenu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu1.Location = new System.Drawing.Point(0, 155);
            this.btnSubMenu1.Name = "btnSubMenu1";
            this.btnSubMenu1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubMenu1.Size = new System.Drawing.Size(250, 45);
            this.btnSubMenu1.TabIndex = 4;
            this.btnSubMenu1.Text = "  Data Penduduk";
            this.btnSubMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenu1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubMenu1.UseVisualStyleBackColor = true;
            this.btnSubMenu1.Click += new System.EventHandler(this.btnSubMenu1_Click);
            // 
            // btnMain2
            // 
            this.btnMain2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain2.FlatAppearance.BorderSize = 0;
            this.btnMain2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMain2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain2.Location = new System.Drawing.Point(0, 110);
            this.btnMain2.Name = "btnMain2";
            this.btnMain2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMain2.Size = new System.Drawing.Size(250, 45);
            this.btnMain2.TabIndex = 2;
            this.btnMain2.Text = "  Pengaturan";
            this.btnMain2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMain2.UseVisualStyleBackColor = true;
            // 
            // btnMain1
            // 
            this.btnMain1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain1.FlatAppearance.BorderSize = 0;
            this.btnMain1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMain1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain1.Location = new System.Drawing.Point(0, 65);
            this.btnMain1.Name = "btnMain1";
            this.btnMain1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMain1.Size = new System.Drawing.Size(250, 45);
            this.btnMain1.TabIndex = 1;
            this.btnMain1.Text = "  Dashboard";
            this.btnMain1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMain1.UseVisualStyleBackColor = true;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.logoPanel.Controls.Add(this.logoLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(250, 65);
            this.logoPanel.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(12, 23);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(121, 20);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "KEPENDUDUKAN";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.headerPanel.Controls.Add(this.userLabel);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(250, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(750, 80);
            this.headerPanel.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(640, 32);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(88, 17);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Admin User";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(101, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dashboard";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(250, 80);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(750, 520);
            this.mainPanel.TabIndex = 2;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidebarPanel);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Kependudukan";
            this.sidebarPanel.ResumeLayout(false);
            this.subPanel2.ResumeLayout(false);
            this.subPanel1.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button btnMain1;
        private System.Windows.Forms.Button btnMain2;
        private System.Windows.Forms.Panel subPanel1;
        private System.Windows.Forms.Button btnSubMenu1;
        private System.Windows.Forms.Button btnSubOption1;
        private System.Windows.Forms.Button btnSubOption2;
        private System.Windows.Forms.Button btnSubMenu2;
        private System.Windows.Forms.Panel subPanel2;
        private System.Windows.Forms.Button btnSubOption4;
        private System.Windows.Forms.Button btnSubOption3;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel mainPanel;
    }
}