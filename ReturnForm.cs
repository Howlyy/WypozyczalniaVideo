using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    public partial class ReturnForm : Form
    {
        SqlConnection db_con;
        
        public ReturnForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }

        private void SearchReturnBTN_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            db_con.Open();


            SqlCommand cmd_bor_search = new SqlCommand("borrow_return_view", db_con);

            cmd_bor_search.CommandType = CommandType.StoredProcedure;

            cmd_bor_search.Parameters.AddWithValue("@combo", SqlDbType.NVarChar).Value = SearchTypeReturnCB.Text;

            if (SearchTypeReturnCB.Text == "Tytuł")
            {
                cmd_bor_search.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = SearchreturnTB.Text;
                cmd_bor_search.Parameters.AddWithValue("@client_name", SqlDbType.NVarChar).Value = "";
            }
            else
            {
                cmd_bor_search.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = "";
                cmd_bor_search.Parameters.AddWithValue("@client_name", SqlDbType.NVarChar).Value = SearchreturnTB.Text;
            }


            SqlDataAdapter dtg = new SqlDataAdapter(cmd_bor_search);


            dtg.Fill(dt);


            SearchReturnDG.DataSource = dt;



            db_con.Close();

        }

        private void ReturnBTN_Click(object sender, EventArgs e)
        {

            string book_title = TitleReturnTB.Text;
            string client_firstname = FirstnameReturnTB.Text;
            string client_lastname = LastnameReturnTB.Text;


            db_con.Open();


            SqlCommand cmd_borrow = new SqlCommand("return_book", db_con);
            cmd_borrow.CommandType = CommandType.StoredProcedure;

            cmd_borrow.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = TitleReturnTB.Text;
            cmd_borrow.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = FirstnameReturnTB.Text;
            cmd_borrow.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = LastnameReturnTB.Text;
            cmd_borrow.Parameters.AddWithValue("@id_log_return", SqlDbType.Int).Value = WypozyczalniaVideo.LoggedUserId;
            cmd_borrow.Parameters.AddWithValue("@result", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd_borrow.ExecuteNonQuery();

            string result = cmd_borrow.Parameters["@result"].Value.ToString();

            db_con.Close();


            if (result == "Returned")
            {
                MessageBox.Show("Zwrócono!");
            }
            else
            {
                MessageBox.Show("Nie zwrócono! Sprawdz dane!");
            }
        }
    }
}
