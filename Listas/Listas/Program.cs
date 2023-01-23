using System;
using System.Reflection.Metadata.Ecma335;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {



            double[] a = new double[] {10.2, 10.8, 10.1, 10.3};
            string[] b = new string[] { "zola", "zopenco", "adios", "odisea" };
            float[] c = new float[] { 2.8f, 2.9f, 4f, 8.5f, 1.7f };
            int[] d = new int[] {4, 5, 7, 9 };
            char[] e = new char[] { 'a', 'c', 'b', 'd', 'z', 'f' };
           Console.WriteLine(IndexOfArray(b, "adios", delstring));
            /*for (int j = 0; j < b.Length; j++)
            {
                Console.WriteLine(b[j]);
            }*/
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
            int min = 0;
            int max = list.Count - 1;
            int mid = (min + max) / 2;

            while (min <= max)
            {
                mid = (min + max) / 2;
                if (list[mid] == number)
                    return mid;
                if (list[mid] > number)
                    max = mid - 1;
                else
                    min = mid + 1;
            }

            return -1;
        }

        public static bool SearchInt(int[] numarray, int number)
        {
            for (int i=0; i < numarray.Length; i++)
            {
                if (numarray[i] == number)
                    return true;
            }
            return false;
        }

        public static bool SearchString(string[] array, string word)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == word)
                    return true;
            }
            return false;
        }

        public static bool SearchChar(char[] array, char letter)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == letter)
                    return true;
            }
            return false;
        }

        public static bool SearchDouble(double[] array, double number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return true;
            }
            return false;
        }

        public static bool SearchFloat(float[] array, float number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return true;
            }
            return false;
        }
        //Swap
        public static void Swap<T>(ref T value1, ref T value2)
        {
            T auxiliar = value1;
            value1 = value2;
            value2 = auxiliar;
        }
    

        //Flip
        public static void FlipArray<T>(T[] array)
        {
            for(int i = 0; i < array.Length / 2; i++)
            {
                Swap<T>(ref array[i], ref array[array.Length - 1 - i]);
            }

        }

        //sort 
        public delegate int Comparator<T>(ref T a, ref T b);
        static Comparator<string> delstring = (ref string a, ref string b)=> 
            {
                if (a.Length > b.Length)
                    return 1;
                if (a.Length < b.Length)
                    return -1;
                return 0;

            }
            ;
       static Comparator<int> delint = (ref int a, ref int b) =>
        {
            if (a > b)
                return 1;
            if (a < b)
                return -1;
            return 0;

        }
        ;
        static Comparator<bool> delbool = (ref bool a, ref bool b) =>
        {
            if ((a == true) && (b == false))
                return 1;
            if ((a == false) && (b == true))
                return -1;
            return 0;

        }


;




        public static void SortArray<T>(ref T[] array, Comparator<T> del)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    // Comparer str1 = new Comparer(array[i]);
                    //Comparer str2 = new Comparer(array[j]);

                    if (del(ref array[i], ref array[j]) == 1)
                        Swap(ref array[i], ref array[j]);
                        
                    
                }
            }
        }

        //Index of

        public static int IndexOfArray<T>(T[] array, T a, Comparator<T> del)
        {
            if (array == null)
                return -1;

            for (int i = 0; i < array.Length; i++)
            {
                
                if (del(ref array[i],ref a) == 0)
                    return i;
            }

            return -1;
        }
        //Binary Search (p)

        public static int BinarySearch<T>(T[] array, T number, Comparator<T> del)
        {
            int min = 0;
            int max = array.Length - 1;
            int mid = (min + max) / 2;

            while (min <= max)
            {
                mid = (min + max) / 2;
     
                if (del(ref array[mid],ref number) == -1)
                    return mid;
                if (del(ref array[mid],ref number) == 1)
                    max = mid - 1;
                else
                    min = mid + 1;
            }

            return -1;
        }


        //add
        public static T[] AddToArray<T>(T[] array, T a)
        {

            T[] result = new T[array.Length + 1];

            for(int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }

            result[result.Length - 1] = a;
            return result;
        }
        //remove at

        public static T[] RemoveAt<T>(T[] array, int pos)
        {
            T[] result = new T[0];
            for(int i = 0; i < array.Length; i++)
            {
                if (i == pos)
                    continue;
                AddToArray<T>(result, array[i]);
            }

            return result;
        }
        //remove
        public static T[] Remove<T>(T[] array, T element, Comparator <T> del)
        {
            for(int i = 0; i < array.Length; i++)
            {
                
                if (del(ref array[i], ref element) == -1)
                {
                    RemoveAt<T>(array, i);
                    i -= 1;
                }
            }

            return array;
        }
     
        //Rotate Left/Right

        public static void LimitArrayDisplacement<T>(T[] values, ref int displacement)
        {
            while (displacement > values.Length)
                displacement -= values.Length;

            while (displacement < -values.Length)
                displacement += values.Length;

            if (displacement > values.Length / 2)
                displacement = -(values.Length - displacement);

            if (displacement < -(values.Length / 2))
                displacement = (values.Length + displacement);
        }

        public static void InvertSection<T>(T[] values, int start, int displacement)
        {
            T aux;
            displacement -= 1;
            for(int i = start, j = displacement; i < j; i++, j--)
            {
                aux = values[i];
                values[i] = values[j];
                values[j] = aux;
            }
        }
        public static void PositionArrayElements<T>(T[] values, int distance, int displacement)
        {
            if (displacement > 0)
            {
                InvertSection(values, values.Length - distance, values.Length);
                InvertSection(values, 0, values.Length - distance);
            }
            else
            {
                InvertSection(values, 0, distance);
                InvertSection(values, distance, values.Length);
            }
        }

        public static void PositionOuterNumbers<T>(T[] values, int distance)
        {
            while (true)
            {
                if (distance < 1)
                    break;
                Swap(ref values[distance - 1], ref values[values.Length - distance]);
                distance--;
            }
        }
        public static void RotateBothDirection<T>(T[] values, int displacement)
        {
            displacement *= -1;
            LimitArrayDisplacement(values, ref displacement);
            if (displacement == 0)
                return;
            int distance;
            if (displacement < 0)
                distance = -displacement;
            else
                distance = displacement;

            PositionOuterNumbers(values, distance);
            InvertSection(values, distance, values.Length - distance);
            PositionArrayElements(values, distance, displacement);
          

            
        }

    }
}