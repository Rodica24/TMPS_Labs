namespace Laboratory2{
    public class Product : ICloneable
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public object Clone()
        {
            return new Product(Name, Price);
        }
    }
}
