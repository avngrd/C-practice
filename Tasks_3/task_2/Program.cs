using static MyNamespace.Program;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
           Mammal animal = new Mammal();
            animal.MammalCheck();
        }

        public class Animal
        {
            public string animalName;
            public void InputAnimallName()
            {
                Console.WriteLine("Введите название животного");
                animalName = Console.ReadLine();
                Console.WriteLine($"Название животного:{animalName}");
            }
        }
        // Классы выносим в отдельные файлы. например Bird.cs
        // в редких случаях допускается использование нескольких классов в одном файле, но это исключение
        public class Bird : Animal
        {
            public bool isBird;
            public int isBirdCheck;

            public void BirdCheck()
            {
                //Выносим класс Console и его методы в метод Main класса Program
                Console.WriteLine($"{this.animalName} - Является птицей?(1 - да, 0 - нет)");
                isBirdCheck = Convert.ToInt32(Console.ReadLine());
                if (isBirdCheck == 0)
                {
                    isBird = false;
                    Console.WriteLine($"{this.animalName} - не птица");

                }
                else if (isBirdCheck == 1)
                {
                    isBird = true;
                    Console.WriteLine($"{this.animalName} - птица");
                }
                else
                {
                    Console.WriteLine("Вы ввели не правильное значение");
                }
            }
        }
        public class Artiodactyl : Bird
        {
           public bool isArtiodactyl;
            int isArtiodactylCheck;

            public void CheckArtiodactyl()
            {
                Console.WriteLine($"{this.animalName} - Парнокопытное?(1 - да, 0 - нет)");
                isArtiodactylCheck = Convert.ToInt32(Console.ReadLine());
                if (isArtiodactylCheck == 0)
                {
                    isArtiodactyl = false;
                    Console.WriteLine($"Парнокопытное - {isArtiodactyl}");
                    
                }
                else if (isArtiodactylCheck == 1)
                {
                    isArtiodactyl = true;
                    Console.WriteLine($"Парнокопытное - {isArtiodactyl}");
                }
                else
                {
                    Console.WriteLine("Вы ввели не правильное значение");
                }
            }
        }
        public class Mammal:Artiodactyl
        {
            bool isMammal;
            int isMammalCheck;

            public void MammalCheck()
            {
                this.InputAnimallName();
                this.BirdCheck();
                this.CheckArtiodactyl();

                Console.WriteLine($"{this.animalName} - Млекопитающее?(1 - да, 0 - нет)");
                isMammalCheck = Convert.ToInt32(Console.ReadLine());
                if (isMammalCheck == 0)
                {
                    isMammal = false;
                    Console.WriteLine($"Млекопитающее - {isMammal}");
                }
                else if (isMammalCheck == 1)
                {
                    isMammal = true;
                    Console.WriteLine($"Млекопитающее - {isMammal}");
                }
                else
                {
                    Console.WriteLine("Вы ввели не правильное значение");
                }
                Console.WriteLine($"Животное - {this.animalName}, Птица - {this.isBird}, Парнокопытное - {this.isArtiodactyl}, Млекопитающее - {this.isMammal}");
            }
        }
    }
}
