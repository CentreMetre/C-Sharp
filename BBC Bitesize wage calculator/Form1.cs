using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBC_Bitesize_wage_calculator
{
    public partial class Form1 : Form
    {
        
        /*void CalculateWage(double hoursWorked, ref double totalPay)
        {
            if (hoursWorked >= minHours && hoursWorked <= maxHours)
            {
                if (hoursWorked <= normalHours) //no overtime
                {
                    //no overtime
                    double totalPayNoSym = hoursWorked * hourlyRate;
                    string totalpay = "£" + Convert.ToString(totalPayNoSym);
                    lbl_total_pay_output.Text = Convert.ToString(totalPay);
                }
                else if (hoursWorked > normalHours)
                {
                    //there is overtime
                }
                else
                {
                    //Something has gone seriously wrong!
                }
            }
            else if (hoursWorked <= minHours || hoursWorked >= maxHours)
            {
                lbl_error_output.Text = "Sorry, that amount of hours isnt valid.";
            }
            else
            {
                //Something has gone seriously wrong!
            }
        }*/

        public Form1()
        {
            InitializeComponent();
        }
        //constants
        const double hourlyRate = 10.00;
        const double overtimeRate = 15.00;
        const int maxHours = 60;
        const int minHours = 1;
        const int normalHours = 40;

        //non-constant variables
        double hoursWorked = 0;
        double overtimeHours = 0;
        double normalPay;
        double overtimePay = 0;
        double totalPay = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //error not there, dimensions = 234, 201
            //error there, dimensions = 234, 248
        }

        private void btn_test1_Click(object sender, EventArgs e)
        {
            //lbl_error_output.Text = "Sorry, that amount of hours isnt valid.";
            //lbl_total_pay_output.Text = "£40";
            lbl_total_pay_output.Text = txtbox_hours_worked.Text;
        }

        private void lbl_hours_worked_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        { 
            //CalculateWage(hoursWorked, ref totalPay);
            lbl_error_output.Text = "";
            lbl_total_pay_output.Text = "£0";

            try
            {
                hoursWorked = double.Parse(txtbox_hours_worked.Text);
            }
            catch (FormatException)
            {
                lbl_error_output.Text = "Sorry, but that input is invalid.";
                Size = new Size(234, 248);
                return;
            }

            if (hoursWorked >= minHours)
            {
                if (hoursWorked <= maxHours)
                {
                    if (hoursWorked <= normalHours) //no overtime
                    {
                        //no overtime
                        normalPay = hoursWorked * hourlyRate;
                        totalPay = normalPay;
                        lbl_total_pay_output.Text = Convert.ToString("£" + totalPay);
                    }
                    else if (hoursWorked > normalHours) //There is overtime
                    {
                        //Minusing the overtime from the hours worked and wrking out the pay
                        overtimeHours = hoursWorked - normalHours;
                        overtimePay = overtimeHours * overtimeRate;

                        //working out normal pay
                        normalPay = normalHours * hourlyRate;
                        
                        //seting total pay
                        totalPay = normalPay + overtimePay;
                        lbl_total_pay_output.Text = Convert.ToString("£" + totalPay);
                    }
                    else
                    {
                        //Something has gone seriously wrong!
                    }
                }
                else if (hoursWorked >= maxHours)
                {
                    lbl_error_output.Text = "";
                    lbl_error_output.Text = "Sorry, that amount of hours is to many.";
                }
                else
                {
                    //Something has gone seriously wrong
                }
            }
            else if (hoursWorked <= minHours)
            {
                lbl_error_output.Text = "";
                lbl_error_output.Text = "Sorry, that amount of hours isn't enough.";
            }
            else
            {
                //Something has gone seriously wrong!
            }

            if (lbl_error_output.Text == "")
            {
                //error not there, dimensions = 234, 201
                Size = new Size(234, 201);
                
            }
            else if (lbl_error_output.Text != "")
            {
                //error there, dimensions = 234, 248
                Size = new Size(234, 248);
            }
            else
            {
                //something is wrong 
            }
        }
    }
}
