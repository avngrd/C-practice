using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class InfoObj
    {
        public static void Info<tip>(tip obj)
       where tip : Animals
        {
            obj.PrintInfoAboutAnimal();
        }
    }
}
