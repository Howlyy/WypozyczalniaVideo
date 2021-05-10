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


            if (SearchTypeCB.Text == "Kategoria")
            {

                SqlCommand cmd_bor_search = new SqlCommand("borrow_search_category_view", db_con);
                cmd_bor_search.CommandType = CommandType.StoredProcedure;

                cmd_bor_search.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = SearchborrowTB.Text;

                SqlDataAdapter dtg = new SqlDataAdapter(cmd_bor_search);

                dtg.Fill(dt);

                SearchBorrowDG.DataSource = dt;
            }
            else 
            {
                
                SqlCommand cmd_bor_search = new SqlCommand("borrow_search_title_view", db_con);
                cmd_bor_search.CommandType = CommandType.StoredProcedure;

                cmd_bor_search.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = SearchborrowTB.Text;



                SqlDataAdapter dtg = new SqlDataAdapter(cmd_bor_search);

                dtg.Fill(dt);

                SearchBorrowDG.DataSource = dt;



            }
          



            db_con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string book_title = TitleBorrowTB.Text;
            string client_firstname = FirstnameBorrowTB.Text;
            string client_lastname = LastnameBorrowTB.Text;


            db_con.Open();


            SqlCommand cmd_borrow = new SqlCommand("book_borrow", db_con);
            cmd_borrow.CommandType = CommandType.StoredProcedure;

            cmd_borrow.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = TitleBorrowTB.Text;
            cmd_borrow.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = FirstnameBorrowTB.Text;
            cmd_borrow.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = LastnameBorrowTB.Text;
            cmd_borrow.Parameters.AddWithValue("@id_login", SqlDbType.NVarChar).Value = WypozyczalniaVideo.LoggedUserId;
            cmd_borrow.Parameters.AddWithValue("@result", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

            cmd_borrow.ExecuteNonQuery();

            string result = cmd_borrow.Parameters["@result"].Value.ToString();

            db_con.Close();
            //
            //Problem z FK na Loginach po zmianie kluczy w bazie (dropnietą i stworzona na nowo Borrows z nowymi kolumnami - Sprawdzić)
            //
            //

            if(result == "Borrowed")
            {
                MessageBox.Show("Wypozyczono!");
            }
            else
            {
                MessageBox.Show("Nie wypożyczono! Sprawdz dane!");
            }
            

        }
    }
}
