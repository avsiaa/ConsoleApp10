using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool isTrue = true;
            bool isRandom = false;

            while (isTrue)
            {
                Console.WriteLine("\nОберіть дію:");
                Console.WriteLine("1. Заповнення масиву самостійно");
                Console.WriteLine("2. Заповнення масиву рандомно");
                Console.WriteLine("3. Видалити записані дані масиву");
                Console.WriteLine("4. Завдання студентів");
                Console.WriteLine("0. Вихід");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Заповнення масиву самостійно");
                        ArrayHelper.InputArray();
                        isRandom = false;
                        break;

                    case 2:
                        Console.WriteLine("Заповнення масиву рандомно");
                        ArrayRandom.InputArrayRandom();
                        isRandom = true;
                        break;

                    case 3:
                        Console.WriteLine("Видалення записаних даних масиву");
                        ArrayHelper.ClearArrayRandom();
                        ArrayRandom.ClearArray();
                        break;

                    case 4:
                        HandleStudentTasks(isRandom);
                        break;

                    case 0:
                        Console.WriteLine("Вихід із програми...");
                        isTrue = false;
                        break;

                    default:
                        Console.WriteLine("Некоректний вибір! Спробуйте ще раз.");
                        break;
                }
            }
        }

        static void HandleStudentTasks(bool isRandom)
        {
            bool continueTasks = true;
            bool usePreviousArray = false;

            while (continueTasks)
            {
                Console.WriteLine("\nОберіть завдання студента:");
                Console.WriteLine("1. Вольвач Анастасія - варіант 7");
                Console.WriteLine("2. Риженкова Ольга - варіант 11");
                Console.WriteLine("3. Бондаренко Єлизавета - варіант 6");
                Console.WriteLine("0. Повернутися до головного меню");

                int studentChoice = int.Parse(Console.ReadLine());

                switch (studentChoice)
                {
                    case 1:
                        Console.WriteLine("Виконую завдання Вольвач Анастасії");
                        Methods.firstBlockAV(isRandom);
                        break;

                    case 2:
                        Console.WriteLine("Виконую завдання Риженкової Ольги");
                        Methods.Olga1(isRandom);
                        break;

                    case 3:
                        Console.WriteLine("Виконую завдання Бондаренко Єлизавети");
                        Methods.firstBlockBond(isRandom);
                        break;

                    case 0:
                        continueTasks = false;
                        return;

                    default:
                        Console.WriteLine("Некоректний вибір студента!");
                        continue;
                }

                Console.WriteLine("\nОберіть наступну дію:");
                Console.WriteLine("1. Виконати наступний варіант із початковим масивом");
                Console.WriteLine("2. Виконати наступний варіант із масивом після змін");
                Console.WriteLine("0. Вийти до головного меню");

                int nextChoice = int.Parse(Console.ReadLine());

                switch (nextChoice)
                {
                    case 1:
                        usePreviousArray = false;
                        break;
                    case 2:
                        usePreviousArray = true;
                        break;
                    case 0:
                        continueTasks = false;
                        break;
                    default:
                        Console.WriteLine("Некоректний вибір! Повернення до головного меню.");
                        continueTasks = false;
                        break;
                }
            }
        }
    }
}
