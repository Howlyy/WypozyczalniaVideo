using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    /// <summary>
    /// Form Logowania do programu Wypozyczalni Video
    /// </summary>
    public partial class LoginForm : Form
    {
        
        
        public LoginForm()
        {
            InitializeComponent();
            
             
        }
        /// <summary>
        /// Methoda uzycia przycisku LoginBTN. Po przyciśnieciu używa methody login_check to sprawdzenia poprawności danych. Jak tak to pokazuje Mainform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Methoda używająca procedury SQL do sprawdzenia popraności danych logowania. Przypisuje do LoggedUserId jego id w bazie.  666- nie poprawne 
        /// </summary>
        /// <param name="username">Username uzytkownika</param>
        /// <param name="password">Hasło użytkownika</param>
        /// <returns></returns>
        public static int login_check(string username, string password)
        {
            SqlConnection db_con;

            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);

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
