using System;

namespace ConsoleApp10
{
    partial class Methods
    {
        public static void firstBlockBond(bool isRandom)
        {
            int[] array = isRandom ? ArrayRandom.GetArrayRandom() : ArrayHelper.GetArray();
            if (array.Length == 0)
            {
                Console.WriteLine("Масив порожній! Введіть дані спочатку.");
                return;
            }

            int newSize = array.Length / 2 + (array.Length % 2);
            int[] resultArray = new int[newSize];
            int index = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                resultArray[index++] = array[i];
            }

            Console.WriteLine("Масив без елементів із парними індексами:");
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
