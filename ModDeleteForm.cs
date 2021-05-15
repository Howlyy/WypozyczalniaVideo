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

        private void ModDeleteVideoBTN_Click(object sender, EventArgs e)
        {
            string title = ModDeleteTitleTB.Text;
            string category = ModDeleteCategoryCB.Text;

            delete_messagebox(title, category);

        }

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

        private void delete_messagebox(string title, string category)
        {
            var mb_result =  MessageBox.Show("Czy napewno chcesz usunąć " + ModDeleteTitleTB.Text + " ?", "Powiadomienie" + ModDeleteTitleTB.Text, MessageBoxButtons.YesNo);

            if (mb_result == DialogResult.Yes)
            {
                delete_video(title, category);
            }
            else
                MessageBox.Show("lipa");

        }
    }
}
