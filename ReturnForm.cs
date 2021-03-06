using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    /// <summary>
    /// Form zwrotu video
    /// </summary>
    public partial class ReturnForm : Form
    {
        SqlConnection db_con;
        
        public ReturnForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }
        /// <summary>
        /// Methoda użycia przycisku SearchReturnBTN. Używa procedury SQL Borrow_return_view i wypisuje otrzymane dane do datagrida.
        /// Dane czerpie z TextBoxów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchReturnBTN_Click(object sender, EventArgs e)
        {

            string combo = SearchTypeReturnCB.Text;
            string title = SearchreturnTB.Text;
            string firstname = SearchreturnTB.Text;
            string lastname = ReturnSearchLastnameTB.Text;

            DataTable dt = new DataTable();

            db_con.Open();


            SqlCommand cmd_bor_search = new SqlCommand("borrow_return_view", db_con);

            cmd_bor_search.CommandType = CommandType.StoredProcedure;

            cmd_bor_search.Parameters.AddWithValue("@combo", SqlDbType.NVarChar).Value = combo;

            if (SearchTypeReturnCB.Text == "Tytuł")
            {
                cmd_bor_search.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = title;
                cmd_bor_search.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = "";
                cmd_bor_search.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = "";
            }
            else if (SearchTypeReturnCB.Text == "Imię i nazwisko")
            {
                cmd_bor_search.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = "";
                cmd_bor_search.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = firstname;
                cmd_bor_search.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = lastname;
            }
            else
            {
                cmd_bor_search = new SqlCommand("Borrow_return_view_all",db_con);
            }


            SqlDataAdapter dtg = new SqlDataAdapter(cmd_bor_search);


            dtg.Fill(dt);


            SearchReturnDG.DataSource = dt;



            db_con.Close();

        }

        /// <summary>
        /// Methoda użycia przycisku ReturnBTN. Używa methody return_video do zwrotu video. Jezeli return_video_result = 1 - zwrot inaczej błędne dane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnBTN_Click(object sender, EventArgs e)
        {

            string video_title = TitleReturnTB.Text;
            string client_firstname = FirstnameReturnTB.Text;
            string client_lastname = LastnameReturnTB.Text;



            int return_video_result = return_video(video_title, client_firstname, client_lastname);
            


            if (return_video_result == 1)
            {
                MessageBox.Show("Zwrócono!");
            }
            else
            {
                MessageBox.Show("Nie zwrócono! Sprawdz dane!");
            }
        }

        /// <summary>
        /// Methoda zwrotu video. Wykorzystuje procedurę SQL return_video. Zwraca w postaci inta zmienna return_result. 1 - zwrot inaczej bład danych
        /// </summary>
        /// <param name="title">Tytłu video zwracanego</param>
        /// <param name="client_firstname">Imię klienta zwracającego video</param>
        /// <param name="client_lastname">Nazwisko klienta zwracającego video</param>
        /// <returns></returns>
        private int return_video(string title, string client_firstname, string client_lastname)
        {
           
            db_con.Open();


            SqlCommand cmd_return = new SqlCommand("return_video", db_con);
            cmd_return.CommandType = CommandType.StoredProcedure;

            cmd_return.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = title;
            cmd_return.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = client_firstname;
            cmd_return.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = client_lastname;
            cmd_return.Parameters.AddWithValue("@id_log_return", SqlDbType.Int).Value = WypozyczalniaVideo.LoggerUserId;
            cmd_return.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_return.ExecuteNonQuery();

            int return_result = (int)cmd_return.Parameters["@result"].Value;

            db_con.Close();

            return return_result;
        }

        /// <summary>
        /// Methoda zdażenia zmiany wartości w combo boxie. Jeżeli dojdzie do zmiany wywołuje methodę LastnameTB_visible(Combo, lastname)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTypeReturnCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LastnameTb_visible(SearchTypeReturnCB, ReturnSearchLastnameTB, "Imię i nazwisko");
        }

        /// <summary>
        /// Methoda ustawiania widocznosci lastnametb. Jeżeli wartość w Comboboxie zmieni sie na "Imię i nazwisko" ustawia parametr Visible = true na ReturnSearchLastnameTB
        /// </summary>
        /// <param name="combo">Nazwa ComboBoxa</param>
        /// <param name="lastnameTB">Nazwa textboxa do odkrycia</param>
        /// <param name="wartosc">Wartośc przy której będzie zmiana Visible na true</param>
        private void LastnameTb_visible(ComboBox combo, TextBox lastnameTB, string wartosc)
        {
            if (combo.SelectedItem == wartosc)
            {
                lastnameTB.Visible = true;
            }
            else
            {
                lastnameTB.Visible = false;
            }
        }
    }
}
