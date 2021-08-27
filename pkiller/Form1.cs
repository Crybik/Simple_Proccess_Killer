using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkiller
{
    public partial class Pkiller : Form
    {

        public Pkiller()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This Program was made by This cute guy
            // www.github.com/Crybik
            // www.saleh.club
        }

        private void Killer_Click(object sender, EventArgs e)
        {
            String pname = tb.Text;
            foreach (Process proc in Process.GetProcessesByName(pname))
            {
                proc.Kill();
            }
        }
    }
}
