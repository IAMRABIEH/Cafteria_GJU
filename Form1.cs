using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Data.SqlClient;

namespace CafeManagement
{
    public partial class Form1 : Form
    {

       
        
        public Form1()
        {
            InitializeComponent();
            //test

        }

        private void button3_Click(object sender, EventArgs e)
        { //btnReset
            txtNescafe.Text = "0";
            txtHotChocolate.Text = "0";
            txtCofee.Text = "0";
            txtWater.Text = "0";
            txtCappu.Text = "0";
            txtRedBull.Text = "0";
            txtIceTea.Text = "0";
            txtTea.Text = "0";
            txtZinger.Text = "0";
            txtFajita.Text = "0";
            txtHotdog.Text = "0";
            txtFriesnCheese.Text = "0";
            txtExtraGum.Text = "0";
            txtChocolateBar.Text = "0";
            txtCheeseCake.Text = "0";
            txtPastryNutella.Text = "0";
            lblCakeCost.Text = "0";
            lblDrinkCost.Text = "0"; 
            lblSvcCharge.Text = "0";
            lblTax.Text = "0";
            lblSubTotal.Text = "0";
            lblTotal.Text = "0";

            chkNescafe.Checked = false;
            chkHotChocolate.Checked = false;
            chkCofee.Checked = false;
            chkWater.Checked = false;
            chkCappucino.Checked = false;
            chkRedBull.Checked = false;
            chkIceTea.Checked = false;
            chkTea.Checked = false;
            chkFajita.Checked = false;
            chkZinger.Checked = false;
            chkHotdog.Checked = false;
            chkFriesncheese.Checked = false;
            checkBox13.Checked = false;
            chkChocolateBar.Checked = false;
            chkCheese.Checked = false;
            chkPastryNutella.Checked = false;
        }
        
        
        public void button2_Click(object sender, EventArgs e)
        {


            Form3 frm = new Form3();


            //btnReceipt
            frm.rtfReceipt.Clear();
           

            // rtfReceipt.AppendText(Environment.NewLine);
            frm.rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            frm.rtfReceipt.AppendText("\t" + "       GJU CAFTERIA" + Environment.NewLine);
            frm.rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            frm.rtfReceipt.AppendText("ITEM" + "\t\t\t\t" + "QTY" + Environment.NewLine);
            frm.rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            if (chkNescafe.Checked == true)
            {
                frm.rtfReceipt.AppendText("Nescafe       \t\t\t\t" + txtNescafe.Text + Environment.NewLine);
              
            }
            else
            {

            }
            if (chkHotChocolate.Checked == true)
            {
                frm.rtfReceipt.AppendText("Hot Chocolate \t\t\t\t" + txtHotChocolate.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkCofee.Checked == true)
            {
                frm.rtfReceipt.AppendText("Coffee   \t\t\t\t" + txtCofee.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkWater.Checked == true)
            {
                frm.rtfReceipt.AppendText("Water    \t\t\t\t" + txtWater.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkCappucino.Checked == true)
            {
                frm.rtfReceipt.AppendText("Capuucino \t\t\t\t" + txtCappu.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkRedBull.Checked == true)
            {
                frm.rtfReceipt.AppendText("RedBull \t\t\t\t" + txtRedBull.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkIceTea.Checked == true)
            {
                frm.rtfReceipt.AppendText("Ice Tea       \t\t\t\t" + txtIceTea.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkTea.Checked == true)
            {
                frm.rtfReceipt.AppendText("Tea           \t\t\t\t" + txtTea.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkZinger.Checked == true)
            {
                frm.rtfReceipt.AppendText("Zinger        \t\t\t\t" + txtZinger.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkFajita.Checked == true)
            {
                frm.rtfReceipt.AppendText("Fajita        \t\t\t\t" + txtFajita.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkHotdog.Checked == true)
            {
                 frm.rtfReceipt.AppendText("Hotdog       \t\t\t\t" + txtHotdog.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkFriesncheese.Checked == true)
            {
                frm.rtfReceipt.AppendText("Fries n Cheese \t\t\t\t" + txtFriesnCheese.Text + Environment.NewLine);
            }
            else
            {

            }
            if (checkBox13.Checked == true)
            {
                frm.rtfReceipt.AppendText("Extra Gum     \t\t\t\t" + txtExtraGum.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkChocolateBar.Checked == true)
            {
                frm.rtfReceipt.AppendText("Chocolate Bar \t\t\t\t" + txtChocolateBar.Text + Environment.NewLine);
            }
            else
            {
               
            }
            if (chkCheese.Checked == true)
            {
                frm.rtfReceipt.AppendText("Cheese Cake  \t\t\t\t" + txtCheeseCake.Text + Environment.NewLine);
            }
            else
            {

            }
            if (chkPastryNutella.Checked == true)
            {
                frm.rtfReceipt.AppendText("Nutella Pastry\t\t\t\t" + txtPastryNutella.Text + Environment.NewLine);
            }
            else
            {

            }
            double nes, cof, coco, wat, cappu, red, itee, tee, sCh;
            double zin, faj, hot, fri, exg, chb, chs, pan;
            double tax;
            tax = 0.08;
            sCh = 0.25;

            nes = 0.50; cof = 0.50; coco = 0.50; wat = 0.25; cappu = 0.50; red = 1.5; itee = 0.60; tee = 0.25; //coffee pries
            zin = 1.75; chs = 1; faj = 1.75; hot = 0.25; fri = 1.25; exg = 0.65; chb = 0.60; pan = 0.50; //cake prices
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-JOD");
            //CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US"); //US Currency

            //Coffee
            double Nescafe = Convert.ToDouble(txtNescafe.Text);
            double Coffee = Convert.ToDouble(txtCofee.Text);
            double HotChocolate = Convert.ToDouble(txtHotChocolate.Text);
            double Water = Convert.ToDouble(txtWater.Text);
            double cappCof = Convert.ToDouble(txtCappu.Text);
            double RedBull = Convert.ToDouble(txtRedBull.Text);
            double IceTea = Convert.ToDouble(txtIceTea.Text);
            double Tea = Convert.ToDouble(txtTea.Text);
            //Cakes
            double Zinger = Convert.ToDouble(txtZinger.Text);
            double Fajita = Convert.ToDouble(txtFajita.Text);
            double Hotdog = Convert.ToDouble(txtHotdog.Text);
            double FriesnCheese = Convert.ToDouble(txtFriesnCheese.Text);
            double Extragum = Convert.ToDouble(txtExtraGum.Text);
            double ChocolateBar = Convert.ToDouble(txtChocolateBar.Text);
            double cheeseCak = Convert.ToDouble(txtCheeseCake.Text);
            double PastryNutella = Convert.ToDouble(txtPastryNutella.Text);
            Cafe eat_in_cafe = new Cafe(Nescafe, Coffee, HotChocolate, Water, cappCof, RedBull, IceTea, Tea,
                Zinger, Fajita, Hotdog, FriesnCheese, Extragum, ChocolateBar, cheeseCak, PastryNutella);

            double drinkCosts = (Nescafe * nes) + (Coffee * cof) + (HotChocolate * coco) + (Water * wat) + (cappCof * cappu) + (RedBull * red) + (IceTea * itee) + (Tea * tee);
            lblDrinkCost.Text = Convert.ToString(drinkCosts);
            double foodCosts = (Zinger * zin) + (Fajita * faj) + (Hotdog * hot) + (FriesnCheese * fri) + (Extragum * exg) + (ChocolateBar * chb) + (cheeseCak * chs) + (PastryNutella * pan);
            lblCakeCost.Text = Convert.ToString(foodCosts);

            double svcCharge = Convert.ToDouble(sCh);
            double total = foodCosts + svcCharge + drinkCosts;
            lblSubTotal.Text = Convert.ToString(foodCosts + drinkCosts + svcCharge);
            lblTax.Text = Convert.ToString(tax * total);
            double totalAftTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(foodCosts + drinkCosts + svcCharge + totalAftTax);

            lblDrinkCost.Text = String.Format(culture, "{0:C}", drinkCosts);
            lblCakeCost.Text = String.Format(culture, "{0:C}", foodCosts);
            lblSvcCharge.Text = String.Format(culture, "{0:C}", svcCharge);
            lblSubTotal.Text = String.Format(culture, "{0:C}", (foodCosts + drinkCosts + svcCharge));
            lblTax.Text = String.Format(culture, "{0:C}", totalAftTax);
            lblTotal.Text = String.Format(culture, "{0:C}", (foodCosts + drinkCosts + svcCharge + totalAftTax));

            MySqlConnection conn = new MySqlConnection("Data source = 127.0.0.1; Database = cafgju; UserID = root; Password = 123456789; SSL Mode = None");

            conn.Open();

            float Tx = float.Parse(lblTax.Text.Replace("$", ""), CultureInfo.InvariantCulture.NumberFormat);
            float Total = float.Parse(lblTotal.Text.Replace("$", ""), CultureInfo.InvariantCulture.NumberFormat);
            float SubTotal = float.Parse(lblSubTotal.Text.Replace("$", ""), CultureInfo.InvariantCulture.NumberFormat);

            // String Query = "INSERT INTO caftotal(OrderNo,Total,Subtotal) VALUES("
            //             + Tx + "," + Total + "," + SubTotal + ");";
            String Query = "INSERT INTO caftotal(Total,Subtotal) VALUES(" + Total + "," + SubTotal + ");";
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.ExecuteReader();

            frm.rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            frm.rtfReceipt.AppendText("Service Charge \t\t" + lblSvcCharge.Text + Environment.NewLine);
            frm.rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            frm.rtfReceipt.AppendText("Tax \t\t\t\t" + lblTax.Text + Environment.NewLine);
            frm.rtfReceipt.AppendText("Sub Total \t\t\t" + lblSubTotal.Text  + Environment.NewLine);
            frm.rtfReceipt.AppendText("Total Cost \t\t\t" + lblTotal.Text + Environment.NewLine);
            frm.rtfReceipt.AppendText("----------------------------------------------------------------" + Environment.NewLine);
            frm.rtfReceipt.AppendText(lblTimer.Text + "\t\t\t");
            this.Hide();
            frm.timer1.Enabled = true;
            frm.ShowDialog();

        }

        public void button1_Click(object sender, EventArgs e)
        { //btnTotal

            double nes, cof, coco, wat, cappu, red, itee, tee, sCh;
            double zin, faj, hot, fri, exg, chb, chs, pan;
            double tax;
            tax = 0.08;
            sCh = 0.25;

            nes = 0.50; cof = 0.50; coco = 0.50; wat = 0.25; cappu = 0.50; red = 1.5; itee = 0.60; tee = 0.25; //coffee pries
            zin = 1.75; chs = 1; faj = 1.75; hot = 0.25; fri = 1.25; exg = 0.65; chb = 0.60; pan = 0.50; //cake prices
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-JOD");
            //CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US"); //US Currency

            //Coffee
            double Nescafe = Convert.ToDouble(txtNescafe.Text);
            double Coffee = Convert.ToDouble(txtCofee.Text);
            double HotChocolate = Convert.ToDouble(txtHotChocolate.Text);
            double Water = Convert.ToDouble(txtWater.Text);
            double cappCof = Convert.ToDouble(txtCappu.Text);
            double RedBull = Convert.ToDouble(txtRedBull.Text);
            double IceTea = Convert.ToDouble(txtIceTea.Text);
            double Tea = Convert.ToDouble(txtTea.Text);
            //Cakes
            double Zinger = Convert.ToDouble(txtZinger.Text);
            double Fajita = Convert.ToDouble(txtFajita.Text);
            double Hotdog = Convert.ToDouble(txtHotdog.Text);
            double FriesnCheese = Convert.ToDouble(txtFriesnCheese.Text);
            double Extragum = Convert.ToDouble(txtExtraGum.Text);
            double ChocolateBar = Convert.ToDouble(txtChocolateBar.Text);
            double cheeseCak = Convert.ToDouble(txtCheeseCake.Text);
            double PastryNutella = Convert.ToDouble(txtPastryNutella.Text);
            Cafe eat_in_cafe = new Cafe(Nescafe, Coffee, HotChocolate, Water, cappCof, RedBull, IceTea, Tea,
                Zinger, Fajita, Hotdog, FriesnCheese, Extragum, ChocolateBar, cheeseCak, PastryNutella);

            double drinkCosts = (Nescafe * nes) + (Coffee * cof) + (HotChocolate * coco) + (Water * wat) + (cappCof * cappu) + (RedBull * red) + (IceTea * itee) + (Tea * tee);
            lblDrinkCost.Text = Convert.ToString(drinkCosts);
            double foodCosts = (Zinger * zin) + (Fajita * faj) + (Hotdog * hot) + (FriesnCheese * fri) + (Extragum * exg) + (ChocolateBar * chb) + (cheeseCak * chs) + (PastryNutella * pan);
            lblCakeCost.Text = Convert.ToString(foodCosts);

            double svcCharge = Convert.ToDouble(sCh);
            double total = drinkCosts + foodCosts + svcCharge;
            lblSubTotal.Text = Convert.ToString(foodCosts + drinkCosts + svcCharge);
            lblTax.Text = Convert.ToString(tax * total);
            double totalAftTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(foodCosts + drinkCosts + svcCharge + totalAftTax);

            lblDrinkCost.Text = String.Format(culture, "{0:C}", drinkCosts);
            lblCakeCost.Text = String.Format(culture, "{0:C}", foodCosts);
            lblSvcCharge.Text = String.Format(culture, "{0:C}", svcCharge);
            lblSubTotal.Text = String.Format(culture, "{0:C}", (foodCosts + drinkCosts + svcCharge));
            lblTax.Text = String.Format(culture, "{0:C}", totalAftTax);
            lblTotal.Text = String.Format(culture, "{0:C}", (foodCosts + drinkCosts + svcCharge + totalAftTax));



           
            MySqlConnection conn = new MySqlConnection("Data source = 127.0.0.1; Database = cafgju; UserID = root; Password = 123456789; SSL Mode = None");
                  
            conn.Open();
          
            float Tx = float.Parse(lblTax.Text.Replace("$",""), CultureInfo.InvariantCulture.NumberFormat);
            float Total = float.Parse(lblTotal.Text.Replace("$",""), CultureInfo.InvariantCulture.NumberFormat);
            float SubTotal = float.Parse(lblSubTotal.Text.Replace("$",""), CultureInfo.InvariantCulture.NumberFormat);

           // String Query = "INSERT INTO caftotal(OrderNo,Total,Subtotal) VALUES("
               //             + Tx + "," + Total + "," + SubTotal + ");";
            String Query = "INSERT INTO caftotal(Total,Subtotal) VALUES(" + Total + "," + SubTotal + ");";
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.ExecuteReader();
            this.Hide();
           Form2 from = new Form2();

            from.label1.Text = this.lblTax.Text;
            from.label2.Text = this.lblSubTotal.Text;
            from.label6.Text = this.lblTotal.Text;
            from.label12.Text = this.lblDrinkCost.Text;
            from.label7.Text = this.lblSvcCharge.Text;
            from.label8.Text = this.lblCakeCost.Text;
            
          
            from.ShowDialog();
            conn.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
            double latteeCof = Convert.ToDouble(txtNescafe.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();


            txtNescafe.Text = "0";
            txtHotChocolate.Text = "0";
            txtCofee.Text = "0";
            txtWater.Text = "0";
            txtCappu.Text = "0";
            txtRedBull.Text = "0";
            txtIceTea.Text = "0";
            txtTea.Text = "0";
            txtZinger.Text = "0";
            txtFajita.Text = "0";
            txtHotdog.Text = "0";
            txtFriesnCheese.Text = "0";
            txtExtraGum.Text = "0";
            txtChocolateBar.Text = "0";
            txtCheeseCake.Text = "0";
            txtPastryNutella.Text = "0";
            lblCakeCost.Text = "0";
            lblDrinkCost.Text = "0";
            lblSvcCharge.Text = "0";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";

            txtNescafe.Enabled = false;
            txtHotChocolate.Enabled = false; ;
            txtCofee.Enabled = false;
            txtWater.Enabled = false;
            txtCappu.Enabled = false;
            txtRedBull.Enabled = false;
            txtIceTea.Enabled = false;
            txtTea.Enabled = false;
            txtZinger.Enabled = false;
            txtFajita.Enabled = false;
            txtHotdog.Enabled = false;
            txtFriesnCheese.Enabled = false;
            txtExtraGum.Enabled = false;
            txtChocolateBar.Enabled = false;
            txtCheeseCake.Enabled = false;
            txtPastryNutella.Enabled = false;

            chkNescafe.Checked = false;
            chkHotChocolate.Checked = false;
            chkCofee.Checked = false;
            chkWater.Checked = false;
            chkCappucino.Checked = false;
            chkRedBull.Checked = false;
            chkIceTea.Checked = false;
            chkTea.Checked = false;
            chkFajita.Checked = false;
            chkZinger.Checked = false;
            chkHotdog.Checked = false;
            chkFriesncheese.Checked = false;
            checkBox13.Checked = false;
            chkChocolateBar.Checked = false;
            chkCheese.Checked = false;
            chkPastryNutella.Checked = false;

            rtfReceipt.Clear();

        }

        private void chkNescafe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNescafe.Checked==true)
            {
                txtNescafe.Enabled = true;
                txtNescafe.Text = "1";
            }
            else
            {
                txtNescafe.Enabled = false;
                txtNescafe.Text = "0";
            }
        }    

        private void txtNescafe_Click(object sender, EventArgs e)
        {
            txtNescafe.Text = "";
            txtNescafe.Focus();
        }

        private void chkHotChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHotChocolate.Checked == true)
            {
               txtHotChocolate.Enabled = true;
                txtHotChocolate.Text = "1";
            }
            else
            {
                txtHotChocolate.Enabled = false;
                txtHotChocolate.Text = "0";
            }
        }

        private void txtHotChocolate_Click(object sender, EventArgs e)
        {
            txtHotChocolate.Text = "";
            txtHotChocolate.Focus();
        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCofee.Checked == true)
            {
                txtCofee.Enabled = true;
                txtCofee.Text = "1";
            }
            else
            {
                txtCofee.Enabled = false;
                txtCofee.Text = "0";
            }
        }

        private void txtCoffee_Click(object sender, EventArgs e)
        {
            txtCofee.Text = "";
            txtCofee.Focus();
        }

        private void chkWater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWater.Checked == true)
            {
                txtWater.Enabled = true;
                txtWater.Text = "1";
            }
            else
            {
                txtWater.Enabled = false;
                txtWater.Text = "0";
            }
        }

        private void txtWater_Click(object sender, EventArgs e)
        {
            txtWater.Text = "";
            txtWater.Focus();
        }

        private void chkCappucino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappucino.Checked == true)
            {
                txtCappu.Enabled = true;
                txtCappu.Text = "1";
            }
            else
            {
                txtCappu.Enabled = false;
                txtCappu.Text = "0";
            }
        }

        private void txtCappu_Click(object sender, EventArgs e)
        {
            txtCappu.Text = "";
            txtCappu.Focus();
        }

        private void chkRedBull_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedBull.Checked == true)
            {
                txtRedBull.Enabled = true;
                txtRedBull.Text = "1";
            }
            else
            {
                txtRedBull.Enabled = false;
                txtRedBull.Text = "0";
            }
        }

           private void txtRedBull_Click(object sender, EventArgs e)
        {
            txtRedBull.Text = "";
            txtRedBull.Focus();
        }

        private void chkIceTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIceTea.Checked == true)
            {
                txtIceTea.Enabled = true;
                txtIceTea.Text = "1";
            }
            else
            {
                txtIceTea.Enabled = false;
                txtIceTea.Text = "0";
            }
        }

