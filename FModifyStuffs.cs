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
    public partial class FModifyStuffs : Form
    {

        //Make connection
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = SuperMarket; Integrated Security = True");
        // Check GoodsId for Update and Delete
        Boolean CodeCheck = false;
        public FModifyStuffs()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Goods WHERE GoodsId ='" + Convert.ToInt64(textBox1.Text) + "' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                textBox2.Text = dt.Rows[0].ItemArray[1].ToString();
                textBox3.Text = dt.Rows[0].ItemArray[2].ToString();
                textBox4.Text = dt.Rows[0].ItemArray[3].ToString();
                //GoodsId is Correct
                CodeCheck = true;
            }
            catch(Exception)
            {
                textBox2.Text = textBox3.Text = textBox4.Text = "";
                //GoodsId is not correct
                CodeCheck = false;
            }


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text =="")
            {
                textBox1.Focus();
            }
            else if ( CodeCheck == false)
            {
                textBox1.Focus();
                MessageBox.Show("Stuff not found");
            }
            else
            {
                try
                {
                    //DELETE operation
                    conn.Open();
                    SqlCommand comm = new SqlCommand("Delete from Goods WHERE GoodsId=@GoodsId", conn);
                    comm.Parameters.AddWithValue("@GoodsId", Convert.ToInt64(textBox1.Text));
                    comm.ExecuteNonQuery();
                    conn.Close();

                    //After DELETE
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = ""; textBox1.Focus();
                    MessageBox.Show("Delete Done");
                    FModifyStuffs_Load(sender, e);
                }
                catch(Exception)
                {
                    MessageBox.Show("Delete not compeleted. Please check the Data", "Error");
                }
                
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                textBox1.Focus();
            }
            else if (CodeCheck == false)
            {
                textBox1.Focus();
                MessageBox.Show("Stuff not found");
            }
            else if(textBox3.Text == "")
            {
                textBox3.Focus();
            }
            else if(textBox4.Text =="")
            {
                textBox4.Focus();
            }
            else
            {
                try
                {
                    //UPDATE Operation
                    conn.Open();
                    //do not change GoodId in SQL query 
                    SqlCommand com = new SqlCommand("UPDATE Goods SET  Name = @Name, Price = @Price, Quantity = @Quantity WHERE (GoodsId = @GoodsId) ", conn);
                    com.Parameters.AddWithValue("@Name", textBox2.Text);
                    com.Parameters.AddWithValue("@Price", Convert.ToInt32(textBox3.Text));
                    com.Parameters.AddWithValue("@Quantity", Convert.ToInt32(textBox4.Text));
                    com.Parameters.AddWithValue("@GoodsId", Convert.ToInt64(textBox1.Text));
                    com.ExecuteNonQuery();
                    conn.Close();

                    //After Update
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    textBox1.Focus();
                    MessageBox.Show("Update Done");
                    FModifyStuffs_Load(sender, e);
                }
                catch(Exception)
                {
                    MessageBox.Show("Update not compeleted. Please check the Data","Error");
                }
            }
        }

        private void FModifyStuffs_Load(object sender, EventArgs e)
        {
            // Show DATA in DATAGRIDVIEW
            SqlDataAdapter da = new SqlDataAdapter("Select * from Goods", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Customize DATAGRIDVIEW
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
        }
    }
}
