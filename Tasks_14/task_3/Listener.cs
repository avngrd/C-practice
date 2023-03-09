using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Listener
    {
        private string _name;

        public Listener(string name)
        {
            _name = name;
        }

        public void Listen(string message)
        {
            Console.WriteLine($"{_name} see: {message}");
        }
    }
}
