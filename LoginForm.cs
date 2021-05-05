using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


       

        private void LoginBT_Click(object sender, EventArgs e)
        {

            //string config = ConfigurationManager.ConnectionStrings["Video"].ConnectionString; // chwilowo - napisać za pomocą mothody


            //SqlConnection db_con = new SqlConnection(config);

            //SqlDataReader data_reader = null;

            //db_con.Open();

            //SqlCommand cmd_log = new SqlCommand("check_login", db_con);

            //cmd_log.CommandType = System.Data.CommandType.StoredProcedure;

            //cmd_log.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = UsernameTB.Text;
            //cmd_log.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = PasswordTB.Text;
            //cmd_log.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            //cmd_log.ExecuteNonQuery();

            //var result = cmd_log.Parameters["@result"].Value.ToString();

            string username = UsernameLabel.Text;
            string password = PasswordTB.Text;

            string login_result = Login(username, password);


                if (login_result == "1")
                {
                    this.Hide();
                    new MainForm().Show();

                }
                else
                {
                    MessageBox.Show("Błędne dane logowania!");
                }


                //db_con.Close();
            
        }

        private string Login(string @username, string @password)
        {
            string config = ConfigurationManager.ConnectionStrings["Video"].ConnectionString; // chwilowo - napisać za pomocą mothody


            SqlConnection db_con = new SqlConnection(config);

            SqlDataReader data_reader = null;

            db_con.Open();

            SqlCommand cmd_log = new SqlCommand("check_login", db_con);

            cmd_log.CommandType = System.Data.CommandType.StoredProcedure;

            cmd_log.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = UsernameTB.Text;
            cmd_log.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = PasswordTB.Text;
            cmd_log.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_log.ExecuteNonQuery();

            var result = cmd_log.Parameters["@result"].Value.ToString();


            db_con.Close();

            return result;
        }
    }
}
