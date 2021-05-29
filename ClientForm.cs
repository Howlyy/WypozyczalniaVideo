using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    public partial class ClientForm : Form
    {
        SqlConnection db_con;

        public static string client_firstname = "";
        public static string client_lastname = "";
        public static string client_pesel = "";
        public static string client_nrtel = "";
        public static string client_combo = "";
        public static int client_id = 0;


        public ClientForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }

        /// <summary>
        /// Metoda uzycia przycisku Dodanie kontrahenta. Wyświetla ClientAddForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientAddBTN_Click(object sender, EventArgs e)
        {
            new ClientAddForm().Show();
        }

        /// <summary>
        /// Metoda uzycia przycisku usunięcie kontrahenta. Wywoluje methodę client_data_datagrid() która przypisuję wartości do publicznych zmiennych staticznych w ClientFormie jezeli sa zaznaczone na datagridzie.
        /// Wyświetla ClientDeleteForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientDeleteBTN_Click(object sender, EventArgs e)
        {
            
            if (client_data_datagrid() == 0)
            {
                delete_messagebox(client_firstname, client_lastname, client_pesel);
                

            }
            else
            {
                MessageBox.Show("Nie ma czego usuwać! Wyszukaj dane");
            }

            

        }

        /// <summary>
        /// Metoda uzycia przycisku Wyszukaj. Jeżeli TextBoxy są puste wyświetla methodę Search_view_all, inaczej Search_view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientSearchBTN_Click(object sender, EventArgs e)
        {
            if (ClientSearchCB.Text == "" && ClientSearchTB.Text == "")
            {
                Search_view_all();
            }
            else
            {
                Search_view();
            }
        }

        /// <summary>
        /// Metoda użycia przycisku Modyfikuj kontrahenta. Jeżeli dane są wybrane na datagridzie przypisuję dane do publicznych zmiennych statycznych w clientformie i wyświetla ClientMOdForm.
        /// Inaczej wyświetla komunikat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientModBTN_Click(object sender, EventArgs e)
        {
            

            if (client_data_datagrid() == 0)
            {
                new ClientModForm().Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego modyfikować! Wyszukaj dane");
            }
        }

        /// <summary>
        /// Metoda wywołująca procedurę SQL all_client_view która zwraca informacje o wszystkich kontrahentach z bazy do datagrida. 
        /// </summary>
        private void Search_view_all()
        {
            DataTable dt = new DataTable();

            db_con.Open();


            SqlCommand cmd_client_search = new SqlCommand("all_client_view", db_con);

            cmd_client_search.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dtg = new SqlDataAdapter(cmd_client_search);

            dtg.Fill(dt);


            ClientSearchDG.DataSource = dt;


            db_con.Close();
        }

        /// <summary>
        /// Metoda wywołująca procedurę SQL client_view która przyjmuje parametry @firstname, @lastname, @pesel, @nrtel.
        /// Jeżeli ComboBox(ClientSearchCB)  == "Imię i nazwisko" wyświetla dane po Imieniu i nazwisku. Jeżeli pesel to po peselu kontrahenta.
        /// Inaczej po numerze telefonu. Dane wyswietlaja sie w datagridzie
        /// </summary>
        private void Search_view()
        {
            DataTable dt = new DataTable();

            db_con.Open();


            SqlCommand cmd_client_mod_search = new SqlCommand("client_view", db_con);



            cmd_client_mod_search.CommandType = CommandType.StoredProcedure;

            cmd_client_mod_search.Parameters.AddWithValue("@combo", SqlDbType.NVarChar).Value = ClientSearchCB.Text;

            if (ClientSearchCB.Text == "Imię i nazwisko")
            {

                cmd_client_mod_search.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = ClientSearchTB.Text;
                cmd_client_mod_search.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = ClientSearchLastTB.Text;
                cmd_client_mod_search.Parameters.AddWithValue("@pesel", SqlDbType.NVarChar).Value = "";
                cmd_client_mod_search.Parameters.AddWithValue("@nrtel", SqlDbType.NVarChar).Value = "";
            }
            else if (ClientSearchCB.Text == "Pesel")
            {
                cmd_client_mod_search.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = "";
                cmd_client_mod_search.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = "";
                cmd_client_mod_search.Parameters.AddWithValue("@pesel", SqlDbType.NVarChar).Value = ClientSearchTB.Text;
                cmd_client_mod_search.Parameters.AddWithValue("@nrtel", SqlDbType.NVarChar).Value = "";
            }
            else
            {
                cmd_client_mod_search.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = "";
                cmd_client_mod_search.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = "";
                cmd_client_mod_search.Parameters.AddWithValue("@pesel", SqlDbType.NVarChar).Value = "";
                cmd_client_mod_search.Parameters.AddWithValue("@nrtel", SqlDbType.NVarChar).Value = ClientSearchTB.Text;
            }



            SqlDataAdapter dtg = new SqlDataAdapter(cmd_client_mod_search);

            dtg.Fill(dt);


            ClientSearchDG.DataSource = dt;


            db_con.Close();
        }

        /// <summary>
        /// Methoda ustawiająca parametr Visible na Textboxie po wybraniu "Imię i nazwisko" w Comboboxie.
        /// </summary>
        /// <param name="combo">Nazwa comboboxu</param>
        /// <param name="lastnameTB">Nazwa textboxu ustawienia parametru Visible true or false</param>
        private void LastnameTb_visible(ComboBox combo, TextBox lastnameTB)
        {
            if (combo.SelectedItem == "Imię i nazwisko")
            {
                lastnameTB.Visible = true;
            }
            else
            {
                lastnameTB.Visible = false;
            }
        }
        /// <summary>
        /// Methoda zmiany wartości w Comboxie ClientSearchCB. Jeżeli wartość ulegnie zmianie wywołuje methodę LastnameTB_Visible(ClientSearchCB, ClientSearchLastTB)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientSearchCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LastnameTb_visible(ClientSearchCB, ClientSearchLastTB);
        }

        /// <summary>
        /// Methoda dopisująca wartości do zmiennych publicznych statycznych w ClientForm jeżeli są zaznaczone na datagridzie, inaczej wyłapuje Errora.
        /// </summary>
        /// <returns>Int error - powyłapaniu error ustawia wartośc na 1, inaczej 0</returns>
        private int client_data_datagrid()
        {
            int error;
            try
            {
                var selected_firstname = (string)ClientSearchDG.SelectedCells[0].Value;
                var selected_lastname = (string)ClientSearchDG.SelectedCells[1].Value;
                var selected_pesel = (string)ClientSearchDG.SelectedCells[2].Value;
                var selected_nrtel = (string)ClientSearchDG.SelectedCells[3].Value;

                client_firstname = selected_firstname;
                client_lastname = selected_lastname;
                client_pesel = selected_pesel;
                client_nrtel = selected_nrtel;
                client_combo = ClientSearchCB.Text;
                client_id = Client_id(selected_pesel, selected_firstname, selected_lastname);

                error = 0;
            }
            catch (Exception e)
            {

                error = 1;
            }

            return error;
        }


        /// <summary>
        /// Methoda wywołująca procedurę SQL delete_client przyjmująca parametry @firstname, @lastname, pesel, @result jako OUTPUT.
        /// </summary>
        /// <param name="firstname">Imię kontrahenta</param>
        /// <param name="lastname">Nazwisko kontrahenta</param>
        /// <param name="pesel">Pesel kontrahenta</param>
        /// <returns>int delete_result przyjmuję wartość 1 gdy udało się usunąć kontrahenta, 666 gdy nie</returns>
        private static int delete_client(string firstname, string lastname, string pesel)
        {


            SqlConnection db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);

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
            var mb_result = MessageBox.Show("Czy napewno chcesz usunąć " + client_firstname + " " + client_lastname + " ?", "Powiadomienie", MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {
                delete_client(firstname, lastname, pesel);
                MessageBox.Show("Usunięto kontrahenta!");
                
                
            }
            else
                MessageBox.Show("lipa");


        }

        /// <summary>
        /// Metoda wywołująca procedure SQL client_id 
        /// </summary>
        /// <param name="pesel">Pesel klienta</param>
        /// <returns>int client_id - id klienta z bazy</returns>
        private int Client_id(string pesel, string firstname, string lastname)
        {
            db_con.Open();

            SqlCommand cmd_id_client = new SqlCommand("client_id", db_con);
            cmd_id_client.CommandType = CommandType.StoredProcedure;

            cmd_id_client.Parameters.AddWithValue("@pesel", SqlDbType.Char).Value = pesel;
            cmd_id_client.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = firstname;
            cmd_id_client.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = lastname;
            cmd_id_client.Parameters.AddWithValue("@id_client", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_id_client.ExecuteNonQuery();

            int client_id = (int)cmd_id_client.Parameters["@id_client"].Value;




            db_con.Close();

            return client_id;
        }

    }

}
