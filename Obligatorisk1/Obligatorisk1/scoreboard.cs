using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Obligatorisk1
{
    public partial class scoreboard : Form
    {
        public scoreboard()
        {
            InitializeComponent();
        }
        // https://msdn.microsoft.com/en-us/library/system.windows.forms.openfiledialog(v=vs.110).aspx

        private void scoreboard_Load(object sender, EventArgs e)
        {
            rtbScore.Text = File.ReadAllText("Scoreboard.txt");
            //Array.Sort(rtbScore.Text.Equals == Points);
        }
    }
}
