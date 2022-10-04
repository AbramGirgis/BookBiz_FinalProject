namespace BookBizManagementSystem
{
    partial class OrderClerksForm
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
            this.labelQuestionClerk = new System.Windows.Forms.Label();
            this.labelWelcomeOrderClerk = new System.Windows.Forms.Label();
            this.buttonListOrders = new System.Windows.Forms.Button();
            this.buttonSearchOrder = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClerkLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestionClerk
            // 
            this.labelQuestionClerk.AutoSize = true;
            this.labelQuestionClerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionClerk.Location = new System.Drawing.Point(85, 204);
            this.labelQuestionClerk.Name = "labelQuestionClerk";
            this.labelQuestionClerk.Size = new System.Drawing.Size(375, 36);
            this.labelQuestionClerk.TabIndex = 16;
            this.labelQuestionClerk.Text = "What would you like to do?";
            // 
            // labelWelcomeOrderClerk
            // 
            this.labelWelcomeOrderClerk.AutoSize = true;
            this.labelWelcomeOrderClerk.BackColor = System.Drawing.Color.RosyBrown;
            this.labelWelcomeOrderClerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeOrderClerk.Location = new System.Drawing.Point(601, 73);
            this.labelWelcomeOrderClerk.Name = "labelWelcomeOrderClerk";
            this.labelWelcomeOrderClerk.Size = new System.Drawing.Size(454, 48);
            this.labelWelcomeOrderClerk.TabIndex = 15;
            this.labelWelcomeOrderClerk.Text = "Welcome, Order Clerk";
            // 
            // buttonListOrders
            // 
            this.buttonListOrders.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonListOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListOrders.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonListOrders.Location = new System.Drawing.Point(267, 507);
            this.buttonListOrders.Name = "buttonListOrders";
            this.buttonListOrders.Size = new System.Drawing.Size(275, 130);
            this.buttonListOrders.TabIndex = 14;
            this.buttonListOrders.Text = "List Orders";
            this.buttonListOrders.UseVisualStyleBackColor = false;
            this.buttonListOrders.Click += new System.EventHandler(this.buttonListOrders_Click);
            // 
            // buttonSearchOrder
            // 
            this.buttonSearchOrder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSearchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchOrder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSearchOrder.Location = new System.Drawing.Point(630, 312);
            this.buttonSearchOrder.Name = "buttonSearchOrder";
            this.buttonSearchOrder.Size = new System.Drawing.Size(275, 130);
            this.buttonSearchOrder.TabIndex = 13;
            this.buttonSearchOrder.Text = "Search Order";
            this.buttonSearchOrder.UseVisualStyleBackColor = false;
            this.buttonSearchOrder.Click += new System.EventHandler(this.buttonSearchOrder_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddOrder.Location = new System.Drawing.Point(267, 312);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(275, 130);
            this.buttonAddOrder.TabIndex = 12;
            this.buttonAddOrder.Text = "Add Order";
            this.buttonAddOrder.UseVisualStyleBackColor = false;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelOrder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCancelOrder.Location = new System.Drawing.Point(630, 507);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(275, 130);
            this.buttonCancelOrder.TabIndex = 18;
            this.buttonCancelOrder.Text = "Cancel Order";
            this.buttonCancelOrder.UseVisualStyleBackColor = false;
            this.buttonCancelOrder.Click += new System.EventHandler(this.buttonCancelOrder_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonExit.Location = new System.Drawing.Point(892, 762);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(163, 61);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClerkLogout
            // 
            this.buttonClerkLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClerkLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonClerkLogout.Location = new System.Drawing.Point(678, 762);
            this.buttonClerkLogout.Name = "buttonClerkLogout";
            this.buttonClerkLogout.Size = new System.Drawing.Size(163, 61);
            this.buttonClerkLogout.TabIndex = 19;
            this.buttonClerkLogout.Text = "Logout";
            this.buttonClerkLogout.UseVisualStyleBackColor = true;
            this.buttonClerkLogout.Click += new System.EventHandler(this.buttonClerkLogout_Click);
            // 
            // OrderClerksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 871);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClerkLogout);
            this.Controls.Add(this.buttonCancelOrder);
            this.Controls.Add(this.labelQuestionClerk);
            this.Controls.Add(this.labelWelcomeOrderClerk);
            this.Controls.Add(this.buttonListOrders);
            this.Controls.Add(this.buttonSearchOrder);
            this.Controls.Add(this.buttonAddOrder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderClerksForm";
            this.Text = "Order Clerks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelQuestionClerk;
        private System.Windows.Forms.Label labelWelcomeOrderClerk;
        private System.Windows.Forms.Button buttonListOrders;
        private System.Windows.Forms.Button buttonSearchOrder;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClerkLogout;
    }
}