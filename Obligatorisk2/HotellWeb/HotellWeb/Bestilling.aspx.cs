using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotellWeb
{
    // direct mode (direkte oppkobling til db, uten bruk av dataset) vs offline mode (dataset)
    public partial class Bestilling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSlettBestilling_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                // direct mode
                string delete = "delete from gjest where kundenavn= @kundenavn AND refkey= @refkey ";
                MySqlCommand cmd = new MySqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@kundenavn", txtkundenavn.Text);
                cmd.Parameters.AddWithValue("@refkey", txtRefkey.Text);
                con.Open();
                cmd.ExecuteReader();
                lblMessage.Text = "Reservasjon har blitt slettet";
                // TODO: skal bruke dataset

            }
        }
    }
}
