namespace BookBizManagementSystem
{
    partial class ListOrderForm
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
            this.dataGridViewOrdersList = new System.Windows.Forms.DataGridView();
            this.labelOrdersList = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrdersList
            // 
            this.dataGridViewOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdersList.Location = new System.Drawing.Point(114, 213);
            this.dataGridViewOrdersList.Name = "dataGridViewOrdersList";
            this.dataGridViewOrdersList.RowHeadersWidth = 72;
            this.dataGridViewOrdersList.RowTemplate.Height = 31;
            this.dataGridViewOrdersList.Size = new System.Drawing.Size(1148, 529);
            this.dataGridViewOrdersList.TabIndex = 43;
            // 
            // labelOrdersList
            // 
            this.labelOrdersList.AutoSize = true;
            this.labelOrdersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdersList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOrdersList.Location = new System.Drawing.Point(500, 81);
            this.labelOrdersList.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOrdersList.Name = "labelOrdersList";
            this.labelOrdersList.Size = new System.Drawing.Size(269, 55);
            this.labelOrdersList.TabIndex = 42;
            this.labelOrdersList.Text = "Orders List";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(1122, 810);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 60);
            this.buttonBack.TabIndex = 41;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ListOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 951);
            this.Controls.Add(this.dataGridViewOrdersList);
            this.Controls.Add(this.labelOrdersList);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListOrderForm";
            this.Text = "List of Orders";
            this.Load += new System.EventHandler(this.ListOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrdersList;
        private System.Windows.Forms.Label labelOrdersList;
        private System.Windows.Forms.Button buttonBack;
    }
}