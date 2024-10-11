using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lekker__EET
{
    public partial class Mainform_foruser : Form
    {
        public Mainform_foruser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MAINFORM mf = new MAINFORM();
            mf.Show();
            this.Hide();
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Meals Ms = new Meals();
            Ms.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Starters St = new Starters();
            St.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Decirte Dt = new Decirte();
            Dt.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
