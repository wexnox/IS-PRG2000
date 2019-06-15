using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HotellGUI
{
    public partial class ShowGuests : Form
    {
        MySqlDataAdapter da1;
        DataSet ds;
        public ShowGuests()
        {
            InitializeComponent();
        }

        private void ShowGuests_Load(object sender, EventArgs e)
        {
//--------------------------------------- gridview innhold start-------------------------------------
            String cs = "Data Source = localhost; Database=hotell; User=root; Password=7oIPM8ad";
            MySqlConnection dbconn = new MySqlConnection(cs);
            dbconn.Open();

            String sql = "select * from gjest";
            MySqlCommand cmd = new MySqlCommand(sql, dbconn);
            da1 = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da1);
            ds = new DataSet("TEST");
            da1.Fill(ds, "gjest");

            //--------------------------------------- gridview innhold avsluttet-------------------------------------
            //--------------------------------------- skjermstørrelse-------------------------------------
            Size = new Size(900, 750);
//--------------------------------------- Slå av muligheten for å endre størrelsen-------------------------------------
            FormBorderStyle = FormBorderStyle.FixedSingle; 
        }
       #region Meny
        // ----------------------------- tilabake til forsiden ----------------------------
        private void BtnHome_Click(object sender, EventArgs e)
        {
            Form Form1 = new Gui();
            Form1.Owner = this;
            Form1.Show();
            Hide();
        }

        // ----------------------------- ny side = show all rooms ----------------------------
        private void btnShowRoom_Click(object sender, EventArgs e)
        {
            Form ShowAllRooms = new ShowAllRooms();
            ShowAllRooms.Owner = this;
            ShowAllRooms.Show();
            this.Hide();
        }

        // ----------------------------- ny side = show all guests ----------------------------
        private void btnShowGuest_Click(object sender, EventArgs e)
        {
            Form ShowGuests = new ShowGuests();
            ShowGuests.Owner = this;
            ShowGuests.Show();
            this.Hide();
        }

        // ----------------------------- ny side = new guest ----------------------------
        private void BtnNewGuest_Click(object sender, EventArgs e)
        {
            Form NewGuest = new NewGuest();
            NewGuest.Owner = this;
            NewGuest.Show();
            Hide();
        }

        // ----------------------------- ny side = asign guests ----------------------------
        private void BtnAsignGuests_Click(object sender, EventArgs e)
        {
            Form AsignGuests = new AssignGuests();
            AsignGuests.Owner = this;
            AsignGuests.Show();
            Hide();
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            Console.WriteLine(e.RowIndex);
            DataGridView dgv = (DataGridView)sender;
            Console.WriteLine(dgv.CurrentCell.Value);
        }

        private void btnHent_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "gjest";
        }

        private void btnoppdater_Click(object sender, EventArgs e)
        {
            da1.Update(ds, "gjest");
        }

    }
}