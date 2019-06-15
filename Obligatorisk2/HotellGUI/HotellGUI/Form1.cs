using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using MySql.Data.Types;

namespace HotellGUI
{
    // TODO: Må rydde opp i dataset, ds,dsGjest,dsAll
    public partial class Gui : Form
    {
        private MySqlCommandBuilder cb;
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        private MySqlConnection con;
        private DataSet ds;
        private DataSet dsGjest;
        private DataSet dsAll; // alle gjestene
        //private DataSet dsrom;
        //private string dbinfo;
        //private string sql;
        private List<string> fetchList = new List<string>();
        public BindingList<string> ResultatList;
        private DateTime myDateTime;

        public Gui()
        {
            InitializeComponent();
            //Size = new Size(1100,800);
        }


        // ------------ Form load ------------------
        private void GUI_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.FixedSingle; //Slå av muligheten for å endre størrelsen
            //this.Size = new System.Drawing.Size(965, 750); //Endrer skjermstørrelsen
            GetData();
            AddRooms(tabPage1, 1, dsAll);
            AddRooms(tabPage2, 2, dsAll);
        }

        #region Listeboks

        public void GetData()
        {
            string CS = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                //var stmt = "Select r.id, r.rom_nr, r.navn, e.id , e.etg_navn from rom r left join etg e on r.etg_id = e.id";
                var stmt = " SELECT * FROM rom, booking, gjest";
                cmd = new MySqlCommand(stmt, con);
                da = new MySqlDataAdapter(cmd);
                cb = new MySqlCommandBuilder(da);
                dsAll = new DataSet("bookinger");
                da.Fill(dsAll, "all");

                // Listeboks
                var sql = "SELECT * from gjest WHERE NOT EXISTS(SELECT gjest_id FROM booking WHERE gjest_id = gjest.id)";
                cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                cb = new MySqlCommandBuilder(da);
                ds = new DataSet("bookinger");
                da.Fill(ds, "booking");

                fetchList = (from r in ds.Tables["booking"].AsEnumerable()
                             select
                         r.Field<int>("id") + " " + r.Field<string>("kundenavn") + ": " +
                         r.Field<DateTime>("innsjekk").Year + "-" + r.Field<DateTime>("innsjekk").Month + "-" + r.Field<DateTime>("innsjekk").Day + " > " +
                         r.Field<DateTime>("utsjekk").Year + "-" + r.Field<DateTime>("utsjekk").Month + "-" + r.Field<DateTime>("utsjekk").Day).ToList();
                ResultatList = new BindingList<string>(fetchList);
                listBox1.DataSource = ResultatList;
            }
        }
        #endregion

        #region SetupTabs

        private void AddRooms(TabPage tab, int etg, DataSet ds)
        {
            int i, j;
            var count = 1;

            for (i = 1; i <= 3; i++)
                for (j = 1; j <= 4; j++)
                {
                    var p = new Panel();
                    var l = new Label();
                    p.Location = new Point(i * 125, j * 75);
                    p.BorderStyle = BorderStyle.FixedSingle;
                    p.Width = 120;
                    p.Height = 70;
                    l.Location = new Point(10, 10);
                    l.Width = 120;
                    l.Height = 70;
                    if (count < 10)
                    {
                        p.Name = $"{etg}0{count}";
                        l.Text = $@"{etg}0{count}";
                    }
                    else if (count >= 10 && count < 20)
                    {
                        p.Name = $"{etg}{count}";
                        l.Text = $@"{etg}{count}";
                    }

                    p.BackColor = Color.GreenYellow;
                    p.AllowDrop = true;

                    p.DragDrop += Gui_DragDrop;
                    p.DragOver += Gui_DragOver;
                    tab.Controls.Add(p);
                    p.Controls.Add(l);


                    foreach (DataRow rad in ds.Tables["all"].Rows)
                        try
                        {
                            if ((DateTime)rad["utsjekk"] >= myDateTime && (int)rad["rom_nr"] == int.Parse(p.Name))
                                if (!((DateTime)rad["innsjekk"] < myDateTime) && !((DateTime)rad["utsjekk"] > myDateTime))
                                {
                                    p.BackColor = Color.Red;
                                    p.AllowDrop = false;
                                    l.Text = p.Name + $" - " + "Id: " + rad["id"] + " " + rad["kundenavn"] + " " +
                                             rad["etternavn"] + " " + rad["utsjekk"].ToString().Substring(0, 10) + " > " +
                                             rad["innsjekk"].ToString().Substring(0, 10);
                                }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    count++;
                }

        }
        #endregion

        #region New Guest
        // TODO: legge til å kjøre refresh på listeboks når button blir kjørt!!!!! **VIKTIG** ** DONE **
        /// <summary>
        /// Seksjon for laging av ny gjest
        /// </summary>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // sjekker om txt felter er fylt ut
            if (txtKundenavn.Text == string.Empty || txtRefkey.Text == string.Empty)
            {
                MessageBox.Show("Fyll ut kundenavn og referanse nøkkel");
                return;
            }
            // sjekke om dato ikke er før dagens dato
            else if (calArrival.SelectionStart.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Dato må ikke være før datoen i dag");
                return;
            }
            // sjekker om dato utsjekking ikke er før innsjekking
            else if (calDep.SelectionStart.Date < calArrival.SelectionStart.Date)
            {
                MessageBox.Show("Kan ikke velge tidligere dato");
                return;
            }

            string CS = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                con.Open(); // åpner connection
                var gjestAll = "SELECT * FROM gjest";
                cmd = new MySqlCommand(gjestAll, con);
                da = new MySqlDataAdapter(cmd);
                cb = new MySqlCommandBuilder(da);
                dsGjest = new DataSet("gjester"); // alle gjestene
                da.Fill(dsGjest, "gjest"); // Fyller datasettet
                DataRow dr = dsGjest.Tables["gjest"].NewRow(); // legger til ny row
                dr["refkey"] = txtRefkey.Text; // binder txtbox til refkey tabel
                dr["kundenavn"] = txtKundenavn.Text; // binder txtbox til kundenavn tabel
                // legge til kalender innsjekking data
                dr["innsjekk"] = calArrival.SelectionStart.Year + "-" +
                                 calArrival.SelectionStart.Month + "-" +
                                 calArrival.SelectionStart.Day;
                // legge til kalender utsjekking data
                dr["utsjekk"] = calDep.SelectionStart.Year + "-" +
                                calDep.SelectionStart.Month + "-" +
                                calDep.SelectionStart.Day;
                dsGjest.Tables["gjest"].Rows.Add(dr);
                da.Update(dsGjest, "gjest");
                lblMessage.Visible = Enabled;
                lblMessage.Text = lblMessage.Text + "Gjesten er registrert";
                GetData();
            }
        }
        #endregion

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.All);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                try
                {
                    listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Move);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
        }


        // TODO: denne må fikses
        private void Gui_DragDrop(object sender, DragEventArgs e)
        {
            var c = (Control)sender;
            string CS = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                //Typekonverter for å få tak i egenskapene til Control
                //Control c = (Control)sender;

                //c.Controls[0].Text = ToString();
                //c.Controls[1].Text = ToString();
                //c.Controls[2].Text = ToString();
                // TODO: Endre tekst  "item vil inneholde navnet som dras fra nedtrekkslisten"
                if (c.BackColor == Color.Red)
                {
                    AllowDrop = false;
                }

                else
                {
                    var item = e.Data.GetData(typeof(string));
                    //var gjest_idLabel = c.Gjest;
                    var etgRomNrLabel = c.Name;

                    MessageBox.Show(item.ToString());

                    char[] separatingChars = { ':', '>', ' ' };
                    var text = item.ToString();
                    var values = text.Split(separatingChars, StringSplitOptions.RemoveEmptyEntries);
                    // TODO: fikse validering av tidspunkter

                    var stmt = "SELECT * FROM gjest WHERE (innsjekk BETWEEN CAST('" + values[2] + "' AS DATE) AND CAST('" +
                              values[3] + "' AS DATE) AND utsjekk BETWEEN CAST('" + values[2] + "' AS DATE) AND CAST('" + values[3] +
                              "' AS DATE) AND rom_id =" + c.Name + ")";


                    using (var cmd = new MySqlCommand(stmt, con))
                    {
                        con.Open();
                        var numRowsUpdated = cmd.ExecuteScalar();

                        if (numRowsUpdated == null)
                        {
                            // Skulle ha fylt ut arrayet
                            c.Controls[0].Text = $"{etgRomNrLabel}\n{item}";
                        //c.Controls[1].Text = $"{gjest_idLabel}\n{item}";
                        c.BackColor = Color.Red;
                        var query = "SELECT * FROM gjest WHERE id =" + values[0];
                        da = new MySqlDataAdapter(query, con);
                        cb = new MySqlCommandBuilder(da);
                        // TODO: Vil helle bruke en table til booking enn å legge rom i gjest
                        //ds.Tables["booking"].Rows[0]["gjest_id"] = c.Controls[0];
                        ds.Tables["booking"].Rows[0]["rom_id"] = c.Name;
                        da.Update(ds, "booking");
                        ResultatList.Remove((string)item); // sletter fra listeboksen
                    }
                        else
                        {
                        // TODO: Error msg
                        this.Refresh();
                        }
                        con.Close();
                    }
                }
            }
        }

        private void Gui_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
