using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfValue
{
    public class PaymentPerHour : WorkData
    {
        
        private double payment;
        private int hours;
     
        public PaymentPerHour(int code, string type, double payment, int hours) : base(code, type)
        {
            Payment = payment;
            Hours = hours;
        }

        public double Payment
        {
            get { return payment; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Your payment can not be negative or neutral!");
                }
                payment = value;
            }
        }
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value < 0) 
                {
                    throw new ArgumentNullException("You should have at least 1 hour!");
                }
                hours = value;
            }
        }

        public override void Print()
        {
            Console.WriteLine($"Work code and type -> {Code}, {Type}");
            Console.WriteLine($"Working hours - payment -> {Hours} - {Payment}");
        }

    }
}
