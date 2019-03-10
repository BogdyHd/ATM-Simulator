using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        private void Amount_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            Login.Visible = true;
            flowLayoutPanel1.Visible = true;
            Insert.Visible = false;
            PanelMain.Visible = false;
        }

        private void CardExample_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        
        int pin = 1;
        int AmInt;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.Visible == true)
                switch (pin)
                {
                    case 1:
                        PIN1.Text = "1";
                        pin++;
                        break;
                    case 2:
                        PIN2.Text = "1";
                        pin++;
                        break;
                    case 3:
                        PIN3.Text = "1";
                        pin++;
                        break;
                    case 4:
                        PIN4.Text = "1";
                        pin++;
                        break;
                    default:
                        break;
                }
            else if (YourOption.Visible == true)
            {
                Amount.Text += "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Login.Visible == true)
                switch (pin)
                {
                    case 1:
                        PIN1.Text = "2";
                        pin++;
                        break;
                    case 2:
                        PIN2.Text = "2";
                        pin++;
                        break;
                    case 3:
                        PIN3.Text = "2";
                        pin++;
                        break;
                    case 4:
                        PIN4.Text = "2";
                        pin++;
                        break;
                    default:
                        break;
                }
            else if (YourOption.Visible == true)
            {
                Amount.Text += "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Login.Visible == true)
                switch (pin)
                {
                    case 1:
                        PIN1.Text = "3";
                        pin++;
                        break;
                    case 2:
                        PIN2.Text = "3";
                        pin++;
                        break;
                    case 3:
                        PIN3.Text = "3";
                        pin++;
                        break;
                    case 4:
                        PIN4.Text = "3";
                        pin++;
                        break;
                    default:
                        break;
                }
            else if (YourOption.Visible == true)
            {
                Amount.Text += "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Login.Visible == true)
                switch (pin)
                {
                    case 1:
                        PIN1.Text = "4";
                        pin++;
                        break;
                    case 2:
                        PIN2.Text = "4";
                        pin++;
                        break;
                    case 3:
                        PIN3.Text = "4";
                        pin++;
                        break;
                    case 4:
                        PIN4.Text = "4";
                        pin++;
                        break;
                    default:
                        break;
                }
            else if (YourOption.Visible == true)
            {
                Amount.Text += "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (Login.Visible == true)
                switch (pin)
                {
                    case 1:
                        PIN1.Text = "5";
                        pin++;
                        break;
                    case 2:
                        PIN2.Text = "5";
                        pin++;
                        break;
                    case 3:
                        PIN3.Text = "5";
                        pin++;
                        break;
                    case 4:
                        PIN4.Text = "5";
                        pin++;
                        break;
                    default:
                        break;
                }
            else if (YourOption.Visible == true)
            {
                Amount.Text += "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (Login.Visible == true)
                switch (pin)
                {
                    case 1:
                        PIN1.Text = "6";
                        pin++;
                        break;
                    case 2:
                        PIN2.Text = "6";
                        pin++;
                        break;
                    case 3:
                        PIN3.Text = "6";
                        pin++;
                        break;
                    case 4:
                        PIN4.Text = "6";
                        pin++;
                        break;
                    default:
                        break;
                }
            else if (YourOption.Visible == true)
            {
                Amount.Text += "6";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (Login.Visible == true)
                switch (pin)
                {
                    case 1:
                        PIN1.Text = "7";
                        pin++;
                        break;
                    case 2:
                        PIN2.Text = "7";
                        pin++;
                        break;
                    case 3:
                        PIN3.Text = "7";
                        pin++;
                        break;
                    case 4:
                        PIN4.Text = "7";
                        pin++;
                        break;
                    default:
                        break;
                }
            else if (YourOption.Visible == true)
            {
                Amount.Text += "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (Login.Visible == true)
                switch (pin)
                {
                    case 1:
                        PIN1.Text = "8";
                        pin++;
                        break;
                    case 2:
                        PIN2.Text = "8";
                        pin++;
                        break;
                    case 3:
                        PIN3.Text = "8";
                        pin++;
                        break;
                    case 4:
                        PIN4.Text = "8";
                        pin++;
                        break;
                    default:
                        break;
                }
            else if (YourOption.Visible == true)
            {
                Amount.Text += "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (Login.Visible == true)
                switch (pin)
                {
                    case 1:
                        PIN1.Text = "9";
                        pin++;
                        break;
                    case 2:
                        PIN2.Text = "9";
                        pin++;
                        break;
                    case 3:
                        PIN3.Text = "9";
                        pin++;
                        break;
                    case 4:
                        PIN4.Text = "9";
                        pin++;
                        break;
                    default:
                        break;
                }
            else if (YourOption.Visible == true)
            {
                Amount.Text += "9";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (Login.Visible == true)
                switch (pin)
                {
                    case 1:
                        PIN1.Text = "0";
                        pin++;
                        break;
                    case 2:
                        PIN2.Text = "0";
                        pin++;
                        break;
                    case 3:
                        PIN3.Text = "0";
                        pin++;
                        break;
                    case 4:
                        PIN4.Text = "0";
                        pin++;
                        break;
                    default:
                        break;
                }
            else if (YourOption.Visible == true)
            {
                if(Amount.Text!="")
                    Amount.Text += "0";
            }
        }

        private void PIN1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void PIN2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void PIN3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (Login.Visible == true)
            {
                PIN1.Text = "";
                PIN2.Text = "";
                PIN3.Text = "";
                PIN4.Text = "";
                balBox.Text = bal.ToString("0.00");
                PanelMain.Visible = true;
                Insert.Visible = true;
                flowLayoutPanel1.Visible = false;
                Login.Visible = false;
            }
            if (Cho.Visible == true)
            {
                panelWithdraw.Visible = true;
                buttonWithdraw.Visible = true;
                Cho.Visible = false;
                flowLayoutPanel1.Visible = false;
                panelWithdraw.BringToFront();
                MoneyBox.Visible = false;
            }
            if (YourOption.Visible == true)
            {
                Cho.Visible = true;
                YourOption.Visible = false;
            }
            if ((MoneyBox.Image != null) || (NrOfBills.Text != ""))
            {
                MoneyBox.Image = null;
                NrOfBills.Text = null;
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (Login.Visible == true)
            {
                PIN1.Text = "";
                PIN2.Text = "";
                PIN3.Text = "";
                PIN4.Text = "";
                pin = 1;
            }
            else if (YourOption.Visible == true)
            {
                Amount.Text = "";
            }
        }
        double bal = 1000.00;
        int aAmInt=0;
        int bAmInt=0;
        int cAmInt=0;
        int dAmInt=0;
        int eAmInt=0;
        int fAmInt=0;
        int gAmInt=0;
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if ((Login.Visible==true) && (PIN1.Text != "") && (PIN2.Text != "") && (PIN3.Text != "") && (PIN4.Text != ""))
            {
                balBox.Text = bal.ToString("0.00");
                panelWithdraw.Visible = true;
                buttonWithdraw.Visible = true;
                flowLayoutPanel1.Visible = false;
                Login.Visible = false;
                panelWithdraw.BringToFront();
            }
            else if (YourOption.Visible == true)
            {
                AmInt=Convert.ToInt32(Amount.Text);
                if(bal>=AmInt)
                {
                    if (AmInt > 99)
                    {
                        aAmInt = AmInt / 100;
                        bal -= aAmInt * 100;
                        AmInt %= 100;
                        balBox.Text = bal.ToString("0.00");
                    }
                     if (AmInt > 49)
                    {
                        bAmInt = AmInt / 50;
                        bal -= bAmInt * 50;
                        AmInt %= 50;
                        balBox.Text = bal.ToString("0.00");
                    }
                     if (AmInt > 19)
                    {
                        cAmInt = AmInt / 20;
                        bal -= cAmInt * 20;
                        AmInt %= 20;
                        balBox.Text = bal.ToString("0.00");
                    }
                     if (AmInt > 9)
                    {
                        dAmInt = AmInt / 10;
                        bal -= dAmInt * 10;
                        AmInt %= 10;
                        balBox.Text = bal.ToString("0.00");
                    }
                     if (AmInt > 4)
                    {
                        eAmInt = AmInt / 5;
                        bal -= eAmInt * 5;
                        AmInt %= 5;
                        balBox.Text = bal.ToString("0.00");
                    }
                     if (AmInt > 1)
                    {
                        fAmInt = AmInt / 2;
                        bal -= fAmInt * 2;
                        AmInt %= 2;
                        balBox.Text = bal.ToString("0.00");
                    }
                    if(AmInt == 1)
                    {
                        gAmInt = 1;
                        bal -= 1;
                        balBox.Text = bal.ToString("0.00");
                    }
                    goodbye.Visible = true;
                    flowLayoutPanel1.Visible = false;
                    panelWithdraw.Visible = false;
                    YourOption.Visible = false;
                    timer2.Interval = 100;
                    timer2.Start();
                } else
                {
                    MessageBox.Show("You don't have that amount of money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (aAmInt > 0)
            {
                MoneyBox.Image = Properties.Resources._100;
                NrOfBills.Text = "X " + aAmInt.ToString();
                aAmInt = 0;
                timer2.Interval = 2000;
            }
            else if (bAmInt > 0)
            {
                MoneyBox.Image = Properties.Resources._50;
                NrOfBills.Text = "X " + bAmInt.ToString();
                bAmInt = 0;
            }
            else if (cAmInt > 0)
            {
                MoneyBox.Image = Properties.Resources._20;
                NrOfBills.Text = "X " + cAmInt.ToString();
                cAmInt = 0;
            }
            else if (dAmInt > 0)
            {
                MoneyBox.Image = Properties.Resources._10;
                NrOfBills.Text = "X " + dAmInt.ToString();
                dAmInt = 0;
            }
            else if (eAmInt > 0)
            {
                MoneyBox.Image = Properties.Resources._5;
                NrOfBills.Text = "X " + eAmInt.ToString();
                eAmInt = 0;
            }
            else if (fAmInt > 0)
            {
                MoneyBox.Image = Properties.Resources._2;
                NrOfBills.Text = "X " + fAmInt.ToString();
                fAmInt = 0;
            }
            else if (gAmInt > 0)
            {
                MoneyBox.Image = Properties.Resources._1;
                NrOfBills.Text = "X 1";
                gAmInt = 0;
                timer2.Stop();
            }
        }
        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            Cho.Visible = true;
            MoneyBox.Visible = true;
            panelWithdraw.Visible = false;
            buttonWithdraw.Visible = false;
            MoneyBox.Image = null;
        }

        private void panelWithdraw_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonN1_Click(object sender, EventArgs e)
        {

        }

        private void balBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Choice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void money5_Click(object sender, EventArgs e)
        {
            if (bal > 4)
            {
                bal -= 5;
                goodbye.Visible = true;
                Cho.Visible = false;
                balBox.Text = bal.ToString("0.00");
                MoneyBox.Image = Properties.Resources._5;
            }
        }

        private void MoneyBox_Click(object sender, EventArgs e)
        {

        }

        private void Money10_Click(object sender, EventArgs e)
        {
            if (bal > 9)
            {
                bal -= 10;
                goodbye.Visible = true;
                Cho.Visible = false;
                balBox.Text = bal.ToString("0.00");
                MoneyBox.Image = Properties.Resources._10;
            }
        }

        private void money50_Click(object sender, EventArgs e)
        {
            if (bal > 49)
            {
                bal -= 50;
                goodbye.Visible = true;
                Cho.Visible = false;
                balBox.Text = bal.ToString("0.00");
                MoneyBox.Image = Properties.Resources._50;
            }
        }

        private void money100_Click(object sender, EventArgs e)
        {
            if (bal > 99)
            {
                goodbye.Visible = true;
                Cho.Visible = false;
                bal -= 100;
                balBox.Text = bal.ToString("0.00");
                MoneyBox.Image = Properties.Resources._100;
            }
        }

        int NrOfMoney = 0;
        private void money250_Click(object sender, EventArgs e)
        {
            if (bal > 249)
            {
                goodbye.Visible = true;
                Cho.Visible = false;
                timer1.Interval = 100;
                bal -= 250;
                balBox.Text = bal.ToString("0.00");
                timer1.Start();
            }
        }
        private void Ascuns_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Ascuns.Visible == false)
            {
                MoneyBox.Image = Properties.Resources._100;
                NrOfBills.Text = "X 2";
                timer1.Interval = 2000;
                Ascuns.Visible = true;
            }
            else
            {
                MoneyBox.Image = Properties.Resources._50;
                NrOfBills.Text = "X 1";
                Ascuns.Visible = false;
                timer1.Stop();
            }
        }


        private void NrOfBills_Click(object sender, EventArgs e)
        {

        }

        private void money500_Click(object sender, EventArgs e)
        {
            if(bal > 499)
            {
                goodbye.Visible = true;
                Cho.Visible = false;
                bal -= 500;
                balBox.Text = bal.ToString("0.00");
                NrOfBills.Text = "X 5";
                MoneyBox.Image = Properties.Resources._100;
            }
        }

        private void moneyCho_Click(object sender, EventArgs e)
        {

            YourOption.Visible = true;
            flowLayoutPanel1.Visible = true;
            Cho.Visible = false;

        }

        private void YourOption_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonN2_Click(object sender, EventArgs e)
        {

        }
    }
}