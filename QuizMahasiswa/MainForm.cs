using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMahasiswa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void masterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterBarang032 a = new MasterBarang032();
            a.Show();
        }

        private void reportBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportBarang010 a = new ReportBarang010();
            a.Show();
        }
    }
}
