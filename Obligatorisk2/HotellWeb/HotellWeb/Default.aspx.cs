using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace HotellWeb
{
    public partial class _Default : Page
    {
        DataSet ds;
        MySqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Insert Data
        protected void submit_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                con.Open();
                String sql = "select * from gjest";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                ds = new DataSet("TEST");
                da.Fill(ds, "gjest");
                Response.Write(ds.Tables["gjest"].Rows.Count);

                // Skal legge inn i gjesteboken
                DataRow dr = ds.Tables["gjest"].NewRow();
                dr["kundenavn"] = txtKundenavn.Text;
                dr["innsjekk"] = txtStartdato.Text;
                dr["utsjekk"] = txtUtsjekking.Text;
                dr["refkey"] = txtrefkey.Text;
                ds.Tables["gjest"].Rows.Add(dr);
                da.Update(ds, "gjest");
                Response.Redirect(Request.RawUrl);
            }

        }
        #endregion 
    }
}