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
            int rating = 0;

            // Check which RadioButton is checked
            if (rb1.Checked) rating = 1;
            else if (rb2.Checked) rating = 2;
            else if (rb3.Checked) rating = 3;
            else if (rb4.Checked) rating = 4;
            else if (rb5.Checked) rating = 5;

            
         Result.Text = "You rated this product: {rating}star(s)";
        }
    }
}
