namespace task_3
{
    public static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            for (int i = 0; i < list.Values.Length; i++)
            {
                Console.WriteLine(list.Values[i]);
            }
            return list.Values;
        }
    }
}
