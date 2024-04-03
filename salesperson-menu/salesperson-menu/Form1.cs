using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace salesperson_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
                totalTBox.Font = fd.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                totalTBox.BackColor = cd.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameTBox.Text = "";
            SalesTBox.Text = "";

            NameTBox.Focus();
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if(superCheckBox.Checked)
            {
                Supervisor s = new Supervisor(NameTBox.Text, Convert.ToDouble(SalesTBox.Text));
                Program.Person.Add(s);
                totalTBox.Text = s.CalculateTotalPay().ToString("0.00");
            }
            else
            {
                Person tmp = new Person(NameTBox.Text, Convert.ToDouble(SalesTBox.Text));
                Program.Person.Add(tmp);

                totalTBox.Text = "" + tmp.CalculateTotalPay().ToString("0.00");
            }
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SummaryForm().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Boolean ValidateInput()
        {
            if (NameTBox.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }

            Regex regex = new Regex(@"^\d*\.?\d+$");

            if (SalesTBox.Text == "")
            {
                MessageBox.Show("Please enter a sales amount.");
                return false;
            }
            else if(!regex.IsMatch(SalesTBox.Text))
            {
                MessageBox.Show("Please enter a valid sales amount.");
                return false;
            }

            return true;
        }
    }
}
