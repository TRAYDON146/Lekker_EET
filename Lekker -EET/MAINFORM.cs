﻿using System;
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
    public partial class MAINFORM : Form
    {
        public MAINFORM()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Drinks WHERE PK = " + textBox7 + "";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception X)
            {
                MessageBox.Show("Error look at your code" + X.Message);
            }
        }

        private void MAINFORM_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\L5G2\Documents\Database2.accdb");
            cmd = new OleDbCommand();
            cmd.Connection = conn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Drinks SET Title = '',Description = ',Ingredients' = ',Instructions'=','UserID=', WHERE PK = ''";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception X)
            {
                MessageBox.Show("ERROR LOOK AT YOUR CODE" + X.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Drinks";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select*from Drinks WHERE PK = " + textBox3.Text + "";


            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("THIS Drink DOES EXIST !try a diffrent NAME");
            }
            else
            {
                reader.Close();
                cmd.CommandText = "INSERT INTO Drinks(Title,Description,Ingredients,Instructions,UserID,PK)VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox7.Text + "','" + textBox6.Text.ToString() + "," + textBox3.Text.ToString() + ")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record added successfuly");

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mainform_foruser FF = new Mainform_foruser();
            FF.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType= CommandType.Text;
            cmd.CommandText= "Select* from Drinks WHERE PK = '" + textBox3.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt= new DataTable();
            OleDbDataAdapter da= new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

       
        
    }
}

 