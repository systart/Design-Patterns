using TasarimDesenleri.GoFPatterns.CreationalClasses.FactoryExample.Implementations;
using TasarimDesenleri.GoFPatterns.CreationalClasses.FactoryExample.Interfaces;

namespace TasarimDesenleri.GoFPatterns.CreationalClasses.FactoryExample
{
    public class PaymentFactory
    {
        public IPay CreatePaymentObject(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.CreditCard: return new CreditCard();
                case PaymentType.BankAccount: return new BankAccount();
                default: return new CreditCard();
            }
        }
    }
}
