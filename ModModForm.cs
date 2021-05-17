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

        private void ModModVideoBTN_Click(object sender, EventArgs e)
        {
            string title = ModModTitleTB.Text;
            int quantity = (int)ModModQuantityNUD.Value;
            string category = ModModCategoryCB.Text;

            modyfi_messagebox(title, quantity, category); 
            
           
            
               
            
        }

       private int video_modyfi(string title, int quantity, string category)
        {
            db_con.Open();


            SqlCommand cmd_return = new SqlCommand("modify_video", db_con);
            cmd_return.CommandType = CommandType.StoredProcedure;

            cmd_return.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = title;
            cmd_return.Parameters.AddWithValue("@quantity", SqlDbType.Int).Value = quantity;
            cmd_return.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = category;
            cmd_return.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_return.ExecuteNonQuery();

            int modyfi_result = (int)cmd_return.Parameters["@result"].Value;

            db_con.Close();

            return modyfi_result;
        }

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

        }
    }
}
