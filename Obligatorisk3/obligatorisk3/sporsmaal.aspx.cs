using MySql.Data.MySqlClient;
using System;
using System.Web.UI;
using System.Drawing;
using System.Collections;

namespace obligatorisk3
{
    public partial class sporsmaal : Page
    {
        int brukerId;
        int forsokstallet;
        static int spmNr;

        static ArrayList numbers = new ArrayList();

        MySqlConnection con = new MySqlConnection("Database=trafikkskole; Host = 127.0.0.1; Port = 33060; User=homestead; Password=secret;");

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                brukerId = (int)Session["id"];
                forsokstallet = (int)Session["forsok"];
            }
            catch
            {

            }

            // Hvis siden lastes uten at den responderer på en hendelse (f.eks ved button_click)
            if (!IsPostBack)
            {
                lblAnswerd.Text = "" + GetCounter();

                HitRandomNummer();

                if (numbers.Contains(spmNr))
                {
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    question();
                    svarAlt();
                }

            }
            // debug
                //Response.Write("SpmNr: " + spmNr);
                //Response.Write("GetNumber: " + GetRandomNummer());
                //Response.Write("Bruker id: " + brukerId);
                //Response.Write("forsokstall: " + forsokstallet);
            // end debug

            //Hvis spørsmålsnummeret er mindre enn 20
            if (GetCounter() < 20)
            {
                nesteBtn.Text = "Neste Spørsmål >>";
            }
            // Hvis spørsmålsnummeret er større en 20
            else
            {
                nesteBtn.Text = "Resultater >>";
            }

            // DEBUGGING for å sjekke at id'en til spørsmålene som er besvart blir lagt i arraylisten numbers
            //Response.Write("Antall nummere i arrayliste = " + numbers.Count); 

            // DEBUGGING for å sjekke at metoden GetRandomNumber() henter tilfeldig tall
            //Label3.Visible = true;
            //Label3.Text = GetRandomNummer().ToString();

            // DEBUGGING for å sjekke innholdet i arraylista numbers
            /*foreach (int i in numbers)
            {
                Response.Write(i + ", ");
            }*/

            // Hvis et spørsmål ikke har en illustrasjon
            if (Image1.ImageUrl == "")

                Image1.Visible = false;
        }

        private void question()
        {
            string question = "SELECT * FROM sporsmaal WHERE id = " + spmNr + ";";
            MySqlCommand cmd = new MySqlCommand(question, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //Label1.Text = reader.GetString("id");
                lblsporsmaal.Text = reader.GetString("sporsmaal");
            }

            // Hvis kolonnen url inneholder en url til et bilde
            if (reader["bilde"] != null)
            {
                Image1.Visible = true;
                Image1.ImageUrl = reader["bilde"].ToString();
            }

            reader.Close();
            con.Close();

            //nesteBtn.Enabled = false; // TODO: debugger
        }

        private void svarAlt()
        {
            string sql2 = "SELECT * FROM svaralternativer WHERE id=" + spmNr + ";";
            MySqlCommand cmd2 = new MySqlCommand(sql2, con);
            con.Open();
            MySqlDataReader leser = cmd2.ExecuteReader();

            while (leser.Read())
            {
                radio1.Text = leser.GetString("svar1");
                radio2.Text = leser.GetString("svar2");
                radio3.Text = leser.GetString("svar3");
                radio4.Text = leser.GetString("svar4");
            }

            leser.Close();
            con.Close();

            nesteBtn.Enabled = true;
        }


        protected void nesteBtn_Click(object sender, EventArgs e)
        {
            // Hvis man har svart på mindre enn 20 spm
            if (GetCounter() < 20)
            {
                HitCounter();
                Response.Redirect(Request.RawUrl);
            }
            // Hvis man har svart på 20 spørsmål
            else
            {
                //  TODO: bytte om dersom feiler
                //Response.Redirect("ferdig.aspx"); 
                Response.Redirect("http://localhost:62871/ferdig");
            }
        }

        protected void btnLoggut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx");
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                infoLbl.Text = radio1.Text;
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                infoLbl.Text = radio2.Text;
            }
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton3.Checked)
            {
                infoLbl.Text = radio3.Text;
            }
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton4.Checked)
            {
                infoLbl.Text = radio4.Text;
            }
        }

        private static long count = 1;

        public static void HitCounter()
        {
            count++;
        }
        public static long GetCounter()
        {
            return count;
        }

        public static long randomNummer;

        public static void HitRandomNummer()
        {
            Random rnd = new Random();
            spmNr = rnd.Next(1, 21);
        }

        public static long GetRandomNummer()
        {
            return spmNr;
        }

        protected void btnSvar_Click(object sender, EventArgs e)
        {
            // Hvis ingen svaralternativer er valgt
            if (!RadioButton1.Checked && !RadioButton2.Checked && !RadioButton3.Checked && !RadioButton4.Checked)
            {
                infoLbl.Visible = true;
                infoLbl.ForeColor = Color.Red;
                infoLbl.Text = "Du har ikke valgt noe alternativ!";
            }
            // Hvis et av alternativene er valgt
            else
            {
                if (!numbers.Contains(spmNr))
                {
                    numbers.Add(spmNr);
                    string sql = "UPDATE brukersvar SET svar" + spmNr + " = '" + infoLbl.Text + "' WHERE brukerId = " + brukerId + " AND forsok = " + forsokstallet + ";";

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                nesteBtn.Enabled = true;
                btnSvar.Enabled = false;
            }
        }
    }
}


