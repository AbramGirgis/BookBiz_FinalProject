namespace BookBizManagementSystem
{
    partial class ListEmployeeForm
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
            this.dataGridViewEmployeeList = new System.Windows.Forms.DataGridView();
            this.labelEmployeeList = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployeeList
            // 
            this.dataGridViewEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeList.Location = new System.Drawing.Point(100, 213);
            this.dataGridViewEmployeeList.Name = "dataGridViewEmployeeList";
            this.dataGridViewEmployeeList.RowHeadersWidth = 72;
            this.dataGridViewEmployeeList.RowTemplate.Height = 31;
            this.dataGridViewEmployeeList.Size = new System.Drawing.Size(1148, 529);
            this.dataGridViewEmployeeList.TabIndex = 40;
            // 
            // labelEmployeeList
            // 
            this.labelEmployeeList.AutoSize = true;
            this.labelEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmployeeList.Location = new System.Drawing.Point(486, 81);
            this.labelEmployeeList.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmployeeList.Name = "labelEmployeeList";
            this.labelEmployeeList.Size = new System.Drawing.Size(363, 55);
            this.labelEmployeeList.TabIndex = 39;
            this.labelEmployeeList.Text = "Employees List";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(1108, 810);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 60);
            this.buttonBack.TabIndex = 38;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ListEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 931);
            this.Controls.Add(this.dataGridViewEmployeeList);
            this.Controls.Add(this.labelEmployeeList);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListEmployeeForm";
            this.Text = "List of Employees";
            this.Load += new System.EventHandler(this.ListEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployeeList;
        private System.Windows.Forms.Label labelEmployeeList;
        private System.Windows.Forms.Button buttonBack;
    }
}