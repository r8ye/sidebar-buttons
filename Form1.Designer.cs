﻿namespace night
{
    partial class Form1
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
            this.elipseForm1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pMenuBar = new Guna.UI2.WinForms.Guna2Panel();
            this.pExit = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnUserConfiguration = new FontAwesome.Sharp.IconButton();
            this.btnProgram = new FontAwesome.Sharp.IconButton();
            this.btnYearLevel = new FontAwesome.Sharp.IconButton();
            this.btnDepartment = new FontAwesome.Sharp.IconButton();
            this.btnStudents = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.pLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.pbLogo = new FontAwesome.Sharp.IconPictureBox();
            this.elipseMenubar = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseDesktop = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pDesktop = new System.Windows.Forms.Panel();
            this.pMenuBar.SuspendLayout();
            this.pExit.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseForm1
            // 
            this.elipseForm1.BorderRadius = 20;
            this.elipseForm1.TargetControl = this;
            // 
            // pMenuBar
            // 
            this.pMenuBar.BackColor = System.Drawing.Color.White;
            this.pMenuBar.Controls.Add(this.pExit);
            this.pMenuBar.Controls.Add(this.btnUserConfiguration);
            this.pMenuBar.Controls.Add(this.btnProgram);
            this.pMenuBar.Controls.Add(this.btnYearLevel);
            this.pMenuBar.Controls.Add(this.btnDepartment);
            this.pMenuBar.Controls.Add(this.btnStudents);
            this.pMenuBar.Controls.Add(this.btnDashboard);
            this.pMenuBar.Controls.Add(this.pLogo);
            this.pMenuBar.Location = new System.Drawing.Point(12, 12);
            this.pMenuBar.Name = "pMenuBar";
            this.pMenuBar.ShadowDecoration.Parent = this.pMenuBar;
            this.pMenuBar.Size = new System.Drawing.Size(62, 561);
            this.pMenuBar.TabIndex = 0;
            // 
            // pExit
            // 
            this.pExit.BackColor = System.Drawing.Color.Transparent;
            this.pExit.Controls.Add(this.btnLogout);
            this.pExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pExit.Location = new System.Drawing.Point(0, 417);
            this.pExit.Name = "pExit";
            this.pExit.ShadowDecoration.Parent = this.pExit;
            this.pExit.Size = new System.Drawing.Size(62, 144);
            this.pExit.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoEllipsis = true;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.Lavender;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 35;
            this.btnLogout.Location = new System.Drawing.Point(0, 76);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 50);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserConfiguration
            // 
            this.btnUserConfiguration.AutoEllipsis = true;
            this.btnUserConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserConfiguration.ForeColor = System.Drawing.Color.Transparent;
            this.btnUserConfiguration.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnUserConfiguration.IconColor = System.Drawing.Color.Lavender;
            this.btnUserConfiguration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserConfiguration.IconSize = 35;
            this.btnUserConfiguration.Location = new System.Drawing.Point(0, 361);
            this.btnUserConfiguration.Name = "btnUserConfiguration";
            this.btnUserConfiguration.Size = new System.Drawing.Size(62, 50);
            this.btnUserConfiguration.TabIndex = 7;
            this.btnUserConfiguration.UseVisualStyleBackColor = true;
            this.btnUserConfiguration.Click += new System.EventHandler(this.btnUserConfiguration_Click);
            // 
            // btnProgram
            // 
            this.btnProgram.AutoEllipsis = true;
            this.btnProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgram.ForeColor = System.Drawing.Color.Transparent;
            this.btnProgram.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            this.btnProgram.IconColor = System.Drawing.Color.Lavender;
            this.btnProgram.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProgram.IconSize = 35;
            this.btnProgram.Location = new System.Drawing.Point(0, 311);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(62, 50);
            this.btnProgram.TabIndex = 6;
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // btnYearLevel
            // 
            this.btnYearLevel.AutoEllipsis = true;
            this.btnYearLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYearLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearLevel.ForeColor = System.Drawing.Color.Transparent;
            this.btnYearLevel.IconChar = FontAwesome.Sharp.IconChar.Stairs;
            this.btnYearLevel.IconColor = System.Drawing.Color.Lavender;
            this.btnYearLevel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnYearLevel.IconSize = 35;
            this.btnYearLevel.Location = new System.Drawing.Point(0, 261);
            this.btnYearLevel.Name = "btnYearLevel";
            this.btnYearLevel.Size = new System.Drawing.Size(62, 50);
            this.btnYearLevel.TabIndex = 5;
            this.btnYearLevel.UseVisualStyleBackColor = true;
            this.btnYearLevel.Click += new System.EventHandler(this.btnYearLevel_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.AutoEllipsis = true;
            this.btnDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.ForeColor = System.Drawing.Color.Transparent;
            this.btnDepartment.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btnDepartment.IconColor = System.Drawing.Color.Lavender;
            this.btnDepartment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDepartment.IconSize = 35;
            this.btnDepartment.Location = new System.Drawing.Point(0, 211);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(62, 50);
            this.btnDepartment.TabIndex = 4;
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.AutoEllipsis = true;
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.ForeColor = System.Drawing.Color.Transparent;
            this.btnStudents.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnStudents.IconColor = System.Drawing.Color.Lavender;
            this.btnStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudents.IconSize = 35;
            this.btnStudents.Location = new System.Drawing.Point(0, 161);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(62, 50);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AutoEllipsis = true;
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnDashboard.IconColor = System.Drawing.Color.Lavender;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 35;
            this.btnDashboard.Location = new System.Drawing.Point(0, 111);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(62, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.Transparent;
            this.pLogo.Controls.Add(this.pbLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.ShadowDecoration.Parent = this.pLogo;
            this.pLogo.Size = new System.Drawing.Size(62, 111);
            this.pLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.pbLogo.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.pbLogo.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.pbLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbLogo.IconSize = 44;
            this.pbLogo.Location = new System.Drawing.Point(9, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(50, 44);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // elipseMenubar
            // 
            this.elipseMenubar.BorderRadius = 20;
            this.elipseMenubar.TargetControl = this.pMenuBar;
            // 
            // elipseDesktop
            // 
            this.elipseDesktop.BorderRadius = 20;
            this.elipseDesktop.TargetControl = this.pDesktop;
            // 
            // pDesktop
            // 
            this.pDesktop.BackColor = System.Drawing.Color.White;
            this.pDesktop.Location = new System.Drawing.Point(89, 12);
            this.pDesktop.Name = "pDesktop";
            this.pDesktop.Size = new System.Drawing.Size(873, 561);
            this.pDesktop.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(974, 585);
            this.Controls.Add(this.pDesktop);
            this.Controls.Add(this.pMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pMenuBar.ResumeLayout(false);
            this.pExit.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseForm1;
        private Guna.UI2.WinForms.Guna2Panel pMenuBar;
        private Guna.UI2.WinForms.Guna2Elipse elipseMenubar;
        private Guna.UI2.WinForms.Guna2Panel pLogo;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnStudents;
        private FontAwesome.Sharp.IconButton btnDepartment;
        private FontAwesome.Sharp.IconButton btnYearLevel;
        private FontAwesome.Sharp.IconButton btnProgram;
        private FontAwesome.Sharp.IconButton btnUserConfiguration;
        private Guna.UI2.WinForms.Guna2Panel pExit;
        private FontAwesome.Sharp.IconButton btnLogout;
        private Guna.UI2.WinForms.Guna2Elipse elipseDesktop;
        private FontAwesome.Sharp.IconPictureBox pbLogo;
        private System.Windows.Forms.Panel pDesktop;
    }
}

