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
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string config = ConfigurationManager.ConnectionStrings["Video"].ConnectionString; // chwilowo - napisać za pomocą mothody

            DataTable dt = new DataTable();

            SqlConnection db_con = new SqlConnection(config);

            SqlDataReader data_reader = null;

            db_con.Open();

            //SqlCommand cmd_bor = new SqlCommand("Select * from dbo.videocassettes", db_con);

            

            

            

            if (SearchTypeCB.Text == "Kategoria")
            {

                SqlCommand cmd_bor = new SqlCommand("borrow_search_category_view", db_con);
                cmd_bor.CommandType = CommandType.StoredProcedure;

                cmd_bor.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = SearchborrowTB.Text;

                SqlDataAdapter dtg = new SqlDataAdapter(cmd_bor);

                dtg.Fill(dt);

                SearchBorrowDG.DataSource = dt;
            }
            else 
            {
                
                SqlCommand cmd_bor = new SqlCommand("borrow_search_title_view", db_con);
                cmd_bor.CommandType = CommandType.StoredProcedure;

                cmd_bor.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = SearchborrowTB.Text;



                SqlDataAdapter dtg = new SqlDataAdapter(cmd_bor);

                dtg.Fill(dt);

                SearchBorrowDG.DataSource = dt;



            }
          



            db_con.Close();

        }

    }
}
