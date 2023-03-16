using System.Text;

class Program
{
    private string nameOfProduct;
    private string nameOfStore;
    private int priceOfProduct;

    static void Main(string[] args)
    {
        var count = 3;
        Product[] products = new Product[count];
        var creater = new ProductCreator();
        for (int i = 0; i < count; i++)
        {
            products[i] = creater.Create();
        }
        var stock = new Stock(products);

        foreach (var product in stock.Products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine(stock);
    }

    /// <summary>
    /// Created class Product with getters and setters
    /// </summary>

    internal class Product
    {
        public string Name { get; set; }
        public string StoreName { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"Название товара: {Name} - Магазин: {StoreName} - Цена: {Price}";
        }
    }

    /// <summary>
    /// Created class ProductCreator to create products
    /// </summary>

    internal class ProductCreator
    {
        /// <summary>
        /// Method of creating product with entered data
        /// </summary>
        /// <returns>
        /// returns products with entered data
        /// </returns>

        public Product Create()
        {
            var product = new Product();
            Console.WriteLine("Введите название товара");
            product.Name = Console.ReadLine();
            Console.WriteLine("Введите название магазина");
            product.StoreName = Console.ReadLine();
            Console.WriteLine("Введите цену");
            product.Price = Convert.ToDecimal(Console.ReadLine());

            return product;
        }
    }

    /// <summary>
    /// Created class stock when we store Product[]
    /// </summary>

    internal class Stock
    {
        private Product[] products;
        public Product[] Products => products;
        public Stock(Product[] products)
        {
            this.products = products;
        }

        public Stock()
        {
            products = new Product[0];
        }

        /// <summary>
        /// Method to add product in Array Product[]
        /// </summary>

        public void Add(Product product)
        {
            products[0] = product;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in products)
            {
                sb.AppendLine(product.ToString());
            }
            return sb.ToString();
        }
    }
}