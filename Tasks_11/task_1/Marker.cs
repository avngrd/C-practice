namespace task_1
{
    internal class Marker:Product
    {
        public string name;
        public int sort;

        public Marker(string name, int sort, int count, decimal price) : base(count, price)
        {
            this.name = name;
            this.sort = sort;
        }

        internal override decimal Price() {
            decimal totalPrice = base.Price() / (decimal) Math.Sqrt(sort);
           
            return totalPrice;
        }
    }
}
