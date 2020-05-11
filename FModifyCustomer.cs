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
    public partial class FModifyCustomer : Form
    {
        //Make connection
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = SuperMarket; Integrated Security = True");

        // Check the correct CustomerId for update
        Boolean CheckCode = false;
        public FModifyCustomer()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckCode == false)
            {
                textBox1.Focus();
                MessageBox.Show("Customer Id Does Not Exsit ! Please Enter Correct Customer Id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                textBox1.Focus();
            }
            else if (textBox2.Text =="")
            {
                textBox2.Focus();
            }
            else if ( textBox3.Text =="")
            {
                textBox3.Focus();
            }
            else if( textBox4.Text =="")
            {
                textBox4.Focus();
            }
            else if ( textBox5.Text == "")
            {
                textBox5.Focus();
            }
            else
            { 
                try
                {
                    /// UPDATE Customer
                    conn.Open();
                    SqlCommand com = new SqlCommand("UPDATE Customer SET Name = @Name, Family = @Family, Address = @Address, Tel = @Tel WHERE (CustomerId = @CustomerId) ", conn);
                    com.Parameters.AddWithValue("@Name", textBox2.Text);
                    com.Parameters.AddWithValue("@Family", textBox3.Text);
                    com.Parameters.AddWithValue("@Address", textBox4.Text);
                    com.Parameters.AddWithValue("Tel", Convert.ToInt64(textBox5.Text));
                    com.Parameters.AddWithValue("@CustomerId", Convert.ToInt32(textBox1.Text));
                    com.ExecuteNonQuery();

                    conn.Close();
                    //After Update
                    MessageBox.Show("Customer UPDATED Successfuly", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FModifyCustomer_Load(sender, e);
                }
                catch(Exception)
                {
                    MessageBox.Show("Wrong Data Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FModifyCustomer_Load(sender, e);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

            
                SqlDataAdapter da = new SqlDataAdapter("SELECT  Name, Family, Address, Tel  FROM   Customer WHERE CustomerId ='" + Convert.ToInt32(textBox1.Text) + "' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                textBox2.Text = dt.Rows[0].ItemArray[0].ToString();
                textBox3.Text = dt.Rows[0].ItemArray[1].ToString();
                textBox4.Text = dt.Rows[0].ItemArray[2].ToString();
                textBox5.Text = dt.Rows[0].ItemArray[3].ToString();
                //FModifyCustomer_Load(sender, e);
                CheckCode = true;
            }
            catch(Exception)
            {
                // MessageBox.Show("Wrong Data Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FModifyCustomer_Load(object sender, EventArgs e)
        {
            // Make the form ready
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
            textBox1.Focus();

            // Show data in DATAGRIDVIEW
            SqlDataAdapter da = new SqlDataAdapter("select * from Customer", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

           

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Focus();
                
            }
            else if(CheckCode == false)
            {
                textBox1.Focus();
                MessageBox.Show("Customer Does Not Exsist!");
            }
            else
            {
                //try
                //{
                    //Delete Customer
                    conn.Open();
                    SqlCommand com = new SqlCommand("Delete from Customer where (CustomerId = @CustomerId) ", conn);
                    com.Parameters.AddWithValue("@CustomerId", Convert.ToInt32(textBox1.Text));
                    com.ExecuteNonQuery();
                    conn.Close();

                    // AFter Delete
                    MessageBox.Show("Customer Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FModifyCustomer_Load(sender, e);
            //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Wrong Data Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }
    }
}
