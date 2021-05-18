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
        /// <summary>
        /// Methoda użycia przycisku Usuń klienta. Wywołuje methode delete_messagebox(string firstname, string lastname, string pesel).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientDeleteBTN_Click(object sender, EventArgs e)
        {
            string firstname = ClientDeleteFirstTB.Text;
            string lastname = ClientDeleteLastTB.Text;
            string pesel = ClientDeletePeselTB.Text;

            delete_messagebox(firstname,lastname,pesel);
        }

        /// <summary>
        /// Methoda wywołująca procedurę SQL delete_client przyjmująca parametry @firstname, @lastname, pesel, @result jako OUTPUT.
        /// </summary>
        /// <param name="firstname">Imię kontrahenta</param>
        /// <param name="lastname">Nazwisko kontrahenta</param>
        /// <param name="pesel">Pesel kontrahenta</param>
        /// <returns>int delete_result przyjmuję wartość 1 gdy udało się usunąć kontrahenta, 666 gdy nie</returns>
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

        /// <summary>
        /// Methoda wywołująca MessageBox YESNO. Jeżeli wybrano YES wywołuje methode delete_client(firstname, lastname, pesel), wyświetla komunikat o usunięciu i zamyka okno.
        /// Inaczej wyświetla komunikat o błędzie.
        /// </summary>
        /// <param name="firstname">Imię kontrahenta</param>
        /// <param name="lastname">Nazwisko kontrahenta</param>
        /// <param name="pesel">Pesel kontrahenta</param>
        private void delete_messagebox(string firstname, string lastname, string pesel)
        {
            var mb_result = MessageBox.Show("Czy napewno chcesz usunąć " + ClientDeleteFirstTB.Text + " " + ClientDeleteLastTB.Text + " ?", "Powiadomienie", MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {
                delete_client(firstname, lastname, pesel);
                MessageBox.Show("Usunięto kontrahenta!");
                Hide();
            }
            else
                MessageBox.Show("lipa");
                

        }
    }
}
