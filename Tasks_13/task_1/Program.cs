using task_1;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int arraySize = 2;
            Product[] products = new Product[arraySize];
            Console.WriteLine("Выберите создаваемый обьект: ");
            int chosenObject = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            decimal priceBread = 0;
            decimal priceMeat = 0;
            decimal SrPriceBread;
            decimal SrPriceMeat;

            while (i < arraySize)
            {
                switch (chosenObject)
                {
                    case 1:
                        products[i] = new Product(); ++i; break;
                    case 2:
                        Bread bread = new Bread();
                        bread.BreadPrice();
                        priceBread = priceBread + bread.price;
                        products[i] = bread as Product; ++i; break;
                    case 3:
                        Meat meat = new Meat();
                        meat.MeatPrice();
                        priceMeat = priceMeat + meat.price;
                        products[i] = meat as Product; ++i; break;
                    default: Console.WriteLine("Выбранного пункта не существует"); break;
                }
            }
            for(int t = 0; t < products.Length; t++)
            {
                if(products[t] != null)
                {
                    products[t].GetInfo();
                }
            }
            SrPriceBread = priceBread / arraySize;
            SrPriceMeat = priceMeat / arraySize;

            if (SrPriceBread == 0)
            {
                Console.WriteLine("Средняя стоимость:{0}", SrPriceMeat);
            }
            else
            {
                Console.WriteLine("Средняя стоимость:{0}", SrPriceBread);
            }
            Console.ReadLine();
        }
    }
}