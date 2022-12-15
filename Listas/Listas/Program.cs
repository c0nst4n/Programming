using System;
namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<int> list = new List<int>();
            list.Add(3);
            list.Add(5);
            list.Add(-1);
            list.Add(0);
            list.Add(7);

            Console.WriteLine(BinarySort(list, 0));
        }

        public static int GetMax(List<int> list)
        {
            int result = int.MinValue;

            for (int i = 0; i < list.Count; i++)
            {
             if (list[i] > result)
                {
                    result = list[i]; 
                }  
                
            }
            
            return result;
        }

        public static int IndexOf(List<int> list, int number)
        {
            if (list == null)
                return -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (number == list[i])
                    return i;
            }
            return -1;
        }

        public static bool SearchList(List<int> list, int number)
        {

            return IndexOf(list, number) >= 0;

        }

        public static List<int> Sort(List<int> list)
        {
            for(int i=0; i < list.Count -1; i++)
            {
              for(int j = i + 1; j < list.Count; j++)
                {
                    if(list[j] > list[i])
                    {
                        int aux = list[i];
                        list[i] = list[j];
                        list[j] = aux;
                    }
                }
            }
            return list;
        }

        public static int BinarySort(List<int> list, int number)
        {
            List<int> SortedList = Sort(list);

            int max = SortedList.Count - 1;
            int min = SortedList[0];
            int mid = (max + min) / 2;

            while (max > min)
            {
                if (number != mid)
                    mid = min;
            }

            return mid;
        }
    }
}