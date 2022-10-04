namespace BookBizManagementSystem
{
    partial class CancelOrderForm
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
            this.comboBoxOrdersList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCancelOrder = new System.Windows.Forms.DataGridView();
            this.labelCancelOrder = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCancelOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxOrdersList
            // 
            this.comboBoxOrdersList.FormattingEnabled = true;
            this.comboBoxOrdersList.Location = new System.Drawing.Point(482, 228);
            this.comboBoxOrdersList.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxOrdersList.Name = "comboBoxOrdersList";
            this.comboBoxOrdersList.Size = new System.Drawing.Size(218, 32);
            this.comboBoxOrdersList.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Select order ID you wish to cancel";
            // 
            // dataGridViewCancelOrder
            // 
            this.dataGridViewCancelOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCancelOrder.Location = new System.Drawing.Point(141, 322);
            this.dataGridViewCancelOrder.Name = "dataGridViewCancelOrder";
            this.dataGridViewCancelOrder.RowHeadersWidth = 72;
            this.dataGridViewCancelOrder.RowTemplate.Height = 31;
            this.dataGridViewCancelOrder.Size = new System.Drawing.Size(1095, 401);
            this.dataGridViewCancelOrder.TabIndex = 30;
            // 
            // labelCancelOrder
            // 
            this.labelCancelOrder.AutoSize = true;
            this.labelCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCancelOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCancelOrder.Location = new System.Drawing.Point(535, 97);
            this.labelCancelOrder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCancelOrder.Name = "labelCancelOrder";
            this.labelCancelOrder.Size = new System.Drawing.Size(322, 55);
            this.labelCancelOrder.TabIndex = 29;
            this.labelCancelOrder.Text = "Cancel Order";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(1036, 800);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(200, 60);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelOrder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCancelOrder.Location = new System.Drawing.Point(674, 800);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(320, 60);
            this.buttonCancelOrder.TabIndex = 33;
            this.buttonCancelOrder.Text = "REMOVE ORDER";
            this.buttonCancelOrder.UseVisualStyleBackColor = false;
            this.buttonCancelOrder.Click += new System.EventHandler(this.buttonCancelOrder_Click);
            // 
            // CancelOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 957);
            this.Controls.Add(this.buttonCancelOrder);
            this.Controls.Add(this.comboBoxOrdersList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCancelOrder);
            this.Controls.Add(this.labelCancelOrder);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancelOrderForm";
            this.Text = "Cancel Order";
            this.Load += new System.EventHandler(this.CancelOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCancelOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOrdersList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCancelOrder;
        private System.Windows.Forms.Label labelCancelOrder;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCancelOrder;
    }
}