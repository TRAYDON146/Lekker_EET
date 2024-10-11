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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbCommand cmd;

        private void button2_Click(object sender, EventArgs e)
        {
            Mainform_foruser Mf=new Mainform_foruser();
            Mf.Show();
            this.Hide();  

        }

    private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\L5G2\Documents\Database2.accdb");
            cmd = new OleDbCommand();
            cmd.Connection = conn;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NEW_USERS NU = new NEW_USERS();
            NU.Show();
            this.Hide();
        }
      
    }
}

