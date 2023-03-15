using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Pl : IEnumerable
    {
        private ArrayList list;
        public Pl()
        {
            list = new ArrayList();
        }
        public Pl(ArrayList a)
        {
            list = a;
        }
        public void Add(Animals m)
        {
            list.Add(m);
        }
        public Pl Clone()
        {
            return new Pl(list);
        }
        public void RemoveAt(int i)
        {
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
