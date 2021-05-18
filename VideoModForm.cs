using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    public partial class VideoModForm : Form
    {
        SqlConnection db_con;
        
        public static string video_title = "";
        public static string video_category = "";
        public static int video_quantity = 0;
        public VideoModForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }

        /// <summary>
        /// Metoda użycia przcisku Dodaj video. Otwiera ModAddVideoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModAddBTN_Click(object sender, EventArgs e)
        {

            new ModAddVideoForm().Show();
        
        }

        /// <summary>
        /// Metoda użycia przcisku Wyszukaj. Uzywa methody Search_view_all gdy nie ma wpisanych wartości w TextBoxy. Gdy są to uzywa mthody Search_view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModSearchBTN_Click(object sender, EventArgs e)
        {
            if (ModSearchCB.Text == "" && ModSearchTB.Text == "")
            {
                Search_view_all();
            }
            else
            {
                Search_view();
            }

        }

        /// <summary>
        /// Metoda użycia przcisku Usuń video. Otwiera ModDeleteForm gdy są zaznaczone dane na DataGridzie(if data_grid() == 0).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModDeleteBTN_Click(object sender, EventArgs e)
        {


            if (data_datagrid() == 0)
            {
                new ModDeleteForm().Show();
            }
            else
            {
                MessageBox.Show("Wyszukaj i zaznacz video");
            }
        }

        /// <summary>
        /// Methoda która po zaznaczeniu komórek na Datagridzie przypisuje je odpowiednio do publicznych zmiennych statycznych(selected_title, selected_category, selected_quantity). Inaczej catchuje errror i ustawia 1 na zmiennej error.
        /// </summary>
        /// <returns>Int Error - zmienna której przypisywana jest 1 jeżeli try,catch wyłapie error inaczej 0</returns>
        private int data_datagrid()
        {
            int error;
            try
            {
                var selected_title = (string)ModSearchDG.SelectedCells[0].Value;
                var selected_quantity = (int)ModSearchDG.SelectedCells[1].Value;
                var selected_category = (string)ModSearchDG.SelectedCells[2].Value;

                video_title = selected_title;
                video_quantity = selected_quantity;
                video_category = selected_category;

                error = 0;
            }
            catch (Exception e)
            {

                error = 1;
            }

            return error;
        }

        /// <summary>
        /// Methoda użycia przycisku Modyfikuj video. Jeżeli są zaznaczone dane czyli data_datagrid zwróci 0 otwiera ModModForm inaczej komunikat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModModifyBTN_Click(object sender, EventArgs e)
        {
            
            if (data_datagrid() == 0)
            {
                new ModModForm().Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego modyfikować! Wyszukaj dane");
            }

        }

        /// <summary>
        /// Methoda wywołująca procedurę SQL video_view o parametrach @title, @category i @combo. Jeżeli @combo (ModSearchCB) == "Tytuł" wyświetlane sa dane 
        /// na datagridzie szukanego video po tytule. Jeżeli @combo (ModSearchCB) jest inne to wyświetla video szukane po kategorii.
        /// </summary>
        private void Search_view()
        {
            DataTable dt = new DataTable();

            db_con.Open();


            SqlCommand cmd_mod_search = new SqlCommand("video_view", db_con);


            cmd_mod_search.CommandType = CommandType.StoredProcedure;

            cmd_mod_search.Parameters.AddWithValue("@combo", SqlDbType.NVarChar).Value = ModSearchCB.Text;

            if (ModSearchCB.Text == "Tytuł")
            {
                cmd_mod_search.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = ModSearchTB.Text;
                cmd_mod_search.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = "";
            }
            else
            {
                cmd_mod_search.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = "";
                cmd_mod_search.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = ModSearchTB.Text;
            }

            SqlDataAdapter dtg = new SqlDataAdapter(cmd_mod_search);

            dtg.Fill(dt);


            ModSearchDG.DataSource = dt;


            db_con.Close();
        }

        /// <summary>
        /// Metoda wywołująca procedurę SQL all_video_view. Uzupełnia dane na datagridzie wszystkimi video z bazy.
        /// </summary>
        private void Search_view_all()
        {
            DataTable dt = new DataTable();

            db_con.Open();


            SqlCommand cmd_mod_search = new SqlCommand("all_video_view", db_con);



            cmd_mod_search.CommandType = CommandType.StoredProcedure;




            SqlDataAdapter dtg = new SqlDataAdapter(cmd_mod_search);

            dtg.Fill(dt);


            ModSearchDG.DataSource = dt;


            db_con.Close();
        }
    }
}
      
