using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaWork
{
    public partial class Form1 : Form
    {


     

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            menPage1.BringToFront();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/?hl=ru");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            menPage1.BringToFront();
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/MyNewBotForBot");
        }


        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            womenPage1.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            discount1.BringToFront();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This ptogram hase been devoloped by Mykhailo Yanitskyi," +
                " if you have some questuion, please, write them here \nyanitskyi.m@gmail.com");
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
        }

        private void WomenPage1_Load(object sender, EventArgs e)
        {

        }

        private void Discount1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
