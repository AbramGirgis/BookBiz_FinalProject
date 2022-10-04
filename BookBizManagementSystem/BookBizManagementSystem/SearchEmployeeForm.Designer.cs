namespace BookBizManagementSystem
{
    partial class SearchEmployeeForm
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
            this.comboBoxEmployeeList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.labelSearchEmployee = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEmployeeList
            // 
            this.comboBoxEmployeeList.FormattingEnabled = true;
            this.comboBoxEmployeeList.Location = new System.Drawing.Point(295, 222);
            this.comboBoxEmployeeList.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxEmployeeList.Name = "comboBoxEmployeeList";
            this.comboBoxEmployeeList.Size = new System.Drawing.Size(218, 32);
            this.comboBoxEmployeeList.TabIndex = 37;
            this.comboBoxEmployeeList.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Employee ID";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(134, 320);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 72;
            this.dataGridViewEmployee.RowTemplate.Height = 31;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1105, 379);
            this.dataGridViewEmployee.TabIndex = 35;
            // 
            // labelSearchEmployee
            // 
            this.labelSearchEmployee.AutoSize = true;
            this.labelSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSearchEmployee.Location = new System.Drawing.Point(473, 85);
            this.labelSearchEmployee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSearchEmployee.Name = "labelSearchEmployee";
            this.labelSearchEmployee.Size = new System.Drawing.Size(419, 55);
            this.labelSearchEmployee.TabIndex = 34;
            this.labelSearchEmployee.Text = "Search Employee";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(1099, 793);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 60);
            this.buttonBack.TabIndex = 33;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // SearchEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 907);
            this.Controls.Add(this.comboBoxEmployeeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.labelSearchEmployee);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchEmployeeForm";
            this.Text = "Search Employee";
            this.Load += new System.EventHandler(this.SearchEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEmployeeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Label labelSearchEmployee;
        private System.Windows.Forms.Button buttonBack;
    }
}