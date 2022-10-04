namespace BookBizManagementSystem
{
    partial class ListBookForm
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
            this.dataGridViewBookList = new System.Windows.Forms.DataGridView();
            this.labelListBook = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookList
            // 
            this.dataGridViewBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookList.Location = new System.Drawing.Point(111, 211);
            this.dataGridViewBookList.Name = "dataGridViewBookList";
            this.dataGridViewBookList.RowHeadersWidth = 72;
            this.dataGridViewBookList.RowTemplate.Height = 31;
            this.dataGridViewBookList.Size = new System.Drawing.Size(1176, 574);
            this.dataGridViewBookList.TabIndex = 30;
            // 
            // labelListBook
            // 
            this.labelListBook.AutoSize = true;
            this.labelListBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelListBook.Location = new System.Drawing.Point(552, 62);
            this.labelListBook.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelListBook.Name = "labelListBook";
            this.labelListBook.Size = new System.Drawing.Size(311, 55);
            this.labelListBook.TabIndex = 29;
            this.labelListBook.Text = "List of Books";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(1147, 883);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 60);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ListBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 1014);
            this.Controls.Add(this.dataGridViewBookList);
            this.Controls.Add(this.labelListBook);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListBookForm";
            this.Text = "List Of Books";
            this.Load += new System.EventHandler(this.ListBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBookList;
        private System.Windows.Forms.Label labelListBook;
        private System.Windows.Forms.Button buttonBack;
    }
}