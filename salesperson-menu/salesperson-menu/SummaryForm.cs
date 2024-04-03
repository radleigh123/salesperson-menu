using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace salesperson_menu
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();

            double sales = 0.0;
            double commission = 0.0;
            double pay = 0.0;

            foreach(Person p in Program.Person)
            {
                sales += p.Sales;
                commission += p.CalculateCommission();
                pay += p.CalculateTotalPay();
            }

            SalesL.Text = "$" + sales.ToString("0.00");
            ComL.Text = "$" + commission.ToString("0.00");
            PayL.Text = "$" + pay.ToString("0.00");
        }
    }
}
