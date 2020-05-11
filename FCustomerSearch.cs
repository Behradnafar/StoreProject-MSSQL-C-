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
    public partial class FCustomerSearch : Form
    {
        //Make connection
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = SuperMarket; Integrated Security = True");
        public FCustomerSearch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Show Data in datagridview by CustomerId
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerId,Name,Family,Tel,Address FROM Customer WHERE CustomerId LIKE '" + textBox1.Text + "%' ORDER By CustomerId ASC ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


                conn.Close();
            }
            catch(Exception)
            {

            }
           
        }

        private void FCustomerSearch_Load(object sender, EventArgs e)
        {
            //Show Data in datagridview
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerId,Name,Family,Tel,Address FROM Customer",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 70;

            conn.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Show Data in datagridview by Name & Family
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerId,Name,Family,Tel,Address FROM Customer WHERE Name LIKE N'%" + textBox2.Text  + "%' And Family like N'%"+textBox3.Text+"%' ORDER By CustomerId ASC ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


                conn.Close();
            }
            catch (Exception)
            {

            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text = "";
            //Show Data in datagridview
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerId,Name,Family,Tel,Address FROM Customer", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }
    }
}
