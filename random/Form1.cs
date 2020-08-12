using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OMG, sabia que lo harias :))))", "U DID IT!!!!!!!");
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ"); 
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random randomX = new Random();
            Random randomY = new Random();
            button2.Location = new Point((randomX.Next(0, 800)), (randomY.Next(0, 200)));
            button2.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random randomX = new Random();
            Random randomY = new Random();
            button2.Location = new Point((randomX.Next(0, 800)), (randomY.Next(0, 200)));
            button2.Show();
        }
    }
}
