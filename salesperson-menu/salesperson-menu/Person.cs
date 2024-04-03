using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace salesperson_menu
{
    internal class Person
    {
        public string Name { get; set; }
        public double Sales { get; set; }

        public Person(string name, double sales)
        {
            Name = name;
            Sales = sales;
        }

        public virtual double CalculateTotalPay()
        {
            if (Sales >= Program.QUOTA)
                return Program.BASE_PAY + (Sales * Program.COMMISSION);

            return Program.BASE_PAY;
        }

        public virtual double CalculateCommission()
        {
            if (Sales >= Program.QUOTA)
                return Sales * Program.COMMISSION;

            return 0.0;
        }
    }
}
