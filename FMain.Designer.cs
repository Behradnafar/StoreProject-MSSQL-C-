namespace SuperMarket
{
    partial class FMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modifyCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyStuffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInformationToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.goodsToolStripMenuItem,
            this.receiptToolStripMenuItem,
            this.MenuStatistics,
            this.searchToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // userInformationToolStripMenuItem
            // 
            this.userInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem});
            this.userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            this.userInformationToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.userInformationToolStripMenuItem.Text = "Users";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.modifyCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.customerToolStripMenuItem.Text = "Customers";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 6);
            // 
            // modifyCustomerToolStripMenuItem
            // 
            this.modifyCustomerToolStripMenuItem.Name = "modifyCustomerToolStripMenuItem";
            this.modifyCustomerToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.modifyCustomerToolStripMenuItem.Text = "Modify Customer";
            this.modifyCustomerToolStripMenuItem.Click += new System.EventHandler(this.modifyCustomerToolStripMenuItem_Click);
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStuffToolStripMenuItem,
            this.modifyStuffsToolStripMenuItem});
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.goodsToolStripMenuItem.Text = "Goods";
            // 
            // addNewStuffToolStripMenuItem
            // 
            this.addNewStuffToolStripMenuItem.Name = "addNewStuffToolStripMenuItem";
            this.addNewStuffToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.addNewStuffToolStripMenuItem.Text = "Add New Stuff";
            this.addNewStuffToolStripMenuItem.Click += new System.EventHandler(this.addNewStuffToolStripMenuItem_Click);
            // 
            // modifyStuffsToolStripMenuItem
            // 
            this.modifyStuffsToolStripMenuItem.Name = "modifyStuffsToolStripMenuItem";
            this.modifyStuffsToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.modifyStuffsToolStripMenuItem.Text = "Modify Stuffs";
            this.modifyStuffsToolStripMenuItem.Click += new System.EventHandler(this.modifyStuffsToolStripMenuItem_Click);
            // 
            // receiptToolStripMenuItem
            // 
            this.receiptToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptToolStripMenuItem.Name = "receiptToolStripMenuItem";
            this.receiptToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.receiptToolStripMenuItem.Text = "Receipt";
            this.receiptToolStripMenuItem.Click += new System.EventHandler(this.receiptToolStripMenuItem_Click);
            // 
            // MenuStatistics
            // 
            this.MenuStatistics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiptByDateToolStripMenuItem});
            this.MenuStatistics.Name = "MenuStatistics";
            this.MenuStatistics.Size = new System.Drawing.Size(85, 29);
            this.MenuStatistics.Text = "Reports";
            this.MenuStatistics.Click += new System.EventHandler(this.MenuStatistics_Click);
            // 
            // receiptByDateToolStripMenuItem
            // 
            this.receiptByDateToolStripMenuItem.Name = "receiptByDateToolStripMenuItem";
            this.receiptByDateToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.receiptByDateToolStripMenuItem.Text = "Receipts by Date";
            this.receiptByDateToolStripMenuItem.Click += new System.EventHandler(this.receiptByDateToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersSearchToolStripMenuItem,
            this.goodsSearchToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // customersSearchToolStripMenuItem
            // 
            this.customersSearchToolStripMenuItem.Name = "customersSearchToolStripMenuItem";
            this.customersSearchToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.customersSearchToolStripMenuItem.Text = "Customers Search";
            this.customersSearchToolStripMenuItem.Click += new System.EventHandler(this.customersSearchToolStripMenuItem_Click);
            // 
            // goodsSearchToolStripMenuItem
            // 
            this.goodsSearchToolStripMenuItem.Name = "goodsSearchToolStripMenuItem";
            this.goodsSearchToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.goodsSearchToolStripMenuItem.Text = "Goods Search";
            this.goodsSearchToolStripMenuItem.Click += new System.EventHandler(this.goodsSearchToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(658, 497);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Market";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyStuffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuStatistics;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptByDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

