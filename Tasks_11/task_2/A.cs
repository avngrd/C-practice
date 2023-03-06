namespace task_2
{
    internal class A
    {
        protected internal int a, b;
        public A() { a = 3; b = 2; }
        protected internal  int c
        {
            get { return a / b; }
            set { c = value; }
        }
    }
}
