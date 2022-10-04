namespace BookBizManagementSystem
{
    partial class AddOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxISBN = new System.Windows.Forms.ComboBox();
            this.comboBoxClientID = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.labelQty = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAddOrder = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.groupBoxAddToOrder = new System.Windows.Forms.GroupBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.labelOrderTotal = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBoxAddToOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxISBN
            // 
            this.comboBoxISBN.FormattingEnabled = true;
            this.comboBoxISBN.Location = new System.Drawing.Point(238, 82);
            this.comboBoxISBN.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxISBN.Name = "comboBoxISBN";
            this.comboBoxISBN.Size = new System.Drawing.Size(218, 40);
            this.comboBoxISBN.TabIndex = 23;
            // 
            // comboBoxClientID
            // 
            this.comboBoxClientID.FormattingEnabled = true;
            this.comboBoxClientID.Location = new System.Drawing.Point(266, 357);
            this.comboBoxClientID.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxClientID.Name = "comboBoxClientID";
            this.comboBoxClientID.Size = new System.Drawing.Size(218, 32);
            this.comboBoxClientID.TabIndex = 22;
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(266, 292);
            this.comboBoxEmployeeID.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(218, 32);
            this.comboBoxEmployeeID.TabIndex = 21;
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQty.Location = new System.Drawing.Point(51, 155);
            this.labelQty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(121, 32);
            this.labelQty.TabIndex = 20;
            this.labelQty.Text = "Quantity";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBN.Location = new System.Drawing.Point(51, 82);
            this.labelISBN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(79, 32);
            this.labelISBN.TabIndex = 19;
            this.labelISBN.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 357);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Client ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Clerk ID";
            // 
            // labelAddOrder
            // 
            this.labelAddOrder.AutoSize = true;
            this.labelAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAddOrder.Location = new System.Drawing.Point(475, 51);
            this.labelAddOrder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddOrder.Name = "labelAddOrder";
            this.labelAddOrder.Size = new System.Drawing.Size(255, 55);
            this.labelAddOrder.TabIndex = 64;
            this.labelAddOrder.Text = "Add Order";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBack.Location = new System.Drawing.Point(912, 914);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(206, 60);
            this.buttonBack.TabIndex = 82;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToOrder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddToOrder.Location = new System.Drawing.Point(116, 234);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(365, 60);
            this.buttonAddToOrder.TabIndex = 80;
            this.buttonAddToOrder.Text = "ADD TO THE ORDER";
            this.buttonAddToOrder.UseVisualStyleBackColor = false;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlaceOrder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonPlaceOrder.Location = new System.Drawing.Point(157, 436);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(266, 60);
            this.buttonPlaceOrder.TabIndex = 83;
            this.buttonPlaceOrder.Text = "PLACE ORDER";
            this.buttonPlaceOrder.UseVisualStyleBackColor = false;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // groupBoxAddToOrder
            // 
            this.groupBoxAddToOrder.Controls.Add(this.buttonAddToOrder);
            this.groupBoxAddToOrder.Controls.Add(this.textBoxQuantity);
            this.groupBoxAddToOrder.Controls.Add(this.labelISBN);
            this.groupBoxAddToOrder.Controls.Add(this.labelQty);
            this.groupBoxAddToOrder.Controls.Add(this.comboBoxISBN);
            this.groupBoxAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddToOrder.Location = new System.Drawing.Point(560, 202);
            this.groupBoxAddToOrder.Name = "groupBoxAddToOrder";
            this.groupBoxAddToOrder.Size = new System.Drawing.Size(558, 334);
            this.groupBoxAddToOrder.TabIndex = 85;
            this.groupBoxAddToOrder.TabStop = false;
            this.groupBoxAddToOrder.Text = "Add to Order";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(238, 152);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(218, 39);
            this.textBoxQuantity.TabIndex = 91;
            // 
            // labelOrderDetails
            // 
            this.labelOrderDetails.AutoSize = true;
            this.labelOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderDetails.Location = new System.Drawing.Point(78, 577);
            this.labelOrderDetails.Name = "labelOrderDetails";
            this.labelOrderDetails.Size = new System.Drawing.Size(226, 39);
            this.labelOrderDetails.TabIndex = 86;
            this.labelOrderDetails.Text = "Order Details:";
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(85, 644);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.RowHeadersWidth = 72;
            this.dataGridViewOrderDetails.RowTemplate.Height = 31;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(1033, 217);
            this.dataGridViewOrderDetails.TabIndex = 87;
            // 
            // labelOrderTotal
            // 
            this.labelOrderTotal.AutoSize = true;
            this.labelOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderTotal.Location = new System.Drawing.Point(78, 886);
            this.labelOrderTotal.Name = "labelOrderTotal";
            this.labelOrderTotal.Size = new System.Drawing.Size(197, 39);
            this.labelOrderTotal.TabIndex = 88;
            this.labelOrderTotal.Text = "Order Total:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(277, 886);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(225, 39);
            this.labelTotal.TabIndex = 92;
            this.labelTotal.Text = "Order Total $:";
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 1011);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelOrderTotal);
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.labelOrderDetails);
            this.Controls.Add(this.groupBoxAddToOrder);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelAddOrder);
            this.Controls.Add(this.comboBoxClientID);
            this.Controls.Add(this.comboBoxEmployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrderForm";
            this.Text = "Place Order";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            this.groupBoxAddToOrder.ResumeLayout(false);
            this.groupBoxAddToOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxISBN;
        private System.Windows.Forms.ComboBox comboBoxClientID;
        private System.Windows.Forms.ComboBox comboBoxEmployeeID;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAddOrder;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.GroupBox groupBoxAddToOrder;
        private System.Windows.Forms.Label labelOrderDetails;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Label labelOrderTotal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelTotal;
    }
}