namespace BookBizManagementSystem
{
    partial class SearchClientForm
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
            this.comboBoxClientList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.labelSearchClient = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClientList
            // 
            this.comboBoxClientList.FormattingEnabled = true;
            this.comboBoxClientList.Location = new System.Drawing.Point(238, 191);
            this.comboBoxClientList.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxClientList.Name = "comboBoxClientList";
            this.comboBoxClientList.Size = new System.Drawing.Size(218, 32);
            this.comboBoxClientList.TabIndex = 37;
            this.comboBoxClientList.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Client ID";
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(127, 294);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersWidth = 72;
            this.dataGridViewClient.RowTemplate.Height = 31;
            this.dataGridViewClient.Size = new System.Drawing.Size(1111, 429);
            this.dataGridViewClient.TabIndex = 35;
            // 
            // labelSearchClient
            // 
            this.labelSearchClient.AutoSize = true;
            this.labelSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSearchClient.Location = new System.Drawing.Point(527, 76);
            this.labelSearchClient.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSearchClient.Name = "labelSearchClient";
            this.labelSearchClient.Size = new System.Drawing.Size(325, 55);
            this.labelSearchClient.TabIndex = 34;
            this.labelSearchClient.Text = "Search Client";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(1098, 803);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 60);
            this.buttonBack.TabIndex = 33;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // SearchClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 921);
            this.Controls.Add(this.comboBoxClientList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.labelSearchClient);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchClientForm";
            this.Text = "Search Client";
            this.Load += new System.EventHandler(this.SearchClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClientList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Label labelSearchClient;
        private System.Windows.Forms.Button buttonBack;
    }
}