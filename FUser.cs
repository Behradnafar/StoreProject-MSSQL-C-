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
    public partial class FUser : Form
    {
        // Make Connection
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=SuperMarket;Integrated Security=True");
        public FUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text == "")
            {   
                NametextBox.Focus();
            }
            else if (PasswordtextBox.Text == "")
            {
                PasswordtextBox.Focus();
            }
            else
            {   // Sign in process 
                int usertype;
                if(radioButton1.Checked == true)
                {
                    //User 0
                    usertype = 0;
                }
                else
                {
                    //Admin 1
                    usertype = 1;
                }
                try 
                {
                    conn.Open();
                    // Insert to table
                    SqlCommand com = new SqlCommand("INSERT INTO[user] (UserName,Password,UserType,Sign)  VALUES(@UserName,@Password,@UserType,@Sign)", conn);
                    com.Parameters.AddWithValue("@UserName", NametextBox.Text);
                    com.Parameters.AddWithValue("@Password", PasswordtextBox.Text);
                    com.Parameters.AddWithValue("@UserType", usertype);
                    com.Parameters.AddWithValue("@Sign",0);
                    com.ExecuteNonQuery();
                    conn.Close();
                    //After Insert Job :
                    FUser_Load(sender, e); // Load again the form to refresh
                    NametextBox.Text = PasswordtextBox.Text = "";
                    NametextBox.Focus();
                    MessageBox.Show("User has been registered", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("This Username has been already exsit!","Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
               
            }
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void FUser_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT [User].UserName, UserType.TypeName As[Type of User], [User].Sign, [User].LastDateSignIn, [User].LastTimeSignIn FROM   [User] INNER JOIN UserType ON [User].UserType = UserType.UserType", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
