using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FUser fu = new FUser();
            fu.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCustomer fm = new FCustomer();
            fm.ShowDialog();
        }

        private void modifyCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FModifyCustomer fmc = new FModifyCustomer();
            fmc.ShowDialog();
        }

        private void addNewStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FGoods fg = new FGoods();
            fg.ShowDialog();
        }

        private void modifyStuffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FModifyStuffs fms = new FModifyStuffs();
            fms.ShowDialog();
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FReceipt fr = new FReceipt();
            fr.ShowDialog();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            if (Memory.UserName =="")
            {
                FLogin fl = new FLogin();
                fl.ShowDialog();
            }
            //Authorize Users
            if (Memory.usertype == 0)
            {
                // For User
                MenuStatistics.Enabled = false;
            }
            else
            {
                // For Admin
                MenuStatistics.Enabled = true;
            }
      
        }

        private void customersSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCustomerSearch fcs = new FCustomerSearch();
            fcs.ShowDialog();
        }

        private void goodsSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FGoodsSearch fgs = new FGoodsSearch();
            fgs.ShowDialog();
        }

        private void MenuStatistics_Click(object sender, EventArgs e)
        {

        }

        private void receiptByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FReportDate frd = new FReportDate();
            frd.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
