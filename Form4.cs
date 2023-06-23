using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
            MySqlConnection conn = new MySqlConnection("Data source = 127.0.0.1; Database = cafgju; UserID = root; Password = 123456789; SSL Mode = None");
        

            conn.Open();
            string sql = "SELECT COUNT(OrderNo) FROM caftotal;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            label2.Text = cmd.ExecuteScalar().ToString();
            
        }
          
        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }
    }
}
