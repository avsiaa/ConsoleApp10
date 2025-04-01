using System;

namespace ConsoleApp10
{
    partial class Methods
    {
        public static void firstBlockBond(bool isRandom)
        {
            int[] array = isRandom ? ArrayRandom.GetArrayRandom() : ArrayHelper.GetArray();
            int newSize = array.Length / 2 + (array.Length % 2);
            int[] resultArray = new int[newSize];

            NewInputArrayRandom(ref resultArray, array);
            Print(resultArray);
        }
        static void Print(int[] resultArray)
        { 
            Console.WriteLine("Масив без елементів із парними індексами:");
            Console.WriteLine(string.Join(" ", resultArray));
        }
        static void NewInputArrayRandom(ref int[] resultArray, int[] array)
        {
            int index = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                resultArray[index++] = array[i];
            }
        }
    }
}