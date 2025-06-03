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

        private void btnRegion_Click(object sender, EventArgs e)
        {
            subPanelRegion.Visible = !subPanelRegion.Visible;
            if (subPanelRegion.Visible)
            {
                subPanelPopulation.Visible = false;
                subPanelSettings.Visible = false;
            }
        }

        private void btnPopulationMenu_Click(object sender, EventArgs e)
        {
            subPanelPopulation.Visible = !subPanelPopulation.Visible;
            if (subPanelPopulation.Visible)
            {
                subPanelRegion.Visible = false;
                subPanelSettings.Visible = false;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            subPanelSettings.Visible = !subPanelSettings.Visible;
            if (subPanelSettings.Visible)
            {
                subPanelRegion.Visible = false;
                subPanelPopulation.Visible = false;
            }
        }

        private void InitializeComponent()
        {
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.subPanelSettings = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.subPanelPopulation = new System.Windows.Forms.Panel();
            this.btnEconomy = new System.Windows.Forms.Button();
            this.btnFamily = new System.Windows.Forms.Button();
            this.btnPopulation = new System.Windows.Forms.Button();
            this.btnPopulationMenu = new System.Windows.Forms.Button();
            this.subPanelRegion = new System.Windows.Forms.Panel();
            this.btnVillage = new System.Windows.Forms.Button();
            this.btnDistrict = new System.Windows.Forms.Button();
            this.btnRegency = new System.Windows.Forms.Button();
            this.btnProvince = new System.Windows.Forms.Button();
            this.btnRegion = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.subPanelSettings.SuspendLayout();
            this.subPanelPopulation.SuspendLayout();
            this.subPanelRegion.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.sidebarPanel.Controls.Add(this.subPanelSettings);
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.subPanelPopulation);
            this.sidebarPanel.Controls.Add(this.btnPopulationMenu);
            this.sidebarPanel.Controls.Add(this.subPanelRegion);
            this.sidebarPanel.Controls.Add(this.btnRegion);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.Controls.Add(this.logoPanel);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(250, 600);
            this.sidebarPanel.TabIndex = 0;
            // 
            // subPanelSettings
            // 
            this.subPanelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.subPanelSettings.Controls.Add(this.btnLogout);
            this.subPanelSettings.Controls.Add(this.btnChangePassword);
            this.subPanelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelSettings.Location = new System.Drawing.Point(0, 470);
            this.subPanelSettings.Name = "subPanelSettings";
            this.subPanelSettings.Size = new System.Drawing.Size(250, 80);
            this.subPanelSettings.TabIndex = 7;
            this.subPanelSettings.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Location = new System.Drawing.Point(0, 40);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 40);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 0);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(250, 40);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.Text = "Ganti Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 425);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(250, 45);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "  Pengaturan";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // subPanelPopulation
            // 
            this.subPanelPopulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.subPanelPopulation.Controls.Add(this.btnEconomy);
            this.subPanelPopulation.Controls.Add(this.btnFamily);
            this.subPanelPopulation.Controls.Add(this.btnPopulation);
            this.subPanelPopulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelPopulation.Location = new System.Drawing.Point(0, 335);
            this.subPanelPopulation.Name = "subPanelPopulation";
            this.subPanelPopulation.Size = new System.Drawing.Size(250, 120);
            this.subPanelPopulation.TabIndex = 5;
            this.subPanelPopulation.Visible = false;
            // 
            // btnEconomy
            // 
            this.btnEconomy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEconomy.FlatAppearance.BorderSize = 0;
            this.btnEconomy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEconomy.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEconomy.Location = new System.Drawing.Point(0, 80);
            this.btnEconomy.Name = "btnEconomy";
            this.btnEconomy.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEconomy.Size = new System.Drawing.Size(250, 40);
            this.btnEconomy.TabIndex = 2;
            this.btnEconomy.Text = "Ekonomi";
            this.btnEconomy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEconomy.UseVisualStyleBackColor = true;
            // 
            // btnFamily
            // 
            this.btnFamily.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFamily.FlatAppearance.BorderSize = 0;
            this.btnFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamily.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFamily.Location = new System.Drawing.Point(0, 40);
            this.btnFamily.Name = "btnFamily";
            this.btnFamily.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFamily.Size = new System.Drawing.Size(250, 40);
            this.btnFamily.TabIndex = 1;
            this.btnFamily.Text = "Keluarga";
            this.btnFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFamily.UseVisualStyleBackColor = true;
            // 
            // btnPopulation
            // 
            this.btnPopulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPopulation.FlatAppearance.BorderSize = 0;
            this.btnPopulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopulation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPopulation.Location = new System.Drawing.Point(0, 0);
            this.btnPopulation.Name = "btnPopulation";
            this.btnPopulation.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPopulation.Size = new System.Drawing.Size(250, 40);
            this.btnPopulation.TabIndex = 0;
            this.btnPopulation.Text = "Penduduk";
            this.btnPopulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPopulation.UseVisualStyleBackColor = true;
            // 
            // btnPopulationMenu
            // 
            this.btnPopulationMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPopulationMenu.FlatAppearance.BorderSize = 0;
            this.btnPopulationMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopulationMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopulationMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPopulationMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPopulationMenu.Location = new System.Drawing.Point(0, 290);
            this.btnPopulationMenu.Name = "btnPopulationMenu";
            this.btnPopulationMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPopulationMenu.Size = new System.Drawing.Size(250, 45);
            this.btnPopulationMenu.TabIndex = 4;
            this.btnPopulationMenu.Text = "  Kependudukan";
            this.btnPopulationMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPopulationMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPopulationMenu.UseVisualStyleBackColor = true;
            this.btnPopulationMenu.Click += new System.EventHandler(this.btnPopulationMenu_Click);
            // 
            // subPanelRegion
            // 
            this.subPanelRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.subPanelRegion.Controls.Add(this.btnVillage);
            this.subPanelRegion.Controls.Add(this.btnDistrict);
            this.subPanelRegion.Controls.Add(this.btnRegency);
            this.subPanelRegion.Controls.Add(this.btnProvince);
            this.subPanelRegion.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelRegion.Location = new System.Drawing.Point(0, 155);
            this.subPanelRegion.Name = "subPanelRegion";
            this.subPanelRegion.Size = new System.Drawing.Size(250, 168);
            this.subPanelRegion.TabIndex = 3;
            this.subPanelRegion.Visible = false;
            // 
            // btnVillage
            // 
            this.btnVillage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVillage.FlatAppearance.BorderSize = 0;
            this.btnVillage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVillage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVillage.Location = new System.Drawing.Point(0, 120);
            this.btnVillage.Name = "btnVillage";
            this.btnVillage.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVillage.Size = new System.Drawing.Size(250, 40);
            this.btnVillage.TabIndex = 3;
            this.btnVillage.Text = "Desa";
            this.btnVillage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVillage.UseVisualStyleBackColor = true;
            // 
            // btnDistrict
            // 
            this.btnDistrict.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDistrict.FlatAppearance.BorderSize = 0;
            this.btnDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistrict.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDistrict.Location = new System.Drawing.Point(0, 80);
            this.btnDistrict.Name = "btnDistrict";
            this.btnDistrict.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDistrict.Size = new System.Drawing.Size(250, 40);
            this.btnDistrict.TabIndex = 2;
            this.btnDistrict.Text = "Kecamatan";
            this.btnDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDistrict.UseVisualStyleBackColor = true;
            // 
            // btnRegency
            // 
            this.btnRegency.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegency.FlatAppearance.BorderSize = 0;
            this.btnRegency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegency.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegency.Location = new System.Drawing.Point(0, 40);
            this.btnRegency.Name = "btnRegency";
            this.btnRegency.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegency.Size = new System.Drawing.Size(250, 40);
            this.btnRegency.TabIndex = 1;
            this.btnRegency.Text = "Kabupaten";
            this.btnRegency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegency.UseVisualStyleBackColor = true;
            // 
            // btnProvince
            // 
            this.btnProvince.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProvince.FlatAppearance.BorderSize = 0;
            this.btnProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvince.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProvince.Location = new System.Drawing.Point(0, 0);
            this.btnProvince.Name = "btnProvince";
            this.btnProvince.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProvince.Size = new System.Drawing.Size(250, 40);
            this.btnProvince.TabIndex = 0;
            this.btnProvince.Text = "Provinsi";
            this.btnProvince.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProvince.UseVisualStyleBackColor = true;
            // 
            // btnRegion
            // 
            this.btnRegion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegion.FlatAppearance.BorderSize = 0;
            this.btnRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegion.Location = new System.Drawing.Point(0, 110);
            this.btnRegion.Name = "btnRegion";
            this.btnRegion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegion.Size = new System.Drawing.Size(250, 45);
            this.btnRegion.TabIndex = 2;
            this.btnRegion.Text = "  Wilayah";
            this.btnRegion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegion.UseVisualStyleBackColor = true;
            this.btnRegion.Click += new System.EventHandler(this.btnRegion_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 65);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(250, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
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
            this.subPanelSettings.ResumeLayout(false);
            this.subPanelPopulation.ResumeLayout(false);
            this.subPanelRegion.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnRegion;
        private System.Windows.Forms.Panel subPanelRegion;
        private System.Windows.Forms.Button btnVillage;
        private System.Windows.Forms.Button btnDistrict;
        private System.Windows.Forms.Button btnRegency;
        private System.Windows.Forms.Button btnProvince;
        private System.Windows.Forms.Button btnPopulationMenu;
        private System.Windows.Forms.Panel subPanelPopulation;
        private System.Windows.Forms.Button btnEconomy;
        private System.Windows.Forms.Button btnFamily;
        private System.Windows.Forms.Button btnPopulation;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel subPanelSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePassword;
    }
}