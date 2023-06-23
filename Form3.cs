using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void rtfReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNescafe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCheeseCake_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Hide();
            Form4 frm=new Form4();
            frm.ShowDialog();
           
            
            
            
        }
    }
}
