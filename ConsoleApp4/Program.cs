using System;
// Задание: создать калькулятор матриц, в который пользователь сам вводит значения и определяет размерность. Добавить сложение и вычитание.
//Обязательное условие: метод, цикл и двумерный массив.
namespace Matrices
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите размерность матрицы: ");
            int razmer = int.Parse(Console.ReadLine());

            int[,] a = new int[razmer, razmer];
            int[,] b = new int[razmer, razmer];

            Console.WriteLine("Введите значения для матрицы a:");
            vvod(a, razmer);

            Console.WriteLine("Введите значения для матрицы b:");
            vvod(b, razmer);

            while (true)
            {
                Console.WriteLine("\nВыберите действие: \n");
                Console.WriteLine("1. Вывести матрицу a");
                Console.WriteLine("2. Вывести матрицу b");
                Console.WriteLine("3. Сложить матрицы a и b");
                Console.WriteLine("4. Вычесть матрицу a из b");
                Console.WriteLine("5. Вычесть матрицу b из a");
                Console.WriteLine("6. Выйти");
                int vybor = int.Parse(Console.ReadLine());

                switch (vybor)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Матрица a:");
                        vyvod(a, razmer);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Матрица b:");
                        vyvod(b, razmer);
                        break;
                    case 3:
                        Console.Clear();
                        int[,] summa = Plus(a, b, razmer);
                        Console.WriteLine("a + b = ");
                        vyvod(summa, razmer);
                        break;
                    case 4:
                        Console.Clear();
                        int[,] raznost = aminusb(a, b, razmer);
                        Console.WriteLine("a - b = ");
                        vyvod(raznost, razmer);
                        break;
                    case 5:
                        Console.Clear();
                        int[,] raznost1 = bminusa(a, b, razmer);
                        Console.WriteLine("b - a = ");
                        vyvod(raznost1, razmer);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Выход");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Некорректный выбор. Попробуйте выбрать ещё раз");
                        break;
                }
            }
        }
        static void vvod(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Элемент [{i + 1}, {j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void vyvod(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] aminusb(int[,] matrixa, int[,] matrixb, int size)
        {
            int[,] result = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = matrixa[i, j] - matrixb[i, j];
                }
            }
            return result;
        }
        static int[,] bminusa(int[,] matrixa, int[,] matrixb, int size)
        {
            int[,] result = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = matrixb[i, j] - matrixa[i, j];
                }
            }

            return result;
        }
        static int[,] Plus(int[,] matrixa, int[,] matrixb, int size)
        {
            int[,] result = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = matrixa[i, j] + matrixb[i, j];
                }
            }

            return result;
        }
    }
}