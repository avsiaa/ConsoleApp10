using System;

namespace ConsoleApp10
{
    partial class Methods
    {
        public static void firstBlockAV(bool isRandom)
        {
            int[] array = isRandom ? ArrayRandom.GetArrayRandom() : ArrayHelper.GetArray();

            (int firstMinIndex, int lastMaxIndex) = FindMinMaxIndices(array);

            if (firstMinIndex == lastMaxIndex)
            {
                Console.WriteLine("Мінімальний і максимальний елементи співпадають, видалення не потрібне.");
                return;
            }

            int[] resultArray = CreateFilteredArray(array, firstMinIndex, lastMaxIndex);

            Console.WriteLine("Масив після видалення елементів між першим мінімальним і останнім максимальним:");
            Console.WriteLine(string.Join(" ", resultArray));
        }

        private static (int, int) FindMinMaxIndices(int[] array)
        {
            int minValue = array[0], maxValue = array[0];
            int firstMinIndex = 0, lastMaxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    firstMinIndex = i;
                }
                if (array[i] >= maxValue)
                {
                    maxValue = array[i];
                    lastMaxIndex = i;
                }
            }

            if (firstMinIndex > lastMaxIndex)
            {
                (firstMinIndex, lastMaxIndex) = (lastMaxIndex, firstMinIndex);
            }

            return (firstMinIndex, lastMaxIndex);
        }

        private static int[] CreateFilteredArray(int[] array, int firstMinIndex, int lastMaxIndex)
        {
            int newSize = firstMinIndex + 1 + (array.Length - lastMaxIndex);
            int[] resultArray = new int[newSize];

            int index = 0;
            for (int i = 0; i <= firstMinIndex; i++)
                resultArray[index++] = array[i];

            for (int i = lastMaxIndex; i < array.Length; i++)
                resultArray[index++] = array[i];

            return resultArray;
        }
    }
}