namespace MyNamespace
{
    class Program
    {
        struct ZNAK
        {
            public string name, surname, zodiacSign;
            public int[] birthday;
        }
        public static void Main()
        {
            ZNAK[] arr = new ZNAK[2];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите имя: ");
                arr[i].name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите фамилию: ");
                arr[i].surname = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите знак зодиака: ");
                arr[i].zodiacSign = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите дату рождения: ");
                arr[i].birthday = new int[3];
                for (int j = 0; j < arr[i].birthday.Length; j++)
                {
                    arr[i].birthday[j] = int.Parse(Console.ReadLine());
                }
            }

            Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("ZNAK" + " " + (i + 1) + ":");
                Console.WriteLine("Имя: " + arr[i].name);
                Console.WriteLine("Фамилия: " + arr[i].surname);
                Console.WriteLine("Знак зодиака: " + arr[i].zodiacSign);
                for (int j = 0; j < arr[i].birthday.Length; j++)
                {
                    Console.Write(arr[i].birthday[j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Введите фамилию человека:");
            string inputSurname = Console.ReadLine();
            personInformation(inputSurname, arr);
        }
        static bool isMin(ZNAK first, ZNAK second)
        {
            if (first.birthday[2] < second.birthday[2])
                return false;
            else if (first.birthday[2] > second.birthday[2])
                return true;
            else
            if (first.birthday[1] < second.birthday[1])
                return false;
            else if (first.birthday[1] > second.birthday[1])
                return true;
            else
            if (first.birthday[0] < second.birthday[0])
                return false;
            else if (first.birthday[0] > second.birthday[0])
                return true;
            else return false;
        }
        static void Sort(ZNAK[] arr)
        {
            ZNAK buf;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (isMin(arr[i], arr[j]))
                    {
                        buf = arr[i];
                        arr[i] = arr[j];
                        arr[j] = buf;
                    }
                }
            }
        }
        static void personInformation(string inputSurname, ZNAK[] arr)
        {
            for (int i = 0; i < arr.Length; i++) {
                if (inputSurname == arr[i].surname) {
                   Console.WriteLine("ZNAK" + " " + (i + 1) + ":");
                   Console.WriteLine("Имя: " + arr[i].name);
                   Console.WriteLine("Фамилия: " + arr[i].surname);
                   Console.WriteLine("Знак зодиака: " + arr[i].zodiacSign);
                    for (int j = 0; j < arr[i].birthday.Length; j++)
                    {
                        Console.Write(arr[i].birthday[j] + " ");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}