using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Windows.Input;
/// <summary>
/// 
/// 3/29/2019: V1.0 Program is almost done. There is a glitch where you cant dispence a number like 280. I believe its because 280 would typily 
/// include 2 hunnys and 1 fiddy then 1.5 twennys. Because the 20s modulus is not a whole number, It fails. so the program needs to dispence 2 hunnys, and 4 twenties.
/// 
/// </summary>
namespace ATMprogram
{
    public partial class Form1 : Form
    {
        string pin = "0000";
        string attempt;
        int withdrawl = 0;
        int deposit = 0;
        int balance1 = 500;
        bool withd = false;
        bool pind = true;
        bool depd = false;
        public Form1()
        {
            InitializeComponent();
            //Change the Top lable and make input available
            lbDisplay.Text = "Please Enter Your Pin";
            this.ActiveControl = tbOutput;
        }

   
        private void btEnter_Click(object sender, EventArgs e)
        {
            //if program in withdrawl state
            if(withd)
            {
                //if withdrawl amount is less balance
                if(int.Parse(attempt) <= balance1)
                {
                    bool rightamount = true;
                    withdrawl = int.Parse(attempt);
                    if(WillItWork(true))
                    {
                        Console.WriteLine("!!Mod SUCCESS");
                        lbDisplay.Text = Dispence(dispence: "");
                        balance1 = balance1 - withdrawl;
                    }
                    else
                    {
                        lbDisplay.Text = "Amount must be in 20s, 50s, or 100s";
                        tbOutput.Clear();
                        attempt = "";
                        lbDisplay2.Text = "...";
                        this.ActiveControl = tbOutput;
                        Console.WriteLine("Mod FAIL");
                        rightamount = false;
                    }

                    lbDisplay2.Text = "...";
                    


                    lbDisplay2.Text = "...";
                    if(rightamount)
                    {
                        withd = false;
                    }
                    
                }
                //withdrawl amount is more than balance.
                else
                {
                    tbOutput.Clear();
                    lbDisplay.Text = "Amount exceeds balance, try again";
                    attempt = "";
                    lbDisplay2.Text = "...";
                    this.ActiveControl = tbOutput;
                }

              
          
               
            }
            //if the program is in the deposit state
            if (depd)
            {
                //get how much the user wants to deposit from tbOutput then add it to balance
                deposit = int.Parse(attempt);
                balance1 = balance1 + deposit;
                Console.WriteLine("depositSUCCESS");
                lbDisplay.Text = "New Balance: $" + balance1;

                depd = false;
            }
            
            
            if(pind)
            {
                if (attempt == pin)
                {
                    btbalance.Enabled = true;
                    btCancel.Enabled = true;
                    btWithdrawl.Enabled = true;
                    btDeposit.Enabled = true;
                    lbDisplay.Text = "Please select function";
                    lbDisplay2.Text = "...";
                    lbDisplay2.Text = "";
                    tbOutput.Clear();
                    Console.WriteLine("SUCCESS");
                    pind = false;
                }
                else if (attempt != pin)
                {
                    lbDisplay.Text = "Wrong Pin, Try Again";
                    attempt = "";
                    lbDisplay2.Text = "";
                    this.ActiveControl = tbOutput;
                }

            }
           
        }
        //Function to create a string that says what the machine will dispence
        private string Dispence(string dispence)
        {
            int amount = withdrawl;
            
            int hunny, twnny, fiddy;
            if (amount >= 100)
            {

                hunny = amount % 100;
                hunny = (amount - hunny) / 100;
                amount = amount - (hunny * 100);
                Console.WriteLine("!!!" + hunny + "!!!" + amount);


            }
            else hunny = 0;
            if (amount >= 50)
            {
                
               
                fiddy = amount % 50;
                fiddy = (amount - fiddy) / 50;
                amount = amount - (fiddy * 50);
                Console.WriteLine("%%% " + fiddy + " %%% " + amount);
            }
            else fiddy = 0;
            if (amount >= 20)
            {
                twnny = amount % 20;
                twnny = (amount - twnny) / 20;
                amount = amount - (twnny * 20);
                Console.WriteLine(" @@@ " + twnny + " @@@ " + amount);
            }
            else twnny = 0;
            string plhundred, plfifty, pltwenty;
            
            if (hunny > 1 || hunny == 0)
            {
                plhundred = " Hundreds ";
            }
            else plhundred = " Hundred ";
            if (fiddy == 0)
            {
                plfifty = " Fifties, ";
            }
            else plfifty = " Fifty, ";
            if (twnny > 1 || twnny == 0)
            {
                pltwenty = " Twenties ";
            }
            else pltwenty = " Twentie ";

               
            dispence = "Dispencing " + hunny.ToString() + plhundred +fiddy+plfifty+" and "+twnny+pltwenty ;

            return dispence;
        }

