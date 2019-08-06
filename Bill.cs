using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillInheretinceLab14
{
    class Bill
    {
        public double Subtotal { get; set; }
        public double TaxRate { get; set; }

        public Bill(double subtotal, double taxRate)
        {
            Subtotal = subtotal;
            TaxRate = taxRate;
        }

        public Bill()
        {
        }
        public virtual double CalcTotal()
        {
            double total = (Subtotal * (1 + TaxRate));
            //total = Math.Round(total, 2);
            return total;
        }
    }
}
