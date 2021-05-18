using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    public partial class ClientAddForm : Form
    {
        SqlConnection db_con;
        public ClientAddForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }

        /// <summary>
        /// Methoda uzycia przycisku Dodaj klienta. Jeżeli methoda add_client(firstname, lastname, pesel, nrtel) == 1 wyświetla komunika o dodaniu, inaczej że kontrahent juz istnieje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientAddBTN_Click(object sender, EventArgs e)
        {
            string firstname = ClientAddFirstTB.Text;
            string lastname = ClientAddLastTB.Text;
            string pesel = ClientAddPeselTB.Text;
            string nrtel = ClientAddTelTB.Text;

            if (add_client(firstname, lastname, pesel, nrtel) == 1)
            {
                MessageBox.Show("Dodano nowego kontrahenta!");
                Hide();
            }
            else
                MessageBox.Show("Taki kontrahent już istnieje!");
        }

        /// <summary>
        /// Methoda wywołująca procedurę SQL add_new_client przyjmująca parametry @firstname, @lastname, @pesel, @nrtel.
        /// </summary>
        /// <param name="firstname">Imię kontrahenta</param>
        /// <param name="lastname">Nazwisko kontrahenta</param>
        /// <param name="pesel">Pesel kontrahenta</param>
        /// <param name="nrtel">Numer telefonu kontrahenta</param>
        /// <returns>in add_result przyjmuje wartość 1 gdy dodanie powiodło się, inaczej 666 jeżeli taki kontrahent już istnieje</returns>
        private int add_client(string firstname, string lastname, string pesel, string nrtel)
        {
            db_con.Open();


            SqlCommand cmd_return = new SqlCommand("add_new_client", db_con);
            cmd_return.CommandType = CommandType.StoredProcedure;

            cmd_return.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = firstname;
            cmd_return.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = lastname;
            cmd_return.Parameters.AddWithValue("@pesel", SqlDbType.Int).Value = pesel;
            cmd_return.Parameters.AddWithValue("@nrtel", SqlDbType.Int).Value = nrtel;
            cmd_return.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_return.ExecuteNonQuery();

            int add_result = (int)cmd_return.Parameters["@result"].Value;

            db_con.Close();
            return add_result;
        }
    }
}
