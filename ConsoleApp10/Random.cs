using System;

namespace ConsoleApp10
{
    public static class ArrayRandom
    {
        private static int[] arrayRandom;
        public static void InputArrayRandom()
        {
            Console.Write("Введіть, скільки елементів згенерувати випадково: ");//Допрацювала метод для випадкового заповнювання масиву (додала можливість вказувати мінімальне та максимальне значення при заповненні)
            int size = int.Parse(Console.ReadLine());

            Console.Write("Введіть мінімальне значення: ");
            int minValue = int.Parse(Console.ReadLine());

            Console.Write("Введіть максимальне значення: ");
            int maxValue = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(minValue, maxValue + 1);
            }
            Console.WriteLine("Масив успішно збережений");
            arrayRandom = arr;

            Console.Write("Згенерований масив: ");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
        }

        public static int[] GetArrayRandom()
        {
            return arrayRandom ?? new int[0];
        }
        public static void ClearArray()
        {
            arrayRandom = null;
        }
    }
}
