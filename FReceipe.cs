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
    public partial class FReceipt : Form
    {
        //Make Connection
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = SuperMarket; Integrated Security = True");
        // Check CustomerId is vaild or not
        Boolean CheckCustomerId = false;
        Boolean CheckGoodsId = false;

        Boolean CheckReceiptHasCustomer = false;


        public FReceipt()
        {
            InitializeComponent();
        }
        public void ShowDataForReceiot()
        {
            // Show data in Datagridview
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Goods.Name, Items.GoodsId ,Goods.Price, Items.QuantityOfItems, Items.QuantityOfItems * Goods.Price AS Sum FROM   Goods INNER JOIN Items ON Goods.GoodsId = Items.GoodsId WHERE Items.ReceiptId='"+ Convert.ToInt64( LblReceiptNo.Text )+"'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 50;

            // Calculate Total of Receipt:
            da = new SqlDataAdapter("SELECT Sum(Goods.Price*Items.QuantityOfItems)  FROM   Goods INNER JOIN  Items ON Goods.GoodsId = Items.GoodsId WHERE Items.ReceiptId='" + Convert.ToInt64(LblReceiptNo.Text) + "'", conn);
            dt = new DataTable();
            da.Fill(dt);

            LblSumPrice.Text = dt.Rows[0].ItemArray[0].ToString() ;
             

            conn.Close();

        }
        public void NewReceipeId()
        {
           try
            {
                // Create New ReceiptID
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MAX(ReceiptId) from Receipt ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                //Create max(receiptid)+1
                LblReceiptNo.Text = (Convert.ToUInt32(dt.Rows[0].ItemArray[0]) + 1).ToString();
            }
            catch (Exception)
            {
                //Start ReceiptId from 100
                LblReceiptNo.Text = "100";
            }
           


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void LblReceiptNo_Click(object sender, EventArgs e)
        {

        }

        private void FReceipt_Load(object sender, EventArgs e)
        {
            NewReceipeId();
            //Set Date by Calling Date Function
            LblDate.Text = Date.DateandTime();
            textBox1.Text = "1";
            textBox2.Focus();
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT  Name, Family, Address, Tel  FROM   Customer WHERE CustomerId ='" + Convert.ToInt32(textBox1.Text) + "' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                LblCustomerName.Text = dt.Rows[0].ItemArray[0].ToString();
                LblCustomerFamily.Text = dt.Rows[0].ItemArray[1].ToString();
                LblCustomerAddress.Text = dt.Rows[0].ItemArray[2].ToString();
                LblCustomerTel.Text = dt.Rows[0].ItemArray[3].ToString();
                //CustomerId is Valid
                CheckCustomerId = true;
            }
            catch (Exception)
            {
                LblCustomerName.Text = LblCustomerFamily.Text = LblCustomerAddress.Text = LblCustomerTel.Text = "";
                CheckCustomerId = false;
                // MessageBox.Show("Wrong Data Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Goods WHERE GoodsId ='" + Convert.ToInt64(textBox2.Text) + "' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                LblItemName.Text = dt.Rows[0].ItemArray[1].ToString();
                LblItemPrice.Text = dt.Rows[0].ItemArray[2].ToString();
                LblQuantity.Text = dt.Rows[0].ItemArray[3].ToString();
                //GoodsId is Correct
                CheckGoodsId = true;
            }
            catch (Exception)
            {
                LblItemName.Text = LblItemPrice.Text = LblQuantity.Text = "";
                //GoodsId is not correct
                CheckGoodsId = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                textBox1.Focus();
            }
            else if ( CheckCustomerId == false )
            {
                textBox1.Focus();
                MessageBox.Show("Customer Id does not exsit");
            }
            else if ( textBox2.Text =="")
            {
                textBox2.Focus();
            }
            else if ( CheckGoodsId==false)
            {
                textBox2.Focus();
                MessageBox.Show("Items Id does not exsit");
            }
            else if (textBox3.Text =="")
            {
                textBox3.Focus();
            }
            else if ( Convert.ToInt32( textBox3.Text) > Convert.ToInt32( LblQuantity.Text))
            {
                textBox3.Focus();
                MessageBox.Show("Ordered Item is more than Quantity");
            }
            else
            {
                if ( CheckReceiptHasCustomer == false)
                {
                    // Insert Into Receipt:
                    conn.Open();
                    SqlCommand com = new SqlCommand("insert into Receipt (ReceiptId, UserName, CustomerId, DateOfPurchase, TimeOfPurchase)VALUES(@ReceiptId, @UserName, @CustomerId, @DateOfPurchase, @TimeOfPurchase) ", conn);
                    com.Parameters.AddWithValue("@ReceiptId", Convert.ToInt32(LblReceiptNo.Text));
                    com.Parameters.AddWithValue("@UserName", Memory.UserName);
                    com.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(textBox1.Text));
                    com.Parameters.AddWithValue("@DateOfPurchase", DateTime.Now.ToShortDateString());
                    com.Parameters.AddWithValue("@TimeOfPurchase", DateTime.Now.ToShortTimeString());
                    com.ExecuteNonQuery();
                    conn.Close();

                    CheckReceiptHasCustomer = true;
                }
               
                //Insert Into Items:
                conn.Open();
                SqlCommand com1 = new SqlCommand("Insert Into Items (ReceiptId,GoodsId,QuantityOfItems) Values(@ReceiptId,@GoodsId,@QuantityOfItems)", conn);
                com1.Parameters.AddWithValue("@ReceiptId",Convert.ToInt32(LblReceiptNo.Text));
                com1.Parameters.AddWithValue("@GoodsId", Convert.ToInt64(textBox2.Text));
                com1.Parameters.AddWithValue("@QuantityOfItems", Convert.ToInt32(textBox3.Text));
                com1.ExecuteNonQuery();
                

                // Update the Quantity after sell
                com1 = new SqlCommand(" UPDATE Goods SET Quantity = Quantity - @NumberOfOrder WHERE (GoodsId = @GoodsId) ", conn);
                com1.Parameters.AddWithValue("@NumberOfOrder", Convert.ToInt32( textBox3.Text));
                com1.Parameters.AddWithValue("@GoodsId",Convert.ToInt64( textBox2.Text));
                com1.ExecuteNonQuery();
                conn.Close();

                //After Insert:
                textBox2.Text = textBox3.Text = "";
                textBox2.Focus();

                //Show Data in DataGridView
                ShowDataForReceiot();

            }

        }

        private void LblDate_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchCustomerId_Click(object sender, EventArgs e)
        {
            FCustomerSearch fcs = new FCustomerSearch();
            fcs.ShowDialog();
        }

        private void BtnGoodsSearch_Click(object sender, EventArgs e)
        {
            FGoodsSearch fgs = new FGoodsSearch();
            fgs.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnCommit_Click(object sender, EventArgs e)
        {
             if (CheckReceiptHasCustomer == true)
            {
                // Add Total in receipt Table
                conn.Open();
                SqlCommand com = new SqlCommand("UPDATE Receipt SET SumPrice = @SumPrice WHERE (ReceiptId = @ReceiptId) ", conn);
                com.Parameters.AddWithValue("@SumPrice", Convert.ToInt64(LblSumPrice.Text));
                com.Parameters.AddWithValue("@ReceiptId", Convert.ToInt32(LblReceiptNo.Text));
                com.ExecuteNonQuery();
                conn.Close();
                CheckReceiptHasCustomer = false;
                //close receipt form
                this.Close();
            }
           

        }

        private void BtnNextReceipt_Click(object sender, EventArgs e)
        {
            if (CheckReceiptHasCustomer == true)
            {
                BtnCommit_Click(sender, e);
                CheckReceiptHasCustomer = false; // return to defult
                // Next Receipt
                FReceipt fr = new FReceipt();
                fr.ShowDialog();
            }

           
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
