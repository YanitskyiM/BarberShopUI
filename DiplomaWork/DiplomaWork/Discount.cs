using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaWork
{
    public partial class Discount : UserControl
    {
        public Discount()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(textBox1.Text) % 2) == 0)
            {
                MessageBox.Show("Say 'Spider Man' to your hairdresser and get discount for 50%", "Congratulation!");
            }
            else
            {
                MessageBox.Show("You didn't guess, and don't get a discount", "Sorry!");

            }
        }

       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
