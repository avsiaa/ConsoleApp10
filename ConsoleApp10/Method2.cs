using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    partial class Methods
    {
        static void Main()
        {
            int n = GetArraySize();
            int[] arr = ChooseArrVedenia(n);

            (int min, int max) = MinMax(arr);
            int[] newArr = NewArray(arr, min, max);

            PrintArray(newArr);
        }
        static int GetArraySize()
        {
            Console.Write("Введіть розмір масиву: ");
            return int.Parse(Console.ReadLine());
        }
        static int[] ChooseArrVedenia(int size)
        {
            Console.Write("Оберіть спосіб заповнення масиву (1 - вручну, 2 - рандомно): ");
            int choice = int.Parse(Console.ReadLine());

            return choice == 1 ? ManualArray(size) : RandomArray(size);
        }

        static int[] ManualArray(int size)
        {
            int[] arr = new int[size];
            Console.WriteLine("Введіть елементи масиву:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static int[] RandomArray(int size)
        {
            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(-1000000, 1000000);
            }
            Console.WriteLine("Згенерований масив: " + string.Join(" ", arr));
            return arr;
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

