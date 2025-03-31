using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    partial class Methods
    {
        public static void firstBlockBond()
        {
            int[] array = GetUserInputForSixthBlock1();

            if (array.Length == 0)
            {
                Console.WriteLine("Масив порожній!");
                return;
            }
            int newSize = array.Length / 2;
            if (array.Length % 2 != 0)
            {
                newSize++;
            }

            int[] resultArray = new int[newSize];
            int index = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                resultArray[index++] = array[i];
            }

            Console.WriteLine("Масив без елементів із парними індексами:");
            Console.WriteLine(string.Join(" ", resultArray));
        }
        private static int[] GetUserInputForSixthBlock1()
        {
            Console.WriteLine("Введіть елементи масиву через пробіл:");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int[] array = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = int.Parse(parts[i]);
            }
            return array;
        }
    }
}