using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorisk1
{
    public partial class ShipShooter : Form
    {
        public int points;
 
        public ShipShooter()
        {
            InitializeComponent();

            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // skjermstørrelse
            Size s = new System.Drawing.Size(900, 600);
            this.ClientSize = s;
            //Slå av muligheten for å endre størrelsen
            FormBorderStyle = FormBorderStyle.FixedSingle;
            pbTorpedo.Visible = false;
            points = 0;
            ScoreCount.Text = points.ToString();
            
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        // ----------------Bevegelse og skyte mekanisme-----------------
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // ------------------- Keybevegelser --------------------
            if (e.KeyCode == Keys.Left)
            {
                pbSubmarine.Left -= 20;

                if (torpedotimer.Enabled == false)
                {
                    pbTorpedo.Left = pbSubmarine.Left + 40;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                pbSubmarine.Left += 20;

                if (torpedotimer.Enabled == false)
                {
                    pbTorpedo.Left = pbSubmarine.Left + 40;
                }
            }
            // ---------------------- Keybevegelser END --------

            // -----------------------Skytemekanisme -------------------
            if (e.KeyCode == Keys.Space)
            {
                pbTorpedo.Visible = true;
                torpedotimer.Start();
            }
            // --------------------- Skytemekanisme end --------------------
            if (e.KeyCode == Keys.S)
            {
                NewGame();
            }
        }
        // --------------- Bevegelse END ----------------

        // ------------- New Game start------------------
        public void NewGame()
        {
            Ship.Enabled = true;
        }
        // -------------- New Game END

        // ------------------------- Båt Timer start ----------------------
        private void ShipTimer_Tick(object sender, EventArgs e)
        {
            pbSailboat.Location = new Point(pbSailboat.Location.X + 20, pbSailboat.Location.Y);
            // ---------------------- Sjekker om båt er utenfor spillbrettetutenfor spillbrett ---------- 
            if (pbSailboat.Left >= ShipShooter.ActiveForm.Width)
            {
                moveSailboatToStart();
            }
            pbRowboat.Location = new Point(pbRowboat.Location.X + 30, pbRowboat.Location.Y);
            if (pbRowboat.Left >= ShipShooter.ActiveForm.Width)
            {
                moveRowboatToStart();
            }
            pbShip.Location = new Point(pbShip.Location.X + 10, pbShip.Location.Y);
            if (pbShip.Left >= ShipShooter.ActiveForm.Width)
            {
                moveShipToStart();
            }
            this.Refresh();
        }
        // ------------------------- Båt Timer END----------------

        //------------------------Torpedo timer---------------------
        private void torpedotimer_Tick(object sender, EventArgs e)
        {
            pbTorpedo.Location = new Point(pbTorpedo.Location.X, pbTorpedo.Location.Y - 20);
            if (pbTorpedo.Bottom <= 0)
            {
                points--;
                TorpedoRespawn();
            }
            if (pbTorpedo.Top > 599)
            {
                TorpedoRespawn();
            }
            // sjekker om den traff båt 1
            if (pbTorpedo.Bounds.IntersectsWith(pbRowboat.Bounds))
            {
                TorpedoRespawn();
                points += 5; // legger til 5 points til score
            }
            // sjekker om den traff båt 2
            if (pbTorpedo.Bounds.IntersectsWith(pbSailboat.Bounds))
            {
                TorpedoRespawn();
                points += 3; // 3 points til score
            }
            // sjekker om den traf båt 3
            if (pbTorpedo.Bounds.IntersectsWith(pbShip.Bounds))
            {
                TorpedoRespawn();
                points++; // legger til 1 point til score
            }
         
        }
        // --------------------- TorpedoTimer END-------------

        // --------------------- Torpedo Respawn -------------
        public void TorpedoRespawn()
        {
            torpedotimer.Stop();
            pbTorpedo.Visible = true;
            pbTorpedo.Top = pbSubmarine.Top;
            pbTorpedo.Left = pbSubmarine.Left;
            ScoreCount.Text = "" + points;
        }
        // ---------------------- Torpedo Respawn END---------

        // ---------------------- Avfyr Torpedo------------
        public void MoveTorpedoUp()
        {
            pbTorpedo.Location = new Point(pbTorpedo.Location.X, pbTorpedo.Location.Y - 10);
        }
        // ----------------------- Avfyr Torpedo END ---------------

        // ------------------- Move to start---------------
        private void moveShipToStart()
        {
            pbShip.Location = new Point(pbShip.Location.X - 900, pbShip.Location.Y);
        }

        private void moveSailboatToStart()
        {
            pbSailboat.Location = new Point(pbSailboat.Location.X - 900, pbSailboat.Location.Y);
        }

        private void moveRowboatToStart()
        {
            pbRowboat.Location = new Point(pbRowboat.Location.X - 900, pbRowboat.Location.Y);
        }
        // ------------------ Move to start end------------------

        #region Menu
        // ----------------------Menu------------------
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ship.Enabled = true;
        }
        // ------------- Avslutter Spillet uten save -------------

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // --------------- Avslutter spillet END ----------

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart(); // TODO: denne funker ikke 100%, starter ikke på nytt
        }
        #region Scoreboard
        // --------------------- Scoreboard display
        private void scoreboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form scoreboard = new scoreboard();
            scoreboard.Owner = this;
            scoreboard.Show();
            Ship.Stop();
        }
        #endregion
        // --------------------- Scoreboard END

        // -------------------- Avslutt game ----------------------
        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lagreScore = new LagreScore(points);
            lagreScore.Owner = this;
            lagreScore.Show();
            Ship.Stop();
        }
        // ------------------------- Avslutt game END -------------

        // ----------------------Menu END------------------
        #endregion
    }
}
