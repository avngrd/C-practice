namespace MyNamespace
{
    class Program
    {
        delegate double CalcFigure(double number);

        public static void Main()
        {
            Console.WriteLine("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - длина окружности, 2 - площадь круга, 3 - обьем шара");
            int chooseOperation = Convert.ToInt32(Console.ReadLine());
            double result;
            
            switch (chooseOperation)
            {
                case 1:
                CalcFigure getLength = Get_Length;
                    result = getLength(radius);
                    Console.WriteLine(result);
                    break;
                case 2:
                CalcFigure getArea = Get_Area;
                    result = getArea(radius);
                    Console.WriteLine(result);
                    break;
                case 3:
                CalcFigure getVolume = Get_Volume;
                    result = getVolume(radius);
                    Console.WriteLine(result);
                    break;
            }
        }

        public static double Get_Length(double number)
        {
            return 2 * 3.14 * number;
        }

        public static double Get_Area(double number)
        {
            return 3.14 * number * number;
        }

        public static double Get_Volume(double number)
        {
            return (4/3) * 3.14 * number * number * number;
        }
    }
}