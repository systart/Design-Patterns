namespace TasarimDesenleri.GoFPatterns.CreationalClasses.BuilderExample
{
    public abstract class PizzaBuilder
    {
        protected Pizza Pizza;

        public Pizza GetPizza()
        {
            return Pizza;
        }

        public void CreateNewPizzaProduct()
        {
            Pizza = new Pizza();
        }

        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();
    }
}
