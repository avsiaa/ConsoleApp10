using System;

namespace ConsoleApp10
{
    public static class ArrayHelper
    {
        public static int[] array;
        public static int[] reserveArray;
        public static void InputArray()
        {
            Console.WriteLine("Введіть елементи масиву через пробіл:");
            string input = Console.ReadLine();
            array = ParseArray(input);
            Console.WriteLine("Масив успішно збережений!");
        }

        private static int[] ParseArray(string input)
        {
            string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                arr[i] = int.Parse(parts[i]);
            }
            return arr;
        }

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
            array = arr;

            Console.Write("Згенерований масив: ");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }

        }
        public static int[] GetArray()
        {
            return array ?? new int[0];
        }
        public static void ClearArrayRandom()
        {
            array = null;
        }
    }
}