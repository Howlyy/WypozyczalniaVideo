using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace WypożyczalniaVideo
{
    public partial class ModAddVideoForm : Form
    {
        SqlConnection db_con;

        public ModAddVideoForm()
        {
            InitializeComponent();
            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }

        private void ModAddVideoBTN_Click(object sender, EventArgs e)
        {
            string book_title = ModAddTitleTB.Text;
            int quantity = Convert.ToInt32(ModAddQuantityTB.Text);
            string category = ModAddCategoryCB.Text;


            db_con.Open();


            SqlCommand cmd_return = new SqlCommand("add_video", db_con);
            cmd_return.CommandType = CommandType.StoredProcedure;

            cmd_return.Parameters.AddWithValue("@title", SqlDbType.NVarChar).Value = book_title;
            cmd_return.Parameters.AddWithValue("@quantity", SqlDbType.NVarChar).Value = quantity;
            cmd_return.Parameters.AddWithValue("@category", SqlDbType.NVarChar).Value = category;
            cmd_return.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd_return.ExecuteNonQuery();

            int result = (int)cmd_return.Parameters["@result"].Value;

            db_con.Close();


            if (result == 666)
            {
                MessageBox.Show("Takie video już istnieje!");
            }
            else
            {
                MessageBox.Show("Dodano!");
            }

            Hide();
        }
    }
}
