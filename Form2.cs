using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Form2 : Form
    {
    

        public Form2()
        {
            InitializeComponent();
            
                       
        }
        private void Form2_Load (object sender, EventArgs e)
        {
            
        }
        

        private void lblTax_Click(object sender, EventArgs e)
        {
           
        }

        private void lblCakeCost_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.ShowDialog();
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
