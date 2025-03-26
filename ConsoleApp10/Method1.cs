using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{

    partial class Methods
    {

        public static void firstBlock()
        {
            int[] array = GetUserInputForFirstBlock();

            if (array.Length < 2) return;

            int indexOfFirstMin = Array.IndexOf(array, array.Min());
            int indexOfLastMax = Array.LastIndexOf(array, array.Max());

            int newLength = (indexOfFirstMin + 1) + (array.Length - indexOfLastMax);
            int[] resultArray = new int[newLength];
            int j = 0;

            for(int i = 0; i <= indexOfFirstMin; i++)
            {
                resultArray[j++] = array[i];
            }

            for(int i = indexOfLastMax; i < array.Length; i++)
            {
                resultArray[j++] = array[i];
            }

            Console.WriteLine(string.Join(", ", resultArray));
        }
        

        private static int[] GetUserInputForFirstBlock()
        {
            Console.WriteLine("Введіть элементи масиву через пробіл: ");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            return array;
        }



        public static void secondBlock() {
            int[][] array = GetUserInputForSecondBlock();

            int count = 0;
            foreach (var row in array)
            {
                if (row.Length > 0)
                {
                    count++;
                }
            }

            
            int[][] result = new int[count][];
            int index = 0;

         
            foreach (var row in array)
            {
                if (row.Length > 0)
                {
                    result[index++] = row;
                }
            }

            ShowJaggedArray(result);

            

        }

        private static int[][] GetUserInputForSecondBlock()
        {
            Console.WriteLine("Введіть розмір зубчастого масиву: ");
            int size = int.Parse( Console.ReadLine());
            int[][] array = new int[size][];
            Console.WriteLine("Починайте вводити зубчастий масив: ");
            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(row))
                {
                    array[i] = new int[0];
                }
                else
                {
                    array[i] = row.Trim().Split(' ').Select(int.Parse).ToArray();
                }
            }

            return array;
        
        }

        private static void ShowJaggedArray(int[][] array)
        {
            Console.WriteLine("Ваш зубчастий массив: ");
            foreach (var row in array)
            {
                Console.WriteLine(string.Join("\t", row));

            }
        }
    }
     
    }

