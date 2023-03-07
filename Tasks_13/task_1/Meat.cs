namespace task_1
{
    internal class Meat:Product
    {
        public int sort;
        public int gramms;
        public decimal price;

        public Meat()
        {
            this.sort = 0;
            this.gramms = 0;
            Input();
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Введите сорт(1-3):");
            sort = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void MeatPrice()
        {
            price = Convert.ToDecimal(sort * gramms * price);
        }
        public override void GetInfo()
        {
            MeatPrice();
            Console.WriteLine("Название:{0} \n Сорт:{1} \n Граммы:{2} \n Стоимость:{3}", name,sort,gramms,price);
        }
    }
}
