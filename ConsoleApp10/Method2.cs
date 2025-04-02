using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    partial class Methods
    {
        public static void Olga1()
        {
            int[] array = ArrayHelper.GetArray();
            (int min, int max) = MinMax(array);
            int[] newArr = NewArray(array, min, max);
            PrintArray(newArr);
            ArrayHelper.reserveArray = ArrayHelper.array;
            ArrayHelper.array = newArr;
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

        static int[] NewArray(int[] arr, int min, int max)
        {
            int[] newArr = new int[arr.Length + 2];
            newArr[0] = min;
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }
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