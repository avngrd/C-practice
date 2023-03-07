namespace task_1
{
    internal class Bread:Product
    {
        public int gramms;
        public string manufacturer;
        public decimal price;

        public Bread()
        {
            this.gramms = 0;
            this.manufacturer = null;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Введите количество грамм: ");
            gramms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите производителя: ");
            manufacturer = Console.ReadLine();
        }

        public virtual void BreadPrice()
        {
            price = gramms * (decimal)0.01;
        }

        public override void GetInfo()
        {
            BreadPrice();
            Console.WriteLine("Название:{0} \n Количество грамм:{1} \n Производитель:{2} \n Стоимость:{3}",name,gramms,manufacturer,price );
        }
    }
}
