using System;
using System.Linq;

class Program1
{
    static void Main()
    {
        #region Задания с 16 по 30 с двумерными массивами

        // Задача 16
        Console.WriteLine("\n=== Задача 16 ===");
        Console.Write("Введите размер квадратного массива n: ");
        int n_16 = int.Parse(Console.ReadLine());
        int[,] matrix_16 = new int[n_16, n_16];
        Console.WriteLine($"Введите элементы квадратного массива {n_16}x{n_16}:");
        for (int i = 0; i < n_16; i++)
        {
            for (int j = 0; j < n_16; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_16[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int productFirstRow_16 = 1;
        for (int j = 0; j < n_16; j++)
        {
            productFirstRow_16 *= matrix_16[0, j];
        }
        Console.WriteLine($"Произведение элементов первой строки: {productFirstRow_16}");

        // Задача 17
        Console.WriteLine("\n=== Задача 17 ===");
        int[,] matrix_17 = new int[10, 10];
        Console.WriteLine("Введите элементы массива 10x10:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_17[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Суммы элементов по строкам:");
        for (int i = 0; i < 10; i++)
        {
            int sumRow_17 = 0;
            for (int j = 0; j < 10; j++)
            {
                sumRow_17 += matrix_17[i, j];
            }
            Console.WriteLine($"Строка {i + 1}: {sumRow_17}");
        }

        // Задача 18
        Console.WriteLine("\n=== Задача 18 ===");
        int[,] matrix_18 = new int[4, 4];
        Console.WriteLine("Введите элементы массива 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_18[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int minSum_18 = int.MaxValue;
        int minRowIndex_18 = 0;
        for (int i = 0; i < 4; i++)
        {
            int sumRow_18 = 0;
            for (int j = 0; j < 4; j++)
            {
                sumRow_18 += matrix_18[i, j];
            }
            if (sumRow_18 < minSum_18)
            {
                minSum_18 = sumRow_18;
                minRowIndex_18 = i;
            }
        }
        Console.WriteLine($"Строка с наименьшей суммой: {minRowIndex_18 + 1} (сумма = {minSum_18})");

        // Задача 19
        Console.WriteLine("\n=== Задача 19 ===");
        int[,] matrix_19 = new int[7, 7];
        Console.WriteLine("Введите элементы массива 7x7:");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_19[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int maxSum_19 = int.MinValue;
        int maxRowIndex_19 = 0;
        for (int i = 0; i < 7; i++)
        {
            int sumRow_19 = 0;
            for (int j = 0; j < 7; j++)
            {
                sumRow_19 += matrix_19[i, j];
            }
            if (sumRow_19 > maxSum_19)
            {
                maxSum_19 = sumRow_19;
                maxRowIndex_19 = i;
            }
        }
        Console.WriteLine($"Строка с наибольшей суммой: {maxRowIndex_19 + 1} (сумма = {maxSum_19})");

        // Задача 20
        Console.WriteLine("\n=== Задача 20 ===");
        int[,] matrix_20 = new int[6, 8];
        Console.WriteLine("Введите элементы массива 6x8:");
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_20[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int productFirstCol_20 = 1;
        for (int i = 0; i < 6; i++)
        {
            if (matrix_20[i, 0] > 0)
            {
                productFirstCol_20 *= matrix_20[i, 0];
            }
        }
        Console.WriteLine($"Произведение положительных элементов первого столбца: {productFirstCol_20}");

        // Задача 21
        Console.WriteLine("\n=== Задача 21 ===");
        int[,] matrix_21 = new int[4, 6];
        Console.WriteLine("Введите элементы массива 4x6:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_21[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Суммы по столбцам:");
        for (int j = 0; j < 6; j++)
        {
            int sumCol_21 = 0;
            for (int i = 0; i < 4; i++)
            {
                sumCol_21 += matrix_21[i, j];
            }
            Console.WriteLine($"Столбец {j + 1}: {sumCol_21}");
        }

        // Задача 22
        Console.WriteLine("\n=== Задача 22 ===");
        int[,] matrix_22 = new int[5, 10];
        Console.WriteLine("Введите элементы массива 5x10:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_22[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int minRowSum_22 = int.MaxValue;
        for (int i = 0; i < 5; i++)
        {
            int sumRow_22 = 0;
            for (int j = 0; j < 10; j++)
            {
                sumRow_22 += matrix_22[i, j];
            }
            if (sumRow_22 < minRowSum_22)
            {
                minRowSum_22 = sumRow_22;
            }
        }
        Console.WriteLine($"Минимальное значение среди сумм строк: {minRowSum_22}");

        // Задача 23
        Console.WriteLine("\n=== Задача 23 ===");
        int[,] matrix_23 = new int[4, 5];
        Console.WriteLine("Введите элементы массива 4x5:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_23[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int totalSum_23 = 0;
        int totalCount_23 = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                totalSum_23 += matrix_23[i, j];
                totalCount_23++;
            }
        }
        double average_23 = (double)totalSum_23 / totalCount_23;

        int countAboveAvg_23 = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (matrix_23[i, j] > average_23)
                {
                    countAboveAvg_23++;
                }
            }
        }
        Console.WriteLine($"Среднее арифметическое: {average_23:F2}");
        Console.WriteLine($"Количество элементов выше среднего: {countAboveAvg_23}");

        // Задача 24
        Console.WriteLine("\n=== Задача 24 ===");
        Console.Write("Введите количество строк N: ");
        int N_24 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов M: ");
        int M_24 = int.Parse(Console.ReadLine());
        int[,] matrix_24 = new int[N_24, M_24];
        Console.WriteLine($"Введите элементы массива {N_24}x{M_24}:");
        for (int i = 0; i < N_24; i++)
        {
            for (int j = 0; j < M_24; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_24[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int sumSecondRow_24 = 0;
        for (int j = 0; j < M_24; j++)
        {
            sumSecondRow_24 += matrix_24[1, j];
        }
        Console.WriteLine($"Сумма элементов второй строки: {sumSecondRow_24}");

        // Задача 25
        Console.WriteLine("\n=== Задача 25 ===");
        int[,] matrix_25 = new int[4, 4];
        Console.WriteLine("Введите элементы массива 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_25[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int negativeCount_25 = 0;
        for (int i = 0; i < 4; i++)
        {
            if (matrix_25[i, 1] < 0)
            {
                negativeCount_25++;
            }
        }
        Console.WriteLine($"Количество отрицательных элементов во втором столбце: {negativeCount_25}");

        // Задача 26
        Console.WriteLine("\n=== Задача 26 ===");
        int[,] matrix_26 = new int[3, 7];
        Console.WriteLine("Введите элементы массива 3x7:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_26[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Количество элементов по столбцам:");
        for (int j = 0; j < 7; j++)
        {
            int count_26 = 0;
            for (int i = 0; i < 3; i++)
            {
                count_26++;
            }
            Console.WriteLine($"Столбец {j + 1}: {count_26} элементов");
        }

        // Задача 27
        Console.WriteLine("\n=== Задача 27 ===");
        Console.Write("Введите количество строк: ");
        int rows_27 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int cols_27 = int.Parse(Console.ReadLine());
        int[,] matrix_27 = new int[rows_27, cols_27];
        Console.WriteLine($"Введите элементы массива {rows_27}x{cols_27}:");
        for (int i = 0; i < rows_27; i++)
        {
            for (int j = 0; j < cols_27; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_27[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int sumOdd_27 = 0;
        for (int i = 0; i < rows_27; i++)
        {
            for (int j = 0; j < cols_27; j++)
            {
                if (matrix_27[i, j] % 2 != 0)
                {
                    sumOdd_27 += matrix_27[i, j];
                }
            }
        }
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd_27}");

        // Задача 28
        Console.WriteLine("\n=== Задача 28 ===");
        int[,] matrix_28 = new int[5, 5];
        Console.WriteLine("Введите элементы массива 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_28[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintMatrix(matrix_28);

        // Меняем местами 4 и 5 строку
        for (int j = 0; j < 5; j++)
        {
            int temp_28 = matrix_28[3, j];
            matrix_28[3, j] = matrix_28[4, j];
            matrix_28[4, j] = temp_28;
        }

        Console.WriteLine("После перестановки 4 и 5 строк:");
        PrintMatrix(matrix_28);

        // Задача 29
        Console.WriteLine("\n=== Задача 29 ===");
        Console.Write("Введите количество строк: ");
        int rows_29 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int cols_29 = int.Parse(Console.ReadLine());
        int[,] matrix_29 = new int[rows_29, cols_29];
        Console.WriteLine($"Введите элементы массива {rows_29}x{cols_29}:");
        for (int i = 0; i < rows_29; i++)
        {
            for (int j = 0; j < cols_29; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_29[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int minColSum_29 = int.MaxValue;
        int minColIndex_29 = 0;
        for (int j = 0; j < cols_29; j++)
        {
            int sumCol_29 = 0;
            for (int i = 0; i < rows_29; i++)
            {
                sumCol_29 += matrix_29[i, j];
            }
            if (sumCol_29 < minColSum_29)
            {
                minColSum_29 = sumCol_29;
                minColIndex_29 = j;
            }
        }
        Console.WriteLine($"Столбец с наименьшей суммой: {minColIndex_29 + 1} (сумма = {minColSum_29})");

        // Задача 30
        Console.WriteLine("\n=== Задача 30 ===");
        Console.Write("Введите количество строк: ");
        int rows_30 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int cols_30 = int.Parse(Console.ReadLine());
        int[,] matrix_30 = new int[rows_30, cols_30];
        Console.WriteLine($"Введите элементы массива {rows_30}x{cols_30}:");
        for (int i = 0; i < rows_30; i++)
        {
            for (int j = 0; j < cols_30; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_30[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int nonNegativeCount_30 = 0;
        for (int i = 0; i < rows_30; i++)
        {
            if (matrix_30[i, 1] >= 0) // второй столбец (индекс 1)
            {
                nonNegativeCount_30++;
            }
        }
        Console.WriteLine($"Количество неотрицательных элементов во втором столбце: {nonNegativeCount_30}");

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        #endregion


        #region Задания с 3 по 30 с двумерными массивами

        // Задача 3
        Console.WriteLine("\n=== Задача 3 ===");
        int[,] matrix_3 = new int[4, 4];
        int num_3 = 1;

        int top_3 = 0, bottom_3 = 3, left_3 = 0, right_3 = 3;

        while (num_3 <= 16)
        {
            for (int j = left_3; j <= right_3 && num_3 <= 16; j++)
                matrix_3[top_3, j] = num_3++;
            top_3++;

            for (int i = top_3; i <= bottom_3 && num_3 <= 16; i++)
                matrix_3[i, right_3] = num_3++;
            right_3--;

            for (int j = right_3; j >= left_3 && num_3 <= 16; j--)
                matrix_3[bottom_3, j] = num_3++;
            bottom_3--;

            for (int i = bottom_3; i >= top_3 && num_3 <= 16; i--)
                matrix_3[i, left_3] = num_3++;
            left_3++;
        }

        Console.WriteLine("Массив по спирали:");
        PrintMatrix(matrix_3);

        // Задача 4
        Console.WriteLine("\n=== Задача 4 ===");
        Console.Write("Введите количество строк n: ");
        int n_4 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов m: ");
        int m_4 = int.Parse(Console.ReadLine());
        int[,] matrix_4 = new int[n_4, m_4];
        Console.WriteLine($"Введите элементы массива {n_4}x{m_4}:");
        for (int i = 0; i < n_4; i++)
        {
            for (int j = 0; j < m_4; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_4[i, j] = int.Parse(Console.ReadLine());
            }
        }

        List<int> rowsToKeep_4 = new List<int>();
        for (int i = 0; i < n_4; i++)
        {
            bool hasDuplicate_4 = false;
            for (int j = 0; j < m_4; j++)
            {
                for (int k = j + 1; k < m_4; k++)
                {
                    if (matrix_4[i, j] == matrix_4[i, k])
                    {
                        hasDuplicate_4 = true;
                        break;
                    }
                }
                if (hasDuplicate_4) break;
            }
            if (hasDuplicate_4)
            {
                rowsToKeep_4.Add(i);
            }
        }

        Console.WriteLine("Строки с повторяющимися элементами:");
        foreach (int row in rowsToKeep_4)
        {
            for (int j = 0; j < m_4; j++)
            {
                Console.Write($"{matrix_4[row, j]} ");
            }
            Console.WriteLine();
        }

        // Задача 5
        Console.WriteLine("\n=== Задача 5 ===");
        int[,] matrix_5 = new int[3, 3];
        int center_5 = 1;
        matrix_5[1, 1] = center_5;

        int current_5 = 2;
        int[] dx_5 = { 0, 1, 0, -1 };
        int[] dy_5 = { 1, 0, -1, 0 };
        int x_5 = 1, y_5 = 1;
        int direction_5 = 0;
        int step_5 = 1;

        while (current_5 <= 9)
        {
            for (int k = 0; k < 2; k++)
            {
                for (int i = 0; i < step_5 && current_5 <= 9; i++)
                {
                    x_5 += dx_5[direction_5];
                    y_5 += dy_5[direction_5];
                    if (x_5 >= 0 && x_5 < 3 && y_5 >= 0 && y_5 < 3)
                    {
                        matrix_5[x_5, y_5] = current_5++;
                    }
                }
                direction_5 = (direction_5 + 1) % 4;
            }
            step_5++;
        }

        Console.WriteLine("Массив 3x3 по спирали от центра:");
        PrintMatrix(matrix_5);

        // Задача 6
        Console.WriteLine("\n=== Задача 6 ===");
        Random rand_6 = new Random();
        int size_6 = 4;
        int[,] matrixA_6 = new int[size_6, size_6];

        Console.WriteLine("Матрица A (случайные числа):");
        for (int i = 0; i < size_6; i++)
        {
            for (int j = 0; j < size_6; j++)
            {
                matrixA_6[i, j] = rand_6.Next(1, 100);
                Console.Write($"{matrixA_6[i, j],4}");
            }
            Console.WriteLine();
        }

        int minDiag_6 = matrixA_6[0, 0];
        int minRow_6 = 0;
        for (int i = 1; i < size_6; i++)
        {
            if (matrixA_6[i, i] < minDiag_6)
            {
                minDiag_6 = matrixA_6[i, i];
                minRow_6 = i;
            }
        }

        int[,] matrixB_6 = new int[size_6 - 1, size_6];
        int newRow_6 = 0;
        for (int i = 0; i < size_6; i++)
        {
            if (i != minRow_6)
            {
                for (int j = 0; j < size_6; j++)
                {
                    matrixB_6[newRow_6, j] = matrixA_6[i, j];
                }
                newRow_6++;
            }
        }

        Console.WriteLine($"Удалена строка {minRow_6 + 1} с минимальным элементом {minDiag_6}");
        Console.WriteLine("Матрица B:");
        PrintMatrix(matrixB_6);

        // Задача 7
        Console.WriteLine("\n=== Задача 7 ===");
        Console.Write("Введите порядок матрицы n: ");
        int n_7 = int.Parse(Console.ReadLine());
        int[,] matrix_7 = new int[n_7, n_7];

        int num_7 = 1;
        int top_7 = 0, bottom_7 = n_7 - 1, left_7 = 0, right_7 = n_7 - 1;

        while (num_7 <= n_7 * n_7)
        {
            for (int i = top_7; i <= bottom_7 && num_7 <= n_7 * n_7; i++)
                matrix_7[i, left_7] = num_7++;
            left_7++;

            for (int j = left_7; j <= right_7 && num_7 <= n_7 * n_7; j++)
                matrix_7[bottom_7, j] = num_7++;
            bottom_7--;

            for (int i = bottom_7; i >= top_7 && num_7 <= n_7 * n_7; i--)
                matrix_7[i, right_7] = num_7++;
            right_7--;

            for (int j = right_7; j >= left_7 && num_7 <= n_7 * n_7; j--)
                matrix_7[top_7, j] = num_7++;
            top_7++;
        }

        Console.WriteLine($"Матрица {n_7}x{n_7} по спирали против часовой стрелки:");
        PrintMatrix(matrix_7);

        // Задача 8
        Console.WriteLine("\n=== Задача 8 ===");
        Console.Write("Введите порядок матрицы n: ");
        int n_8 = int.Parse(Console.ReadLine());
        int[,] matrix_8 = new int[n_8, n_8];

        int num_8 = 1;
        int top_8 = 0, bottom_8 = n_8 - 1, left_8 = 0, right_8 = n_8 - 1;

        while (num_8 <= n_8 * n_8)
        {
            for (int j = left_8; j <= right_8 && num_8 <= n_8 * n_8; j++)
                matrix_8[top_8, j] = num_8++;
            top_8++;

            for (int i = top_8; i <= bottom_8 && num_8 <= n_8 * n_8; i++)
                matrix_8[i, right_8] = num_8++;
            right_8--;

            for (int j = right_8; j >= left_8 && num_8 <= n_8 * n_8; j--)
                matrix_8[bottom_8, j] = num_8++;
            bottom_8--;

            for (int i = bottom_8; i >= top_8 && num_8 <= n_8 * n_8; i--)
                matrix_8[i, left_8] = num_8++;
            left_8++;
        }

        Console.WriteLine($"Матрица {n_8}x{n_8} по спирали по часовой стрелке:");
        PrintMatrix(matrix_8);

        // Задача 9
        Console.WriteLine("\n=== Задача 9 ===");
        Console.Write("Введите количество строк M: ");
        int M_9 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов N: ");
        int N_9 = int.Parse(Console.ReadLine());
        int[,] matrixA_9 = new int[M_9, N_9];
        Console.WriteLine($"Введите элементы массива {M_9}x{N_9}:");
        for (int i = 0; i < M_9; i++)
        {
            for (int j = 0; j < N_9; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrixA_9[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int[] arrayB_9 = new int[M_9];
        for (int i = 0; i < M_9; i++)
        {
            arrayB_9[i] = i;
        }

        Console.WriteLine($"Массив B (номера строк): [{string.Join(", ", arrayB_9)}]");

        // Задача 10
        Console.WriteLine("\n=== Задача 10 ===");
        Console.Write("Введите количество строк N: ");
        int N_10 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов M: ");
        int M_10 = int.Parse(Console.ReadLine());
        int[,] matrixA_10 = new int[N_10, M_10];
        Console.WriteLine($"Введите элементы массива {N_10}x{M_10}:");
        for (int i = 0; i < N_10; i++)
        {
            for (int j = 0; j < M_10; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrixA_10[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Введите число B: ");
        int B_10 = int.Parse(Console.ReadLine());

        List<int> arrayC_10 = new List<int>();
        int count_10 = 0;

        for (int i = 0; i < N_10; i++)
        {
            for (int j = 0; j < M_10; j++)
            {
                if (Math.Abs(matrixA_10[i, j]) > B_10)
                {
                    arrayC_10.Add(matrixA_10[i, j]);
                    count_10++;
                }
            }
        }

        Console.WriteLine($"Количество элементов > |{B_10}|: {count_10}");
        Console.WriteLine($"Массив C: [{string.Join(", ", arrayC_10)}]");

        // Задача 11
        Console.WriteLine("\n=== Задача 11 ===");
        Console.Write("Введите количество строк N: ");
        int N_11 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов M: ");
        int M_11 = int.Parse(Console.ReadLine());
        int[,] matrixA_11 = new int[N_11, M_11];
        Console.WriteLine($"Введите элементы массива {N_11}x{M_11}:");
        for (int i = 0; i < N_11; i++)
        {
            for (int j = 0; j < M_11; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrixA_11[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Введите число для поиска: ");
        int searchNum_11 = int.Parse(Console.ReadLine());

        int count_11 = 0;
        for (int i = 0; i < N_11; i++)
        {
            for (int j = 0; j < M_11; j++)
            {
                if (matrixA_11[i, j] == searchNum_11)
                {
                    count_11++;
                }
            }
        }
        Console.WriteLine($"Число {searchNum_11} встречается {count_11} раз");

        // Задача 12
        Console.WriteLine("\n=== Задача 12 ===");
        int[,] matrixA_12 = new int[5, 10];
        Console.WriteLine("Введите элементы массива 5x10:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrixA_12[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int maxAbs_12 = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (Math.Abs(matrixA_12[i, j]) > maxAbs_12)
                {
                    maxAbs_12 = Math.Abs(matrixA_12[i, j]);
                }
            }
        }

        double[,] matrixB_12 = new double[5, 10];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrixB_12[i, j] = (double)matrixA_12[i, j] / maxAbs_12;
            }
        }

        Console.WriteLine("Новая матрица (после деления):");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{matrixB_12[i, j]:F2} ");
            }
            Console.WriteLine();
        }

        // Задача 13
        Console.WriteLine("\n=== Задача 13 ===");
        Console.Write("Введите количество строк: ");
        int rows_13 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int cols_13 = int.Parse(Console.ReadLine());
        int[,] matrix_13 = new int[rows_13, cols_13];
        Console.WriteLine($"Введите элементы массива {rows_13}x{cols_13}:");
        for (int i = 0; i < rows_13; i++)
        {
            for (int j = 0; j < cols_13; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_13[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int minValue_13 = matrix_13[0, 0];
        int minRow_13 = 0;
        for (int i = 0; i < rows_13; i++)
        {
            for (int j = 0; j < cols_13; j++)
            {
                if (matrix_13[i, j] < minValue_13)
                {
                    minValue_13 = matrix_13[i, j];
                    minRow_13 = i;
                }
            }
        }

        int[,] newMatrix_13 = new int[rows_13 + 1, cols_13];
        int newRow_13 = 0;

        for (int i = 0; i < rows_13; i++)
        {
            for (int j = 0; j < cols_13; j++)
            {
                newMatrix_13[newRow_13, j] = matrix_13[i, j];
            }
            newRow_13++;

            if (i == minRow_13)
            {
                for (int j = 0; j < cols_13; j++)
                {
                    newMatrix_13[newRow_13, j] = matrix_13[0, j];
                }
                newRow_13++;
            }
        }

        Console.WriteLine("Матрица после вставки:");
        PrintMatrix(newMatrix_13);

        // Задача 14
        Console.WriteLine("\n=== Задача 14 ===");
        int[,] matrixB_14 = new int[5, 5];
        Console.WriteLine("Введите элементы массива 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrixB_14[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int product_14 = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                product_14 *= matrixB_14[i, j];
            }
        }
        Console.WriteLine($"Произведение элементов ниже главной диагонали: {product_14}");

        // Задача 15
        Console.WriteLine("\n=== Задача 15 ===");
        int[,] matrixB_15 = new int[5, 5];
        Console.WriteLine("Введите элементы массива 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrixB_15[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int sum_15 = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                sum_15 += matrixB_15[i, j];
            }
        }
        Console.WriteLine($"Сумма элементов выше главной диагонали: {sum_15}");

        // Задача 16
        Console.WriteLine("\n=== Задача 16 ===");
        int[,] matrix16 = new int[5, 5];
        Console.WriteLine("Введите элементы массива 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix16[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int j = 0; j < 5; j++)
        {
            if (matrix16[0, j] < 0)
            {
                matrix16[0, j] = 0;
            }
        }

        Console.WriteLine("Матрица после замены:");
        PrintMatrix(matrix16);

        // Задача 17
        Console.WriteLine("\n=== Задача 17 ===");
        int[,] matrix17 = new int[5, 5];
        Console.WriteLine("Введите элементы массива 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix17[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int maxAbs_17 = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (Math.Abs(matrix17[i, j]) > maxAbs_17)
                {
                    maxAbs_17 = Math.Abs(matrix17[i, j]);
                }
            }
        }

        double[,] newMatrix_17 = new double[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                newMatrix_17[i, j] = (double)matrix17[i, j] / maxAbs_17;
            }
        }

        Console.WriteLine("Новая матрица:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{newMatrix_17[i, j]} ");
            }
            Console.WriteLine();
        }

        // Задача 18
        Console.WriteLine("\n=== Задача 18 ===");
        Console.Write("Введите количество строк M: ");
        int M_18 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов N: ");
        int N_18 = int.Parse(Console.ReadLine());
        int[,] matrix18 = new int[M_18, N_18];
        Console.WriteLine($"Введите элементы массива {M_18}x{N_18}:");
        for (int i = 0; i < M_18; i++)
        {
            for (int j = 0; j < N_18; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix18[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int j = 0; j < N_18; j++)
        {
            int[] column = new int[M_18];
            for (int i = 0; i < M_18; i++)
            {
                column[i] = matrix18[i, j];
            }

            if (j % 2 == 0)
            {
                Array.Sort(column);
            }
            else
            {
                Array.Sort(column);
                Array.Reverse(column);
            }

            for (int i = 0; i < M_18; i++)
            {
                matrix18[i, j] = column[i];
            }
        }

        Console.WriteLine("Матрица после сортировки:");
        PrintMatrix(matrix18);

        // Задача 19
        Console.WriteLine("\n=== Задача 19 ===");
        int[,] matrix19 = new int[8, 5];
        Console.WriteLine("Введите элементы массива 8x5:");
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix19[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int sumCol2_19 = 0;
        for (int i = 0; i < 8; i++)
        {
            sumCol2_19 += matrix_19[i, 1];
        }

        int sumRow3_19 = 0;
        for (int j = 0; j < 5; j++)
        {
            sumRow3_19 += matrix19[2, j];
        }

        Console.WriteLine($"Сумма второго столбца: {sumCol2_19}");
        Console.WriteLine($"Сумма третьей строки: {sumRow3_19}");

        // Задача 20
        Console.WriteLine("\n=== Задача 20 ===");
        Console.Write("Введите количество строк M: ");
        int M_20 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов N: ");
        int N_20 = int.Parse(Console.ReadLine());
        int[,] matrix20 = new int[M_20, N_20];
        Console.WriteLine($"Введите элементы массива {M_20}x{N_20}:");
        for (int i = 0; i < M_20; i++)
        {
            for (int j = 0; j < N_20; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix20[i, j] = int.Parse(Console.ReadLine());
            }
        }

        List<int> array_20 = new List<int>();
        for (int i = 0; i < M_20; i++)
        {
            for (int j = 0; j < N_20; j++)
            {
                if (matrix20[i, j] >= 1 && matrix20[i, j] <= 20)
                {
                    array_20.Add(matrix20[i, j]);
                }
            }
        }

        double avg_20 = array_20.Count > 0 ? array_20.Average() : 0;
        Console.WriteLine($"Одномерный массив: [{string.Join(", ", array_20)}]");
        Console.WriteLine($"Среднее арифметическое: {avg_20}");

        // Задача 21
        Console.WriteLine("\n=== Задача 21 ===");
        Console.Write("Введите количество строк M: ");
        int M_21 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов N: ");
        int N_21 = int.Parse(Console.ReadLine());
        int[,] matrix21 = new int[M_21, N_21];
        Console.WriteLine($"Введите элементы массива {M_21}x{N_21}:");
        for (int i = 0; i < M_21; i++)
        {
            for (int j = 0; j < N_21; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix21[i, j] = int.Parse(Console.ReadLine());
            }
        }

        List<int> array21 = new List<int>();
        for (int i = 0; i < M_21; i++)
        {
            for (int j = 0; j < N_21; j++)
            {
                if (matrix21[i, j] >= 1 && matrix21[i, j] <= 10)
                {
                    array21.Add(matrix21[i, j]);
                }
            }
        }

        long product21 = 1;
        foreach (int num in array21)
        {
            product21 *= num;
        }
        Console.WriteLine($"Одномерный массив: [{string.Join(", ", array21)}]");
        Console.WriteLine($"Произведение элементов: {product21}");

        // Задача 22
        Console.WriteLine("\n=== Задача 22 ===");
        Console.Write("Введите размер квадратной матрицы: ");
        int size22 = int.Parse(Console.ReadLine());
        int[,] matrix22 = new int[size22, size22];
        Console.WriteLine($"Введите элементы массива {size22}x{size22}:");
        for (int i = 0; i < size22; i++)
        {
            for (int j = 0; j < size22; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix22[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < size22; i++)
        {
            int maxInRow22 = matrix22[i, 0];
            int maxIndex22 = 0;

            for (int j = 1; j < size22; j++)
            {
                if (matrix22[i, j] > maxInRow22)
                {
                    maxInRow22 = matrix22[i, j];
                    maxIndex22 = j;
                }
            }

            int temp22 = matrix22[i, i];
            matrix22[i, i] = matrix22[i, maxIndex22];
            matrix22[i, maxIndex22] = temp22;
        }

        Console.WriteLine("Матрица после замен:");
        PrintMatrix(matrix22);

        // Задача 23
        Console.WriteLine("\n=== Задача 23 ===");
        Console.Write("Введите размер квадратной матрицы: ");
        int size23 = int.Parse(Console.ReadLine());
        int[,] matrix23 = new int[size23, size23];
        Console.WriteLine($"Введите элементы массива {size23}x{size23}:");
        for (int i = 0; i < size23; i++)
        {
            for (int j = 0; j < size23; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix23[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int minColumn23 = 0;
        int minCount23 = int.MaxValue;

        for (int j = 0; j < size23; j++)
        {
            int count23 = 0;
            for (int i = 0; i < size23; i++)
            {
                int sumIndex23 = i + j;
                if (matrix23[i, j] % sumIndex23 == 0 && sumIndex23 != 0)
                {
                    count23++;
                }
            }

            if (count23 < minCount23)
            {
                minCount23 = count23;
                minColumn23 = j;
            }
        }

        Console.WriteLine($"Столбец с минимальным количеством элементов, кратных сумме индексов: {minColumn23 + 1}");

        // Задача 24
        Console.WriteLine("\n=== Задача 24 ===");
        Console.Write("Введите размер квадратной матрицы: ");
        int size24 = int.Parse(Console.ReadLine());
        int[,] matrix24 = new int[size24, size24];
        Console.WriteLine($"Введите элементы массива {size24}x{size24}:");
        for (int i = 0; i < size24; i++)
        {
            for (int j = 0; j < size24; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix24[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int sumAbove24 = 0;
        for (int i = 0; i < size24; i++)
        {
            for (int j = i + 1; j < size24; j++)
            {
                sumAbove24 += matrix24[i, j];
            }
        }
        Console.WriteLine($"Сумма элементов выше главной диагонали: {sumAbove24}");

        // Задача 25
        Console.WriteLine("\n=== Задача 25 ===");
        Console.Write("Введите размер квадратной матрицы: ");
        int size25 = int.Parse(Console.ReadLine());
        int[,] matrix25 = new int[size25, size25];
        Console.WriteLine($"Введите элементы массива {size25}x{size25}:");
        for (int i = 0; i < size25; i++)
        {
            for (int j = 0; j < size25; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix25[i, j] = int.Parse(Console.ReadLine());
            }
        }

        bool isSymmetric25 = true;
        for (int i = 0; i < size25; i++)
        {
            for (int j = i + 1; j < size25; j++)
            {
                if (matrix25[i, j] != matrix25[j, i])
                {
                    isSymmetric25 = false;
                    break;
                }
            }
            if (!isSymmetric25) break;
        }

        Console.WriteLine(isSymmetric25 ? "Массив симметричен" : "Массив не симметричен");

        // Задача 26
        Console.WriteLine("\n=== Задача 26 ===");
        Console.Write("Введите размер квадратной матрицы: ");
        int size26 = int.Parse(Console.ReadLine());
        int[,] matrix26 = new int[size26, size26];
        Console.WriteLine($"Введите элементы массива {size26}x{size26}:");
        for (int i = 0; i < size26; i++)
        {
            for (int j = 0; j < size26; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix26[i, j] = int.Parse(Console.ReadLine());
            }
        }

        bool isNotSymmetric26 = false;
        for (int i = 0; i < size26; i++)
        {
            for (int j = i + 1; j < size26; j++)
            {
                if (matrix26[i, j] != matrix26[j, i])
                {
                    isNotSymmetric26 = true;
                    break;
                }
            }
            if (isNotSymmetric26) break;
        }

        Console.WriteLine(isNotSymmetric26 ? "Массив не симметричен" : "Массив симметричен");

        // Задача 27
        Console.WriteLine("\n=== Задача 27 ===");
        Console.Write("Введите n: ");
        int n27 = int.Parse(Console.ReadLine());
        Console.Write("Введите m: ");
        int m27 = int.Parse(Console.ReadLine());
        int[,] matrix27 = new int[m27, m27];

        for (int index = 0; index < m27 * m27; index++)
        {
            int i = index / m27;
            int j = index % m27;
            matrix27[i, j] = (i + 1) * (j + 1);
        }

        Console.WriteLine("Таблица умножения:");
        PrintMatrix(matrix27);

        // Задача 28
        Console.WriteLine("\n=== Задача 28 ===");
        Console.Write("Введите количество строк N: ");
        int N28 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов M: ");
        int M28 = int.Parse(Console.ReadLine());
        int[,] matrix28 = new int[N28, M28];
        Console.WriteLine($"Введите элементы массива {N28}x{M28}:");
        for (int i = 0; i < N28; i++)
        {
            for (int j = 0; j < M28; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix28[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int minSameRow28 = 0;
        int minSameCount28 = int.MaxValue;

        for (int i = 0; i < N28; i++)
        {
            Dictionary<int, int> frequency28 = new Dictionary<int, int>();
            for (int j = 0; j < M28; j++)
            {
                if (frequency28.ContainsKey(matrix28[i, j]))
                    frequency28[matrix28[i, j]]++;
                else
                    frequency28[matrix28[i, j]] = 1;
            }

            int maxFreq28 = frequency28.Values.Max();
            if (maxFreq28 < minSameCount28)
            {
                minSameCount28 = maxFreq28;
                minSameRow28 = i;
            }
        }

        Console.WriteLine($"Строка с минимальным числом одинаковых элементов: {minSameRow28 + 1}");

        // Задача 29
        Console.WriteLine("\n=== Задача 29 ===");
        Console.Write("Введите размер квадратной матрицы: ");
        int size29 = int.Parse(Console.ReadLine());
        int[,] matrix29 = new int[size29, size29];
        Console.WriteLine($"Введите элементы массива {size29}x{size29}:");
        for (int i = 0; i < size29; i++)
        {
            for (int j = 0; j < size29; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix29[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int productBelow29 = 1;
        for (int i = 0; i < size29; i++)
        {
            for (int j = 0; j < i; j++)
            {
                productBelow29 *= matrix29[i, j];
            }
        }
        Console.WriteLine($"Произведение элементов ниже главной диагонали: {productBelow29}");

        // Задача 30
        Console.WriteLine("\n=== Задача 30 ===");
        Console.Write("Введите количество строк N: ");
        int N30 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов M: ");
        int M30 = int.Parse(Console.ReadLine());
        int[,] matrix30 = new int[N30, M30];
        Console.WriteLine($"Введите элементы массива {N30}x{M30}:");
        for (int i = 0; i < N30; i++)
        {
            for (int j = 0; j < M30; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix30[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int maxSameRow30 = 0;
        int maxSameCount30 = 0;

        for (int i = 0; i < N30; i++)
        {
            Dictionary<int, int> frequency30 = new Dictionary<int, int>();
            for (int j = 0; j < M30; j++)
            {
                if (frequency30.ContainsKey(matrix30[i, j]))
                    frequency30[matrix30[i, j]]++;
                else
                    frequency30[matrix30[i, j]] = 1;
            }

            int maxFreq30 = frequency30.Values.Max();
            if (maxFreq30 > maxSameCount30)
            {
                maxSameCount30 = maxFreq30;
                maxSameRow30 = i;
            }
        }

        Console.WriteLine($"Строка с максимальным числом одинаковых элементов: {maxSameRow30 + 1}");


        #endregion


        #region Задания с 1 по 20 с двумерными массивами

        // Задача 1
        Console.WriteLine("=== Задача 1 ===");
        Console.Write("Введите количество точек: ");
        int n1 = int.Parse(Console.ReadLine());

        double[] x1 = new double[n1];
        double[] y1 = new double[n1];

        Console.WriteLine("Введите координаты точек (x y):");
        for (int i = 0; i < n1; i++)
        {
            string[] coords = Console.ReadLine().Split();
            x1[i] = double.Parse(coords[0]);
            y1[i] = double.Parse(coords[1]);
        }

        int maxCount1 = 0;
        double bestX1 = 0, bestY1 = 0, bestR1 = 0;

        for (int i = 0; i < n1; i++)
        {
            for (int j = i + 1; j < n1; j++)
            {
                double centerX1 = (x1[i] + x1[j]) / 2;
                double centerY1 = (y1[i] + y1[j]) / 2;
                double radius1 = Math.Sqrt(Math.Pow(x1[i] - centerX1, 2) + Math.Pow(y1[i] - centerY1, 2));

                int count1 = 0;
                for (int k = 0; k < n1; k++)
                {
                    double distance1 = Math.Sqrt(Math.Pow(x1[k] - centerX1, 2) + Math.Pow(y1[k] - centerY1, 2));
                    if (Math.Abs(distance1 - radius1) < 1e-10)
                        count1++;
                }

                if (count1 > maxCount1)
                {
                    maxCount1 = count1;
                    bestX1 = centerX1;
                    bestY1 = centerY1;
                    bestR1 = radius1;
                }
            }
        }

        Console.WriteLine($"Центр: ({bestX1:F2}, {bestY1:F2}), Радиус: {bestR1:F2}, Точек: {maxCount1}");

        // Задача 2
        Console.WriteLine("\n=== Задача 2 ===");
        Console.Write("Введите количество студентов: ");
        int n2 = int.Parse(Console.ReadLine());

        string[] surnames2 = new string[n2];
        double[] times2 = new double[n2];

        for (int i = 0; i < n2; i++)
        {
            Console.Write($"Фамилия {i + 1}: ");
            surnames2[i] = Console.ReadLine();
            Console.Write($"Время {i + 1} (сек): ");
            times2[i] = double.Parse(Console.ReadLine());
        }

        var sorted2 = surnames2.Zip(times2, (s, t) => new { Surname = s, Time = t })
                              .OrderBy(x => x.Time)
                              .Take(4)
                              .ToArray();

        Console.WriteLine("Команда из 4 лучших бегунов:");
        for (int i = 0; i < sorted2.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {sorted2[i].Surname} - {sorted2[i].Time} сек");
        }

        // Задача 3
        Console.WriteLine("\n=== Задача 3 ===");
        Console.Write("Введите количество строк I: ");
        int I3 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов J: ");
        int J3 = int.Parse(Console.ReadLine());

        int[,] L3 = new int[I3, J3];
        Random rand3 = new Random();

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < I3; i++)
        {
            for (int j = 0; j < J3; j++)
            {
                L3[i, j] = rand3.Next(1, 21);
                Console.Write($"{L3[i, j],4}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Преобразованный массив:");
        for (int i = 0; i < I3; i++)
        {
            for (int j = 0; j < J3; j++)
            {
                L3[i, j] = -L3[i, j] * 3;
                Console.Write($"{L3[i, j],4}");
            }
            Console.WriteLine();
        }

        // Задача 4
        Console.WriteLine("\n=== Задача 4 ===");
        Console.Write("Введите размер квадратной матрицы: ");
        int size4 = int.Parse(Console.ReadLine());
        int[,] matrix4 = new int[size4, size4];

        Console.WriteLine($"Введите элементы матрицы {size4}x{size4}:");
        for (int i = 0; i < size4; i++)
        {
            for (int j = 0; j < size4; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix4[i, j] = int.Parse(Console.ReadLine());
            }
        }

        List<int> belowDiagonal4 = new List<int>();
        for (int i = 1; i < size4; i++)
        {
            for (int j = 0; j < i; j++)
            {
                belowDiagonal4.Add(matrix4[i, j]);
            }
        }

        Console.WriteLine("Матрица:");
        PrintMatrix(matrix4);

        Console.WriteLine($"Массив до сортировки: [{string.Join(", ", belowDiagonal4)}]");

        belowDiagonal4.Sort();
        Console.WriteLine($"Массив после сортировки: [{string.Join(", ", belowDiagonal4)}]");

        // Задача 5
        Console.WriteLine("\n=== Задача 5 ===");
        Console.Write("Введите количество строк: ");
        int rows5 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int cols5 = int.Parse(Console.ReadLine());

        int[,] matrix5 = new int[rows5, cols5];
        Random rand5 = new Random();

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows5; i++)
        {
            for (int j = 0; j < cols5; j++)
            {
                matrix5[i, j] = rand5.Next(1, 101);
                Console.Write($"{matrix5[i, j],4}");
            }
            Console.WriteLine();
        }

        int[] flatArray5 = new int[rows5 * cols5];
        for (int i = 0; i < rows5; i++)
            for (int j = 0; j < cols5; j++)
                flatArray5[i * cols5 + j] = matrix5[i, j];

        int[] bubble5 = (int[])flatArray5.Clone();
        for (int i = 0; i < bubble5.Length - 1; i++)
            for (int j = 0; j < bubble5.Length - i - 1; j++)
                if (bubble5[j] > bubble5[j + 1])
                    (bubble5[j], bubble5[j + 1]) = (bubble5[j + 1], bubble5[j]);

        Console.WriteLine($"Пузырьком: [{string.Join(", ", bubble5.Take(10))}...]");

        int[] insertion5 = (int[])flatArray5.Clone();
        for (int i = 1; i < insertion5.Length; i++)
        {
            int key = insertion5[i];
            int j = i - 1;
            while (j >= 0 && insertion5[j] > key)
            {
                insertion5[j + 1] = insertion5[j];
                j--;
            }
            insertion5[j + 1] = key;
        }

        Console.WriteLine($"Вставкой: [{string.Join(", ", insertion5.Take(10))}...]");

        int[] selection5 = (int[])flatArray5.Clone();
        for (int i = 0; i < selection5.Length - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < selection5.Length; j++)
                if (selection5[j] < selection5[minIdx])
                    minIdx = j;

            (selection5[i], selection5[minIdx]) = (selection5[minIdx], selection5[i]);
        }

        Console.WriteLine($"Выбором: [{string.Join(", ", selection5.Take(10))}...]");

        // Задача 6
        Console.WriteLine("\n=== Задача 6 ===");
        Console.Write("Введите M: ");
        int M6 = int.Parse(Console.ReadLine());
        Console.Write("Введите N: ");
        int N6 = int.Parse(Console.ReadLine());

        int[,] matrix6 = new int[M6, N6];
        Random rand6 = new Random();

        Console.WriteLine("Матрица:");
        for (int i = 0; i < M6; i++)
        {
            for (int j = 0; j < N6; j++)
            {
                matrix6[i, j] = rand6.Next(0, 101);
                Console.Write($"{matrix6[i, j],4}");
            }
            Console.WriteLine();
        }

        HashSet<int> firstRowSet6 = new HashSet<int>();
        for (int j = 0; j < N6; j++)
            firstRowSet6.Add(matrix6[0, j]);

        int similarCount6 = 0;
        for (int i = 1; i < M6; i++)
        {
            HashSet<int> currentRowSet6 = new HashSet<int>();
            for (int j = 0; j < N6; j++)
                currentRowSet6.Add(matrix6[i, j]);

            if (firstRowSet6.SetEquals(currentRowSet6))
                similarCount6++;
        }

        Console.WriteLine($"Строк, похожих на первую: {similarCount6}");

        // Задача 7
        Console.WriteLine("\n=== Задача 7 ===");
        Console.Write("Введите количество строк: ");
        int rows7 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int cols7 = int.Parse(Console.ReadLine());

        int[,] matrix7 = new int[rows7, cols7 + 1];
        Console.WriteLine($"Введите элементы матрицы {rows7}x{cols7}:");
        for (int i = 0; i < rows7; i++)
        {
            for (int j = 0; j < cols7; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix7[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Введите k для поиска: ");
        int k7 = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows7; i++)
        {
            matrix7[i, cols7] = k7;

            int j = 0;
            while (matrix7[i, j] != k7)
                j++;

            if (j < cols7)
                Console.WriteLine($"Строка {i + 1}: найден в столбце {j + 1}");
            else
                Console.WriteLine($"Строка {i + 1}: не найден");
        }

        // Задача 8
        Console.WriteLine("\n=== Задача 8 ===");
        int[,] A8 = new int[3, 3];
        Console.WriteLine("Введите элементы массива 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                A8[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int minSum8 = int.MaxValue;
        int minRow8 = -1;

        for (int i = 0; i < 3; i++)
        {
            int rowSum8 = 0;
            for (int j = 0; j < 3; j++)
                rowSum8 += A8[i, j];

            if (rowSum8 < minSum8)
            {
                minSum8 = rowSum8;
                minRow8 = i;
            }
        }

        Console.WriteLine($"Минимальная сумма: {minSum8} в строке {minRow8 + 1}");
        Console.WriteLine("Матрица после умножения:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                A8[i, j] *= minSum8;
                Console.Write($"{A8[i, j],6}");
            }
            Console.WriteLine();
        }

        // Задача 9
        Console.WriteLine("\n=== Задача 9 ===");
        Console.Write("Введите порядок матрицы N: ");
        int N9 = int.Parse(Console.ReadLine());
        int[,] matrix9 = new int[N9, N9];
        Random rand9 = new Random();

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < N9; i++)
        {
            for (int j = 0; j < N9; j++)
            {
                matrix9[i, j] = rand9.Next(1, 21);
                Console.Write($"{matrix9[i, j],4}");
            }
            Console.WriteLine();
        }

        (int value, int index)[] lastElements9 = new (int, int)[N9];
        for (int i = 0; i < N9; i++)
            lastElements9[i] = (matrix9[i, N9 - 1], i);

        Array.Sort(lastElements9, (a, b) => b.value.CompareTo(a.value));

        int[,] sortedMatrix9 = new int[N9, N9];
        for (int i = 0; i < N9; i++)
            for (int j = 0; j < N9; j++)
                sortedMatrix9[i, j] = matrix9[lastElements9[i].index, j];

        Console.WriteLine("Матрица после перестановки:");
        PrintMatrix(sortedMatrix9);

        // Задача 10
        Console.WriteLine("\n=== Задача 10 ===");
        int[,] matrix10 = new int[5, 10];
        Random rand10 = new Random();

        Console.WriteLine("Матрица 5x10:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix10[i, j] = rand10.Next(1, 101);
                Console.Write($"{matrix10[i, j],4}");
            }
            Console.WriteLine();
        }

        int decreasingColumns10 = 0;
        for (int j = 0; j < 10; j++)
        {
            bool isDecreasing10 = true;
            for (int i = 1; i < 5; i++)
            {
                if (matrix10[i, j] >= matrix10[i - 1, j])
                {
                    isDecreasing10 = false;
                    break;
                }
            }
            if (isDecreasing10)
                decreasingColumns10++;
        }

        Console.WriteLine($"Количество монотонно убывающих столбцов: {decreasingColumns10}");

        // Задача 11
        Console.WriteLine("\n=== Задача 11 ===");
        Console.Write("Введите n: ");
        int n11 = int.Parse(Console.ReadLine());
        Console.Write("Введите m: ");
        int m11 = int.Parse(Console.ReadLine());

        int[,] matrix11 = new int[n11, m11];
        Random rand11 = new Random();

        Console.WriteLine($"Матрица {n11}x{m11}:");
        for (int i = 0; i < n11; i++)
        {
            for (int j = 0; j < m11; j++)
            {
                matrix11[i, j] = rand11.Next(1, 101);
                Console.Write($"{matrix11[i, j],4}");
            }
            Console.WriteLine();
        }

        int maxOfMin11 = int.MinValue;
        int resultI11 = -1, resultJ11 = -1;

        for (int i = 0; i < n11; i++)
        {
            int minInRow11 = matrix11[i, 0];
            int minJ11 = 0;

            for (int j = 1; j < m11; j++)
            {
                if (matrix11[i, j] < minInRow11)
                {
                    minInRow11 = matrix11[i, j];
                    minJ11 = j;
                }
            }

            if (minInRow11 > maxOfMin11)
            {
                maxOfMin11 = minInRow11;
                resultI11 = i;
                resultJ11 = minJ11;
            }
        }

        Console.WriteLine($"Координаты: [{resultI11}, {resultJ11}], значение: {maxOfMin11}");

        // Задача 12
        Console.WriteLine("\n=== Задача 12 ===");
        Console.Write("Введите количество строк: ");
        int rows12 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int cols12 = int.Parse(Console.ReadLine());

        int[,] matrix12 = new int[rows12, cols12];
        Random rand12 = new Random();

        Console.WriteLine("Матрица:");
        for (int i = 0; i < rows12; i++)
        {
            for (int j = 0; j < cols12; j++)
            {
                matrix12[i, j] = rand12.Next(1, 101);
                Console.Write($"{matrix12[i, j],4}");
            }
            Console.WriteLine();
        }

        int maxInSorted12 = 0;
        bool found12 = false;

        for (int j = 0; j < cols12; j++)
        {
            bool isIncreasing12 = true;
            bool isDecreasing12 = true;

            for (int i = 1; i < rows12; i++)
            {
                if (matrix12[i, j] <= matrix12[i - 1, j])
                    isIncreasing12 = false;
                if (matrix12[i, j] >= matrix12[i - 1, j])
                    isDecreasing12 = false;
            }

            if (isIncreasing12 || isDecreasing12)
            {
                int colMax12 = matrix12[0, j];
                for (int i = 1; i < rows12; i++)
                    if (matrix12[i, j] > colMax12)
                        colMax12 = matrix12[i, j];

                if (!found12 || colMax12 > maxInSorted12)
                {
                    maxInSorted12 = colMax12;
                    found12 = true;
                }
            }
        }

        Console.WriteLine(found12 ? $"Максимальный элемент: {maxInSorted12}" : "0");

        // Задача 13
        Console.WriteLine("\n=== Задача 13 ===");
        Console.Write("Введите размер матрицы N: ");
        int N13 = int.Parse(Console.ReadLine());
        int[,] matrix13 = new int[N13, N13];
        Random rand13 = new Random();

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < N13; i++)
        {
            for (int j = 0; j < N13; j++)
            {
                matrix13[i, j] = rand13.Next(1, 21);
                Console.Write($"{matrix13[i, j],4}");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < N13 - 1; i++)
        {
            for (int j = 0; j < N13 - i - 1; j++)
            {
                int temp13 = matrix13[i, j];
                matrix13[i, j] = matrix13[N13 - j - 1, N13 - i - 1];
                matrix13[N13 - j - 1, N13 - i - 1] = temp13;
            }
        }

        Console.WriteLine("После отражения:");
        PrintMatrix(matrix13);

        // Задача 14
        Console.WriteLine("\n=== Задача 14 ===");
        Console.Write("Введите N: ");
        int N14 = int.Parse(Console.ReadLine());
        Console.Write("Введите M: ");
        int M14 = int.Parse(Console.ReadLine());

        int[,] matrix14 = new int[N14, M14];
        Random rand14 = new Random();

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < N14; i++)
        {
            for (int j = 0; j < M14; j++)
            {
                matrix14[i, j] = rand14.Next(1, 21);
                Console.Write($"{matrix14[i, j],4}");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < N14; i++)
        {
            int minVal14 = matrix14[i, 0];
            int minJ14 = 0;

            for (int j = 1; j < M14; j++)
            {
                if (matrix14[i, j] < minVal14)
                {
                    minVal14 = matrix14[i, j];
                    minJ14 = j;
                }
            }

            if (minJ14 != 0)
            {
                int temp14 = matrix14[i, 0];
                matrix14[i, 0] = matrix14[i, minJ14];
                matrix14[i, minJ14] = temp14;
            }
        }

        Console.WriteLine("После преобразования:");
        PrintMatrix(matrix14);

        // Задача 15
        Console.WriteLine("\n=== Задача 15 ===");
        Console.Write("Введите n: ");
        int n15 = int.Parse(Console.ReadLine());
        int[,] A15 = new int[n15, n15];

        for (int i = 0; i < n15; i++)
        {
            for (int j = 0; j < n15; j++)
            {
                if (i + j == n15 - 1)
                    A15[i, j] = 1;
                else if (i + j < n15 - 1)
                    A15[i, j] = 0;
                else
                    A15[i, j] = 2;
            }
        }

        Console.WriteLine("Массив по правилу:");
        PrintMatrix(A15);

        // Задача 16
        Console.WriteLine("\n=== Задача 16 ===");
        Console.Write("Введите размер квадратной матрицы: ");
        int size16 = int.Parse(Console.ReadLine());
        int[,] matrix116 = new int[size16, size16];

        Console.WriteLine($"Введите элементы массива {size16}x{size16}:");
        for (int i = 0; i < size16; i++)
        {
            for (int j = 0; j < size16; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix116[i, j] = int.Parse(Console.ReadLine());
            }
        }

        bool isSymmetric16 = true;
        for (int i = 0; i < size16; i++)
        {
            for (int j = i + 1; j < size16; j++)
            {
                if (matrix116[i, j] != matrix116[j, i])
                {
                    isSymmetric16 = false;
                    break;
                }
            }
            if (!isSymmetric16) break;
        }

        Console.WriteLine(isSymmetric16 ? "Массив симметричен" : "Массив не симметричен");

        // Задача 17
        Console.WriteLine("\n=== Задача 17 ===");
        Console.Write("Введите n: ");
        int n17 = int.Parse(Console.ReadLine());
        Console.Write("Введите m: ");
        int m17 = int.Parse(Console.ReadLine());

        int[,] C17 = new int[n17, m17];

        for (int j = 0; j < m17; j++)
            C17[0, j] = 1;
        for (int i = 0; i < n17; i++)
            C17[i, 0] = 1;

        for (int i = 1; i < n17; i++)
        {
            for (int j = 1; j < m17; j++)
            {
                C17[i, j] = C17[i - 1, j] + C17[i, j - 1];
            }
        }

        Console.WriteLine("Результирующий массив:");
        for (int i = 0; i < n17; i++)
        {
            for (int j = 0; j < m17; j++)
            {
                Console.Write($"{C17[i, j],6}");
            }
            Console.WriteLine();
        }

        // Задача 18
        Console.WriteLine("\n=== Задача 18 ===");
        Console.Write("Введите n: ");
        int n18 = int.Parse(Console.ReadLine());
        Console.Write("Введите m: ");
        int m18 = int.Parse(Console.ReadLine());

        int[,] A18 = new int[n18, m18];
        int counter18 = 0;

        for (int i = 0; i < n18; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < m18; j++)
                    A18[i, j] = counter18++;
            }
            else
            {
                for (int j = m18 - 1; j >= 0; j--)
                    A18[i, j] = counter18++;
            }
        }

        Console.WriteLine("Змейка:");
        PrintMatrix(A18);

        // Задача 19
        Console.WriteLine("\n=== Задача 19 ===");
        Console.Write("Введите n: ");
        int n19 = int.Parse(Console.ReadLine());
        Console.Write("Введите m: ");
        int m19 = int.Parse(Console.ReadLine());

        int[,] A19 = new int[n19, m19];
        int counter19 = 0;

        for (int d = 0; d < n19 + m19 - 1; d++)
        {
            if (d % 2 == 0)
            {
                for (int i = Math.Min(d, n19 - 1); i >= 0 && d - i < m19; i--)
                    A19[i, d - i] = counter19++;
            }
            else
            {
                for (int i = 0; i <= d && i < n19 && d - i < m19; i++)
                    A19[i, d - i] = counter19++;
            }
        }

        Console.WriteLine("Диагональное заполнение:");
        for (int i = 0; i < n19; i++)
        {
            for (int j = 0; j < m19; j++)
            {
                Console.Write($"{A19[i, j],3}");
            }
            Console.WriteLine();
        }

        // Задача 20
        Console.WriteLine("\n=== Задача 20 ===");
        Console.Write("Введите n: ");
        int n20 = int.Parse(Console.ReadLine());
        int size20 = 2 * n20 + 1;
        int[,] A20 = new int[size20, size20];

        int x20 = n20, y20 = n20;
        int value20 = 0;
        int step20 = 1;
        A20[y20, x20] = value20++;

        for (int len = 1; len < size20; len++)
        {
            for (int s = 0; s < len; s++)
            {
                y20--;
                if (y20 >= 0 && y20 < size20 && x20 >= 0 && x20 < size20)
                    A20[y20, x20] = value20++;
            }

            for (int s = 0; s < len; s++)
            {
                x20--;
                if (y20 >= 0 && y20 < size20 && x20 >= 0 && x20 < size20)
                    A20[y20, x20] = value20++;
            }

            len++;
            if (len >= size20) break;

            for (int s = 0; s < len; s++)
            {
                y20++;
                if (y20 >= 0 && y20 < size20 && x20 >= 0 && x20 < size20)
                    A20[y20, x20] = value20++;
            }

            for (int s = 0; s < len; s++)
            {
                x20++;
                if (y20 >= 0 && y20 < size20 && x20 >= 0 && x20 < size20)
                    A20[y20, x20] = value20++;
            }
        }

        Console.WriteLine("Спираль из центра:");
        for (int i = 0; i < size20; i++)
        {
            for (int j = 0; j < size20; j++)
            {
                Console.Write($"{A20[i, j],3}");
            }
            Console.WriteLine();
        }

        #endregion
    }
}