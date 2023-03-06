namespace task_1
{
    internal abstract class Product
    {
        public int count;
        public decimal price;

        public Product(int count, decimal price)
        {
            this.count = count;
            this.price = price;
        }

        internal virtual decimal Price() { 
            int finalPrice = count * Convert.ToInt32((price));
            return finalPrice;
        }
    }
}
