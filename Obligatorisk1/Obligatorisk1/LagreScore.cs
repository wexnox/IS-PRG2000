using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Obligatorisk1
{

    public partial class LagreScore : Form
    {

        public LagreScore(int points)
        {
            InitializeComponent();
            lblScore.Text = points.ToString(); // henter score og printer den til lblscore
        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {
           this.Close(); // lukker vindu
        }
        // ----------------  lagre resultat --------------
        // https://msdn.microsoft.com/en-us/library/system.io.file.appendtext(v=vs.110).aspx
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nick.Text))
            {
                // TODO: feilmelding / validering
            }
            else
            {
                try
                {
                    // Denne henter data fra spiller
                    string TextInput = Nick.Text + "                            " + lblScore.Text.ToString();
                    // filbane til filen
                    string path = @"Scoreboard.txt";
                    // sjekker om filen eksisterer
                    if (!File.Exists(path))
                    {
                        // oppretter fil
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine(TextInput); // skriver til fil
                            this.Close(); // lukker vindu 
                        }
                    }
                    // dersom filen eksisterer skriver den spiller data til filen(append)
                    using (StreamWriter sw = File.AppendText(path)) // legger til "append"
                    {
                        sw.WriteLine(TextInput);
                        this.Close();
                    }
                }
                // feilmelding 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            // popper opp scoreboard når en saver score
            Form scoreboard = new scoreboard();
            scoreboard.Show();
        }
    }
}
