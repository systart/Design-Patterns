using System;
using System.Collections.Generic;
using TasarimDesenleri.GoFPatterns.CreationalClasses.AbstractFactoryExample;
using TasarimDesenleri.GoFPatterns.CreationalClasses.AbstractFactoryExample.Implementations;
using TasarimDesenleri.GoFPatterns.CreationalClasses.AbstractFactoryExample.Interfaces;
using TasarimDesenleri.GoFPatterns.CreationalClasses.BuilderExample;
using TasarimDesenleri.GoFPatterns.CreationalClasses.BuilderExample.Implementations;
using TasarimDesenleri.GoFPatterns.CreationalClasses.FactoryExample;
using TasarimDesenleri.GoFPatterns.CreationalClasses.FactoryExample.Interfaces;
using TasarimDesenleri.GoFPatterns.CreationalClasses.PrototypeExample;
using TasarimDesenleri.GoFPatterns.CreationalClasses.PrototypeExample.Implementations;
using TasarimDesenleri.GoFPatterns.CreationalClasses.PrototypeExample.Interfaces;
using TasarimDesenleri.GoFPatterns.CreationalClasses.SingletonExample;
using TasarimDesenleri.GoFPatterns.StructuralClasses.AdapterExample.Implementations;
using TasarimDesenleri.GoFPatterns.StructuralClasses.AdapterExample.Interfaces;
using TasarimDesenleri.GoFPatterns.StructuralClasses.BridgeExample;
using TasarimDesenleri.GoFPatterns.StructuralClasses.DecoratorExample.Implementations;
using TasarimDesenleri.GoFPatterns.StructuralClasses.DecoratorExample.Interfacces;
using TasarimDesenleri.GoFPatterns.StructuralClasses.FacadeExample;

namespace TasarimDesenleri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CreationalPatterns                     

            #region SingletonClassExample
            /*          
            SingletonSinif hede = SingletonSinif.GetInstance();
            hede.Ad = "Efe";
            hede.Soyad = "Kan";
            Console.WriteLine(hede.Ad + hede.Soyad);
            SingletonSinif asd = SingletonSinif.GetInstance();
            Console.WriteLine(asd.Ad + asd.Soyad);
            */
            #endregion

            #region FactoryClassExample
            /*
            PaymentFactory paymentFactory = new PaymentFactory();
            IPay payment = paymentFactory.CreatePaymentObject(PaymentType.CreditCard);
            payment.MakePayment();
            payment = paymentFactory.CreatePaymentObject(PaymentType.BankAccount);
            payment.MakePayment();
            */
            #endregion

            #region AbstractFactoryClassExample
            /*
            CarFactory carFactory = new BmwFactory();
            ICar bmwCar = carFactory.CreateCar();
            bmwCar.MoveForward();
            bmwCar.Stop();
            carFactory = new AudiFactory();
            ICar audiCar = carFactory.CreateCar();
            audiCar.MoveForward();
            audiCar.Stop();
            */
            #endregion

            #region BuilderClassExample
            /*
            Waiter waiter1 = new Waiter();
            PizzaBuilder hawaiianPizzabuilder = new HawaiianPizzaBuilder();
            waiter1.SetPizzaBuilder(hawaiianPizzabuilder);
            waiter1.ConstructPizza();
            Pizza hawaiianPizza = waiter1.GetPizza();
            hawaiianPizza.ShowProperties();
            Waiter waiter2 = new Waiter();
            PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
            waiter2.SetPizzaBuilder(spicyPizzaBuilder);
            waiter2.ConstructPizza();
            Pizza spicyPizza = waiter2.GetPizza();
            spicyPizza.ShowProperties();
            */
            #endregion

            #region PrototypeClassExample
            /*
            PrototypeModule.AddPrototype(new PrototypeAlpha());
            PrototypeModule.AddPrototype(new PrototypeBeta());
            PrototypeModule.AddPrototype(new ReleasePrototype());
            List<IPrototype> prototypes = new List<IPrototype>();
            string[] names = { "AlphaVersion", "BetaVersion", "ReleaseCandidate" };
            foreach (var protoName in names)
            {
                IPrototype prototype = PrototypeModule.CreatePrototype(protoName);
                if (prototype != null)
                {
                    prototypes.Add(prototype);
                }
            }
            foreach (IPrototype p in prototypes)
            {
                p.Execute();
            }
            */
            #endregion

            #endregion

            #region StructuralPatterns

            #region FacadeClassExample
            /*
            // Ref: https://sourcemaking.com/design_patterns/facade
            Line lineA = new Line(new Point(2, 4), new Point(5, 7));
            lineA.Move(-2, -4);
            Console.WriteLine("after move:  " + lineA);
            lineA.Rotate(45);
            Console.WriteLine("after rotate: " + lineA);
            Line lineB = new Line(new Point(2, 1), new Point(2.866, 1.5));
            lineB.Rotate(30);
            Console.WriteLine("30 degrees to 60 degrees: " + lineB);
            */
            #endregion

            #region AdapterClassExample

            /*
            ILogger logger = new FileLogger();
            logger.SaveLog("Data1");
            logger = new DatabaseLogger();
            logger.SaveLog("Data2");
            logger = new LoggerAdapter();
            logger.SaveLog("Data3");
            */

            #endregion

            #region BridgeClassExample
            /*
            StackArray[] stacks = { new StackArray(), new StackFifo(), new StackHanoi() };
            StackList stackList = new StackList();
            for (int i = 1, num; i < 15; i++)
            {
                stacks[0].Push(i);
                stackList.Push(i);
                stacks[1].Push(i);
            }
            Random rn = new Random();
            for (int i = 1, num; i < 15; i++)
            {
                stacks[2].Push(rn.Next(20));
            }
            while (!stacks[0].IsEmpty())
            {
                Console.Write(stacks[0].Pop() + "  ");
            }
            Console.WriteLine();
            while (!stackList.IsEmpty())
            {
                Console.Write(stackList.Pop() + "  ");
            }
            Console.WriteLine();
            while (!stacks[1].IsEmpty())
            {
                Console.Write(stacks[1].Pop() + "  ");
            }
            Console.WriteLine();
            while (!stacks[2].IsEmpty())
            {
                Console.Write(stacks[2].Pop() + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("total rejected is " + ((StackHanoi)stacks[2]).reportRejected());
            */
            #endregion

            #region DecoratorClassExample
            /*
            IDecoratorInterface[] array = {new X(new A()), new Y(new X(new A())),
                new Z(new Y(new X(new A())))};
            foreach (IDecoratorInterface anArray in array)
            {
                anArray.DoIt();
                Console.Write("  ");
            }
            */
            #endregion

            #endregion
        }
    }
}
