using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    public partial class LoginForm : Form
    {
        SqlConnection db_con;
        public LoginForm()
        {
            InitializeComponent();

            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {

            string username = UsernameTB.Text;
            string password = PasswordTB.Text;

            int login_result = login_check(username, password);

            if (login_result > 0)
            {
                this.Hide();
                new MainForm().Show();

            }
            else
            {
                MessageBox.Show("Błędne dane logowania!");

            }
        }

        private int login_check(string username, string password)
        {

            db_con.Open();

            SqlCommand cmd_log = new SqlCommand("check_login", db_con);

            cmd_log.CommandType = System.Data.CommandType.StoredProcedure;

            cmd_log.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = username;
            cmd_log.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = password;
            cmd_log.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_log.ExecuteNonQuery();

            int LoggedUserId = (int)cmd_log.Parameters["@result"].Value;

            db_con.Close();

            return LoggedUserId;
        }
    }
}
