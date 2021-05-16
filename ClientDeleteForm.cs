using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    public partial class ClientDeleteForm : Form
    {
        SqlConnection db_con;

        public ClientDeleteForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }

        private void ClientDeleteBTN_Click(object sender, EventArgs e)
        {
            string firstname = ClientDeleteFirstTB.Text;
            string lastname = ClientDeleteLastTB.Text;
            string pesel = ClientDeletePeselTB.Text;

            delete_messagebox(firstname,lastname,pesel);
        }

        private int delete_client(string firstname, string lastname, string pesel)
        {
            db_con.Open();


            SqlCommand cmd_return = new SqlCommand("delete_client", db_con);
            cmd_return.CommandType = CommandType.StoredProcedure;

            cmd_return.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = firstname;
            cmd_return.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = lastname;
            cmd_return.Parameters.AddWithValue("@pesel", SqlDbType.NVarChar).Value = pesel;
            cmd_return.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_return.ExecuteNonQuery();

            int delete_result = (int)cmd_return.Parameters["@result"].Value;

            db_con.Close();

            return delete_result;
        }

        private void delete_messagebox(string firstname, string lastname, string pesel)
        {
            var mb_result = MessageBox.Show("Czy napewno chcesz usunąć " + ClientDeleteFirstTB.Text + " " + ClientDeleteLastTB.Text + " ?", "Powiadomienie", MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {
                delete_client(firstname, lastname, pesel);
            }
            else
                MessageBox.Show("lipa");

        }
    }
}
