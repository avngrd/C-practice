using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {



            Calculate x0 = new Calculate(5);
            Calculate x1 = new Calculate(12);

            x0.bF0();

            x0.IxF0(10);
            x1.IxF1();

            x0.F0(5);
            x1.F1();
            (x0 as Iy).F0(7);
            (x1 as Iz).F1();
        }

        interface Ix
        {
            void IxF0(int xKey);
            void IxF1();
        }

        interface Iy
        {
            void F0(int xKey);
            void F1();
        }

        interface Iz
        {
            void F0(int xKey);
            void F1();
        }

        interface Iw
        {
            void F0(int xKey);
            void F1();
        }

        class Calculate : Ix, Iy, Iz, Iw
        {
            public int xVal;

            public Calculate() { xVal = 5; }

            public Calculate(int key)
            {
                xVal = key;
            }
            public void IxF0(int key)
            {
                xVal = Convert.ToInt32(Math.Cos(key));
                Console.WriteLine("IxF0({0})...", xVal);
            }
            public void IxF1()
            {
                xVal = Convert.ToInt32(Math.Cos(xVal));
            }
            public void F0(int xKey)
            {
                xVal = (int)Math.Exp(xKey);
                Console.WriteLine("(Iy/Iz)F0({0})...", xVal);
            }
            public void F1()
            {
                xVal = (int)Math.Exp(xVal);
            }

            void Iw.F0(int xKey) {
                xVal = (int)Math.Exp(xKey);
            }
            void Iw.F1()
            {
                xVal = Convert.ToInt32( 1 / Math.Exp(xVal));
            }
            public void bF0()
            {
                Console.WriteLine("bf0()...");
            }
        }
    }
}

//ixf0,ixf1 - Cos(w)
//iy - exp(w)
//iz - 1/exp(w)
