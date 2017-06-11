namespace TasarimDesenleri.GoFPatterns.CreationalClasses.BuilderExample.Implementations
{
    public class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            Pizza.SetDough("pan baked");
        }

        public override void BuildSauce()
        {
            Pizza.SetSauce("hot");
        }

        public override void BuildTopping()
        {
            Pizza.SetTopping("pepperoni+salami");
        }
    }
}
