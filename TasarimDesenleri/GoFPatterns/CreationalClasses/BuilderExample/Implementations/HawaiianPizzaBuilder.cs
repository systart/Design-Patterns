namespace TasarimDesenleri.GoFPatterns.CreationalClasses.BuilderExample.Implementations
{
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            Pizza.SetDough("cross");
        }

        public override void BuildSauce()
        {
            Pizza.SetSauce("mild");
        }

        public override void BuildTopping()
        {
            Pizza.SetTopping("ham+pineapple");
        }
    }
}
