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
        public static int video_id = 0;
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
                data_datagrid();
            }
            else
            {
                Search_view();
                data_datagrid();
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
                delete_messagebox(video_title,video_category);
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
                
                video_id = Search_id_video(selected_title);

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
            
            
            try
            {
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

                cmd_mod_search.Parameters.AddWithValue("@id_video", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd_mod_search.ExecuteNonQuery();

                video_id = (int)cmd_mod_search.Parameters["@id_video"].Value;

                SqlDataAdapter dtg = new SqlDataAdapter(cmd_mod_search);

                dtg.Fill(dt);


                ModSearchDG.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Nie ma takiego video!");
            }

            


            

            


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
        
        /// <summary>
        /// Metoda wywołująca procedurę SQL delete_video przyjmującą parametry @title, @category, @result jako OUTPUT.
        /// </summary>
        /// <param name="video_title">Tytuł video</param>
        /// <param name="video_category">Kategoria Video</param>
        /// <returns>int delete_result - przyjmuje 1 gdy usunięcie sie powiodło, inaczej 666.</returns>
        private int delete_video(string video_title, string video_category)
        {
            db_con.Open();


            SqlCommand cmd_return = new SqlCommand("delete_video", db_con);
            cmd_return.CommandType = CommandType.StoredProcedure;

            cmd_return.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = video_title;
            cmd_return.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = video_category;
            cmd_return.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_return.ExecuteNonQuery();

            int delete_result = (int)cmd_return.Parameters["@result"].Value;

            db_con.Close();

            return delete_result;
        }

        /// <summary>
        /// Metoda wyświtlająca Messageboxa YESNO. Jezeli wybrano YES wywołuje metode delete_video(title, category) i wyświetla komunikat, inaczej wyświetla komunikat o błędzie.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="category"></param>
        private void delete_messagebox(string title, string category)
        {
            var mb_result = MessageBox.Show("Czy napewno chcesz usunąć " + video_title + " ?", "Powiadomienie" + video_title, MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {
                delete_video(title, category);
                MessageBox.Show("Usunięto video!");
                
            }
            else
                MessageBox.Show("NIe usunięto! Sprawdz dane!");

        }

        /// <summary>
        /// Methoda wywołująca procedure SQL  video_id
        /// </summary>
        /// <param name="title">Tytuł video</param>
        /// <returns>int video_id - id video z bazy</returns>

        private int Search_id_video(string title)
        {
            

            db_con.Open();
            
            SqlCommand cmd_id_video = new SqlCommand("video_id", db_con);
            cmd_id_video.CommandType = CommandType.StoredProcedure;

            cmd_id_video.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = title;
            cmd_id_video.Parameters.AddWithValue("@id_video", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_id_video.ExecuteNonQuery();

            int video_id = (int)cmd_id_video.Parameters["@id_video"].Value;


           

            db_con.Close();

            return video_id;
        }
        
    }


}
      
