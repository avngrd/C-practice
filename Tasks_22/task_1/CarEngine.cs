using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class CarEngine
    {
        public bool empty;
        public bool filled;
        private static CarEngine uniqueState;

        private CarEngine()
        {
            empty = true;
            filled = false;
        }

        public static CarEngine getState()
        {

            if(uniqueState == null)
            {
                uniqueState = new CarEngine();
            }
            return uniqueState;
        }

        public void oilFill()
        {
            if (isEmpty())
            {
                empty = false;
                filled = false;
                Console.WriteLine("Заливаем масло в двигатель");
            }
        }

        public void oilCheck()
        {
            if(!isEmpty() && isFilled())
            {
                empty = true;
                filled = false;

                Console.WriteLine("Проверяем уровень масла");
            }
        }

        public void startEngine()
        {
            if (!isEmpty() && !isFilled())
            {
                filled = true;
                Console.WriteLine("Двигатель начинает заводится");
            }

        }

        public void engineState()
        {
            Console.WriteLine($"Двигатель пустой - {empty}, двигатель завелся - {filled}");
        }

        public bool isEmpty()
        {
            return empty;
        }

        public bool isFilled()
        {
            return filled;
        }
    }
}
