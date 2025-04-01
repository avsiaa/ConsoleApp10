using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    partial class Methods
    {
        public static void Olga1(bool isRandom)
        {
            int[] array = isRandom ? ArrayRandom.GetArrayRandom() : ArrayHelper.GetArray();
            if(array.Length ==0)
            {
                Console.WriteLine("Масив порожній! Введіть дані спочатку.");
                return;
            }
            (int min, int max) = MinMax(array);
            int[] newArr = NewArray(array, min, max);
            PrintArray(newArr);
        }
        
        static (int min, int max) MinMax(int[] arr)
        {
            int min = arr[0], max = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
            return (min, max);
        }

        static int[] NewArray(int[] arr, int min, int max)//зміни тут
        {
            int[] newArr = new int[arr.Length + 2];
            newArr[0] = min;
            Array.Copy(arr, 0, newArr, 1, arr.Length);
            newArr[newArr.Length - 1] = max;
            return newArr;
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine("Оновлений масив:");
            Console.WriteLine(string.Join(" ", arr));
        }
    }

}

