using System.Security.Cryptography.X509Certificates;
using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            File file1 = new File(); 
            Console.WriteLine("Введите название файла: ");
            file1.Filename = Console.ReadLine();
            Console.WriteLine("Введите размер файла: ");
            file1.Lenghtfile = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату создания файла: ");
            file1.Creatingdata = Console.ReadLine();
            file1.WriteInfoFile();
            Console.ReadKey();
        }

        public class File
        {
            private string filename; 
            public string Filename
            {
                get { return filename; }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        filename = value;
                    }
                    filename = value;
                }
            }
            private double lenghtfile; 
            public double Lenghtfile
            {
                get { return lenghtfile; }
                set
                {
                    if (lenghtfile < 0)
                    {
                        Console.Write("Размер файла не может быть < 0 !");
                    }
                    else
                        lenghtfile = value;
                }
            }
            private string creatingdata;
            public string Creatingdata
            {
                get { return creatingdata; }
                set
                {
                    creatingdata = value;
                }
            }
            public void WriteInfoFile()
            {
                Console.WriteLine(filename, lenghtfile, creatingdata);
            }

        }
    }

    
}
