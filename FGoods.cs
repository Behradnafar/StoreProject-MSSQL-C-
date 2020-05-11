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
    public partial class FGoods : Form
    {
        // Create Connection :
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = SuperMarket; Integrated Security = True");
        // For return of COM.ExecuteScalar() 
        Boolean CheckinDatabase;
        public FGoods()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            { textBox1.Focus(); }
            else if ( CheckinDatabase == true)
            {
                textBox1.Focus();
                MessageBox.Show("This Code has exsit already", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text=="")
            { textBox2.Focus(); }
            else if ( textBox3.Text =="")
            { textBox3.Focus(); }
            else if (textBox4.Text =="'")
            { textBox4.Focus(); }
            else
            {
                try
                {
                    // INSERT :
                    conn.Open();
                    SqlCommand com = new SqlCommand("INSERT INTO Goods (GoodsId, Name, Price, Quantity) VALUES (@GoodsId,@Name,@Price,@Quantity)", conn);
                    com.Parameters.AddWithValue("@GoodsId", Convert.ToInt64(textBox1.Text));
                    com.Parameters.AddWithValue("@Name", textBox2.Text);
                    com.Parameters.AddWithValue("@Price", Convert.ToInt32(textBox3.Text));
                    com.Parameters.AddWithValue("@Quantity", Convert.ToInt32(textBox4.Text));
                    com.ExecuteNonQuery();
                    conn.Close();

                    //After Insert
                    FGoods_Load(sender, e);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                    MessageBox.Show("Save Compeleted", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               catch(Exception)
                {
                    MessageBox.Show("Please Check Entered Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Write it here again because when the error occurred "We can add data after solve the problem" do not fill all the box again
                    conn.Close();

                }
            
            }
        }

        private void FGoods_Load(object sender, EventArgs e)
        {
            // Show DATA in DATAGRIDVIEW
            SqlDataAdapter da = new SqlDataAdapter("Select * from Goods",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Customize DATAGRIDVIEW
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /// Check the repeatetive ItemId(GOODSID)
                conn.Open();
                SqlCommand com = new SqlCommand("select * from Goods where GoodsId = @GoodsId  ", conn);
                com.Parameters.AddWithValue("@GoodsId", textBox1.Text);
                CheckinDatabase = Convert.ToBoolean(com.ExecuteScalar());   //Check this parameter is it exsit in DATABASE or not ?  RETURN Boolean
                conn.Close();
            }
            catch (Exception)
            {
                // Write it here again because when the error occurred "We can add data after solve the problem" do not fill all the box again
                conn.Close();
            }

           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
