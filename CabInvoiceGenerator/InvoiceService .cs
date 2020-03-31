using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceService
    {
        int costPerMinute = 1;
        double costPerKilometer = 10;
        double minimumFare = 5;
        
        public double CalculateFare(double distance, double time)
        {
            double totalFare = distance * costPerKilometer + time * costPerMinute;
            if(totalFare>minimumFare)
            {
                return totalFare;
            }
            return minimumFare;

        }
    }
}
