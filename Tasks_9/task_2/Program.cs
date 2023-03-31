using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Employees sergey = Employees.Sergey;
            Employees vadim = Employees.Vadim;
            Employees alex = Employees.Alex;
            Employees artur = Employees.Artur;
            Employees evegeniy = Employees.Evgeniy;
            Employees maxim = Employees.Maxim;
            Employees david = Employees.David;

            string[] employeersNames = { "sergey", "vadim", "alex", "artur", "evgeniy", "maxim", "david" };
            printAllEmployers(employeersNames);

            Console.WriteLine("Введите имя сотрудника о котором хотите узнать информацию(для выходы из программы напишите exit): ");
            string employeeChecker = Console.ReadLine();

            if (Enum.TryParse(typeof(Employees), employeeChecker, out Employees currentEmployee)) ;
            {
                currentEmployee =(Employees)Enum.Parse(typeof(Employees), employeeChecker);
            }
            switch(employeeChecker){
                case "sergey":
                    EmployeeInformation(sergey);
                    break;
                case "vadim":
                    EmployeeInformation(vadim);
                    break;
                case "alex":
                    EmployeeInformation(alex);
                    break;
                case "artur":
                    EmployeeInformation(artur);
                    break;
                case "evgeniy":
                    EmployeeInformation(evegeniy);
                    break;
                case "maxim":
                    EmployeeInformation(maxim);
                    break;
                case "david":
                    EmployeeInformation(david);
                    break;
                case "exit:":
                    break;
            }
        }

        enum Employees
        {
            Sergey = 10,
            Vadim = 20,
            Alex = 5,
            Artur = 15,
            Evgeniy = 19,
            Maxim = 30,
            David = 44,
        }

        static void EmployeeInformation(Employees employees)
        {
            switch (employees)
            {
                case Employees.Sergey:
                    Console.WriteLine($"Сотруднику {Employees.Sergey} требуется отработать:{(int)Employees.Sergey} часов за месяц");
                    break;
                case Employees.Vadim:
                    Console.WriteLine($"Сотруднику {Employees.Vadim} требуется отработать:{(int)Employees.Vadim} часов за месяц");
                    break;
                case Employees.Alex:
                    Console.WriteLine($"Сотруднику {Employees.Alex} требуется отработать:{(int)Employees.Alex} часов за месяц");
                    break;
                case Employees.Artur:
                    Console.WriteLine($"Сотруднику {Employees.Artur} требуется отработать:{(int)Employees.Artur} часов за месяц");
                    break;
                case Employees.Evgeniy:
                    Console.WriteLine($"Сотруднику {Employees.Evgeniy} требуется отработать:{(int)Employees.Evgeniy} часов за месяц");
                    break;
                case Employees.Maxim:
                    Console.WriteLine($"Сотруднику {Employees.Maxim} требуется отработать:{(int)Employees.Maxim} часов за месяц");
                    break;
                case Employees.David:
                    Console.WriteLine($"Сотруднику {Employees.David} требуется отработать:{(int)Employees.David} часов за месяц");
                    break;
            }
        }
        static void printAllEmployers(string[] arr)
        {
            Console.WriteLine("Все сотрудники:");
            for (int i = 0; i < arr.Length;i++) {
            Console.WriteLine(i+"."+arr[i]);
            }
        }
    }
}