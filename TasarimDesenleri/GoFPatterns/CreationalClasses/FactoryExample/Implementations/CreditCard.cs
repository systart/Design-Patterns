using System;
using TasarimDesenleri.GoFPatterns.CreationalClasses.FactoryExample.Interfaces;

namespace TasarimDesenleri.GoFPatterns.CreationalClasses.FactoryExample.Implementations
{
    class CreditCard : IPay
    {
        public bool MakePayment()
        {
            return this.MakePaymentWithCC();
        }

        private bool MakePaymentWithCC()
        {
            Console.WriteLine("Payment completed with credit card.");
            return true;
        }
    }
}
