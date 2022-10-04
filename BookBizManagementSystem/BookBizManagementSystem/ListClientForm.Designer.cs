namespace BookBizManagementSystem
{
    partial class ListClientForm
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
            this.dataGridViewClientList = new System.Windows.Forms.DataGridView();
            this.labelSearchClient = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientList
            // 
            this.dataGridViewClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientList.Location = new System.Drawing.Point(94, 212);
            this.dataGridViewClientList.Name = "dataGridViewClientList";
            this.dataGridViewClientList.RowHeadersWidth = 72;
            this.dataGridViewClientList.RowTemplate.Height = 31;
            this.dataGridViewClientList.Size = new System.Drawing.Size(1132, 544);
            this.dataGridViewClientList.TabIndex = 40;
            // 
            // labelSearchClient
            // 
            this.labelSearchClient.AutoSize = true;
            this.labelSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSearchClient.Location = new System.Drawing.Point(515, 88);
            this.labelSearchClient.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSearchClient.Name = "labelSearchClient";
            this.labelSearchClient.Size = new System.Drawing.Size(269, 55);
            this.labelSearchClient.TabIndex = 39;
            this.labelSearchClient.Text = "Clients List";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(1086, 815);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 60);
            this.buttonBack.TabIndex = 38;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ListClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 963);
            this.Controls.Add(this.dataGridViewClientList);
            this.Controls.Add(this.labelSearchClient);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListClientForm";
            this.Text = "List of Clients";
            this.Load += new System.EventHandler(this.ListClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewClientList;
        private System.Windows.Forms.Label labelSearchClient;
        private System.Windows.Forms.Button buttonBack;
    }
}