using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherToolkit
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void floor1RoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
        }

        private void floor2RoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Floor2 form = new Floor2();
            form.Show();
        }

        private void floor3RoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Floor3 form = new Floor3();
            form.Show();
        }
    }
}
