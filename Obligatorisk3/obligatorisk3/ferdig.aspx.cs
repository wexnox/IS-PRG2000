using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Web.UI.WebControls;

namespace obligatorisk3
{
    public partial class ferdig : System.Web.UI.Page
    {
        int forsokstall;
        int antallRiktige;
        int brukerId;
        string spm;
        string fasit;

        ArrayList brukerSvar = new ArrayList();
        ArrayList fasitSvarArrayList = new ArrayList();
        ArrayList arrayListSpmId = new ArrayList();
        ArrayList arrayListFeiLSvar = new ArrayList();

        MySqlConnection con = new MySqlConnection("Database=trafikkskole; Host = 127.0.0.1; Port = 33060; User=homestead; Password=secret;");


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                forsokstall = (int)Session["forsok"];
                brukerId = (int)Session["id"];
            }
            catch
            {

            }

            Image1.Visible = true;

            GetBrukerSvar();
            GetFasitSvar();

            Response.Write(brukerSvar.Count.ToString()); //DEBUGGING for å sjekke om alle svarene blir lagt inn i arraylista

            for (int r = 0; r < brukerSvar.Count; r++)
            {
                if (fasitSvarArrayList[r].ToString() == brukerSvar[r].ToString())
                {
                    antallRiktige++;
                }
                else
                {
                    arrayListSpmId.Add((r + 1));
                }
            }

            SetAntallRiktig();

            if (antallRiktige > 17)
            {
                Image1.ImageUrl = "http://diamondhelpers.com/wp-content/uploads/2014/03/23820468_s.jpg";
                Label2.Text = "Gratulerer! Du bestod teoritesten og hadde " + antallRiktige + " av 20  spørsmål riktig!" + "<br>" + "Du er nå klar for å gjennomføre teoriprøven hos Statens Vegvesen!";
            }
            else
            {
                Image1.ImageUrl = "http://www.jamaicanmateyangroupie.com/wp-content/uploads/2015/04/failed.png";
                Label2.Text = "Beklager, men du må nok øve mer! Du hadde " + antallRiktige + " av 20 spørsmål riktig!";
            }

            GetAntallFeil();
        }

        private void GetBrukerSvar()
        {
            string sql = "SELECT * FROM brukersvar WHERE brukerId = " + brukerId + " AND forsok = " + forsokstall + ";";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int r = 1; r < 21; r++)
                {
                    brukerSvar.Add(reader.GetString("svar" + r));
                }
            }

            reader.Close();
            con.Close();
        }

        private void GetFasitSvar()
        {
            string sql = "SELECT svar FROM fasit ORDER BY id";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader leser = cmd.ExecuteReader();

            while (leser.Read())
            {
                fasitSvarArrayList.Add(leser.GetString("svar"));
            }

            leser.Close();
            con.Close();
        }

        private void SetAntallRiktig()
        {
            int antallFeil = 20 - antallRiktige;
            string sql = "INSERT INTO resultater (forsok, brukerId, antallRiktige, antallFeil) VALUES (" + forsokstall + ", " + brukerId + ", " + antallRiktige + ", " + antallFeil + ");";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void GetAntallFeil()
        {
            foreach (int o in arrayListSpmId)
            {
                string sqlFasit = "SELECT sporsmaal.id, sporsmaal.sporsmaal, fasit.svar FROM sporsmaal JOIN fasit ON sporsmaal.id = fasit.id WHERE sporsmaal.id =" + o + ";";
                MySqlCommand cmdFasit = new MySqlCommand(sqlFasit, con);
                con.Open();
                MySqlDataReader reader = cmdFasit.ExecuteReader();

                while (reader.Read())
                {
                    spm = (string)reader["sporsmaal"];
                    fasit = (string)reader["svar"];
                    arrayListFeiLSvar.Add(new ListItem(spm, fasit));
                }

                con.Close();
                reader.Close();
            }

            GridView1.DataSource = arrayListFeiLSvar;
            GridView1.DataBind();
        }
        protected void startBtn_Click(object sender, EventArgs e) => Response.Redirect("~/sporsmaal.aspx");

        protected void btnLoggut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx");
        }
    }
}
