using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WypożyczalniaVideo
{
    /// <summary>
    /// Form Wypożyczania video
    /// </summary>
    public partial class BorrowForm : Form
    {
        SqlConnection db_con;

        public BorrowForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }
        /// <summary>
        /// Methoda opisująca użycie przycisku SearchBorrowBTN. Wyszukiwanie po text w Comboboxie oraz Textboxach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBorrowBTN_Click(object sender, EventArgs e)
        {
            

            DataTable dt = new DataTable();

            db_con.Open();

            SqlCommand cmd_bor_search = new SqlCommand("borrow_search_view", db_con);
            cmd_bor_search.CommandType = CommandType.StoredProcedure;


            if (SearchTypeCB.Text == "Kategoria")
            {

                cmd_bor_search.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = "";
                cmd_bor_search.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = SearchborrowTB.Text;
   
            }
            else if (SearchTypeCB.Text == "Tytuł")
            {
                
               
                cmd_bor_search.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = SearchborrowTB.Text;
                cmd_bor_search.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = "";
 
            }
            else
            {
                cmd_bor_search = new SqlCommand("all_video_view", db_con);
                cmd_bor_search.CommandType = CommandType.StoredProcedure; 
            }
           
            SqlDataAdapter dtg = new SqlDataAdapter(cmd_bor_search);

            dtg.Fill(dt);

            SearchBorrowDG.DataSource = dt;

            db_con.Close();

        }

        /// <summary>
        /// Metoda opisująca uzycie przycisku BorrowBTN. Wypozycznie video przez methodę video_borrow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BorrowBTN_Click(object sender, EventArgs e)
        {

            string video_title = TitleBorrowTB.Text;
            string client_firstname = FirstnameBorrowTB.Text;
            string client_lastname = LastnameBorrowTB.Text;



            if(video_borrow(video_title, client_firstname, client_lastname) == 1)
            {
                MessageBox.Show("Wypozyczono!");
            }
            else
            {
                MessageBox.Show("Nie wypożyczono! Sprawdz dane!");
            }
            

        }

        /// <summary>
        /// Methoda korzystająca z procedury w SQL video_borrow. Wypozycza video po podaniu parametrów. Zwraca result 1 - wypożyczono,666 - error
        /// </summary>
        /// <param name="video_title">Tytuł video</param>
        /// <param name="client_firstname">Imię klienta</param>
        /// <param name="client_lastname">Nazwisko klienta</param>
        /// <returns></returns>
        private int video_borrow(string video_title, string client_firstname, string client_lastname)
        {
           
            db_con.Open();


            SqlCommand cmd_borrow = new SqlCommand("video_borrow", db_con);
            cmd_borrow.CommandType = CommandType.StoredProcedure;

            cmd_borrow.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = video_title;
            cmd_borrow.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = client_firstname;
            cmd_borrow.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = client_lastname;
            cmd_borrow.Parameters.AddWithValue("@id_login", SqlDbType.Int).Value = WypozyczalniaVideo.LoggerUserId;
            cmd_borrow.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_borrow.ExecuteNonQuery();

            int borrow_result = (int)cmd_borrow.Parameters["@result"].Value;

            db_con.Close();

            return borrow_result;
        }

        
    }
}
