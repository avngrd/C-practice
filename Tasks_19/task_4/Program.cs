using System;
using System.Collections;

namespace MyNameSpace
{
    class Program
    {
        static void Main()
        {
      
            Hashtable musicTable = new Hashtable();
            musicTable.Add("Крутой парень","грустная песня");
            musicTable.Add("Артур Гугл", "Соната о биткоине");
            musicTable.Add("Весельчаки", "лето");
            musicTable.Add("Красная шапочка", "балконы");

            Console.WriteLine("Введите номер операции 1 - просмотр всего исполнителей, 2 -  просмотр всех песен каталога, 3 - Добавление в каталог, 4 - Удаление из каталога ");
            int chosenOperation = Convert.ToInt32(Console.ReadLine());

            switch (chosenOperation)
            {
                case 1:
                    foreach (string key in musicTable.Keys)
                    {
                        Console.WriteLine(key);
                    }
                    break;
                case 2:
                    foreach (string value in musicTable.Values)
                    {
                        Console.WriteLine(value);
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите исполнителя: ");
                    string singer = Console.ReadLine();
                    Console.WriteLine("Введите название трека: ");
                    string track = Console.ReadLine();
                    musicTable.Add(singer, track);
                    break;
                case 4:
                    Console.WriteLine("Введите исполнителя которого хотите удалить: ");
                    string deleteSinger = Console.ReadLine();
                    musicTable.Remove(deleteSinger);
                break;
                    default:Console.WriteLine("Такой операции не существует");break;
            }
        }
    }
}