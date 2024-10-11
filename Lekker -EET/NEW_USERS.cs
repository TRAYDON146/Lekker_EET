using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lekker__EET
{
    public partial class NEW_USERS : Form
    {
        public NEW_USERS()
        {
            InitializeComponent();
        }
         OleDbConnection conn;
        OleDbCommand cmd;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 FM = new Form1();
           FM.Show();
            this.Hide();
        }

        private void NEW_USERS_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\L5G2\Documents\Database2.accdb");
            cmd = new OleDbCommand();
            cmd.Connection = conn;

        }
    }
}