        //Function to determine if the requested withdraw amount is in the right bills.
        private bool WillItWork(bool works)
        {
            int amount = withdrawl;
            works = false;
            int hunny, twnny, fiddy;
            if (amount >= 100)
            {

                hunny = amount % 100;
                hunny = (amount - hunny) / 100;
                amount = amount - (hunny * 100);
                Console.WriteLine("!!!" + hunny + "!!!" + amount);


            }
            if (amount >= 50)
            {
               
                fiddy = amount % 50;
                fiddy = (amount - fiddy) / 50;
                amount = amount - (fiddy * 50);
                Console.WriteLine("%%% " + fiddy + " %%% " + amount);
            }
            if (amount >= 20)
            {
                twnny = amount % 20;
                twnny = (amount - twnny) / 20;
                amount = amount - (twnny * 20);
                Console.WriteLine(" @@@ " + twnny + " @@@ " + amount);
            }

            if(amount == 0 )
            {
                return works = true;

            }
            else
            {
                return works;
            }
            
           
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            attempt = "";
            lbDisplay2.Text = "";
            this.ActiveControl = tbOutput;

        }

        private void btbalance_Click(object sender, EventArgs e)
        {
            lbDisplay.Text = "Your Balance is: ";
            lbDisplay2.Text = "$" + balance1.ToString() ;
        }

        private void btWithdrawl_Click(object sender, EventArgs e)
        {
            lbDisplay2.Text = "...";

            lbDisplay.Text = "How much would you like to withdrawl?";
            this.ActiveControl = tbOutput;
            //get balance out of textview and perform withdrwal
            tbOutput.Clear();
            attempt = tbOutput.Text;
            
            withd = true;
        }

        private void btDeposit_Click(object sender, EventArgs e)
        {
            lbDisplay.Text = "How much would you like to deposit?";
            this.ActiveControl = tbOutput;
            lbDisplay2.Text = "...";
            tbOutput.Clear();
            attempt = tbOutput.Text;
            depd = true;
        }


        //When You click cancel
        private void btCancel_Click(object sender, EventArgs e)
        {

            attempt = "";
            tbOutput.Clear();
            lbDisplay.Text = "Please Enter your pin: ";
            lbDisplay2.Text = "...";
            this.ActiveControl = tbOutput;
            btbalance.Enabled = false;
            btCancel.Enabled = false;
            btWithdrawl.Enabled = false;
            btDeposit.Enabled = false;
            pind = true;

        }






