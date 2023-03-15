using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Animals
    {
        public string name;
        public int count;
        public Animals(string name, int count)
        {
            this.name = name;
            this.count = count;
        }
        virtual public void PrintInfoAboutAnimal()
        {
            Console.WriteLine($"Название животного: '{name}' На планете их осталось: {count}");
        }
    }
}
