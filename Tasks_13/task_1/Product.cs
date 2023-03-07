namespace task_1
{
    internal class Product
    {
        public string name;

        public Product()
        {
            this.name = null;
        }

        public virtual void Input()
        {
            Console.WriteLine("Введите название продукта");
            name = Console.ReadLine();
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Название:{0}", name);
        }
    }
}