        private void tbOutput_KeyDown(object sender, KeyEventArgs e)
        {


            //Key down opperations for Color
            switch (e.KeyCode)
            {
                case Keys.D1:
                    attempt += "1";
                    button_1.BackColor = Color.Gray;
                    break;

                case Keys.NumPad1:
                    attempt += "1";
                    button_1.BackColor = Color.Gray;

                    break;
                case Keys.D2:
                    attempt += "2";
                    button_2.BackColor = Color.Gray;

                    break;

                case Keys.NumPad2:
                    attempt += "2";
                    button_2.BackColor = Color.Gray;

                    break;
                case Keys.D3:
                    attempt += "3";

                    button_3.BackColor = Color.Gray;
                    break;

                case Keys.NumPad3:
                    attempt += "3";
                    button_3.BackColor = Color.Gray;

                    break;
                case Keys.D4:
                    attempt += "4";

                    button_4.BackColor = Color.Gray;
                    break;

                case Keys.NumPad4:
                    attempt += "4";
                    button_4.BackColor = Color.Gray;

                    break;
                case Keys.D5:
                    attempt += "5";
                    button_5.BackColor = Color.Gray;
                    break;

                case Keys.NumPad5:
                    attempt += "5";
                    button_5.BackColor = Color.Gray;

                    break;
                case Keys.D6:
                    attempt += "6";
                    button_6.BackColor = Color.Gray;
                    break;

                case Keys.NumPad6:
                    attempt += "6";
                    button_6.BackColor = Color.Gray;

                    break;
                case Keys.D7:
                    attempt += "7";
                    button_7.BackColor = Color.Gray;
                    break;

                case Keys.NumPad7:
                    attempt += "7";
                    button_7.BackColor = Color.Gray;

                    break;
                case Keys.D8:
                    attempt += "8";
                    button_8.BackColor = Color.Gray;
                    break;

                case Keys.NumPad8:
                    attempt += "8";
                    button_8.BackColor = Color.Gray;

                    break;
                case Keys.D9:
                    attempt += "9";
                    button_9.BackColor = Color.Gray;
                    break;

                case Keys.NumPad9:
                    attempt += "9";
                    button_9.BackColor = Color.Gray;

                    break;
                case Keys.D0:
                    attempt += "0";
                    button_0.BackColor = Color.Gray;
                    break;

                case Keys.NumPad0:
                    attempt += "0";
                    button_0.BackColor = Color.Gray;
                    break;
            }
            if (e.KeyCode == Keys.Enter)
                btEnter.PerformClick();

            Console.WriteLine(attempt);
            if (!pind)
            {
                lbDisplay2.Text = attempt;
            }
           


        }

        private void tbOutput_KeyUp(object sender, KeyEventArgs e)
        {
            //Key up opperations for color
            switch (e.KeyCode)
            {

                case Keys.D1:

                    button_1.BackColor = SystemColors.ButtonFace;
                    break;

                case Keys.NumPad1:
                    button_1.BackColor = SystemColors.ButtonFace;

                    break;
                case Keys.D2:

                    button_2.BackColor = SystemColors.ButtonFace;
                    break;

                case Keys.NumPad2:
                    button_2.BackColor = SystemColors.ButtonFace;

                    break;
                case Keys.D3:

                    button_3.BackColor = SystemColors.ButtonFace;
                    break;

                case Keys.NumPad3:
                    button_3.BackColor = SystemColors.ButtonFace;

                    break;
                case Keys.D4:

                    button_4.BackColor = SystemColors.ButtonFace;
                    break;

                case Keys.NumPad4:
                    button_4.BackColor = SystemColors.ButtonFace;

                    break;
                case Keys.D5:

                    button_5.BackColor = SystemColors.ButtonFace;
                    break;

                case Keys.NumPad5:
                    button_5.BackColor = SystemColors.ButtonFace;

                    break;
                case Keys.D6:

                    button_6.BackColor = SystemColors.ButtonFace;
                    break;

                case Keys.NumPad6:
                    button_6.BackColor = SystemColors.ButtonFace;

                    break;
                case Keys.D7:

                    button_7.BackColor = SystemColors.ButtonFace;
                    break;

                case Keys.NumPad7:
                    button_7.BackColor = SystemColors.ButtonFace;

                    break;
                case Keys.D8:

                    button_8.BackColor = SystemColors.ButtonFace;
                    break;

                case Keys.NumPad8:
                    button_8.BackColor = SystemColors.ButtonFace;

                    break;
                case Keys.D9:

                    button_9.BackColor = SystemColors.ButtonFace;
                    break;

                case Keys.NumPad9:
                    button_9.BackColor = SystemColors.ButtonFace;

                    break;
                case Keys.D0:

                    button_0.BackColor = SystemColors.ButtonFace;
                    break;

                case Keys.NumPad0:
                    button_0.BackColor = SystemColors.ButtonFace;

                    break;


            }
        }

       
    }
}
