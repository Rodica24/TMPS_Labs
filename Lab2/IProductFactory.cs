namespace Laboratory2 {
public interface IProductFactory
    {
        Product CreateProduct(string name, double price);
    }

    public class ConcreteProductFactory : IProductFactory
    {
        public Product CreateProduct(string name, double price)
        {
            return new Product(name, price);
        }
    }
}