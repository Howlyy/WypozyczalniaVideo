using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    public partial class ModModForm : Form
    {
        SqlConnection db_con;
        public ModModForm()
        {
            

            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }
        /// <summary>
        /// Methoda użcia przycisku Modyfikuj. Po użyciu zostaje wywołana methoda modyfi_messagebox(string title, int quantity, string category)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModModVideoBTN_Click(object sender, EventArgs e)
        {
            string title = ModModTitleTB.Text;
            int quantity = (int)ModModQuantityNUD.Value;
            string category = ModModCategoryCB.Text;

            modyfi_messagebox(title, quantity, category); 
            
           
            
               
            
        }

        /// <summary>
        /// Methoda wywołująca procedurę SQL modyfi_video która przyjmuje parametry @title, @quantity, @category, @result. 
        /// </summary>
        /// <param name="title">Tytuł video</param>
        /// <param name="quantity">Ilość video</param>
        /// <param name="category">Kategoria video</param>
        /// <returns> int modyfi_result jest to zmienna do której zapisywany jest @result(zmienna OUTPUT z procedury SQL) </returns>
       private int video_modyfi(string title, int quantity, string category)
        {
            db_con.Open();


            SqlCommand cmd_modyfi = new SqlCommand("modify_video", db_con);
            cmd_modyfi.CommandType = CommandType.StoredProcedure;

            cmd_modyfi.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = title;
            cmd_modyfi.Parameters.AddWithValue("@quantity", SqlDbType.Int).Value = quantity;
            cmd_modyfi.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = category;
            cmd_modyfi.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_modyfi.ExecuteNonQuery();

            int modyfi_result = (int)cmd_modyfi.Parameters["@result"].Value;

            db_con.Close();

            return modyfi_result;
        }

        /// <summary>
        /// Methoda wywołująca Messageboxa YESNO. Jeżeli kliknieto YES zostaje użyta methoda video_modify(title, quantity, category), inaczej pokazuje komunikat o błędzie.
        /// </summary>
        /// <param name="title">Tytul video</param>
        /// <param name="quantity">Ilość video</param>
        /// <param name="category">Kategoria video</param>
        private void modyfi_messagebox(string title, int quantity, string category)
        {
            var mb_result = MessageBox.Show("Czy napewno chcesz modyfikować " + ModModTitleTB.Text +" ?", "Powiadomienie", MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {
                video_modyfi(title, quantity, category);
                MessageBox.Show("Zmodyfikowano " + ModModTitleTB.Text +" !");
                Hide();
            }
            else
                MessageBox.Show("lipa");
                Hide();

        }
    }
}
