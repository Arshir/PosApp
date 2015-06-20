using System.Windows.Forms;
namespace PosAPP.Forms
{
    partial class MainMDI
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
            if (MessageBox.Show("Are you sure you want to exit the Application?", GlobalData.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AccounttoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPricingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internalRequisitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internalIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustmentRequisitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustmentApprovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expiryItemManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internalItemUsageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externalOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externalOrderReceivalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnOutwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internalReturnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internalReturnAcceptanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sYSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cHANGEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccounttoolStripMenuItem1,
            this.nHToolStripMenuItem,
            this.StockManagementToolStripMenuItem,
            this.sYSTToolStripMenuItem,
            this.SetUpToolStripMenuItem,
            this.cHANGEToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AccounttoolStripMenuItem1
            // 
            this.AccounttoolStripMenuItem1.Name = "AccounttoolStripMenuItem1";
            this.AccounttoolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // nHToolStripMenuItem
            // 
            this.nHToolStripMenuItem.Name = "nHToolStripMenuItem";
            this.nHToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.nHToolStripMenuItem.Text = "NHIA Claim";
            // 
            // StockManagementToolStripMenuItem
            // 
            this.StockManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSetupToolStripMenuItem,
            this.itemPricingToolStripMenuItem,
            this.internalRequisitionToolStripMenuItem,
            this.internalIssuesToolStripMenuItem,
            this.adjustmentRequisitionToolStripMenuItem,
            this.adjustmentApprovalToolStripMenuItem,
            this.expiryItemManagementToolStripMenuItem,
            this.internalItemUsageToolStripMenuItem,
            this.externalOrdersToolStripMenuItem,
            this.externalOrderReceivalToolStripMenuItem,
            this.returnOutwardToolStripMenuItem,
            this.internalReturnsToolStripMenuItem,
            this.internalReturnAcceptanceToolStripMenuItem});
            this.StockManagementToolStripMenuItem.Name = "StockManagementToolStripMenuItem";
            this.StockManagementToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.StockManagementToolStripMenuItem.Text = "Stock Management";
            // 
            // itemSetupToolStripMenuItem
            // 
            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
            this.itemSetupToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            // 
            // itemPricingToolStripMenuItem
            // 
            this.itemPricingToolStripMenuItem.Name = "itemPricingToolStripMenuItem";
            this.itemPricingToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.itemPricingToolStripMenuItem.Text = "Item Pricing";
            this.itemPricingToolStripMenuItem.Click += new System.EventHandler(this.itemPricingToolStripMenuItem_Click);
            // 
            // internalRequisitionToolStripMenuItem
            // 
            this.internalRequisitionToolStripMenuItem.Name = "internalRequisitionToolStripMenuItem";
            this.internalRequisitionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.internalRequisitionToolStripMenuItem.Text = "Internal Requisition";
            // 
            // internalIssuesToolStripMenuItem
            // 
            this.internalIssuesToolStripMenuItem.Name = "internalIssuesToolStripMenuItem";
            this.internalIssuesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.internalIssuesToolStripMenuItem.Text = "Internal Issues";
            // 
            // adjustmentRequisitionToolStripMenuItem
            // 
            this.adjustmentRequisitionToolStripMenuItem.Name = "adjustmentRequisitionToolStripMenuItem";
            this.adjustmentRequisitionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.adjustmentRequisitionToolStripMenuItem.Text = "Adjustment Requisition";
            // 
            // adjustmentApprovalToolStripMenuItem
            // 
            this.adjustmentApprovalToolStripMenuItem.Name = "adjustmentApprovalToolStripMenuItem";
            this.adjustmentApprovalToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.adjustmentApprovalToolStripMenuItem.Text = "Adjustment Approval";
            // 
            // expiryItemManagementToolStripMenuItem
            // 
            this.expiryItemManagementToolStripMenuItem.Name = "expiryItemManagementToolStripMenuItem";
            this.expiryItemManagementToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.expiryItemManagementToolStripMenuItem.Text = "Expiry Item Management";
            // 
            // internalItemUsageToolStripMenuItem
            // 
            this.internalItemUsageToolStripMenuItem.Name = "internalItemUsageToolStripMenuItem";
            this.internalItemUsageToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.internalItemUsageToolStripMenuItem.Text = "Internal Item Usage";
            // 
            // externalOrdersToolStripMenuItem
            // 
            this.externalOrdersToolStripMenuItem.Name = "externalOrdersToolStripMenuItem";
            this.externalOrdersToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.externalOrdersToolStripMenuItem.Text = "External Orders";
            // 
            // externalOrderReceivalToolStripMenuItem
            // 
            this.externalOrderReceivalToolStripMenuItem.Name = "externalOrderReceivalToolStripMenuItem";
            this.externalOrderReceivalToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.externalOrderReceivalToolStripMenuItem.Text = "External Order Receival";
            // 
            // returnOutwardToolStripMenuItem
            // 
            this.returnOutwardToolStripMenuItem.Name = "returnOutwardToolStripMenuItem";
            this.returnOutwardToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.returnOutwardToolStripMenuItem.Text = "Return Outward";
            // 
            // internalReturnsToolStripMenuItem
            // 
            this.internalReturnsToolStripMenuItem.Name = "internalReturnsToolStripMenuItem";
            this.internalReturnsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.internalReturnsToolStripMenuItem.Text = "Internal Returns";
            // 
            // internalReturnAcceptanceToolStripMenuItem
            // 
            this.internalReturnAcceptanceToolStripMenuItem.Name = "internalReturnAcceptanceToolStripMenuItem";
            this.internalReturnAcceptanceToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.internalReturnAcceptanceToolStripMenuItem.Text = "Internal Return Acceptance";
            // 
            // sYSTToolStripMenuItem
            // 
            this.sYSTToolStripMenuItem.Name = "sYSTToolStripMenuItem";
            this.sYSTToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.sYSTToolStripMenuItem.Text = " Reports";
            // 
            // SetUpToolStripMenuItem
            // 
            this.SetUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountToolStripMenuItem,
            this.itemCategoryToolStripMenuItem,
            this.saleTypeToolStripMenuItem,
            this.saleTypeToolStripMenuItem1});
            this.SetUpToolStripMenuItem.Name = "SetUpToolStripMenuItem";
            this.SetUpToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.SetUpToolStripMenuItem.Text = "System Set Up";
            // 
            // userAccountToolStripMenuItem
            // 
            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userAccountToolStripMenuItem.Text = "User Account";
            // 
            // itemCategoryToolStripMenuItem
            // 
            this.itemCategoryToolStripMenuItem.Name = "itemCategoryToolStripMenuItem";
            this.itemCategoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.itemCategoryToolStripMenuItem.Text = "Item Category";
            // 
            // saleTypeToolStripMenuItem
            // 
            this.saleTypeToolStripMenuItem.Name = "saleTypeToolStripMenuItem";
            this.saleTypeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saleTypeToolStripMenuItem.Text = "Item Type";
            // 
            // saleTypeToolStripMenuItem1
            // 
            this.saleTypeToolStripMenuItem1.Name = "saleTypeToolStripMenuItem1";
            this.saleTypeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saleTypeToolStripMenuItem1.Text = "Sale Type";
            // 
            // cHANGEToolStripMenuItem
            // 
            this.cHANGEToolStripMenuItem.Name = "cHANGEToolStripMenuItem";
            this.cHANGEToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.cHANGEToolStripMenuItem.Text = "Change Password";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.eXITToolStripMenuItem.Text = "Exit";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // refundToolStripMenuItem
            // 
            this.refundToolStripMenuItem.Name = "refundToolStripMenuItem";
            this.refundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.refundToolStripMenuItem.Text = "Refund";
            // 
            // returnSalesToolStripMenuItem
            // 
            this.returnSalesToolStripMenuItem.Name = "returnSalesToolStripMenuItem";
            this.returnSalesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.returnSalesToolStripMenuItem.Text = "Return Sales";
            // 
            // MainMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(849, 504);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMDI";
            this.Text = "Point Of Sale ";
            this.Load += new System.EventHandler(this.MainMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AccounttoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StockManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sYSTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHANGEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemPricingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internalRequisitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internalIssuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustmentRequisitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustmentApprovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expiryItemManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internalItemUsageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem externalOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem externalOrderReceivalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnOutwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internalReturnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internalReturnAcceptanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleTypeToolStripMenuItem1;
    }
}

