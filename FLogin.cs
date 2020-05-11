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
    public partial class FLogin : Form
    {
        //Make connection
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = SuperMarket; Integrated Security = True");
        public FLogin()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Focus();
            }
            else if ( textBox2.Text == "")
            {
                textBox2.Focus();
            }
            else
            {
                try
                {

                    SqlDataAdapter da = new SqlDataAdapter("select Password,UserType from [User] WHERE UserName Like N'" +textBox1.Text+"'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    string Pass = dt.Rows[0].ItemArray[0].ToString();

                    //How to Show Data to Authorized User
                    Memory.usertype = Convert.ToInt32( dt.Rows[0].ItemArray[1]);

                    if (textBox2.Text == Pass)
                    {
                        //UserName & PassWord is correct
                        Memory.UserName = textBox1.Text;

                        // Update Login information to DataBase
                        conn.Open();
                        SqlCommand com = new SqlCommand("UPDATE [User] SET Sign = Sign+1 , LastDateSignIn = @LastDateSignIn, LastTimeSignIn = @LastTimeSignIn WHERE (UserName = @UserName) ", conn);
                        com.Parameters.AddWithValue("@LastDateSignIn", DateTime.Now.ToLongDateString() );
                        com.Parameters.AddWithValue("@LastTimeSignIn",DateTime.Now.ToLongTimeString());
                        com.Parameters.AddWithValue("@UserName", textBox1.Text);
                        com.ExecuteNonQuery();
                        conn.Close();

                        this.Close();
                    }
                    else
                    {
                        // UserName is correct but password is wrong

                        textBox2.Focus();
                        MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
                catch (Exception)
            {
                //False UserName :
                textBox1.Focus();
                MessageBox.Show("Wrong UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void BtnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
