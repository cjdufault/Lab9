using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBill
{
    class WaterBillAnalysis
    {
        public double SumQuarterlyBills(List<double> quarters)
        {
            // add up all of the values
            double total = 0;
            foreach (double value in quarters)
            {
                total += value;
            }
            return total;
        }

        public double AvgQuarterlyBill(List<double> quarters)
        {
            double total = SumQuarterlyBills(quarters);
            return total / quarters.Count;
        }
    }
}
