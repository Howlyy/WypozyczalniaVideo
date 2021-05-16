using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WypożyczalniaVideo
{
    public partial class ClientModForm : Form
    {
        SqlConnection db_con;
        public ClientModForm()
        {
            InitializeComponent();

            db_con = new SqlConnection(ConfigurationManager.ConnectionStrings["Video"].ConnectionString);
        }


    }
}
