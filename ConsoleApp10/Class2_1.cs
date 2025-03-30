using System;

namespace DraftForLab2
{
    class Bondarenko_1
    {
        public static void Block_Liza11()
        {
            int[][] masiv;
            Input(out masiv);
            Dodavana(ref masiv);
        }

        public static void Input(out int[][] masiv)
        {
            Console.WriteLine("Введiть кiлькiсть рядкiв у зубчастому масивi:");
            int n = int.Parse(Console.ReadLine());
            masiv = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введiть кiлькiсть елементiв у {i + 1} рядку:");
                int l = int.Parse(Console.ReadLine());
                masiv[i] = new int[l];

                Console.WriteLine($"Введiть {l} елементiв через пробiл:");
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < l; j++)
                {
                    masiv[i][j] = int.Parse(input[j]);
                }
            }
        }

        public static void Dodavana(ref int[][] masiv)
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                int newSize = (masiv[i].Length + 1) / 2;
                int[] newRow = new int[newSize];
                int newIndex = 0;

                for (int j = 0; j < masiv[i].Length; j++)
                {
                    if (j % 2 != 0) /
                    {
                        newRow[newIndex] = masiv[i][j];
                        newIndex++;
                    }
                }
                masiv[i] = newRow;
            }
            Console.WriteLine("\nМасив після видалення парних iндексiв:");
            foreach (var row in masiv)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}