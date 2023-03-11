namespace task_3
{
     public class MyList<T>
     {
        public int index = 0;
        public T[] Values = new T[0];

        public void Add(T value)
        {
           Array.Resize(ref Values, index + 1);

           Values[index] = value;
           index++;
        }
        public T this[int index]
        {
           get => Values[index];
        }

        public int Length
        {
                get => Values.Length;
        }
     }
}