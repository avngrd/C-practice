using System.Xml.Serialization;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            FileStream file = new FileStream(@"f.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string line;
            int n = 0;

            while ((line = reader.ReadLine()) != null)
            {
                n++;
            }
            reader.Close();

            string file2 = "text2.txt";
            string file3 = "text3.txt";
            int[] numbersArray = new int[n];

            FileStream file1 = new FileStream(@"f.txt", FileMode.Open);
            StreamReader reader1 = new StreamReader(file1);
            for (int i = 0; i < n; i++)
            {
                numbersArray[i] = Convert.ToInt32(reader1.ReadLine());
                Console.WriteLine(numbersArray[i]);
            }
            reader1.Close();

            int stringArraysSize = numbersArray.Length;

            string[] even = new string[stringArraysSize];
            string[] odd = new string[stringArraysSize];

            for (int i = 0; i < n; i++)
            {
                if(numbersArray[i] % 2 == 0)
                {
                    even[i] += Convert.ToString(numbersArray[i]);
                }
                else if(numbersArray[i] % 2 != 0)
                {
                    odd[i] += Convert.ToString(numbersArray[i]);
                }
            }
            File.WriteAllLines(file2,even);
            File.WriteAllLines(file3,odd);
        }
    }
}