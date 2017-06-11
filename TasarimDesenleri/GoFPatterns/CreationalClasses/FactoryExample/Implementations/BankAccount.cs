using System;
using TasarimDesenleri.GoFPatterns.CreationalClasses.FactoryExample.Interfaces;

namespace TasarimDesenleri.GoFPatterns.CreationalClasses.FactoryExample.Implementations
{
    class BankAccount : IPay
    {
        public bool MakePayment()
        {
            return this.MakePaymentWithBA();
        }

        private bool MakePaymentWithBA()
        {
            Console.WriteLine("Payment completed with bank account.");
            return true;
        }
    }
}
