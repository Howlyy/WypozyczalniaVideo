using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    public partial class ClientModForm : Form
    {
        SqlConnection db_con;
        public ClientModForm()
        {
            InitializeComponent();

            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }

        private void ClientModBTN_Click(object sender, EventArgs e)
        {
            string firstname = ClientModFirstTB.Text;
            string lastname = ClientModLastTB.Text;
            string pesel = ClientModPeselTB.Text;
            string nrtel = ClientModTelTB.Text;

            mod_client_messagebox(firstname, lastname, pesel, nrtel);
        }


        private int mod_client(string firstname, string lastname, string pesel, string nrtel)
        {
            db_con.Open();


            SqlCommand cmd_mod_client = new SqlCommand("modify_client", db_con);
            cmd_mod_client.CommandType = CommandType.StoredProcedure;

            cmd_mod_client.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = firstname;
            cmd_mod_client.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = lastname;
            cmd_mod_client.Parameters.AddWithValue("@pesel", SqlDbType.NVarChar).Value = pesel;
            cmd_mod_client.Parameters.AddWithValue("@nrtel", SqlDbType.NVarChar).Value = nrtel;
            cmd_mod_client.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_mod_client.ExecuteNonQuery();

            int mod_result = (int)cmd_mod_client.Parameters["@result"].Value;

            db_con.Close();

            return mod_result;
        }

        private void mod_client_messagebox(string firstname, string lastname, string pesel, string nrtel)
        {
            var mb_result = MessageBox.Show("Czy napewno chcesz usunąć " + ClientModFirstTB.Text + " " + ClientModLastTB.Text + " ?", "Powiadomienie", MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {
                mod_client(firstname, lastname, pesel, nrtel);
                MessageBox.Show("Zmodfikowano klienta!");
                Hide();
            }
            else
                MessageBox.Show("lipa");

        }
    }
}
