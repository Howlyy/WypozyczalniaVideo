using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    public partial class ClientForm : Form
    {
        SqlConnection db_con;

        public static string client_firstname = "";
        public static string client_lastname = "";
        public static string client_pesel = "";
        public static string client_nrtel = "";


        public ClientForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }

        private void ClientAddBTN_Click(object sender, EventArgs e)
        {
            new ClientAddForm().Show();
        }

        private void ClientDeleteBTN_Click(object sender, EventArgs e)
        {
            client_data_datagrid();
            new ClientDeleteForm().Show();
        }

        private void ClientSearchBTN_Click(object sender, EventArgs e)
        {
            if (ClientSearchCB.Text == "" && ClientSearchTB.Text == "")
            {
                Search_view_all();
            }
            else
            {
                Search_view();
            }
        }

        private void ClientModBTN_Click(object sender, EventArgs e)
        {
            if (client_data_datagrid() == 0)
            {
                new ClientModForm().Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego modyfikować! Wyszukaj dane");
            }
        }

        private void Search_view_all()
        {
            DataTable dt = new DataTable();

            db_con.Open();


            SqlCommand cmd_client_search = new SqlCommand("all_client_view", db_con);

            cmd_client_search.CommandType = CommandType.StoredProcedure;
            
            SqlDataAdapter dtg = new SqlDataAdapter(cmd_client_search);

            dtg.Fill(dt);


            ClientSearchDG.DataSource = dt;


            db_con.Close();
        }



        private void Search_view()
        {
            DataTable dt = new DataTable();

            db_con.Open();


            SqlCommand cmd_client_mod_search = new SqlCommand("client_view", db_con);



            cmd_client_mod_search.CommandType = CommandType.StoredProcedure;

            cmd_client_mod_search.Parameters.AddWithValue("@combo", SqlDbType.NVarChar).Value = ClientSearchTB.Text;

            if (ClientSearchCB.Text == "Imię i nazwisko")
            {
                
                cmd_client_mod_search.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = ClientSearchTB.Text;
                cmd_client_mod_search.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = ClientSearchLastTB.Text;
                cmd_client_mod_search.Parameters.AddWithValue("@pesel", SqlDbType.NVarChar).Value = "";
                cmd_client_mod_search.Parameters.AddWithValue("@nrtel", SqlDbType.NVarChar).Value = "";
            }
            else if (ClientSearchCB.Text == "Pesel")
            {
                cmd_client_mod_search.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = "";
                cmd_client_mod_search.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = "";
                cmd_client_mod_search.Parameters.AddWithValue("@pesel", SqlDbType.NVarChar).Value = ClientSearchTB.Text;
                cmd_client_mod_search.Parameters.AddWithValue("@nrtel", SqlDbType.NVarChar).Value = "";
            }
            else 
            {
                cmd_client_mod_search.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = "";
                cmd_client_mod_search.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = "";
                cmd_client_mod_search.Parameters.AddWithValue("@pesel", SqlDbType.NVarChar).Value = "";
                cmd_client_mod_search.Parameters.AddWithValue("@nrtel", SqlDbType.NVarChar).Value = ClientSearchTB.Text;
            }
            


            SqlDataAdapter dtg = new SqlDataAdapter(cmd_client_mod_search);

            dtg.Fill(dt);


            ClientSearchDG.DataSource = dt;


            db_con.Close();
        }/* sprawdzić jeszcze bo coś nie działa */

        private void LastnameTb_visible()
        {
            if(ClientSearchCB.SelectedItem == "Imię i nazwisko")
            {
                ClientSearchLastTB.Visible = true;
            }
            else
            {
                ClientSearchLastTB.Visible = false;
            }
        }

        private void ClientSearchCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LastnameTb_visible();
        }
        private int client_data_datagrid()
        {
            int error;
            try
            {
                var selected_firstname = (string)ClientSearchDG.SelectedCells[0].Value;
                var selected_lastname = (string)ClientSearchDG.SelectedCells[1].Value;
                var selected_pesel = (string)ClientSearchDG.SelectedCells[2].Value;
                var selected_nrtel = (string)ClientSearchDG.SelectedCells[3].Value;

                client_firstname = selected_firstname;
                client_lastname = selected_lastname;
                client_pesel = selected_pesel;
                client_nrtel = selected_nrtel;

                error = 0;
            }
            catch (Exception e)
            {

                error = 1;
            }

            return error;
        }

       
    }

}
