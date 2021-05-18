using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    public partial class ModDeleteForm : Form
    {
        SqlConnection db_con;

        public ModDeleteForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }
        /// <summary>
        ///  Metoda uzycia przycisku Usuń. Wywołuje metode delete_messagebox(title, category);
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModDeleteVideoBTN_Click(object sender, EventArgs e)
        {
            string title = ModDeleteTitleTB.Text;
            string category = ModDeleteCategoryCB.Text;

            delete_messagebox(title, category);

            
            

        }

        /// <summary>
        /// Metoda wywołująca procedurę SQL delete_video przyjmującą parametry @title, @category, @result jako OUTPUT.
        /// </summary>
        /// <param name="video_title">Tytuł video</param>
        /// <param name="video_category">Kategoria Video</param>
        /// <returns>int delete_result - przyjmuje 1 gdy usunięcie sie powiodło, inaczej 666.</returns>
        private int delete_video(string video_title,  string video_category)
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
            var mb_result =  MessageBox.Show("Czy napewno chcesz usunąć " + ModDeleteTitleTB.Text + " ?", "Powiadomienie" + ModDeleteTitleTB.Text, MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {
                delete_video(title, category);
                MessageBox.Show("Usunięto video!");
                Hide();
            }
            else
                MessageBox.Show("NIe usunięto! Sprawdz dane!");

        }
    }
}
