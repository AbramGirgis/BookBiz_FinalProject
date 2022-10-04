namespace BookBizManagementSystem
{
    partial class SearchUserForm
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
            this.comboBoxUserList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.labelSearchUser = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxUserList
            // 
            this.comboBoxUserList.FormattingEnabled = true;
            this.comboBoxUserList.Location = new System.Drawing.Point(227, 202);
            this.comboBoxUserList.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxUserList.Name = "comboBoxUserList";
            this.comboBoxUserList.Size = new System.Drawing.Size(218, 32);
            this.comboBoxUserList.TabIndex = 32;
            this.comboBoxUserList.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "User ID";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(116, 316);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 72;
            this.dataGridViewUser.RowTemplate.Height = 31;
            this.dataGridViewUser.Size = new System.Drawing.Size(1126, 398);
            this.dataGridViewUser.TabIndex = 30;
            // 
            // labelSearchUser
            // 
            this.labelSearchUser.AutoSize = true;
            this.labelSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSearchUser.Location = new System.Drawing.Point(476, 82);
            this.labelSearchUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSearchUser.Name = "labelSearchUser";
            this.labelSearchUser.Size = new System.Drawing.Size(303, 55);
            this.labelSearchUser.TabIndex = 29;
            this.labelSearchUser.Text = "Search User";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(1102, 801);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 60);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // SearchUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 917);
            this.Controls.Add(this.comboBoxUserList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.labelSearchUser);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchUserForm";
            this.Text = "Search User";
            this.Load += new System.EventHandler(this.SearchUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Label labelSearchUser;
        private System.Windows.Forms.Button buttonBack;
    }
}