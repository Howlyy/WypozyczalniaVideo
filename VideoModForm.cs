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

        private void ModAddBTN_Click(object sender, EventArgs e)
        {
            

            new ModAddVideoForm().Show();
        
        }

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
      
