using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillInheretinceLab14
{
    class TippableBill : Bill
    {
        public double Tip { get; set; }
        public TippableBill()
        {

        }

        public TippableBill(double subtotal, double taxRate, double tip)
            : base (subtotal,taxRate)
        {
            this.Tip = tip;
        }
        public override double CalcTotal()
        {
            double total = (Subtotal * (1 + TaxRate));
            total += Tip;
           // total = Math.Round(total, 2);
            return total;
        }
    }
}
