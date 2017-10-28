namespace Lab2_XPath
{
    partial class Form1
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
            this.btnGetInvoice = new System.Windows.Forms.Button();
            this.lbxBillingInfo = new System.Windows.Forms.ListBox();
            this.lbxShippingInfo = new System.Windows.Forms.ListBox();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblBillingInfo = new System.Windows.Forms.Label();
            this.lblShippingInfo = new System.Windows.Forms.Label();
            this.lbxItemInfo = new System.Windows.Forms.ListBox();
            this.lblItemInfo = new System.Windows.Forms.Label();
            this.lblNumOfItemsBought = new System.Windows.Forms.Label();
            this.txtNumOfItemsBought = new System.Windows.Forms.TextBox();
            this.lblTotalCostOfOrder = new System.Windows.Forms.Label();
            this.txtTotalCostOfOrder = new System.Windows.Forms.TextBox();
            this.btnGetBilling = new System.Windows.Forms.Button();
            this.btnGetShipping = new System.Windows.Forms.Button();
            this.btnGetItemInfo = new System.Windows.Forms.Button();
            this.btnGetItemsBought = new System.Windows.Forms.Button();
            this.btnGetTotalCostOfOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetInvoice
            // 
            this.btnGetInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGetInvoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGetInvoice.Location = new System.Drawing.Point(1033, 1114);
            this.btnGetInvoice.Name = "btnGetInvoice";
            this.btnGetInvoice.Size = new System.Drawing.Size(247, 78);
            this.btnGetInvoice.TabIndex = 0;
            this.btnGetInvoice.Text = "Generate Invoice";
            this.btnGetInvoice.UseVisualStyleBackColor = false;
            this.btnGetInvoice.Click += new System.EventHandler(this.btnGetInvoice_Click);
            // 
            // lbxBillingInfo
            // 
            this.lbxBillingInfo.FormattingEnabled = true;
            this.lbxBillingInfo.ItemHeight = 25;
            this.lbxBillingInfo.Location = new System.Drawing.Point(125, 178);
            this.lbxBillingInfo.Name = "lbxBillingInfo";
            this.lbxBillingInfo.ScrollAlwaysVisible = true;
            this.lbxBillingInfo.Size = new System.Drawing.Size(516, 454);
            this.lbxBillingInfo.TabIndex = 1;
            // 
            // lbxShippingInfo
            // 
            this.lbxShippingInfo.FormattingEnabled = true;
            this.lbxShippingInfo.ItemHeight = 25;
            this.lbxShippingInfo.Location = new System.Drawing.Point(764, 178);
            this.lbxShippingInfo.Name = "lbxShippingInfo";
            this.lbxShippingInfo.ScrollAlwaysVisible = true;
            this.lbxShippingInfo.Size = new System.Drawing.Size(516, 454);
            this.lbxShippingInfo.TabIndex = 2;
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(510, 37);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(376, 37);
            this.lblInvoice.TabIndex = 3;
            this.lblInvoice.Text = "INVOICE GENERATOR";
            // 
            // lblBillingInfo
            // 
            this.lblBillingInfo.AutoSize = true;
            this.lblBillingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingInfo.Location = new System.Drawing.Point(120, 137);
            this.lblBillingInfo.Name = "lblBillingInfo";
            this.lblBillingInfo.Size = new System.Drawing.Size(231, 29);
            this.lblBillingInfo.TabIndex = 4;
            this.lblBillingInfo.Text = "Billing Information:";
            // 
            // lblShippingInfo
            // 
            this.lblShippingInfo.AutoSize = true;
            this.lblShippingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingInfo.Location = new System.Drawing.Point(759, 137);
            this.lblShippingInfo.Name = "lblShippingInfo";
            this.lblShippingInfo.Size = new System.Drawing.Size(261, 29);
            this.lblShippingInfo.TabIndex = 5;
            this.lblShippingInfo.Text = "Shipping Information:";
            // 
            // lbxItemInfo
            // 
            this.lbxItemInfo.FormattingEnabled = true;
            this.lbxItemInfo.ItemHeight = 25;
            this.lbxItemInfo.Location = new System.Drawing.Point(125, 738);
            this.lbxItemInfo.Name = "lbxItemInfo";
            this.lbxItemInfo.ScrollAlwaysVisible = true;
            this.lbxItemInfo.Size = new System.Drawing.Size(516, 454);
            this.lbxItemInfo.TabIndex = 6;
            // 
            // lblItemInfo
            // 
            this.lblItemInfo.AutoSize = true;
            this.lblItemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemInfo.Location = new System.Drawing.Point(120, 696);
            this.lblItemInfo.Name = "lblItemInfo";
            this.lblItemInfo.Size = new System.Drawing.Size(207, 29);
            this.lblItemInfo.TabIndex = 7;
            this.lblItemInfo.Text = "Item Information:";
            // 
            // lblNumOfItemsBought
            // 
            this.lblNumOfItemsBought.AutoSize = true;
            this.lblNumOfItemsBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfItemsBought.Location = new System.Drawing.Point(726, 738);
            this.lblNumOfItemsBought.Name = "lblNumOfItemsBought";
            this.lblNumOfItemsBought.Size = new System.Drawing.Size(301, 29);
            this.lblNumOfItemsBought.TabIndex = 8;
            this.lblNumOfItemsBought.Text = "Number of Items Bought:";
            // 
            // txtNumOfItemsBought
            // 
            this.txtNumOfItemsBought.Location = new System.Drawing.Point(1033, 736);
            this.txtNumOfItemsBought.Name = "txtNumOfItemsBought";
            this.txtNumOfItemsBought.Size = new System.Drawing.Size(247, 31);
            this.txtNumOfItemsBought.TabIndex = 9;
            // 
            // lblTotalCostOfOrder
            // 
            this.lblTotalCostOfOrder.AutoSize = true;
            this.lblTotalCostOfOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostOfOrder.Location = new System.Drawing.Point(726, 913);
            this.lblTotalCostOfOrder.Name = "lblTotalCostOfOrder";
            this.lblTotalCostOfOrder.Size = new System.Drawing.Size(244, 29);
            this.lblTotalCostOfOrder.TabIndex = 10;
            this.lblTotalCostOfOrder.Text = "Total Cost of Order:";
            // 
            // txtTotalCostOfOrder
            // 
            this.txtTotalCostOfOrder.Location = new System.Drawing.Point(1033, 913);
            this.txtTotalCostOfOrder.Name = "txtTotalCostOfOrder";
            this.txtTotalCostOfOrder.Size = new System.Drawing.Size(247, 31);
            this.txtTotalCostOfOrder.TabIndex = 11;
            // 
            // btnGetBilling
            // 
            this.btnGetBilling.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetBilling.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGetBilling.Location = new System.Drawing.Point(394, 651);
            this.btnGetBilling.Name = "btnGetBilling";
            this.btnGetBilling.Size = new System.Drawing.Size(247, 49);
            this.btnGetBilling.TabIndex = 12;
            this.btnGetBilling.Text = "Get Billing";
            this.btnGetBilling.UseVisualStyleBackColor = false;
            this.btnGetBilling.Click += new System.EventHandler(this.btnGetBilling_Click);
            // 
            // btnGetShipping
            // 
            this.btnGetShipping.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetShipping.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGetShipping.Location = new System.Drawing.Point(1033, 651);
            this.btnGetShipping.Name = "btnGetShipping";
            this.btnGetShipping.Size = new System.Drawing.Size(247, 49);
            this.btnGetShipping.TabIndex = 13;
            this.btnGetShipping.Text = "Get Shipping";
            this.btnGetShipping.UseVisualStyleBackColor = false;
            this.btnGetShipping.Click += new System.EventHandler(this.btnGetShipping_Click);
            // 
            // btnGetItemInfo
            // 
            this.btnGetItemInfo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetItemInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGetItemInfo.Location = new System.Drawing.Point(394, 1210);
            this.btnGetItemInfo.Name = "btnGetItemInfo";
            this.btnGetItemInfo.Size = new System.Drawing.Size(247, 46);
            this.btnGetItemInfo.TabIndex = 14;
            this.btnGetItemInfo.Text = "Get Item Info";
            this.btnGetItemInfo.UseVisualStyleBackColor = false;
            this.btnGetItemInfo.Click += new System.EventHandler(this.btnGetItemInfo_Click);
            // 
            // btnGetItemsBought
            // 
            this.btnGetItemsBought.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetItemsBought.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGetItemsBought.Location = new System.Drawing.Point(1033, 788);
            this.btnGetItemsBought.Name = "btnGetItemsBought";
            this.btnGetItemsBought.Size = new System.Drawing.Size(247, 62);
            this.btnGetItemsBought.TabIndex = 15;
            this.btnGetItemsBought.Text = "Get Number of Items Bought";
            this.btnGetItemsBought.UseVisualStyleBackColor = false;
            this.btnGetItemsBought.Click += new System.EventHandler(this.btnGetItemsBought_Click);
            // 
            // btnGetTotalCostOfOrder
            // 
            this.btnGetTotalCostOfOrder.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetTotalCostOfOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGetTotalCostOfOrder.Location = new System.Drawing.Point(1033, 964);
            this.btnGetTotalCostOfOrder.Name = "btnGetTotalCostOfOrder";
            this.btnGetTotalCostOfOrder.Size = new System.Drawing.Size(247, 62);
            this.btnGetTotalCostOfOrder.TabIndex = 16;
            this.btnGetTotalCostOfOrder.Text = "Get Total Cost of Order";
            this.btnGetTotalCostOfOrder.UseVisualStyleBackColor = false;
            this.btnGetTotalCostOfOrder.Click += new System.EventHandler(this.btnGetTotalCostOfOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(764, 1114);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(247, 78);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1408, 1341);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetTotalCostOfOrder);
            this.Controls.Add(this.btnGetItemsBought);
            this.Controls.Add(this.btnGetItemInfo);
            this.Controls.Add(this.btnGetShipping);
            this.Controls.Add(this.btnGetBilling);
            this.Controls.Add(this.txtTotalCostOfOrder);
            this.Controls.Add(this.lblTotalCostOfOrder);
            this.Controls.Add(this.txtNumOfItemsBought);
            this.Controls.Add(this.lblNumOfItemsBought);
            this.Controls.Add(this.lblItemInfo);
            this.Controls.Add(this.lbxItemInfo);
            this.Controls.Add(this.lblShippingInfo);
            this.Controls.Add(this.lblBillingInfo);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.lbxShippingInfo);
            this.Controls.Add(this.lbxBillingInfo);
            this.Controls.Add(this.btnGetInvoice);
            this.Name = "Form1";
            this.Text = "Lab 2 - XPath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetInvoice;
        private System.Windows.Forms.ListBox lbxBillingInfo;
        private System.Windows.Forms.ListBox lbxShippingInfo;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblBillingInfo;
        private System.Windows.Forms.Label lblShippingInfo;
        private System.Windows.Forms.ListBox lbxItemInfo;
        private System.Windows.Forms.Label lblItemInfo;
        private System.Windows.Forms.Label lblNumOfItemsBought;
        private System.Windows.Forms.TextBox txtNumOfItemsBought;
        private System.Windows.Forms.Label lblTotalCostOfOrder;
        private System.Windows.Forms.TextBox txtTotalCostOfOrder;
        private System.Windows.Forms.Button btnGetBilling;
        private System.Windows.Forms.Button btnGetShipping;
        private System.Windows.Forms.Button btnGetItemInfo;
        private System.Windows.Forms.Button btnGetItemsBought;
        private System.Windows.Forms.Button btnGetTotalCostOfOrder;
        private System.Windows.Forms.Button btnClear;
    }
}

