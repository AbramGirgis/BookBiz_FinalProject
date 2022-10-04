namespace BookBizManagementSystem
{
    partial class SearchOrderForm
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
            this.comboBoxOrderID = new System.Windows.Forms.ComboBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.labelSearchBook = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxOrderID
            // 
            this.comboBoxOrderID.FormattingEnabled = true;
            this.comboBoxOrderID.Location = new System.Drawing.Point(295, 201);
            this.comboBoxOrderID.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxOrderID.Name = "comboBoxOrderID";
            this.comboBoxOrderID.Size = new System.Drawing.Size(218, 32);
            this.comboBoxOrderID.TabIndex = 32;
            this.comboBoxOrderID.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderID_SelectedIndexChanged);
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(116, 208);
            this.labelOrderID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(146, 25);
            this.labelOrderID.TabIndex = 31;
            this.labelOrderID.Text = "Select Order ID";
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(121, 294);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.RowHeadersWidth = 72;
            this.dataGridViewOrderDetails.RowTemplate.Height = 31;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(1095, 401);
            this.dataGridViewOrderDetails.TabIndex = 30;
            // 
            // labelSearchBook
            // 
            this.labelSearchBook.AutoSize = true;
            this.labelSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSearchBook.Location = new System.Drawing.Point(522, 77);
            this.labelSearchBook.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSearchBook.Name = "labelSearchBook";
            this.labelSearchBook.Size = new System.Drawing.Size(350, 55);
            this.labelSearchBook.TabIndex = 29;
            this.labelSearchBook.Text = "Search Orders";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(1076, 790);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 60);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // SearchOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 886);
            this.Controls.Add(this.comboBoxOrderID);
            this.Controls.Add(this.labelOrderID);
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.labelSearchBook);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchOrderForm";
            this.Text = "Search Orders";
            this.Load += new System.EventHandler(this.SearchOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOrderID;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Label labelSearchBook;
        private System.Windows.Forms.Button buttonBack;
    }
}