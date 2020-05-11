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
    public partial class FGoodsSearch : Form
    {
        //Make connection
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = SuperMarket; Integrated Security = True");
        public FGoodsSearch()
        {
            InitializeComponent();
        }

        private void FGoodsSearch_Load(object sender, EventArgs e)
        {
            //Show all data from Goods Table
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Goods ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Goods WHERE GoodsId LIKE '"+textBox1.Text+"%' ORDER BY GoodsId ASC", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Goods WHERE Name LIKE '%" + textBox2.Text + "%' ORDER BY GoodsId ASC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch(Exception)
            {
            }
        }
    }
}
