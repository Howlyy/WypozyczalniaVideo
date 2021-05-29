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

            ClientModFirstTB.Text = ClientForm.client_firstname;
            ClientModLastTB.Text = ClientForm.client_lastname;
            ClientModPeselTB.Text = ClientForm.client_pesel;
            ClientModTelTB.Text = ClientForm.client_nrtel;
        }

        /// <summary>
        /// Methoda uzycia przycisku Modyfikuj. Wywołuje methode  mod_client_messagebox(firstname, lastname, pesel, nrtel).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientModBTN_Click(object sender, EventArgs e)
        {
            string firstname = ClientModFirstTB.Text;
            string lastname = ClientModLastTB.Text;
            string pesel = ClientModPeselTB.Text;
            string nrtel = ClientModTelTB.Text;

            mod_client_messagebox(firstname, lastname, pesel, nrtel);
        }

        /// <summary>
        /// Methoda wywołująca procedurę SQL modify_client przyjmująca parametry @firstname, @lastname, @pesel, @nrtel, @result jako OUTPUT
        /// </summary>
        /// <param name="firstname">Imię kontrahenta</param>
        /// <param name="lastname">Nazwisko kontrahenta</param>
        /// <param name="pesel">Pesel kontrahenta</param>
        /// <param name="nrtel">Numer telefonu kontrahenta</param>
        /// <returns>int mod_result - przyjmuję wartosć 1 jeżeli klient został zmodyfikowany, inaczej 666.</returns>
        private int mod_client(string firstname, string lastname, string pesel, string nrtel)
        {
            db_con.Open();


            SqlCommand cmd_mod_client = new SqlCommand("modify_client", db_con);
            cmd_mod_client.CommandType = CommandType.StoredProcedure;

            cmd_mod_client.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = firstname;
            cmd_mod_client.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = lastname;
            cmd_mod_client.Parameters.AddWithValue("@pesel", SqlDbType.NVarChar).Value = pesel;
            cmd_mod_client.Parameters.AddWithValue("@nrtel", SqlDbType.NVarChar).Value = nrtel;
            cmd_mod_client.Parameters.AddWithValue("@id_client", SqlDbType.Int).Value = ClientForm.client_id;
            cmd_mod_client.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_mod_client.ExecuteNonQuery();

            int mod_result = (int)cmd_mod_client.Parameters["@result"].Value;

            db_con.Close();

            return mod_result;
        }

        /// <summary>
        /// Metoda wyświtlająca Messageboxa YESNO. Jezeli wybrano YES wywołuje methode mod_client(firstname, lastname, pesel, nrtel), wyświtla komunika o poprawnym zmodyfikowaniu kontrahenta i chowa okno.
        /// Inaczej komunikat o błędzie
        /// </summary>
        /// <param name="firstname">Imie kontrahenta</param>
        /// <param name="lastname">Nazwisko kontrahenta</param>
        /// <param name="pesel">Pesel kontrahenta</param>
        /// <param name="nrtel">Numer telefonu kontrahenta</param>
        private void mod_client_messagebox(string firstname, string lastname, string pesel, string nrtel)
        {
            var mb_result = MessageBox.Show("Czy napewno chcesz zmodyfikować " + ClientModFirstTB.Text + " " + ClientModLastTB.Text + " ?", "Powiadomienie", MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {
                mod_client(firstname, lastname, pesel, nrtel);
                MessageBox.Show("Zmodfikowano klienta!");
                Hide();
            }
            else
                MessageBox.Show("Błąd modyfikacji! Sprawdz dane!");

        }
    }
}
