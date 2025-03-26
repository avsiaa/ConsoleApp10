using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//2.Додати К рядків у початок (угору) зубчастого масиву
namespace ConsoleApp10
{
    class Bondarenko_2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            do
            {
                Console.WriteLine("Для виконання блоку з масивом введіть 1");
                Console.WriteLine("Для виконання блоку з List введіть 2");
                Console.WriteLine("Для виходу з програми введіть 0");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Виконую блок 1");
                        Block_Masiv();
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Виконую блок 2");
                        Block_List();
                        break;
                    case 0:
                        Console.WriteLine();
                        Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 0.", choice);
                        break;
                }
            } while (choice != 0);
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
            Console.WriteLine("Введiть число рядкiв, якi треба додати у початок масиву:");
            int K = int.Parse(Console.ReadLine());
            int[][] newMasiv = new int[K + masiv.Length][];

            for (int i = 0; i < K; i++)
            {
                Console.WriteLine($"Введiть кiлькiсть елементiв у {i + 1} рядку:");
                int l = int.Parse(Console.ReadLine());
                newMasiv[i] = new int[l];

                Console.WriteLine($"Введiть {l} елементiв через пробiл:");
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < l; j++)
                {
                    newMasiv[i][j] = int.Parse(input[j]);
                }
            }
            for (int i = 0; i < masiv.Length; i++)
            {
                newMasiv[K + i] = masiv[i];
            }
            masiv = newMasiv;
        }
        public static void Print(int[][] masiv)
        {
            Console.WriteLine("Кінцевий результат:");
            for (int i = 0; i < masiv.Length; i++)
            {
                Console.WriteLine(string.Join(" ", masiv[i]));
            }
        }
        static void Block_Masiv()
        {
            Input(out int[][] masiv);
            Print(masiv);
            Dodavana(ref masiv);
            Print(masiv);
        }

        public static List<int[]> InputList()
        {

            Console.WriteLine("Введiть кiлькiсть рядкiв у зубчастому масивi:");
            int n = int.Parse(Console.ReadLine());
            List<int[]> MasivInList = new List<int[]>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введiть кiлькiсть елементiв у {i + 1} рядку:");
                int l = int.Parse(Console.ReadLine());

                Console.WriteLine($"Введiть {l} елементiв через пробiл:");
                string[] input = Console.ReadLine().Split();
                int[] row = new int[l];
                for (int j = 0; j < l; j++)
                {
                    MasivInList[i][j] = int.Parse(input[j]);
                }
                MasivInList.Add(row);
            }
            return MasivInList;
        }
        public static void DodavanaList(ref List<int[]> MasivInList)
        {
            Console.WriteLine("Введiть число рядкiв, якi треба додати у початок масиву:");
            int K = int.Parse(Console.ReadLine());
            List<int[]> newMasivInList = new List<int[]>();

            for (int i = 0; i < K; i++)
            {
                Console.WriteLine($"Введiть кiлькiсть елементiв у {i + 1} рядку:");
                int l = int.Parse(Console.ReadLine());

                Console.WriteLine($"Введiть {l} елементiв через пробiл:");
                string[] input = Console.ReadLine().Split();
                int[] MasivInList = new int[l];
                for (int j = 0; j < l; j++)
                {
                    MasivInList[j] = int.Parse(input[j]);
                }
            }
            newMasivInList.Add(MasivInList);
        }
        public static void PrintList(List<int[]> MasivInList)
        {
            Console.WriteLine("Кінцевий результат:");
            for (int i = 0; i < MasivInList.Length; i++)
            {
                Console.WriteLine(string.Join(" ", MasivInList[i]));
            }
        }
        static void Block_List()
        {
            List<int[]> MasivInList = InputList();
            DodavanaList(ref MasivInList);
            PrintList(MasivInList);
        }



    }
}

