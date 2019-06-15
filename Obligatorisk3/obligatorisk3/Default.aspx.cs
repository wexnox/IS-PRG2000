using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Web.UI;

namespace obligatorisk3
{
    public partial class _Default : Page
    {
        string brukernavn;

        ArrayList brukere = new ArrayList();
        ArrayList arrayListBrukerId = new ArrayList();
        ArrayList arrayListForsok = new ArrayList();
        ArrayList arrayListNavn = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {

            string sql = "SELECT id, brukernavn, navn, antallForsok FROM bruker;";
            MySqlConnection con = new MySqlConnection("Database=trafikkskole; Host = 127.0.0.1; Port = 33060; User=homestead; Password=secret;");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                brukernavn = (string)reader["brukernavn"];
                int userId = (int)reader["id"];
                int forsok = (int)reader["antallForsok"];
                string navn = (string)reader["navn"];

                brukere.Add(brukernavn);
                arrayListBrukerId.Add(userId);
                arrayListForsok.Add(forsok);
                arrayListNavn.Add(navn); ;
            }

            reader.Close();
            con.Close();
            lblFeilmelding.Visible = false;

        }
        //Login med eksisterende bruker
        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "")
            {
                lblFeilmelding.Visible = true;
                lblFeilmelding.Text = "Du har ikke fylt inn brukernavnet ditt!";
                lblFeilmelding.ForeColor = Color.Red;
            }
            else if (brukere.Contains(txtUsername.Text))
            {
                
                int posisjonstall = brukere.IndexOf(txtUsername.Text);
                int idtall = (int)arrayListBrukerId[posisjonstall];
                int talletForsok = (int)arrayListForsok[posisjonstall];

                try
                {
                    Session["id"] = idtall;
                    Session["forsok"] = talletForsok + 1;
                }
                catch
                {

                }
                // hvis brukeren ikke har gjennomført testen før
                if (talletForsok == 0)
                {
                    string sql2 = "UPDATE bruker SET antallForsok = 1 WHERE id = " + idtall + ";";
                    MySqlConnection con2 = new MySqlConnection("Database=trafikkskole; Host = 127.0.0.1; Port = 33060; User=homestead; Password=secret;");
                    MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                    con2.Close();

                    string sql = "INSERT INTO brukersvar (forsok, brukerId) VALUES (1, " + idtall + ");";
                    MySqlConnection con = new MySqlConnection("Database=trafikkskole; Host = 127.0.0.1; Port = 33060; User=homestead; Password=secret;");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                // Hvis brukeren har gjennomført testen før
                else
                {
                    string sql2 = "UPDATE bruker SET antallForsok = " + (talletForsok + 1) + " WHERE id = " + idtall + ";";
                    MySqlConnection con2 = new MySqlConnection("Database=trafikkskole; Host = 127.0.0.1; Port = 33060; User=homestead; Password=secret;");
                    MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                    con2.Close();

                    string sql = "INSERT INTO brukersvar (forsok, brukerId) VALUES (" + (talletForsok + 1) + ", " + idtall + ");";
                    MySqlConnection con = new MySqlConnection("Database=trafikkskole; Host = 127.0.0.1; Port = 33060; User=homestead; Password=secret;");
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                Response.Redirect("sporsmaal.aspx");
            }
            // Hvis brukernavnet som er skrevet inn ikke finnes!
            else
            {
                lblFeilmelding.Visible = true;
                lblFeilmelding.Text = "Brukernavnet eksisterer ikke.";
                lblFeilmelding.ForeColor = Color.Red;
            }
        }
    }
    
}

