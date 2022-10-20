namespace sorting_algorithms
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void SelectionSort(ref int[] array)
        {
            int minIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(ref array[i], ref array[minIndex]);
            }
        }

        static void InsertionSort(ref int[] array)
        {
            int i = 1, j = 1;
            while (i < array.Length)
            {
                j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    Swap(ref array[j], ref array[j - 1]);
                    j--;
                }
                i++;
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 5, 1, 4, 0};
            
            SelectionSort(ref array);
            //InsertionSort(ref array);

            foreach (int i in array) Console.WriteLine(i);
            
        }
    }
}