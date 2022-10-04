namespace BookBizManagementSystem
{
    partial class InventoryControllerForm
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
            this.labelQuestionInventory = new System.Windows.Forms.Label();
            this.labelWelcomeInventoryController = new System.Windows.Forms.Label();
            this.buttonListBooks = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonInventoryControllerLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestionInventory
            // 
            this.labelQuestionInventory.AutoSize = true;
            this.labelQuestionInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionInventory.Location = new System.Drawing.Point(83, 191);
            this.labelQuestionInventory.Name = "labelQuestionInventory";
            this.labelQuestionInventory.Size = new System.Drawing.Size(375, 36);
            this.labelQuestionInventory.TabIndex = 10;
            this.labelQuestionInventory.Text = "What would you like to do?";
            // 
            // labelWelcomeInventoryController
            // 
            this.labelWelcomeInventoryController.AutoSize = true;
            this.labelWelcomeInventoryController.BackColor = System.Drawing.Color.RosyBrown;
            this.labelWelcomeInventoryController.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeInventoryController.Location = new System.Drawing.Point(506, 55);
            this.labelWelcomeInventoryController.Name = "labelWelcomeInventoryController";
            this.labelWelcomeInventoryController.Size = new System.Drawing.Size(612, 48);
            this.labelWelcomeInventoryController.TabIndex = 9;
            this.labelWelcomeInventoryController.Text = "Welcome, Inventory Controller";
            // 
            // buttonListBooks
            // 
            this.buttonListBooks.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonListBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListBooks.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonListBooks.Location = new System.Drawing.Point(843, 310);
            this.buttonListBooks.Name = "buttonListBooks";
            this.buttonListBooks.Size = new System.Drawing.Size(275, 130);
            this.buttonListBooks.TabIndex = 8;
            this.buttonListBooks.Text = "List Books";
            this.buttonListBooks.UseVisualStyleBackColor = false;
            this.buttonListBooks.Click += new System.EventHandler(this.buttonListBooks_Click);
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSearchBook.Location = new System.Drawing.Point(480, 310);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(275, 130);
            this.buttonSearchBook.TabIndex = 7;
            this.buttonSearchBook.Text = "Search Book";
            this.buttonSearchBook.UseVisualStyleBackColor = false;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddBook.Location = new System.Drawing.Point(117, 310);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(275, 130);
            this.buttonAddBook.TabIndex = 6;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonExit.Location = new System.Drawing.Point(955, 581);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(163, 61);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonInventoryControllerLogout
            // 
            this.buttonInventoryControllerLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventoryControllerLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonInventoryControllerLogout.Location = new System.Drawing.Point(741, 581);
            this.buttonInventoryControllerLogout.Name = "buttonInventoryControllerLogout";
            this.buttonInventoryControllerLogout.Size = new System.Drawing.Size(163, 61);
            this.buttonInventoryControllerLogout.TabIndex = 16;
            this.buttonInventoryControllerLogout.Text = "Logout";
            this.buttonInventoryControllerLogout.UseVisualStyleBackColor = true;
            this.buttonInventoryControllerLogout.Click += new System.EventHandler(this.buttonInventoryControllerLogout_Click);
            // 
            // InventoryControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 730);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInventoryControllerLogout);
            this.Controls.Add(this.labelQuestionInventory);
            this.Controls.Add(this.labelWelcomeInventoryController);
            this.Controls.Add(this.buttonListBooks);
            this.Controls.Add(this.buttonSearchBook);
            this.Controls.Add(this.buttonAddBook);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryControllerForm";
            this.Text = "Inventory Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelQuestionInventory;
        private System.Windows.Forms.Label labelWelcomeInventoryController;
        private System.Windows.Forms.Button buttonListBooks;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInventoryControllerLogout;
    }
}