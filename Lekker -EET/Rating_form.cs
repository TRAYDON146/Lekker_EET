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
    public partial class Rating_form : Form
    {
        public Rating_form()
        {
            InitializeComponent();
        }
        private void Submit_Click()
        {
        
            int rating = (int)numericUpDown1.Value;
            numericUpDown1.Text = "You rated this product: " + rating.ToString();
            MessageBox.Show("You rated this product: " + rating.ToString(), "Rating Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
