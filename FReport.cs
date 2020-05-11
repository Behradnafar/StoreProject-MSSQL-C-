using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarket
{
    public partial class FReportDate : Form
    {
        //Make Connection 
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = SuperMarket; Integrated Security = True");
        public FReportDate()
        {
            InitializeComponent();
        }

        private void FReportDate_Load(object sender, EventArgs e)
        {
            
            SqlDataAdapter da = new SqlDataAdapter(" SELECT Receipt.ReceiptId,Receipt.SumPrice, Receipt.UserName, Receipt.CustomerId, Receipt.DateOfPurchase, Receipt.TimeOfPurchase, Customer.Name, Customer.Family, Customer.Address, Customer.Tel FROM   Receipt INNER JOIN Customer ON Receipt.CustomerId = Customer.CustomerId ORDER BY Receipt.DateOfPurchase", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            LblNumberofReceipt.Text = (Convert.ToUInt32(dataGridView1.Rows.Count) - 1).ToString();


        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="" && textBox2.Text =="")
            {
                SqlDataAdapter da = new SqlDataAdapter(" SELECT Receipt.ReceiptId,Receipt.SumPrice, Receipt.UserName, Receipt.CustomerId, Receipt.DateOfPurchase, Receipt.TimeOfPurchase, Customer.Name, Customer.Family, Customer.Address, Customer.Tel FROM   Receipt INNER JOIN Customer ON Receipt.CustomerId = Customer.CustomerId ORDER BY Receipt.DateOfPurchase DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
            else if (textBox1.Text !="" && textBox2.Text =="")
            {
                SqlDataAdapter da = new SqlDataAdapter(" SELECT Receipt.ReceiptId,Receipt.SumPrice, Receipt.UserName, Receipt.CustomerId, Receipt.DateOfPurchase, Receipt.TimeOfPurchase, Customer.Name, Customer.Family, Customer.Address, Customer.Tel FROM   Receipt INNER JOIN Customer ON Receipt.CustomerId = Customer.CustomerId WHERE Receipt.DateOfPurchase >= '" + textBox1.Text+"' ORDER BY Receipt.DateOfPurchase DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else if(textBox1.Text=="" && textBox2.Text!="")
            {
                SqlDataAdapter da = new SqlDataAdapter(" SELECT Receipt.ReceiptId,Receipt.SumPrice, Receipt.UserName, Receipt.CustomerId, Receipt.DateOfPurchase, Receipt.TimeOfPurchase, Customer.Name, Customer.Family, Customer.Address, Customer.Tel FROM   Receipt INNER JOIN Customer ON Receipt.CustomerId = Customer.CustomerId WHERE Receipt.DateOfPurchase <= '" + textBox2.Text+ "%' ORDER BY Receipt.DateOfPurchase DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter(" SELECT Receipt.ReceiptId,Receipt.SumPrice, Receipt.UserName, Receipt.CustomerId, Receipt.DateOfPurchase, Receipt.TimeOfPurchase, Customer.Name, Customer.Family, Customer.Address, Customer.Tel FROM   Receipt INNER JOIN Customer ON Receipt.CustomerId = Customer.CustomerId WHERE Receipt.DateOfPurchase >= '" + textBox1.Text + "' AND  Receipt.DateOfPurchase <= '" + textBox2.Text + "%' ORDER BY Receipt.DateOfPurchase DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            LblNumberofReceipt.Text= (Convert.ToUInt32( dataGridView1.Rows.Count) -1) .ToString();
        }
    }
}
