using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace salesperson_menu
{
    internal class Supervisor : Person
    {
        private const double BASE_PAY = 500.00;
        private const double COMMISSION = 0.2;
        private const int QUOTA = 2000;

        public Supervisor(string name, double sales) : base(name, sales)
        {
        }

        public override double CalculateTotalPay()
        {
            if (Sales >= QUOTA)
                return BASE_PAY + (Sales * COMMISSION);

            return BASE_PAY;
        }

        public override double CalculateCommission()
        {
            if (Sales >= QUOTA)
                return Sales * COMMISSION;

            return 0.0;
        }
    }
}
