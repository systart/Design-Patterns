using System;

namespace TasarimDesenleri.GoFPatterns.CreationalClasses.BuilderExample
{
    public class Pizza
    {
        private string _dough = "";
        private string _sauce = "";
        private string _topping = "";

        public void SetDough(string dough)
        {
            this._dough = dough;
        }

        public void SetSauce(string sauce)
        {
            this._sauce = sauce;
        }

        public void SetTopping(string topping)
        {
            this._topping = topping;
        }

        public void ShowProperties()
        {
            Console.WriteLine(this._dough + " " + this._sauce + " " + this._topping);
        }
    }
}
