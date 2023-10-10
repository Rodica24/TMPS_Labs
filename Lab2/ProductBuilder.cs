namespace Laboratory2{
    public class ProductBuilder
        {
            private string name;
            private double price;

            public ProductBuilder WithName(string name)
            {
                this.name = name;
                return this;
            }

            public ProductBuilder WithPrice(double price)
            {
                this.price = price;
                return this;
            }

            public Product Build()
            {
                return new Product(name, price);
            }
        }
}