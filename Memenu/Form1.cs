using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa fue creado por Diegsoftman", "Acerca de... Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void borrarColor()
        {
            
            azulToolStripMenuItem.Checked = false;
            rojoToolStripMenuItem1.Checked = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AzulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            label1.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }

        private void RojoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            borrarColor();
            label1.ForeColor = Color.Red;
            rojoToolStripMenuItem1.Checked = true;
        }

        private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicSansToolStripMenuItem1.Checked = false;
            label1.Font = new Font("Times New Roman", 14, label1.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = true;
        }

        private void ComicSansToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            label1.Font = new Font("Comic Sans MS", 14, label1.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = false;
        }
    }
}
