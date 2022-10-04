namespace BookBizManagementSystem
{
    partial class SalesManagerForm
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
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.buttonListClients = new System.Windows.Forms.Button();
            this.labelWelcomeSalesManager = new System.Windows.Forms.Label();
            this.labelQuestionSales = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSalesManagerLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClient.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddClient.Location = new System.Drawing.Point(87, 300);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(275, 130);
            this.buttonAddClient.TabIndex = 0;
            this.buttonAddClient.Text = "Add Client";
            this.buttonAddClient.UseVisualStyleBackColor = false;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchClient.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSearchClient.Location = new System.Drawing.Point(450, 300);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(275, 130);
            this.buttonSearchClient.TabIndex = 1;
            this.buttonSearchClient.Text = "Search Client";
            this.buttonSearchClient.UseVisualStyleBackColor = false;
            this.buttonSearchClient.Click += new System.EventHandler(this.buttonSearchClient_Click);
            // 
            // buttonListClients
            // 
            this.buttonListClients.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonListClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListClients.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonListClients.Location = new System.Drawing.Point(813, 300);
            this.buttonListClients.Name = "buttonListClients";
            this.buttonListClients.Size = new System.Drawing.Size(275, 130);
            this.buttonListClients.TabIndex = 2;
            this.buttonListClients.Text = "List Clients";
            this.buttonListClients.UseVisualStyleBackColor = false;
            this.buttonListClients.Click += new System.EventHandler(this.buttonListClients_Click);
            // 
            // labelWelcomeSalesManager
            // 
            this.labelWelcomeSalesManager.AutoSize = true;
            this.labelWelcomeSalesManager.BackColor = System.Drawing.Color.RosyBrown;
            this.labelWelcomeSalesManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeSalesManager.Location = new System.Drawing.Point(568, 57);
            this.labelWelcomeSalesManager.Name = "labelWelcomeSalesManager";
            this.labelWelcomeSalesManager.Size = new System.Drawing.Size(520, 48);
            this.labelWelcomeSalesManager.TabIndex = 3;
            this.labelWelcomeSalesManager.Text = "Welcome, Sales Manager";
            // 
            // labelQuestionSales
            // 
            this.labelQuestionSales.AutoSize = true;
            this.labelQuestionSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionSales.Location = new System.Drawing.Point(57, 174);
            this.labelQuestionSales.Name = "labelQuestionSales";
            this.labelQuestionSales.Size = new System.Drawing.Size(375, 36);
            this.labelQuestionSales.TabIndex = 4;
            this.labelQuestionSales.Text = "What would you like to do?";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonExit.Location = new System.Drawing.Point(925, 576);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(163, 61);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSalesManagerLogout
            // 
            this.buttonSalesManagerLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesManagerLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSalesManagerLogout.Location = new System.Drawing.Point(711, 576);
            this.buttonSalesManagerLogout.Name = "buttonSalesManagerLogout";
            this.buttonSalesManagerLogout.Size = new System.Drawing.Size(163, 61);
            this.buttonSalesManagerLogout.TabIndex = 16;
            this.buttonSalesManagerLogout.Text = "Logout";
            this.buttonSalesManagerLogout.UseVisualStyleBackColor = true;
            this.buttonSalesManagerLogout.Click += new System.EventHandler(this.buttonSalesManagerLogout_Click);
            // 
            // SalesManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 715);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSalesManagerLogout);
            this.Controls.Add(this.labelQuestionSales);
            this.Controls.Add(this.labelWelcomeSalesManager);
            this.Controls.Add(this.buttonListClients);
            this.Controls.Add(this.buttonSearchClient);
            this.Controls.Add(this.buttonAddClient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesManagerForm";
            this.Text = "Sales Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonSearchClient;
        private System.Windows.Forms.Button buttonListClients;
        private System.Windows.Forms.Label labelWelcomeSalesManager;
        private System.Windows.Forms.Label labelQuestionSales;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSalesManagerLogout;
    }
}