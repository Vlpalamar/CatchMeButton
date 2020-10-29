using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        Random rand;

        public Form1()
        {
            InitializeComponent();
            rand = new Random();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }


        

        private void Static_Click_1(object sender, EventArgs e)
        {

        }

        private void Static_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            
               
                panel1.Location = new Point(rand.Next(0,this.ClientSize.Width-panel1.Size.Width), rand.Next(0, this.ClientSize.Height-panel1.Size.Height));
            
        }
    }
    
}
