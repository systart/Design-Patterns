namespace TasarimDesenleri.GoFPatterns.CreationalClasses.SingletonExample
{
    public class SingletonSinif
    {
        private static SingletonSinif _singletonObj;
        private static readonly object LockObject = new object();
        private SingletonSinif() {; }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public static SingletonSinif GetInstance()
        {
            if (_singletonObj == null)
            {
                lock (LockObject)
                {
                    if (_singletonObj == null)
                    {
                        _singletonObj = new SingletonSinif();
                    }
                }
            }
            return _singletonObj;
        }
    }
}
