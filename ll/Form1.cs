using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            IsMdiContainer = true;
            InitializeComponent();
        }

        private void delegateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmDelegate = new Form2(); // Step 1.A.3.a
            frmDelegate.Dock = DockStyle.Fill; // Step 1.A.3.c
            frmDelegate.Show(); // Step 1.A.3.d
        }


        // Step 1.A.4
        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
