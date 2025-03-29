using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Введіть число, який блок ви хочете побачити? (1,2): ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Блок 1");
                        Console.WriteLine("Завдання якого студента ви хочете побачити?: \n" +
                            "1. Вольвач Анастасія - варіант 7 \n" +
                            "2. Бондаренко Єлизавета - варіант 6 \n" +
                            "3. Gggg Gggg - варіант N \n");
                        int choiceOfTask = int.Parse(Console.ReadLine());

                        switch (choiceOfTask)
                        {
                            case 1:
                                Console.WriteLine("Виконую завдання під варіантом 7: ");
                                Methods.firstBlock();
                                break;

                            default: return;
                                
                        }
                        
                    break;

                    case 2:
                    Console.WriteLine("Блок 2");
                        Console.WriteLine("Завдання якого студента ви хочете побачити?: \n" +
                            "1. Вольвач Анастасія - варіант 10 \n" +
                            "2. Бондаренко Єлизавета - варіант 2 \n" +
                            "3. Gggg Gggg - варіант N \n");
                        int choiceOfTask2 = int.Parse(Console.ReadLine());
                        switch (choiceOfTask2)
                        {
                            case 1:
                                Console.WriteLine("Виконую варіант 10: ");
                                Methods.secondBlock();
                                break;
                            case 2:
                                Console.WriteLine("Виконую варіант 2: ");
                                Bondarenko_2.Block_Lizas();
                                break;


                        }
                        break;
                    default: 
                        isTrue = false;
                        break;

                }
            }


        }
    }
}
