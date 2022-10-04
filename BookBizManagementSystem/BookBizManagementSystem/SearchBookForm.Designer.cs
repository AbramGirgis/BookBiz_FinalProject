namespace BookBizManagementSystem
{
    partial class SearchBookForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelSearchBook = new System.Windows.Forms.Label();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.comboBoxISBN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(1075, 768);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 60);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelSearchBook
            // 
            this.labelSearchBook.AutoSize = true;
            this.labelSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSearchBook.Location = new System.Drawing.Point(514, 65);
            this.labelSearchBook.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSearchBook.Name = "labelSearchBook";
            this.labelSearchBook.Size = new System.Drawing.Size(311, 55);
            this.labelSearchBook.TabIndex = 24;
            this.labelSearchBook.Text = "Search Book";
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Location = new System.Drawing.Point(120, 290);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 72;
            this.dataGridViewBook.RowTemplate.Height = 31;
            this.dataGridViewBook.Size = new System.Drawing.Size(1095, 401);
            this.dataGridViewBook.TabIndex = 25;
            // 
            // comboBoxISBN
            // 
            this.comboBoxISBN.FormattingEnabled = true;
            this.comboBoxISBN.Location = new System.Drawing.Point(231, 193);
            this.comboBoxISBN.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxISBN.Name = "comboBoxISBN";
            this.comboBoxISBN.Size = new System.Drawing.Size(218, 32);
            this.comboBoxISBN.TabIndex = 27;
            this.comboBoxISBN.SelectedIndexChanged += new System.EventHandler(this.comboBoxISBN_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "ISBN";
            // 
            // SearchBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 879);
            this.Controls.Add(this.comboBoxISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.labelSearchBook);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchBookForm";
            this.Text = "Search Book";
            this.Load += new System.EventHandler(this.SearchBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelSearchBook;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.ComboBox comboBoxISBN;
        private System.Windows.Forms.Label label2;
    }
}