        private void txtIceTea_Click(object sender, EventArgs e)
        {
            txtIceTea.Text = "";
            txtIceTea.Focus();
        }

        private void chkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTea.Checked == true)
            {
                txtTea.Enabled = true;
                txtTea.Text = "1";
            }
            else
            {
                txtTea.Enabled = false;
                txtTea.Text = "0";
            }
        }

        private void txtTea_Click(object sender, EventArgs e)
        {
            txtTea.Text = "";
            txtTea.Focus();
        }

        private void chkZinger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkZinger.Checked == true)
            {
                txtZinger.Enabled = true;
                txtZinger.Text = "1";
            }
            else
            {
                txtZinger.Enabled = false;
                txtZinger.Text = "0";
            }
        }

        private void txtZinger_Click(object sender, EventArgs e)
        {
            txtZinger.Text = "";
            txtZinger.Focus();
        }

        private void chkFajita_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFajita.Checked == true)
            {
                txtFajita.Enabled = true;
                txtFajita.Text = "1";
            }
            else
            {
                txtFajita.Enabled = false;
                txtFajita.Text = "0";
            }
        }

        private void txtFajita_Click(object sender, EventArgs e)
        {
            txtFajita.Text = "";
            txtFajita.Focus();
        }


        private void chkHotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHotdog.Checked == true)
            {
                txtHotdog.Enabled = true;
                txtHotdog.Text = "1";
            }
            else
            {
                txtHotdog.Enabled = false;
                txtHotdog.Text = "0";
            }
        }

        private void txtHotdog_Click(object sender, EventArgs e)
        {
            txtHotdog.Text = "";
            txtHotdog.Focus();
        }

        private void chkFriesncheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFriesncheese.Checked == true)
            {
                txtFriesnCheese.Enabled = true;
                txtFriesnCheese.Text = "1";
            }
            else
            {
                txtFriesnCheese.Enabled = false;
                txtFriesnCheese.Text = "0";
            }
        }

        private void txtFriesnCheese_Click(object sender, EventArgs e)
        {
            txtFriesnCheese.Text = "";
            txtFriesnCheese.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
               txtExtraGum.Enabled = true;
                txtExtraGum.Text = "1";
            }
            else
            {
                txtExtraGum.Enabled = false;
                txtExtraGum.Text = "0";
            }
        }

        private void txtExtraGum_Click(object sender, EventArgs e)
        {
            txtExtraGum.Text = "";
            txtExtraGum.Focus();
        }

        private void chckChocoalteBar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChocolateBar.Checked == true)
            {
                txtChocolateBar.Enabled = true;
                txtChocolateBar.Text = "1";
            }
            else
            {
                txtChocolateBar.Enabled = false;
                txtChocolateBar.Text = "0";
            }
        }


        private void txtChocolateBar_Click(object sender, EventArgs e)
        {
            txtChocolateBar.Text = "";
            txtChocolateBar.Focus();
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheese.Checked == true)
            {
                txtCheeseCake.Enabled = true;
                txtCheeseCake.Text = "1";
            }
            else
            {
                txtCheeseCake.Enabled = false;
                txtCheeseCake.Text = "0";
            }
        }


        private void txtCheeseCake_Click(object sender, EventArgs e)
        {
            txtCheeseCake.Text = "";
            txtCheeseCake.Focus();
        }

        private void chkPastryNutella_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPastryNutella.Checked == true)
            {
               txtPastryNutella.Enabled = true;
                txtPastryNutella.Text = "1";
            }
            else
            {
                txtPastryNutella.Enabled = false;
                txtPastryNutella.Text = "0";
            }
        }

        private void txtPastryNutella_Click(object sender, EventArgs e)
        {
            txtPastryNutella.Text = "";
            txtPastryNutella.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

       

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will open text files
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will save text files
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            
            
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCoffeCake_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLatte_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {


        }

        private void rtfReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEspresso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCappu_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblDrinkCost_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void lblSvcCharge_Click(object sender, EventArgs e)
        {

        }

        private void txtFajita_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
