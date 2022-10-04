namespace BookBizManagementSystem
{
    partial class MISManagerForm
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
            this.buttonMISManagerLogout = new System.Windows.Forms.Button();
            this.labelQuestionMIS = new System.Windows.Forms.Label();
            this.labelWelcomeMISManager = new System.Windows.Forms.Label();
            this.buttonListEmployees = new System.Windows.Forms.Button();
            this.buttonSearchEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonListUsers = new System.Windows.Forms.Button();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMISManagerLogout
            // 
            this.buttonMISManagerLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMISManagerLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonMISManagerLogout.Location = new System.Drawing.Point(726, 738);
            this.buttonMISManagerLogout.Name = "buttonMISManagerLogout";
            this.buttonMISManagerLogout.Size = new System.Drawing.Size(163, 61);
            this.buttonMISManagerLogout.TabIndex = 11;
            this.buttonMISManagerLogout.Text = "Logout";
            this.buttonMISManagerLogout.UseVisualStyleBackColor = true;
            this.buttonMISManagerLogout.Click += new System.EventHandler(this.buttonMISManagerLogout_Click);
            // 
            // labelQuestionMIS
            // 
            this.labelQuestionMIS.AutoSize = true;
            this.labelQuestionMIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionMIS.Location = new System.Drawing.Point(64, 218);
            this.labelQuestionMIS.Name = "labelQuestionMIS";
            this.labelQuestionMIS.Size = new System.Drawing.Size(375, 36);
            this.labelQuestionMIS.TabIndex = 10;
            this.labelQuestionMIS.Text = "What would you like to do?";
            // 
            // labelWelcomeMISManager
            // 
            this.labelWelcomeMISManager.AutoSize = true;
            this.labelWelcomeMISManager.BackColor = System.Drawing.Color.RosyBrown;
            this.labelWelcomeMISManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeMISManager.Location = new System.Drawing.Point(640, 58);
            this.labelWelcomeMISManager.Name = "labelWelcomeMISManager";
            this.labelWelcomeMISManager.Size = new System.Drawing.Size(488, 48);
            this.labelWelcomeMISManager.TabIndex = 9;
            this.labelWelcomeMISManager.Text = "Welcome, MIS Manager";
            // 
            // buttonListEmployees
            // 
            this.buttonListEmployees.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonListEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListEmployees.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonListEmployees.Location = new System.Drawing.Point(828, 512);
            this.buttonListEmployees.Name = "buttonListEmployees";
            this.buttonListEmployees.Size = new System.Drawing.Size(275, 130);
            this.buttonListEmployees.TabIndex = 8;
            this.buttonListEmployees.Text = "List Employees";
            this.buttonListEmployees.UseVisualStyleBackColor = false;
            this.buttonListEmployees.Click += new System.EventHandler(this.buttonListEmployees_Click);
            // 
            // buttonSearchEmployee
            // 
            this.buttonSearchEmployee.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchEmployee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSearchEmployee.Location = new System.Drawing.Point(465, 512);
            this.buttonSearchEmployee.Name = "buttonSearchEmployee";
            this.buttonSearchEmployee.Size = new System.Drawing.Size(275, 130);
            this.buttonSearchEmployee.TabIndex = 7;
            this.buttonSearchEmployee.Text = "Search Employee";
            this.buttonSearchEmployee.UseVisualStyleBackColor = false;
            this.buttonSearchEmployee.Click += new System.EventHandler(this.buttonSearchEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmployee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddEmployee.Location = new System.Drawing.Point(102, 512);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(275, 130);
            this.buttonAddEmployee.TabIndex = 6;
            this.buttonAddEmployee.Text = "Add Employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonListUsers
            // 
            this.buttonListUsers.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonListUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListUsers.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonListUsers.Location = new System.Drawing.Point(828, 337);
            this.buttonListUsers.Name = "buttonListUsers";
            this.buttonListUsers.Size = new System.Drawing.Size(275, 130);
            this.buttonListUsers.TabIndex = 14;
            this.buttonListUsers.Text = "List Users";
            this.buttonListUsers.UseVisualStyleBackColor = false;
            this.buttonListUsers.Click += new System.EventHandler(this.buttonListUsers_Click);
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSearchUser.Location = new System.Drawing.Point(465, 337);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(275, 130);
            this.buttonSearchUser.TabIndex = 13;
            this.buttonSearchUser.Text = "Search User";
            this.buttonSearchUser.UseVisualStyleBackColor = false;
            this.buttonSearchUser.Click += new System.EventHandler(this.buttonSearchUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddUser.Location = new System.Drawing.Point(102, 337);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(275, 130);
            this.buttonAddUser.TabIndex = 12;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonExit.Location = new System.Drawing.Point(940, 738);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(163, 61);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MISManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 879);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonListUsers);
            this.Controls.Add(this.buttonSearchUser);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonMISManagerLogout);
            this.Controls.Add(this.labelQuestionMIS);
            this.Controls.Add(this.labelWelcomeMISManager);
            this.Controls.Add(this.buttonListEmployees);
            this.Controls.Add(this.buttonSearchEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MISManagerForm";
            this.Text = "MIS Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMISManagerLogout;
        private System.Windows.Forms.Label labelQuestionMIS;
        private System.Windows.Forms.Label labelWelcomeMISManager;
        private System.Windows.Forms.Button buttonListEmployees;
        private System.Windows.Forms.Button buttonSearchEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonListUsers;
        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonExit;
    }
}