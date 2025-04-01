using System;

namespace ConsoleApp10
{
    public static class ArrayHelper
    {
        private static int[] array;
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
