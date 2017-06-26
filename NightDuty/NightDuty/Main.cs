using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NightDuty
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entry e1 = new Entry();
            e1.Show();
        }

        private void nightDutyFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DutyForm f = new DutyForm();
            f.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
    }
}