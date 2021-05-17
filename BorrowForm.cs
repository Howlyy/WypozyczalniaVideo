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
        SqlConnection db_con;

        public BorrowForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            string book_title = TitleBorrowTB.Text;
            string client_firstname = FirstnameBorrowTB.Text;
            string client_lastname = LastnameBorrowTB.Text;


            int book_borrow_result = book_borrow(book_title, client_firstname, client_lastname);

            if(book_borrow_result == 1)
            {
                MessageBox.Show("Wypozyczono!");
            }
            else
            {
                MessageBox.Show("Nie wypożyczono! Sprawdz dane!");
            }
            

        }

        private int book_borrow(string video_title, string client_firstname, string client_lastname)
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
