namespace Domashna151024
{
    internal class Program
    {
        static void Main()
        {
            List<int> numsList = new List<int>() { -3, 5, 1, 9, -12, 4, 6, -2, 0 };
            SortList(numsList);
            FilterList(numsList);
            PrintList(numsList);
        }
        static void SortList(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (list[j - 1] > list[j])
                    {
                        int temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
        static void FilterList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0 && list[i] < 0)
                {
                    list.RemoveAt(i);
                }
            }
        }
        static void PrintList(List<int> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}

