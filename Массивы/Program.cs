﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {
        #region Задания с 1 по 29
        Console.WriteLine("Решение задач по работе с массивами");

        // Задача 1
        Console.WriteLine("\n=== Задача 1 ===");
        Console.WriteLine("Ввести массив из 14 элементов целого типа. Найти количество элементов четных по значению.");

        int[] array1 = new int[14];
        Console.WriteLine("Введите 14 целых чисел:");
        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        int evenCount = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] % 2 == 0)
            {
                evenCount++;
            }
        }
        Console.WriteLine($"Количество четных элементов: {evenCount}");

        // Задача 2
        Console.WriteLine("\n=== Задача 2 ===");
        Console.WriteLine("Ввести массив из 12 элементов целого типа. Заменить 5-й элемент на среднее арифметическое.");

        int[] array2 = new int[12];
        Console.WriteLine("Введите 12 целых чисел:");
        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array2[i] = int.Parse(Console.ReadLine());
        }

        double average2 = array2.Average();
        int[] newArray2 = new int[12];
        Array.Copy(array2, newArray2, array2.Length);
        newArray2[4] = (int)Math.Round(average2);

        Console.WriteLine($"Исходный массив: [{string.Join(", ", array2)}]");
        Console.WriteLine($"Среднее арифметическое: {average2:F2}");
        Console.WriteLine($"Новый массив: [{string.Join(", ", newArray2)}]");

        // Задача 3
        Console.WriteLine("\n=== Задача 3 ===");
        Console.WriteLine("Задан массив из 11 элементов. Найти количество элементов, |значение| которых > среднего арифметического.");

        int[] array3 = new int[11];
        Console.WriteLine("Введите 11 целых чисел:");
        for (int i = 0; i < array3.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array3[i] = int.Parse(Console.ReadLine());
        }

        double average3 = array3.Average();
        int count3 = 0;
        for (int i = 0; i < array3.Length; i++)
        {
            if (Math.Abs(array3[i]) > average3)
            {
                count3++;
            }
        }
        Console.WriteLine($"Среднее арифметическое: {average3:F2}");
        Console.WriteLine($"Количество элементов с |x| > среднего: {count3}");

        // Задача 4
        Console.WriteLine("\n=== Задача 4 ===");
        Console.WriteLine("Ввести массив из 10 элементов. Поменять местами максимальный и первый элементы.");

        int[] array4 = new int[10];
        Console.WriteLine("Введите 10 целых чисел:");
        for (int i = 0; i < array4.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array4[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", array4)}]");

        int maxIndex4 = 0;
        for (int i = 1; i < array4.Length; i++)
        {
            if (array4[i] > array4[maxIndex4])
            {
                maxIndex4 = i;
            }
        }

        if (maxIndex4 != 0)
        {
            int temp = array4[0];
            array4[0] = array4[maxIndex4];
            array4[maxIndex4] = temp;
        }

        Console.WriteLine($"Массив после обмена: [{string.Join(", ", array4)}]");

        // Задача 5
        Console.WriteLine("\n=== Задача 5 ===");
        Console.WriteLine("Ввести массив из 9 элементов. Поменять местами максимальный и минимальный элементы.");

        int[] array5 = new int[9];
        Console.WriteLine("Введите 9 целых чисел:");
        for (int i = 0; i < array5.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array5[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", array5)}]");

        int maxIndex5 = 0, minIndex5 = 0;
        for (int i = 1; i < array5.Length; i++)
        {
            if (array5[i] > array5[maxIndex5])
                maxIndex5 = i;
            if (array5[i] < array5[minIndex5])
                minIndex5 = i;
        }

        Console.WriteLine($"Максимальный элемент: {array5[maxIndex5]} (индекс {maxIndex5})");
        Console.WriteLine($"Минимальный элемент: {array5[minIndex5]} (индекс {minIndex5})");

        // Обмен элементов
        if (maxIndex5 != minIndex5)
        {
            int temp = array5[maxIndex5];
            array5[maxIndex5] = array5[minIndex5];
            array5[minIndex5] = temp;

            Console.WriteLine("\nПосле обмена: [" + string.Join(", ", array5) + "]");
        }
        else
        {
            Console.WriteLine("\nВсе элементы массива одинаковы.");
        }

        // Задача 6
        Console.WriteLine("\n=== Задача 6 ===");
        Console.WriteLine("Ввести массив из 20 элементов. Определить каких элементов больше: четных или нечетных.");

        int[] array6 = new int[20];
        Console.WriteLine("Введите 20 целых чисел:");
        for (int i = 0; i < array6.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array6[i] = int.Parse(Console.ReadLine());
        }

        int evenCount6 = array6.Count(x => x % 2 == 0);
        int oddCount6 = array6.Length - evenCount6;

        if (evenCount6 > oddCount6)
            Console.WriteLine("Четных больше");
        else if (evenCount6 < oddCount6)
            Console.WriteLine("Нечетных больше");
        else
            Console.WriteLine("Четных больше");


        // Задача 7
        Console.WriteLine("\n=== Задача 7 ===");
        Console.WriteLine("Задан массив из 15 элементов вещественного типа. Определить количество элементов > первого элемента.");

        double[] array7 = new double[15];
        Console.WriteLine("Введите 15 вещественных чисел:");
        for (int i = 0; i < array7.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array7[i] = int.Parse(Console.ReadLine());
        }

        double first7 = array7[0];
        int count7 = 0;
        for (int i = 0; i < array7.Length; i++)
        {
            if (array7[i] > first7)
            {
                count7++;
            }
        }

        Console.WriteLine($"Первый элемент: {first7}");
        Console.WriteLine($"Количество элементов > первого: {count7}");

        // Задача 8
        Console.WriteLine("\n=== Задача 8 ===");
        Console.WriteLine("Задан массив из 16 элементов вещественного типа. Определить индексы максимального и минимального элементов.");

        double[] array8 = new double[16];
        Console.WriteLine("Введите 16 вещественных чисел:");
        for (int i = 0; i < array8.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array8[i] = double.Parse(Console.ReadLine());
        }

        int maxIndex8 = 0, minIndex8 = 0;
        for (int i = 1; i < array8.Length; i++)
        {
            if (array8[i] > array8[maxIndex8])
                maxIndex8 = i;
            if (array8[i] < array8[minIndex8])
                minIndex8 = i;
        }

        Console.WriteLine($"Максимальный элемент: array[{maxIndex8}] = {array8[maxIndex8]}");
        Console.WriteLine($"Минимальный элемент: array[{minIndex8}] = {array8[minIndex8]}");

        // Задача 9
        Console.WriteLine("\n=== Задача 9 ===");
        Console.WriteLine("Дан массив из 15 элементов целого типа. Получить новый массив как разность между элементами и средним арифметическим.");

        int[] array9 = new int[15];
        Console.WriteLine("Введите 15 целых чисел:");
        for (int i = 0; i < array9.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array9[i] = int.Parse(Console.ReadLine());
        }

        double average9 = array9.Average();
        double[] newArray9 = new double[15];
        for (int i = 0; i < array9.Length; i++)
        {
            newArray9[i] = array9[i] - average9;
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", array9)}]");
        Console.WriteLine($"Среднее арифметическое: {average9:F2}");
        Console.WriteLine($"Новый массив: [{string.Join(", ", newArray9.Select(x => x.ToString("F2")))}]");

        // Задача 10
        Console.WriteLine("\n=== Задача 10 ===");
        Console.WriteLine("Ввести целочисленный массив из 17 элементов. Найти сумму элементов, |значение| которых > среднеарифметического модулей отрицательных элементов.");

        int[] array10 = new int[17];
        Console.WriteLine("Введите 17 целых чисел (положительных и отрицательных):");
        for (int i = 0; i < array10.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array10[i] = int.Parse(Console.ReadLine());
        }

        var negativeElements = array10.Where(x => x < 0).ToArray();
        double negativeAvg = negativeElements.Length > 0 ? negativeElements.Average(x => Math.Abs(x)) : 0;

        int sum10 = 0;
        for (int i = 0; i < array10.Length; i++)
        {
            if (Math.Abs(array10[i]) > negativeAvg)
            {
                sum10 += array10[i];
            }
        }

        Console.WriteLine($"Среднее арифметическое модулей отрицательных: {negativeAvg:F2}");
        Console.WriteLine($"Сумма элементов с |x| > этого значения: {sum10}");

        // Задача 11
        Console.WriteLine("\n=== Задача 11 ===");
        Console.WriteLine("Ввести целочисленный массив из 14 элементов. Вычислить количество и сумму четных положительных элементов.");

        int[] array11 = new int[14];
        Console.WriteLine("Введите 14 целых чисел:");
        for (int i = 0; i < array11.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array11[i] = int.Parse(Console.ReadLine());
        }

        int count11 = 0, sum11 = 0;
        for (int i = 0; i < array11.Length; i++)
        {
            if (array11[i] > 0 && array11[i] % 2 == 0)
            {
                count11++;
                sum11 += array11[i];
            }
        }
        Console.WriteLine($"Количество четных положительных: {count11}");
        Console.WriteLine($"Их сумма: {sum11}");

        // Задача 12
        Console.WriteLine("\n=== Задача 12 ===");
        Console.WriteLine("Ввести массив из 12 элементов действительного типа. Расположить элементы в порядке убывания. Вычислить сумму максимального и минимального элементов.");

        double[] array12 = new double[12];
        Console.WriteLine("Введите 12 вещественных чисел:");
        for (int i = 0; i < array12.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array12[i] = double.Parse(Console.ReadLine());
        }

        Array.Sort(array12);
        Array.Reverse(array12);
        double sum12 = array12[0] + array12[array12.Length - 1];

        Console.WriteLine($"Отсортированный массив: [{string.Join(", ", array12)}]");
        Console.WriteLine($"Сумма максимального и минимального: {array12[0]} + {array12[array12.Length - 1]} = {sum12:F2}");

        // Задача 13
        Console.WriteLine("\n=== Задача 13 ===");
        Console.WriteLine("Ввести целочисленный массив из 15 элементов. Определить сумму и разность максимального и минимального элементов.");

        int[] array13 = new int[15];
        Console.WriteLine("Введите 15 целых чисел:");
        for (int i = 0; i < array13.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array13[i] = int.Parse(Console.ReadLine());
        }

        int max13 = array13[0], min13 = array13[0];
        for (int i = 1; i < array13.Length; i++)
        {
            if (array13[i] > max13) max13 = array13[i];
            if (array13[i] < min13) min13 = array13[i];
        }

        Console.WriteLine($"Максимальный элемент: {max13}");
        Console.WriteLine($"Минимальный элемент: {min13}");
        Console.WriteLine($"Сумма: {max13 + min13}");
        Console.WriteLine($"Разность: {max13 - min13}");

        // Задача 14
        Console.WriteLine("\n=== Задача 14 ===");
        Console.WriteLine("Ввести целочисленный массив из 17 элементов. Заменить элементы кратные трем на сумму нечетных по значению элементов.");

        int[] array14 = new int[17];
        Console.WriteLine("Введите 17 целых чисел:");
        for (int i = 0; i < array14.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array14[i] = int.Parse(Console.ReadLine());
        }

        int sumOdd14 = 0;
        for (int i = 0; i < array14.Length; i++)
        {
            if (array14[i] % 2 != 0)
            {
                sumOdd14 += array14[i];
            }
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", array14)}]");
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd14}");

        for (int i = 0; i < array14.Length; i++)
        {
            if (array14[i] % 3 == 0)
            {
                array14[i] = sumOdd14;
            }
        }

        Console.WriteLine($"Массив после замен: [{string.Join(", ", array14)}]");

        // Задача 15
        Console.WriteLine("\n=== Задача 15 ===");
        Console.WriteLine("Ввести массив из 14 элементов действительного типа. Расположить элементы с 1 по 7 по возрастанию, а с 8 по 14 - в порядке убывания.");

        double[] array15 = new double[14];
        Console.WriteLine("Введите 14 вещественных чисел:");
        for (int i = 0; i < array15.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array15[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", array15)}]");

        Array.Sort(array15, 0, 7);
        Array.Sort(array15, 7, 7);
        Array.Reverse(array15, 7, 7);

        Console.WriteLine($"Результирующий массив: [{string.Join(", ", array15)}]");

        // Задача 16
        Console.WriteLine("\n=== Задача 16 ===");
        Console.WriteLine("Ввести массив из 12 элементов действительного типа. Определить количество чисел между максимальным и минимальным элементами.");

        double[] array16 = new double[12];
        Console.WriteLine("Введите 12 вещественных чисел:");
        for (int i = 0; i < array16.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array16[i] = double.Parse(Console.ReadLine());
        }

        int maxIndex16 = 0, minIndex16 = 0;
        for (int i = 1; i < array16.Length; i++)
        {
            if (array16[i] > array16[maxIndex16]) maxIndex16 = i;
            if (array16[i] < array16[minIndex16]) minIndex16 = i;
        }

        int start16 = Math.Min(maxIndex16, minIndex16);
        int end16 = Math.Max(maxIndex16, minIndex16);
        int countBetween16 = Math.Max(0, end16 - start16 - 1);

        Console.WriteLine($"Максимальный элемент на позиции: {maxIndex16}");
        Console.WriteLine($"Минимальный элемент на позиции: {minIndex16}");
        Console.WriteLine($"Количество элементов между ними: {countBetween16}");

        // Задача 17
        Console.WriteLine("\n=== Задача 17 ===");
        Console.WriteLine("Ввести массив из 15 элементов целого типа. Определить количество отрицательных, произведение положительных и количество нулевых элементов.");

        int[] array17 = new int[15];
        Console.WriteLine("Введите 15 целых чисел:");
        for (int i = 0; i < array17.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array17[i] = int.Parse(Console.ReadLine());
        }

        int negativeCount17 = 0, zeroCount17 = 0;
        long productPositive17 = 1;
        bool hasPositive = false;

        for (int i = 0; i < array17.Length; i++)
        {
            if (array17[i] < 0)
                negativeCount17++;
            else if (array17[i] > 0)
            {
                productPositive17 *= array17[i];
                hasPositive = true;
            }
            else
                zeroCount17++;
        }

        Console.WriteLine($"Отрицательных элементов: {negativeCount17}");
        Console.WriteLine($"Нулевых элементов: {zeroCount17}");
        if (hasPositive)
            Console.WriteLine($"Произведение положительных: {productPositive17}");
        else
            Console.WriteLine("Положительных элементов нет");

        // Задача 18
        Console.WriteLine("\n=== Задача 18 ===");
        Console.WriteLine("Ввести массив из 12 элементов действительного типа. Определить границы интервала значений элементов массива.");

        double[] array18 = new double[12];
        Console.WriteLine("Введите 12 вещественных чисел:");
        for (int i = 0; i < array18.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array18[i] = double.Parse(Console.ReadLine());
        }

        double min18 = array18[0], max18 = array18[0];
        for (int i = 1; i < array18.Length; i++)
        {
            if (array18[i] < min18) min18 = array18[i];
            if (array18[i] > max18) max18 = array18[i];
        }

        Console.WriteLine($"Минимальное значение: {min18:F2}");
        Console.WriteLine($"Максимальное значение: {max18:F2}");
        Console.WriteLine($"Интервал значений: [{min18:F2}, {max18:F2}]");

        // Задача 19
        Console.WriteLine("\n=== Задача 19 ===");
        Console.WriteLine("Дан массив из 19 элементов целого типа. Найти сумму элементов до первого отрицательного элемента.");

        int[] array19 = new int[19];
        Console.WriteLine("Введите 19 целых чисел:");
        for (int i = 0; i < array19.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array19[i] = int.Parse(Console.ReadLine());
        }

        int firstNegativeIndex19 = -1;
        for (int i = 0; i < array19.Length; i++)
        {
            if (array19[i] < 0)
            {
                firstNegativeIndex19 = i;
                break;
            }
        }

        if (firstNegativeIndex19 == -1)
        {
            Console.WriteLine("Отрицательных элементов нет");
        }
        else
        {
            int sum19 = 0;
            for (int i = 0; i < firstNegativeIndex19; i++)
            {
                sum19 += array19[i];
            }
            Console.WriteLine($"Первый отрицательный элемент на позиции: {firstNegativeIndex19 + 1}");
            Console.WriteLine($"Сумма элементов до него: {sum19}");
        }

        // Задача 20
        Console.WriteLine("\n=== Задача 20 ===");
        Console.WriteLine("Ввести массив из 16 элементов целого типа. Заменить все элементы кратные трем нулями. Определить количество замен.");

        int[] array20 = new int[16];
        Console.WriteLine("Введите 16 целых чисел:");
        for (int i = 0; i < array20.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array20[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", array20)}]");

        int replacements20 = 0;
        for (int i = 0; i < array20.Length; i++)
        {
            if (array20[i] % 3 == 0 && array20[i] != 0)
            {
                array20[i] = 0;
                replacements20++;
            }
        }

        Console.WriteLine($"Массив после замен: [{string.Join(", ", array20)}]");
        Console.WriteLine($"Количество замен: {replacements20}");

        // Задача 21
        Console.WriteLine("\n=== Задача 21 ===");
        Console.WriteLine("В заданном массиве из 12 действительных чисел увеличить минимальный элемент в три раза и поменять местами с последним.");

        double[] array21 = new double[12];
        Console.WriteLine("Введите 12 вещественных чисел:");
        for (int i = 0; i < array21.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array21[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", array21)}]");

        int minIndex21 = 0;
        for (int i = 1; i < array21.Length; i++)
        {
            if (array21[i] < array21[minIndex21])
                minIndex21 = i;
        }

        Console.WriteLine($"Минимальный элемент: {array21[minIndex21]} (индекс {minIndex21})");

        array21[minIndex21] *= 3;

        double temp21 = array21[minIndex21];
        array21[minIndex21] = array21[array21.Length - 1];
        array21[array21.Length - 1] = temp21;

        Console.WriteLine($"Массив после преобразований: [{string.Join(", ", array21)}]");

        // Задача 22
        Console.WriteLine("\n=== Задача 22 ===");
        Console.WriteLine("Дан массив из 15 вещественных чисел. Расположить элементы в обратном порядке.");

        double[] array22 = new double[15];
        Console.WriteLine("Введите 15 вещественных чисел:");
        for (int i = 0; i < array22.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array22[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", array22)}]");

        for (int i = 0; i < array22.Length / 2; i++)
        {
            double temp22 = array22[i];
            array22[i] = array22[array22.Length - 1 - i];
            array22[array22.Length - 1 - i] = temp22;
        }

        Console.WriteLine($"Массив в обратном порядке: [{string.Join(", ", array22)}]");

        // Задача 23
        Console.WriteLine("\n=== Задача 23 ===");
        Console.WriteLine("Ввести массив из 14 элементов целого типа. Определить сумму элементов четных по индексу и произведение элементов нечетных по значению.");

        int[] array23 = new int[14];
        Console.WriteLine("Введите 14 целых чисел:");
        for (int i = 0; i < array23.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array23[i] = int.Parse(Console.ReadLine());
        }

        int sumEvenIndex23 = 0;
        long productOddValue23 = 1;
        bool hasOdd = false;

        for (int i = 0; i < array23.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumEvenIndex23 += array23[i];
            }
            if (array23[i] % 2 != 0)
            {
                productOddValue23 *= array23[i];
                hasOdd = true;
            }
        }

        Console.WriteLine($"Сумма элементов с четными индексами: {sumEvenIndex23}");
        if (hasOdd)
            Console.WriteLine($"Произведение элементов с нечетными значениями: {productOddValue23}");
        else
            Console.WriteLine("Нечетных элементов нет");

        // Задача 24
        Console.WriteLine("\n=== Задача 24 ===");
        Console.WriteLine("Ввести массив из 12 элементов действительного типа. Определить количество и сумму чисел, значения которых меньше значения последнего элемента.");

        double[] array24 = new double[12];
        Console.WriteLine("Введите 12 вещественных чисел:");
        for (int i = 0; i < array24.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array24[i] = double.Parse(Console.ReadLine());
        }

        double lastElement24 = array24[array24.Length - 1];
        int count24 = 0;
        double sum24 = 0;

        for (int i = 0; i < array24.Length - 1; i++)
        {
            if (array24[i] < lastElement24)
            {
                count24++;
                sum24 += array24[i];
            }
        }

        Console.WriteLine($"Последний элемент: {lastElement24:F2}");
        Console.WriteLine($"Количество элементов меньше последнего: {count24}");
        Console.WriteLine($"Их сумма: {sum24:F2}");

        // Задача 25
        Console.WriteLine("\n=== Задача 25 ===");
        Console.WriteLine("Дан массив из 15 элементов целого типа. Получить новый массив как разность между элементами исходного массива и суммой положительных элементов.");

        int[] array25 = new int[15];
        Console.WriteLine("Введите 15 целых чисел (положительных и отрицательных):");
        for (int i = 0; i < array25.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array25[i] = int.Parse(Console.ReadLine());
        }

        int sumPositive25 = 0;
        for (int i = 0; i < array25.Length; i++)
        {
            if (array25[i] > 0)
            {
                sumPositive25 += array25[i];
            }
        }

        int[] newArray25 = new int[15];
        for (int i = 0; i < array25.Length; i++)
        {
            newArray25[i] = array25[i] - sumPositive25;
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", array25)}]");
        Console.WriteLine($"Сумма положительных элементов: {sumPositive25}");
        Console.WriteLine($"Новый массив: [{string.Join(", ", newArray25)}]");

        // Задача 26
        Console.WriteLine("\n=== Задача 26 ===");
        Console.WriteLine("Дан массив из 15 элементов действительного типа. Определить разность между произведением всех положительных элементов и произведением модулей всех отрицательных.");

        double[] array26 = new double[15];
        Console.WriteLine("Введите 15 вещественных чисел:");
        for (int i = 0; i < array26.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array26[i] = double.Parse(Console.ReadLine());
        }

        double productPositive26 = 1;
        double productNegativeAbs26 = 1;
        bool hasPositive26 = false;
        bool hasNegative26 = false;

        for (int i = 0; i < array26.Length; i++)
        {
            if (array26[i] > 0)
            {
                productPositive26 *= array26[i];
                hasPositive26 = true;
            }
            else if (array26[i] < 0)
            {
                productNegativeAbs26 *= Math.Abs(array26[i]);
                hasNegative26 = true;
            }
        }

        double difference26 = 0;
        if (hasPositive26 && hasNegative26)
        {
            difference26 = productPositive26 - productNegativeAbs26;
            Console.WriteLine($"Произведение положительных: {productPositive26:F2}");
            Console.WriteLine($"Произведение модулей отрицательных: {productNegativeAbs26:F2}");
            Console.WriteLine($"Разность: {difference26:F2}");
        }
        else
        {
            Console.WriteLine("Недостаточно данных для вычисления (нужны и положительные и отрицательные элементы)");
        }

        // Задача 27
        Console.WriteLine("\n=== Задача 27 ===");
        Console.WriteLine("В массиве из 19 целых чисел определить максимальное число и заменить им все четные по значению элементы.");

        int[] array27 = new int[19];
        Console.WriteLine("Введите 19 целых чисел:");
        for (int i = 0; i < array27.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array27[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", array27)}]");

        int max27 = array27[0];
        for (int i = 1; i < array27.Length; i++)
        {
            if (array27[i] > max27)
                max27 = array27[i];
        }

        int replacements27 = 0;
        for (int i = 0; i < array27.Length; i++)
        {
            if (array27[i] % 2 == 0)
            {
                array27[i] = max27;
                replacements27++;
            }
        }

        Console.WriteLine($"Максимальный элемент: {max27}");
        Console.WriteLine($"Массив после замен: [{string.Join(", ", array27)}]");
        Console.WriteLine($"Количество замен: {replacements27}");

        // Задача 28
        Console.WriteLine("\n=== Задача 28 ===");
        Console.WriteLine("Ввести целочисленный массив из 17 элементов. Найти сумму и количество элементов, |значение| которых больше среднеарифметического положительных элементов.");

        int[] array28 = new int[17];
        Console.WriteLine("Введите 17 целых чисел:");
        for (int i = 0; i < array28.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array28[i] = int.Parse(Console.ReadLine());
        }

        var positiveElements28 = array28.Where(x => x > 0).ToArray();
        double positiveAvg28 = positiveElements28.Length > 0 ? positiveElements28.Average() : 0;

        int count28 = 0;
        int sum28 = 0;

        for (int i = 0; i < array28.Length; i++)
        {
            if (Math.Abs(array28[i]) > positiveAvg28)
            {
                count28++;
                sum28 += array28[i];
            }
        }

        Console.WriteLine($"Среднее арифметическое положительных: {positiveAvg28:F2}");
        Console.WriteLine($"Количество элементов с |x| > этого значения: {count28}");
        Console.WriteLine($"Их сумма: {sum28}");

        // Задача 29
        Console.WriteLine("\n=== Задача 29 ===");
        Console.WriteLine("Дан массив из 18 элементов действительного типа. Определить частное от деления произведения всех положительных элементов на сумму модулей всех отрицательных.");

        double[] array29 = new double[18];
        Console.WriteLine("Введите 18 вещественных чисел:");
        for (int i = 0; i < array29.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array29[i] = double.Parse(Console.ReadLine());
        }

        double productPositive29 = 1;
        double sumNegativeAbs29 = 0;
        bool hasPositive29 = false;
        bool hasNegative29 = false;

        for (int i = 0; i < array29.Length; i++)
        {
            if (array29[i] > 0)
            {
                productPositive29 *= array29[i];
                hasPositive29 = true;
            }
            else if (array29[i] < 0)
            {
                sumNegativeAbs29 += Math.Abs(array29[i]);
                hasNegative29 = true;
            }
        }

        if (hasPositive29 && hasNegative29 && sumNegativeAbs29 != 0)
        {
            double quotient29 = productPositive29 / sumNegativeAbs29;
            Console.WriteLine($"Произведение положительных: {productPositive29:F2}");
            Console.WriteLine($"Сумма модулей отрицательных: {sumNegativeAbs29:F2}");
            Console.WriteLine($"Частное: {quotient29:F4}");
        }
        else
        {
            Console.WriteLine("Невозможно вычислить частное (отсутствуют положительные или отрицательные элементы, или сумма модулей отрицательных равна 0)");
        }

        #endregion


        #region Задание с 1 по 30

        // Задача 1
        Console.WriteLine("\n=== Задача 1 ===");
        int[] arr1_1 = new int[10];
        int[] arr1_2 = new int[10];

        Console.WriteLine("Введите 10 целых чисел для первого массива:");
        for (int i = 0; i < arr1_1.Length; i++)
        {
            Console.Write($"Массив 1, элемент {i + 1}: ");
            arr1_1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите 10 целых чисел для второго массива:");
        for (int i = 0; i < arr1_2.Length; i++)
        {
            Console.Write($"Массив 2, элемент {i + 1}: ");
            arr1_2[i] = int.Parse(Console.ReadLine());
        }

        int[] result1 = new int[20];
        for (int i = 0; i < result1.Length; i++)
        {
            if (i % 2 == 0)
                result1[i] = arr1_1[i / 2 * 2 + 1];
            else
                result1[i] = arr1_2[i / 2 * 2];
        }
        Console.WriteLine($"Новый массив: [{string.Join(", ", result1)}]");

        // Задача 2
        Console.WriteLine("\n=== Задача 2 ===");
        int[] arr2 = new int[8];
        Console.WriteLine("Введите 8 двузначных чисел:");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr2[i] = int.Parse(Console.ReadLine());
        }

        int[] newArr2 = new int[8];
        for (int i = 0; i < arr2.Length; i++)
        {
            newArr2[i] = arr2[i] % 10;
        }
        Console.WriteLine($"Новый массив: [{string.Join(", ", newArr2)}]");

        // Задача 3
        Console.WriteLine("\n=== Задача 3 ===");
        int[] arr3 = new int[17];
        Console.WriteLine("Введите 17 двузначных чисел:");
        for (int i = 0; i < arr3.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr3[i] = int.Parse(Console.ReadLine());
        }

        int sumDigits = 0;
        foreach (int num in arr3)
        {
            sumDigits += num / 10 + num % 10;
        }
        Console.WriteLine($"Сумма цифр массива: {sumDigits}");

        // Задача 4
        Console.WriteLine("\n=== Задача 4 ===");
        double[] arr4_1 = new double[9];
        double[] arr4_2 = new double[7];

        Console.WriteLine("Введите 9 вещественных чисел для первого массива:");
        for (int i = 0; i < arr4_1.Length; i++)
        {
            Console.Write($"Массив 1, элемент {i + 1}: ");
            arr4_1[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите 7 вещественных чисел для второго массива:");
        for (int i = 0; i < arr4_2.Length; i++)
        {
            Console.Write($"Массив 2, элемент {i + 1}: ");
            arr4_2[i] = double.Parse(Console.ReadLine());
        }

        double[] result4 = arr4_1.Concat(arr4_2).ToArray();
        Array.Sort(result4);
        Console.WriteLine($"Объединенный отсортированный массив: [{string.Join(", ", result4)}]");

        // Задача 5
        Console.WriteLine("\n=== Задача 5 ===");
        int[] arr5_1 = new int[10];
        int[] arr5_2 = new int[10];

        Console.WriteLine("Введите 10 целых чисел для массива X:");
        for (int i = 0; i < arr5_1.Length; i++)
        {
            Console.Write($"Массив X, элемент {i + 1}: ");
            arr5_1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите 10 целых чисел для массива Y:");
        for (int i = 0; i < arr5_2.Length; i++)
        {
            Console.Write($"Массив Y, элемент {i + 1}: ");
            arr5_2[i] = int.Parse(Console.ReadLine());
        }

        var commonElements = arr5_1.Intersect(arr5_2).ToArray();
        Console.WriteLine($"Общие элементы: [{string.Join(", ", commonElements)}]");

        // Задача 6
        Console.WriteLine("\n=== Задача 6 ===");
        double[] arr6 = new double[12];
        for (int i = 0; i < arr6.Length; i++)
        {
            arr6[i] = Math.Pow(i, 2) - 2 * i + 19.3 * Math.Cos(i);
        }

        double avg6 = arr6.Average();
        var lessThanAvg = arr6.Where(x => x < avg6).ToArray();
        var greaterThanAvg = arr6.Where(x => x >= avg6).ToArray();
        double[] result6 = lessThanAvg.Concat(greaterThanAvg).ToArray();

        Console.WriteLine($"Исходный массив: [{string.Join(", ", arr6.Select(x => x.ToString("F2")))}]");
        Console.WriteLine($"Среднее: {avg6:F2}");
        Console.WriteLine($"Новый массив: [{string.Join(", ", result6.Select(x => x.ToString("F2")))}]");

        // Задача 7
        Console.WriteLine("\n=== Задача 7 ===");
        double[] arr7 = new double[16];
        Console.WriteLine("Введите 16 вещественных чисел:");
        for (int i = 0; i < arr7.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr7[i] = double.Parse(Console.ReadLine());
        }

        double sumEvenIndex = 0, sumMultiple3 = 0;
        for (int i = 0; i < arr7.Length; i++)
        {
            if (i % 2 == 0) sumEvenIndex += arr7[i];
            if (i % 3 == 0) sumMultiple3 += arr7[i];
        }
        Console.WriteLine($"Разность: {sumEvenIndex - sumMultiple3:F2}");

        // Задача 8
        Console.WriteLine("\n=== Задача 8 ===");
        int[] arr8 = new int[9];
        Console.WriteLine("Введите 9 целых чисел:");
        for (int i = 0; i < arr8.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr8[i] = int.Parse(Console.ReadLine());
        }

        int maxOddIndex = -1;
        for (int i = 0; i < arr8.Length; i++)
        {
            if (arr8[i] > 0 && arr8[i] % 2 != 0)
            {
                if (maxOddIndex == -1 || arr8[i] > arr8[maxOddIndex])
                    maxOddIndex = i;
            }
        }

        if (maxOddIndex != -1)
            Console.WriteLine($"Индекс наибольшего нечетного положительного: {maxOddIndex}");
        else
            Console.WriteLine("Нечетных положительных элементов нет");

        // Задача 9
        Console.WriteLine("\n=== Задача 9 ===");
        int[] arr9_X = new int[15];
        Console.WriteLine("Введите 15 целых чисел для массива X:");
        for (int i = 0; i < arr9_X.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr9_X[i] = int.Parse(Console.ReadLine());
        }

        double[] arr9_Y = new double[15];
        for (int i = 0; i < arr9_Y.Length; i++)
        {
            arr9_Y[i] = Math.Cos(Math.Pow(arr9_X[i], 2)) + 2.97 * Math.Pow(Math.Log10(Math.Pow(i, 2)), 2);
        }

        double[] result9 = arr9_X.Select(x => (double)x).Concat(arr9_Y).ToArray();
        Array.Sort(result9);
        Array.Reverse(result9);
        Console.WriteLine($"Объединенный массив по убыванию: [{string.Join(", ", result9.Select(x => x.ToString("F2")))}]");

        // Задача 10
        Console.WriteLine("\n=== Задача 10 ===");
        int[] arr10_X = new int[17];
        Console.WriteLine("Введите 17 целых чисел для массива X:");
        for (int i = 0; i < arr10_X.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr10_X[i] = int.Parse(Console.ReadLine());
        }

        double[] arr10_Y = new double[17];
        for (int i = 0; i < arr10_Y.Length; i++)
        {
            if (Math.Cos(arr10_X[i]) > 0)
                arr10_Y[i] = Math.Pow(arr10_X[i], 3) - 7.5;
            else
                arr10_Y[i] = Math.Pow(arr10_X[i], 2) - 5 * Math.Exp(Math.Sin(arr10_X[i]));
        }

        Array.Sort(arr10_Y);
        Array.Sort(arr10_X);
        Array.Reverse(arr10_X);

        double[] result10 = new double[arr10_X.Length + arr10_Y.Length];
        int idx = 0;
        for (int i = 0; i < arr10_X.Length; i++)
        {
            if (i % 2 == 0) result10[idx++] = arr10_X[i];
        }
        for (int i = 0; i < arr10_Y.Length; i++)
        {
            if (i % 2 == 0) result10[idx++] = arr10_Y[i];
        }

        Array.Resize(ref result10, idx);
        Console.WriteLine($"Массив R: [{string.Join(", ", result10.Select(x => x.ToString("F2")))}]");

        // Задача 11
        Console.WriteLine("\n=== Задача 11 ===");
        int[] arr11 = new int[9];
        Console.WriteLine("Введите 9 двузначных чисел:");
        for (int i = 0; i < arr11.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr11[i] = int.Parse(Console.ReadLine());
        }

        int[] newArr11 = new int[9];
        for (int i = 0; i < arr11.Length; i++)
        {
            newArr11[i] = (arr11[i] / 10) + (arr11[i] % 10);
        }
        Console.WriteLine($"Новый массив: [{string.Join(", ", newArr11)}]");

        // Задача 12
        Console.WriteLine("\n=== Задача 12 ===");
        double[] arr12 = new double[12];
        Console.WriteLine("Введите 12 вещественных чисел:");
        for (int i = 0; i < arr12.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr12[i] = double.Parse(Console.ReadLine());
        }

        double[] sortedArr12 = (double[])arr12.Clone();
        int swaps12 = 0;
        for (int i = 0; i < sortedArr12.Length - 1; i++)
        {
            for (int j = 0; j < sortedArr12.Length - 1 - i; j++)
            {
                if (sortedArr12[j] < sortedArr12[j + 1])
                {
                    double temp = sortedArr12[j];
                    sortedArr12[j] = sortedArr12[j + 1];
                    sortedArr12[j + 1] = temp;
                    swaps12++;
                }
            }
        }
        Console.WriteLine($"Отсортированный массив: [{string.Join(", ", sortedArr12)}]");
        Console.WriteLine($"Количество перестановок: {swaps12}");

        // Задача 13
        Console.WriteLine("\n=== Задача 13 ===");
        int[] arr13 = new int[11];
        Console.WriteLine("Введите 11 целых чисел:");
        for (int i = 0; i < arr13.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr13[i] = int.Parse(Console.ReadLine());
        }

        int sumOddNegative = 0;
        for (int i = 0; i < arr13.Length; i++)
        {
            if (arr13[i] < 0 && arr13[i] % 2 != 0)
            {
                sumOddNegative += arr13[i];
            }
        }

        for (int i = 0; i < arr13.Length; i++)
        {
            if (arr13[i] % 3 == 0)
            {
                arr13[i] = sumOddNegative;
            }
        }

        Console.WriteLine($"Сумма нечетных отрицательных: {sumOddNegative}");
        Console.WriteLine($"Массив после замен: [{string.Join(", ", arr13)}]");

        // Задача 14
        Console.WriteLine("\n=== Задача 14 ===");
        double[] arr14 = new double[14];
        Console.WriteLine("Введите 14 вещественных чисел:");
        for (int i = 0; i < arr14.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr14[i] = double.Parse(Console.ReadLine());
        }

        int swaps14 = 0;
        for (int i = 0; i < arr14.Length / 2; i++)
        {
            double temp = arr14[i];
            arr14[i] = arr14[i + 7];
            arr14[i + 7] = temp;
            swaps14++;
        }

        Console.WriteLine($"Массив после обмена: [{string.Join(", ", arr14)}]");
        Console.WriteLine($"Количество перестановок: {swaps14}");

        // Задача 15
        Console.WriteLine("\n=== Задача 15 ===");
        double[] arr15 = new double[10];
        Console.WriteLine("Введите 10 вещественных чисел:");
        for (int i = 0; i < arr15.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr15[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Введите число S: ");
        double S = double.Parse(Console.ReadLine());

        int farthestIndex = 0;
        double maxDistance = Math.Abs(arr15[0] - S);

        for (int i = 1; i < arr15.Length; i++)
        {
            double distance = Math.Abs(arr15[i] - S);
            if (distance > maxDistance)
            {
                maxDistance = distance;
                farthestIndex = i;
            }
        }

        Console.WriteLine($"Наиболее удаленный элемент: arr15[{farthestIndex}] = {arr15[farthestIndex]}");
        Console.WriteLine($"Расстояние до S: {maxDistance:F2}");

        // Задача 16
        Console.WriteLine("\n=== Задача 16 ===");
        int[] arr16 = new int[10];
        Console.WriteLine("Введите 10 целых чисел:");
        for (int i = 0; i < arr16.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr16[i] = int.Parse(Console.ReadLine());
        }

        int sumBeforeNegative = 0, countBeforeNegative = 0;
        for (int i = 0; i < arr16.Length; i++)
        {
            if (arr16[i] < 0) break;
            sumBeforeNegative += arr16[i];
            countBeforeNegative++;
        }

        Console.WriteLine($"Сумма до первого отрицательного: {sumBeforeNegative}");
        Console.WriteLine($"Количество до первого отрицательного: {countBeforeNegative}");

        // Задача 17
        Console.WriteLine("\n=== Задача 17 ===");
        double[] arr17 = new double[15];
        Console.WriteLine("Введите 15 чисел:");
        for (int i = 0; i < arr17.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr17[i] = double.Parse(Console.ReadLine());
        }

        int localMinCount = 0;
        for (int i = 1; i < arr17.Length - 1; i++)
        {
            if (arr17[i] < arr17[i - 1] && arr17[i] < arr17[i + 1])
            {
                localMinCount++;
            }
        }
        Console.WriteLine($"Количество локальных минимумов: {localMinCount}");

        // Задача 18
        Console.WriteLine("\n=== Задача 18 ===");
        double[] arr18 = new double[15];
        Console.WriteLine("Введите 15 чисел:");
        for (int i = 0; i < arr18.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr18[i] = double.Parse(Console.ReadLine());
        }

        int localMaxCount = 0;
        for (int i = 1; i < arr18.Length - 1; i++)
        {
            if (arr18[i] > arr18[i - 1] && arr18[i] > arr18[i + 1])
            {
                localMaxCount++;
            }
        }
        Console.WriteLine($"Количество локальных максимумов: {localMaxCount}");

        // Задача 19
        Console.WriteLine("\n=== Задача 19 ===");
        int[] arr19 = new int[15];
        Console.WriteLine("Введите 15 целых чисел (положительных, отрицательных и нулей):");
        for (int i = 0; i < arr19.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr19[i] = int.Parse(Console.ReadLine());
        }

        int firstNegativeIndex = -1, firstZeroIndex = -1;
        for (int i = 0; i < arr19.Length; i++)
        {
            if (firstNegativeIndex == -1 && arr19[i] < 0)
                firstNegativeIndex = i;
            if (firstZeroIndex == -1 && arr19[i] == 0)
                firstZeroIndex = i;
        }

        if (firstNegativeIndex != -1 && firstZeroIndex != -1)
        {
            int start = Math.Min(firstNegativeIndex, firstZeroIndex);
            int end = Math.Max(firstNegativeIndex, firstZeroIndex);
            int sumBetween = 0;

            Console.Write("Элементы между первым отрицательным и нулевым: ");
            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{arr19[i]} ");
                sumBetween += arr19[i];
            }
            Console.WriteLine($"\nСумма: {sumBetween}");
        }
        else
        {
            Console.WriteLine("Не найдены отрицательные элементы или нули");
        }

        // Задача 20
        Console.WriteLine("\n=== Задача 20 ===");
        double[] arr20 = new double[12];
        Console.WriteLine("Введите 12 чисел:");
        for (int i = 0; i < arr20.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr20[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Индексы монотонно убывающих последовательностей:");
        for (int i = 0; i < arr20.Length - 1; i++)
        {
            int j = i;
            while (j < arr20.Length - 1 && arr20[j] > arr20[j + 1])
            {
                j++;
            }
            if (j > i)
            {
                Console.Write($"С {i} по {j}: ");
                for (int k = i; k <= j; k++)
                    Console.Write($"{arr20[k]} ");
                Console.WriteLine();
                i = j;
            }
        }

        // Задача 21
        Console.WriteLine("\n=== Задача 21 ===");
        int[] arr21 = new int[15];
        Console.WriteLine("Введите 15 целых чисел:");
        for (int i = 0; i < arr21.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr21[i] = int.Parse(Console.ReadLine());
        }

        List<int> result21 = new List<int>();
        for (int i = 0; i < arr21.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < arr21.Length; j++)
            {
                if (arr21[i] == arr21[j])
                {
                    count++;
                }
            }
            if (count <= 2)
            {
                result21.Add(arr21[i]);
            }
        }
        Console.WriteLine($"Массив после удаления: [{string.Join(", ", result21)}]");

        // Задача 22
        Console.WriteLine("\n=== Задача 22 ===");
        int[] arr22 = new int[10];
        Console.WriteLine("Введите 10 целых чисел:");
        for (int i = 0; i < arr22.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr22[i] = int.Parse(Console.ReadLine());
        }

        List<int> negativesAndZeros = new List<int>();
        List<int> positives = new List<int>();

        for (int i = 0; i < arr22.Length; i++)
        {
            if (arr22[i] <= 0)
                negativesAndZeros.Add(arr22[i]);
            else
                positives.Add(arr22[i]);
        }

        int[] result22 = negativesAndZeros.Concat(positives).ToArray();
        Console.WriteLine($"Новый массив: [{string.Join(", ", result22)}]");

        // Задача 23
        Console.WriteLine("\n=== Задача 23 ===");
        double[] arr23_X = new double[10];
        Console.WriteLine("Введите 10 целых чисел для массива X:");
        for (int i = 0; i < arr23_X.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr23_X[i] = double.Parse(Console.ReadLine());
        }

        double[] arr23_Y = new double[10];
        for (int i = 0; i < arr23_Y.Length; i++)
        {
            arr23_Y[i] = arr23_X[i] * arr23_X[i] + 0.3;
        }

        double numerator = 1, denominator = 1;
        for (int i = 0; i < arr23_X.Length; i++)
        {
            double product = arr23_X[i] * arr23_Y[i];
            if (i % 2 == 0)
                denominator *= product;
            else
                numerator *= product;
        }

        double P = numerator / denominator;
        int remainder = (int)(numerator % denominator);

        Console.WriteLine($"P = {P:F4}");
        Console.WriteLine($"Остаток от деления: {remainder}");

        // Задача 24
        Console.WriteLine("\n=== Задача 24 ===");
        int[] arr24 = new int[10];
        Console.WriteLine("Введите 10 двузначных чисел:");
        for (int i = 0; i < arr24.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr24[i] = int.Parse(Console.ReadLine());
        }

        int[] newArr24 = new int[10];
        for (int i = 0; i < arr24.Length; i++)
        {
            int digit1 = arr24[i] / 10;
            int digit2 = arr24[i] % 10;
            newArr24[i] = Math.Abs(digit1 - digit2);
        }
        Console.WriteLine($"Новый массив: [{string.Join(", ", newArr24)}]");

        // Задача 25
        Console.WriteLine("\n=== Задача 25 ===");
        int[] arr25 = new int[15];
        Console.WriteLine("Введите 15 целых чисел:");
        for (int i = 0; i < arr25.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr25[i] = int.Parse(Console.ReadLine());
        }

        List<int> negatives = new List<int>();
        List<int> positives25 = new List<int>();

        for (int i = 0; i < arr25.Length; i++)
        {
            if (arr25[i] < 0)
                negatives.Add(arr25[i]);
            else if (arr25[i] > 0)
                positives25.Add(arr25[i]);
        }

        negatives.Sort();
        positives25.Sort();
        positives25.Reverse();

        int[] result25 = negatives.Concat(positives25).ToArray();
        Console.WriteLine($"Упорядоченный массив: [{string.Join(", ", result25)}]");

        // Задача 26
        Console.WriteLine("\n=== Задача 26 ===");
        double[] arr26_1 = new double[12];
        double[] arr26_2 = new double[12];

        Console.WriteLine("Введите 12 вещественных чисел для первого массива:");
        for (int i = 0; i < arr26_1.Length; i++)
        {
            Console.Write($"Массив 1, элемент {i + 1}: ");
            arr26_1[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите 12 вещественных чисел для второго массива:");
        for (int i = 0; i < arr26_2.Length; i++)
        {
            Console.Write($"Массив 2, элемент {i + 1}: ");
            arr26_2[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr26_1.Length; i++)
        {
            if (arr26_2.Contains(arr26_1[i]))
            {
                arr26_1[i] = 0;
            }
        }

        Console.WriteLine($"Первый массив после замен: [{string.Join(", ", arr26_1)}]");

        // Задача 27
        Console.WriteLine("\n=== Задача 27 ===");
        double[] arr27 = new double[15];
        Console.WriteLine("Введите 15 чисел:");
        for (int i = 0; i < arr27.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr27[i] = double.Parse(Console.ReadLine());
        }

        int increasingSequences = 0;
        for (int i = 0; i < arr27.Length - 1; i++)
        {
            if (arr27[i] < arr27[i + 1])
            {
                int j = i;
                while (j < arr27.Length - 1 && arr27[j] < arr27[j + 1])
                {
                    j++;
                }
                if (j > i)
                {
                    increasingSequences++;
                    i = j;
                }
            }
        }
        Console.WriteLine($"Количество монотонно возрастающих участков: {increasingSequences}");

        // Задача 28
        Console.WriteLine("\n=== Задача 28 ===");
        int[] arr28 = new int[12];
        Console.WriteLine("Введите 12 целых чисел:");
        for (int i = 0; i < arr28.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr28[i] = int.Parse(Console.ReadLine());
        }

        int sumEven28 = 0, sumOdd28 = 0;
        for (int i = 0; i < arr28.Length; i++)
        {
            if (i % 2 == 0)
                sumEven28 += arr28[i];
            else
                sumOdd28 += arr28[i];
        }

        int remainder28 = sumOdd28 != 0 ? sumEven28 % sumOdd28 : 0;
        Console.WriteLine($"Остаток от деления: {remainder28}");

        // Задача 29
        Console.WriteLine("\n=== Задача 29 ===");
        double[] arr29 = new double[15];
        Console.WriteLine("Введите 15 чисел:");
        for (int i = 0; i < arr29.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr29[i] = double.Parse(Console.ReadLine());
        }

        double average29 = arr29.Average();
        int countAboveAvg = arr29.Count(x => x > average29);
        double percentage = (double)countAboveAvg / arr29.Length * 100;

        Console.WriteLine($"Среднее арифметическое: {average29:F2}");
        Console.WriteLine($"Процент элементов выше среднего: {percentage:F1}%");

        // Задача 30
        Console.WriteLine("\n=== Задача 30 ===");
        double[] arr30_1 = new double[10];
        double[] arr30_2 = new double[10];

        Console.WriteLine("Введите 10 вещественных чисел для первого массива:");
        for (int i = 0; i < arr30_1.Length; i++)
        {
            Console.Write($"Массив 1, элемент {i + 1}: ");
            arr30_1[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите 10 вещественных чисел для второго массива:");
        for (int i = 0; i < arr30_2.Length; i++)
        {
            Console.Write($"Массив 2, элемент {i + 1}: ");
            arr30_2[i] = double.Parse(Console.ReadLine());
        }

        int maxIndex30_1 = Array.IndexOf(arr30_1, arr30_1.Max());
        int maxIndex30_2 = Array.IndexOf(arr30_2, arr30_2.Max());

        double temp30 = arr30_1[maxIndex30_1];
        arr30_1[maxIndex30_1] = arr30_2[maxIndex30_2];
        arr30_2[maxIndex30_2] = temp30;

        Console.WriteLine($"Первый массив после обмена: [{string.Join(", ", arr30_1)}]");
        Console.WriteLine($"Второй массив после обмена: [{string.Join(", ", arr30_2)}]");

        #endregion


        #region Задания с 3 по 30

        // Задача 3
        Console.WriteLine("\n=== Задача 3 ===");
        Console.Write("Введите двоичное число: ");
        string binary3 = Console.ReadLine();
        int decimal3 = Convert.ToInt32(binary3, 2);
        string hex3 = Convert.ToString(decimal3, 16).ToUpper();
        Console.WriteLine($"Двоичное: {binary3} -> Шестнадцатеричное: {hex3}");

        // Задача 4
        Console.WriteLine("\n=== Задача 4 ===");
        Console.Write("Введите дробное двоичное число (например, 101.101): ");
        string binary4 = Console.ReadLine();
        string[] parts4 = binary4.Split('.');
        int intPart4 = Convert.ToInt32(parts4[0], 2);
        double fracPart4 = 0;
        if (parts4.Length > 1)
        {
            for (int i = 0; i < parts4[1].Length; i++)
            {
                fracPart4 += (parts4[1][i] - '0') * Math.Pow(2, -(i + 1));
            }
        }
        double result_4 = intPart4 + fracPart4;
        Console.WriteLine($"Двоичное: {binary4} -> Десятичное: {result_4:F6}");

        // Задача 5
        Console.WriteLine("\n=== Задача 5 ===");
        Console.Write("Введите дробное двоичное число: ");
        string binary5 = Console.ReadLine();
        string[] parts5 = binary5.Split('.');
        int intPart5 = Convert.ToInt32(parts5[0], 2);
        string octalInt = Convert.ToString(intPart5, 8);

        double fracValue5 = 0;
        string octalFrac = "";
        if (parts5.Length > 1)
        {
            double frac = 0;
            for (int i = 0; i < parts5[1].Length; i++)
            {
                frac += (parts5[1][i] - '0') * Math.Pow(2, -(i + 1));
            }

            for (int i = 0; i < 6; i++)
            {
                frac *= 8;
                int digit = (int)frac;
                octalFrac += digit;
                frac -= digit;
                if (frac == 0) break;
            }
        }

        string result5 = octalInt + (octalFrac != "" ? "." + octalFrac : "");
        Console.WriteLine($"Двоичное: {binary5} -> Восьмеричное: {result5}");

        // Задача 6
        Console.WriteLine("\n=== Задача 6 ===");
        Console.Write("Введите дробное двоичное число: ");
        string binary6 = Console.ReadLine();
        string[] parts6 = binary6.Split('.');
        int intPart6 = Convert.ToInt32(parts6[0], 2);
        string hexInt = Convert.ToString(intPart6, 16).ToUpper();

        string hexFrac = "";
        if (parts6.Length > 1)
        {
            double frac = 0;
            for (int i = 0; i < parts6[1].Length; i++)
            {
                frac += (parts6[1][i] - '0') * Math.Pow(2, -(i + 1));
            }

            for (int i = 0; i < 6; i++)
            {
                frac *= 16;
                int digit = (int)frac;
                hexFrac += digit.ToString("X");
                frac -= digit;
                if (frac == 0) break;
            }
        }

        string result_6 = hexInt + (hexFrac != "" ? "." + hexFrac : "");
        Console.WriteLine($"Двоичное: {binary6} -> Шестнадцатеричное: {result_6}");

        // Задача 7
        Console.WriteLine("\n=== Задача 7 ===");
        int[] arr_7 = new int[15];
        Console.WriteLine("Введите 15 двузначных чисел:");
        for (int i = 0; i < arr_7.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_7[i] = int.Parse(Console.ReadLine());
        }

        int[] newArr7 = new int[15];
        for (int i = 0; i < arr_7.Length; i++)
        {
            int digit1 = arr_7[i] / 10;
            int digit2 = arr_7[i] % 10;
            newArr7[i] = digit2 * 10 + digit1;
        }
        Console.WriteLine($"Исходный массив: [{string.Join(", ", arr_7)}]");
        Console.WriteLine($"Новый массив: [{string.Join(", ", newArr7)}]");

        // Задача 8
        Console.WriteLine("\n=== Задача 8 ===");
        string[] arr_8 = new string[9];
        Console.WriteLine("Введите 9 двузначных чисел в восьмеричной системе:");
        for (int i = 0; i < arr_8.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_8[i] = Console.ReadLine();
        }

        int[] newArr8 = new int[9];
        for (int i = 0; i < arr_8.Length; i++)
        {
            newArr8[i] = Convert.ToInt32(arr_8[i], 8);
        }
        Console.WriteLine($"Новый массив в десятичной системе: [{string.Join(", ", newArr8)}]");

        // Задача 9
        Console.WriteLine("\n=== Задача 9 ===");
        int[] arr9 = new int[7];
        Console.WriteLine("Введите 7 двузначных чисел:");
        for (int i = 0; i < arr9.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr9[i] = int.Parse(Console.ReadLine());
        }

        int[] newArr9 = new int[7];
        for (int i = 0; i < arr9.Length; i++)
        {
            newArr9[i] = arr9[i] / 10;
        }
        Console.WriteLine($"Новый массив: [{string.Join(", ", newArr9)}]");

        // Задача 10
        Console.WriteLine("\n=== Задача 10 ===");
        double[] arr10_1 = new double[7];
        double[] arr10_2 = new double[9];

        Console.WriteLine("Введите 7 вещественных чисел для первого массива:");
        for (int i = 0; i < arr10_1.Length; i++)
        {
            Console.Write($"Массив 1, элемент {i + 1}: ");
            arr10_1[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите 9 вещественных чисел для второго массива:");
        for (int i = 0; i < arr10_2.Length; i++)
        {
            Console.Write($"Массив 2, элемент {i + 1}: ");
            arr10_2[i] = double.Parse(Console.ReadLine());
        }

        double[] result_10 = arr10_1.Concat(arr10_2).ToArray();
        Array.Sort(result_10);
        Array.Reverse(result_10);
        Console.WriteLine($"Объединенный массив по убыванию: [{string.Join(", ", result_10)}]");

        // Задача 11
        Console.WriteLine("\n=== Задача 11 ===");
        string[] arr_11 = new string[12];
        Console.WriteLine("Введите 12 двоичных чисел:");
        for (int i = 0; i < arr_11.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_11[i] = Console.ReadLine();
        }

        List<string> result11 = new List<string>();
        for (int i = 0; i < arr_11.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < arr_11.Length; j++)
            {
                if (arr_11[i] == arr_11[j])
                {
                    count++;
                }
            }
            if (count <= 2)
            {
                result11.Add(arr_11[i]);
            }
        }
        Console.WriteLine($"Массив после удаления: [{string.Join(", ", result11)}]");

        // Задача 12
        Console.WriteLine("\n=== Задача 12 ===");
        int[] arr_12 = new int[10];
        Console.WriteLine("Введите 10 целых чисел (только два одинаковых):");
        for (int i = 0; i < arr_12.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_12[i] = int.Parse(Console.ReadLine());
        }

        int firstIndex = -1, secondIndex = -1;
        for (int i = 0; i < arr_12.Length; i++)
        {
            for (int j = i + 1; j < arr_12.Length; j++)
            {
                if (arr_12[i] == arr_12[j])
                {
                    firstIndex = i;
                    secondIndex = j;
                    break;
                }
            }
            if (firstIndex != -1) break;
        }

        if (firstIndex != -1)
            Console.WriteLine($"Одинаковые элементы на позициях: {firstIndex} и {secondIndex}");
        else
            Console.WriteLine("Одинаковых элементов не найдено");

        // Задача 13
        Console.WriteLine("\n=== Задача 13 ===");
        Console.Write("Введите двоичное число: ");
        string binary13 = Console.ReadLine();
        char[] chars13 = binary13.ToCharArray();

        for (int shift = 0; shift < 2; shift++)
        {
            char first = chars13[0];
            for (int i = 0; i < chars13.Length - 1; i++)
            {
                chars13[i] = chars13[i + 1];
            }
            chars13[chars13.Length - 1] = first;
        }

        string shifted13 = new string(chars13);
        int original13 = Convert.ToInt32(binary13, 2);
        int shiftedValue13 = Convert.ToInt32(shifted13, 2);
        int difference13 = original13 - shiftedValue13;

        Console.WriteLine($"Исходное: {binary13} ({original13})");
        Console.WriteLine($"После сдвига: {shifted13} ({shiftedValue13})");
        Console.WriteLine($"Разность: {difference13}");

        // Задача 14
        Console.WriteLine("\n=== Задача 14 ===");
        string[] arr_14 = new string[8];
        Console.WriteLine("Введите 8 двоичных чисел:");
        for (int i = 0; i < arr_14.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_14[i] = Console.ReadLine();
        }

        Array.Sort(arr_14, (a, b) =>
            Convert.ToInt32(b, 2).CompareTo(Convert.ToInt32(a, 2)));

        int sum14 = 0;
        for (int i = 0; i < arr_14.Length; i++)
        {
            sum14 += Convert.ToInt32(arr_14[i], 2);
        }

        Console.WriteLine("Отсортированный массив: [" + string.Join(", ", arr_14) + "]");
        Console.WriteLine($"Сумма чисел: {sum14}");

        // Задача 15
        Console.WriteLine("\n=== Задача 15 ===");
        string[] arr_15 = new string[8];
        Console.WriteLine("Введите 8 двоичных чисел:");
        for (int i = 0; i < arr_15.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_15[i] = Console.ReadLine();
        }

        Array.Sort(arr_15, (a, b) =>
            Convert.ToInt32(a, 2).CompareTo(Convert.ToInt32(b, 2)));

        double sum15 = 0;
        for (int i = 0; i < arr15.Length; i++)
        {
            sum15 += Convert.ToInt32(arr_15[i], 2);
        }
        double average15 = sum15 / arr_15.Length;

        Console.WriteLine($"Отсортированный массив: [{string.Join(", ", arr_15)}]");
        Console.WriteLine($"Среднее значение: {average15:F2}");

        // Задача 16
        Console.WriteLine("\n=== Задача 16 ===");
        string[] arr_16 = new string[8];
        Console.WriteLine("Введите 8 двоичных чисел:");
        for (int i = 0; i < +arr_16.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_16[i] = Console.ReadLine();
        }

        int maxIndex_16 = 0, minIndex_16 = 0;
        for (int i = 1; i < arr_16.Length; i++)
        {
            int current = Convert.ToInt32(arr_16[i], 2);
            int maxVal = Convert.ToInt32(arr_16[maxIndex_16], 2);
            int minVal = Convert.ToInt32(arr_16[minIndex_16], 2);

            if (current > maxVal) maxIndex_16 = i;
            if (current < minVal) minIndex_16 = i;
        }

        string temp16 = arr_16[maxIndex_16];
        arr_16[maxIndex_16] = arr_16[minIndex_16];
        arr_16[minIndex_16] = temp16;

        Console.WriteLine($"Массив после обмена: [{string.Join(", ", arr_16)}]");

        // Задача 17
        Console.WriteLine("\n=== Задача 17 ===");
        Console.Write("Введите двоичное число: ");
        string binary17 = Console.ReadLine();
        char[] chars17 = binary17.ToCharArray();

        char last = chars17[chars17.Length - 1];
        for (int i = chars17.Length - 1; i > 0; i--)
        {
            chars17[i] = chars17[i - 1];
        }
        chars17[0] = last;

        string shifted17 = new string(chars17);
        int original17 = Convert.ToInt32(binary17, 2);
        int shiftedValue17 = Convert.ToInt32(shifted17, 2);
        int sum17 = original17 + shiftedValue17;

        Console.WriteLine($"Исходное: {binary17} ({original17})");
        Console.WriteLine($"После сдвига: {shifted17} ({shiftedValue17})");
        Console.WriteLine($"Сумма: {sum17}");

        // Задача 18
        Console.WriteLine("\n=== Задача 18 ===");
        double[] arr_18 = new double[15];
        Console.WriteLine("Введите 15 чисел:");
        for (int i = 0; i < arr_18.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_18[i] = double.Parse(Console.ReadLine());
        }

        double sumIncreasing = 0, sumDecreasing = 0;

        for (int i = 0; i < arr_18.Length - 1; i++)
        {
            if (arr_18[i] < arr_18[i + 1])
            {
                int j = i;
                double segmentSum = arr_18[i];
                while (j < arr_18.Length - 1 && arr_18[j] < arr_18[j + 1])
                {
                    j++;
                    segmentSum += arr_18[j];
                }
                sumIncreasing += segmentSum;
                i = j;
            }
        }

        for (int i = 0; i < arr_18.Length - 1; i++)
        {
            if (arr_18[i] > arr_18[i + 1])
            {
                int j = i;
                double segmentSum = arr_18[i];
                while (j < arr_18.Length - 1 && arr_18[j] > arr_18[j + 1])
                {
                    j++;
                    segmentSum += arr_18[j];
                }
                sumDecreasing += segmentSum;
                i = j;
            }
        }

        double difference18 = sumIncreasing - sumDecreasing;
        Console.WriteLine($"Разность: {difference18:F2}");

        // Задача 19
        Console.WriteLine("\n=== Задача 19 ===");
        int[] arr_19 = new int[10];
        Console.WriteLine("Введите 10 целых чисел:");
        for (int i = 0; i < arr_19.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_19[i] = int.Parse(Console.ReadLine());
        }

        bool isArithmetic = true;
        int difference19 = arr_19[1] - arr_19[0];
        for (int i = 2; i < arr_19.Length; i++)
        {
            if (arr_19[i] - arr_19[i - 1] != difference19)
            {
                isArithmetic = false;
                break;
            }
        }

        if (isArithmetic)
            Console.WriteLine($"Образует арифметическую прогрессию с разностью: {difference19}");
        else
            Console.WriteLine("Не образует арифметическую прогрессию");

        // Задача 20
        Console.WriteLine("\n=== Задача 20 ===");
        int[] arr_20 = new int[10];
        Console.WriteLine("Введите 10 целых чисел:");
        for (int i = 0; i < arr_20.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_20[i] = int.Parse(Console.ReadLine());
        }

        bool isGeometric = true;
        double ratio20 = (double)arr_20[1] / arr_20[0];
        for (int i = 2; i < arr_20.Length; i++)
        {
            if (Math.Abs((double)arr_20[i] / arr_20[i - 1] - ratio20) > 0.0001)
            {
                isGeometric = false;
                break;
            }
        }

        if (isGeometric)
            Console.WriteLine($"Образует геометрическую прогрессию со знаменателем: {ratio20:F2}");
        else
            Console.WriteLine("Не образует геометрическую прогрессию");

        // Задача 21
        Console.WriteLine("\n=== Задача 21 ===");
        int[] arr_21 = new int[10];
        Console.WriteLine("Введите 10 целых чисел:");
        for (int i = 0; i < arr_21.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_21[i] = int.Parse(Console.ReadLine());
        }

        List<int> indices_21 = new List<int>();
        int count_21 = 0;
        for (int i = 0; i < arr_21.Length - 1; i++)
        {
            if (arr_21[i] > arr_21[i + 1])
            {
                indices_21.Add(i);
                count_21++;
            }
        }

        Console.WriteLine($"Индексы элементов, больших чем справа: [{string.Join(", ", indices_21)}]");
        Console.WriteLine($"Количество таких чисел: {count_21}");

        // Задача 22
        Console.WriteLine("\n=== Задача 22 ===");
        int[] arr_22 = new int[12];
        Console.WriteLine("Введите 12 целых чисел:");
        for (int i = 0; i < arr_22.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_22[i] = int.Parse(Console.ReadLine());
        }

        int lastIndex_22 = -1;
        for (int i = 1; i < arr_22.Length - 1; i++)
        {
            if (arr_22[i - 1] < arr_22[i] && arr_22[i] < arr_22[i + 1])
            {
                lastIndex_22 = i;
            }
        }

        if (lastIndex_22 != -1)
            Console.WriteLine($"Индекс последнего элемента, удовлетворяющего условию: {lastIndex_22}");
        else
            Console.WriteLine("Таких элементов нет");

        // Задача 23
        Console.WriteLine("\n=== Задача 23 ===");
        double[] arr_23 = new double[10];
        Console.WriteLine("Введите 10 вещественных чисел:");
        for (int i = 0; i < arr_23.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_23[i] = double.Parse(Console.ReadLine());
        }

        int maxIndex_23 = 0, minIndex_23 = 0;
        for (int i = 1; i < arr_23.Length; i++)
        {
            if (arr_23[i] > arr_23[maxIndex_23]) maxIndex_23 = i;
            if (arr_23[i] < arr_23[minIndex_23]) minIndex_23 = i;
        }

        int start_23 = Math.Min(maxIndex_23, minIndex_23);
        int end_23 = Math.Max(maxIndex_23, minIndex_23);
        int countBetween_23 = Math.Max(0, end_23 - start_23 - 1);

        if (countBetween_23 > 0)
            Console.WriteLine($"Количество чисел между максимальным и минимальным: {countBetween_23}");
        else
            Console.WriteLine("Между максимальным и минимальным элементами нет чисел");

        // Задача 24
        Console.WriteLine("\n=== Задача 24 ===");
        double[] arr_24 = new double[8];
        Console.WriteLine("Введите 8 вещественных чисел:");
        for (int i = 0; i < arr_24.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_24[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", arr_24)}]");

        double last_24 = arr_24[arr_24.Length - 1];
        for (int i = arr_24.Length - 1; i > 0; i--)
        {
            arr_24[i] = arr_24[i - 1];
        }
        arr_24[0] = last_24;

        Console.WriteLine($"После сдвига вправо: [{string.Join(", ", arr_24)}]");

        // Задача 25
        Console.WriteLine("\n=== Задача 25 ===");
        double[] arr_25 = new double[8];
        Console.WriteLine("Введите 8 вещественных чисел:");
        for (int i = 0; i < arr_25.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_25[i] = double.Parse(Console.ReadLine());
        }

        double sumBefore_25 = arr_25.Sum();
        Console.WriteLine($"Сумма до сдвига: {sumBefore_25:F2}");

        double first_25 = arr_25[0];
        for (int i = 0; i < arr_25.Length - 1; i++)
        {
            arr_25[i] = arr_25[i + 1];
        }
        arr_25[arr_25.Length - 1] = first_25;

        double sumAfter_25 = arr_25.Sum();
        Console.WriteLine($"После сдвига влево: [{string.Join(", ", arr_25)}]");
        Console.WriteLine($"Сумма после сдвига: {sumAfter_25:F2}");

        // Задача 26
        Console.WriteLine("\n=== Задача 26 ===");
        int[] arr_26 = new int[8];
        Console.WriteLine("Введите 8 целых чисел:");
        for (int i = 0; i < arr_26.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_26[i] = int.Parse(Console.ReadLine());
        }

        int binaryAdd_26 = Convert.ToInt32("1010", 2);
        for (int i = 0; i < arr_26.Length; i++)
        {
            arr_26[i] += binaryAdd_26;
        }

        Console.WriteLine($"Массив после увеличения на 1010₂ ({binaryAdd_26}₁₀): [{string.Join(", ", arr_26)}]");

        // Задача 27
        Console.WriteLine("\n=== Задача 27 ===");
        double[] arr_27 = new double[10];
        Console.WriteLine("Введите 10 вещественных чисел:");
        for (int i = 0; i < arr_27.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_27[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Введите число R: ");
        double R_27 = double.Parse(Console.ReadLine());

        int closestIndex_27 = 0;
        double minDistance_27 = Math.Abs(arr_27[0] - R_27);

        for (int i = 1; i < arr_27.Length; i++)
        {
            double distance = Math.Abs(arr_27[i] - R_27);
            if (distance < minDistance_27)
            {
                minDistance_27 = distance;
                closestIndex_27 = i;
            }
        }

        Console.WriteLine($"Наиболее близкий элемент: arr_27[{closestIndex_27}] = {arr_27[closestIndex_27]}");
        Console.WriteLine($"Расстояние до R: {minDistance_27:F2}");

        // Задача 28
        Console.WriteLine("\n=== Задача 28 ===");
        double[] arr_28 = new double[10];
        Console.WriteLine("Введите 10 вещественных чисел:");
        for (int i = 0; i < arr_28.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_28[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Введите число D: ");
        double D_28 = double.Parse(Console.ReadLine());

        int farthestIndex_28 = 0;
        double maxDistance_28 = Math.Abs(arr_28[0] - D_28);

        for (int i = 1; i < arr_28.Length; i++)
        {
            double distance = Math.Abs(arr_28[i] - D_28);
            if (distance > maxDistance_28)
            {
                maxDistance_28 = distance;
                farthestIndex_28 = i;
            }
        }

        Console.WriteLine($"Наиболее удаленный элемент: arr_28[{farthestIndex_28}] = {arr_28[farthestIndex_28]}");
        Console.WriteLine($"Расстояние до D: {maxDistance_28:F2}");

        // Задача 29
        Console.WriteLine("\n=== Задача 29 ===");
        Console.Write("Введите положительное двоичное число: ");
        string positiveBinary_29 = Console.ReadLine();
        Console.Write("Введите отрицательное двоичное число (в дополнительном коде): ");
        string negativeBinary_29 = Console.ReadLine();

        int positive_29 = Convert.ToInt32(positiveBinary_29, 2);
        int negative_29 = Convert.ToInt32(negativeBinary_29, 2);

        if (negativeBinary_29[0] == '1')
        {
            int bits_29 = negativeBinary_29.Length;
            negative_29 = negative_29 - (1 << bits_29);
        }

        int sum_29 = positive_29 + negative_29;
        string binarySum_29 = Convert.ToString(sum_29, 2);

        Console.WriteLine($"Сумма: {positive_29} + ({negative_29}) = {sum_29}");
        Console.WriteLine($"В двоичной системе: {binarySum_29}");

        // Задача 30
        Console.WriteLine("\n=== Задача 30 ===");
        int[] arr_30 = new int[3];
        Console.WriteLine("Введите 3 десятичных числа:");
        for (int i = 0; i < arr_30.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            arr_30[i] = int.Parse(Console.ReadLine());
        }

        string[] binaryArray_30 = new string[3];
        for (int i = 0; i < arr_30.Length; i++)
        {
            binaryArray_30[i] = Convert.ToString(arr_30[i], 2);
        }

        Console.WriteLine($"Исходный массив: [{string.Join(", ", arr_30)}]");
        Console.WriteLine($"Двоичное представление: [{string.Join(", ", binaryArray_30)}]");

        #endregion


        #region Задания с 1 по 15 с двумерными массивами

        // Задача 1
        Console.WriteLine("\n=== Задача 1 ===");
        int[,] matrix_1 = new int[3, 4];
        Console.WriteLine("Введите элементы массива 3x4:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int j = 0; j < 4; j++)
        {
            for (int k = j + 1; k < 4; k++)
            {
                if (matrix_1[2, j] > matrix_1[2, k])
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int temp = matrix_1[i, j];
                        matrix_1[i, j] = matrix_1[i, k];
                        matrix_1[i, k] = temp;
                    }
                }
            }
        }

        Console.WriteLine("Массив после сортировки:");
        PrintMatrix(matrix_1);

        // Задача 2
        Console.WriteLine("\n=== Задача 2 ===");
        int[,] matrix_2 = new int[7, 7];
        Console.WriteLine("Введите элементы массива 7x7:");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int sum_2 = 0;
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (matrix_2[i, j] < 0 && matrix_2[i, j] % 2 != 0)
                {
                    sum_2 += Math.Abs(matrix_2[i, j]);
                }
            }
        }
        Console.WriteLine($"Сумма модулей отрицательных нечетных элементов: {sum_2}");

        // Задача 3
        Console.WriteLine("\n=== Задача 3 ===");
        int[,] matrix_3 = new int[5, 6];
        Console.WriteLine("Введите элементы массива 5x6:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_3[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Среднее арифметическое положительных элементов по столбцам:");
        for (int j = 0; j < 6; j++)
        {
            int sum_3 = 0, count_3 = 0;
            for (int i = 0; i < 5; i++)
            {
                if (matrix_3[i, j] > 0)
                {
                    sum_3 += matrix_3[i, j];
                    count_3++;
                }
            }
            double avg_3 = count_3 > 0 ? (double)sum_3 / count_3 : 0;
            Console.WriteLine($"Столбец {j + 1}: {avg_3:F2}");
        }

        // Задача 4
        Console.WriteLine("\n=== Задача 4 ===");
        double[,] matrix_4 = new double[5, 5];
        Console.WriteLine("Введите элементы квадратной матрицы 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_4[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double min_4 = matrix_4[0, 4];
        for (int i = 1; i < 5; i++)
        {
            if (matrix_4[i, 4 - i] < min_4)
            {
                min_4 = matrix_4[i, 4 - i];
            }
        }
        Console.WriteLine($"Наименьший элемент на побочной диагонали: {min_4:F2}");

        // Задача 5
        Console.WriteLine("\n=== Задача 5 ===");
        int[,] matrix_5 = new int[5, 4];
        Console.WriteLine("Введите элементы массива 5x4:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_5[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int k = i + 1; k < 5; k++)
            {
                if (matrix_5[i, 3] < matrix_5[k, 3])
                {
                    for (int j = 0; j < 4; j++)
                    {
                        int temp = matrix_5[i, j];
                        matrix_5[i, j] = matrix_5[k, j];
                        matrix_5[k, j] = temp;
                    }
                }
            }
        }

        Console.WriteLine("Массив после сортировки:");
        PrintMatrix(matrix_5);

        // Задача 6
        Console.WriteLine("\n=== Задача 6 ===");
        int[,] matrix_6 = new int[4, 3];
        Console.WriteLine("Введите элементы массива 4x3:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_6[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int maxCol1_6 = 0, maxCol3_6 = 0;
        int maxIndex1_6 = 0, maxIndex3_6 = 0;

        for (int i = 0; i < 4; i++)
        {
            if (matrix_6[i, 0] > maxCol1_6)
            {
                maxCol1_6 = matrix_6[i, 0];
                maxIndex1_6 = i;
            }
            if (matrix_6[i, 2] > maxCol3_6)
            {
                maxCol3_6 = matrix_6[i, 2];
                maxIndex3_6 = i;
            }
        }

        int temp_6 = matrix_6[maxIndex1_6, 0];
        matrix_6[maxIndex1_6, 0] = matrix_6[maxIndex3_6, 2];
        matrix_6[maxIndex3_6, 2] = temp_6;

        Console.WriteLine("Массив после обмена:");
        PrintMatrix(matrix_6);

        // Задача 7
        Console.WriteLine("\n=== Задача 7 ===");
        int[,] matrix_7 = new int[3, 4];
        Console.WriteLine("Введите элементы массива 3x4:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_7[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int minRow1_7 = matrix_7[0, 0], minRow3_7 = matrix_7[2, 0];
        int minIndex1_7 = 0, minIndex3_7 = 0;

        for (int j = 0; j < 4; j++)
        {
            if (matrix_7[0, j] < minRow1_7)
            {
                minRow1_7 = matrix_7[0, j];
                minIndex1_7 = j;
            }
            if (matrix_7[2, j] < minRow3_7)
            {
                minRow3_7 = matrix_7[2, j];
                minIndex3_7 = j;
            }
        }

        int temp_7 = matrix_7[0, minIndex1_7];
        matrix_7[0, minIndex1_7] = matrix_7[2, minIndex3_7];
        matrix_7[2, minIndex3_7] = temp_7;

        Console.WriteLine("Массив после обмена:");
        PrintMatrix(matrix_7);

        // Задача 8
        Console.WriteLine("\n=== Задача 8 ===");
        Console.Write("Введите размер матрицы N (<=10): ");
        int N_8 = int.Parse(Console.ReadLine());
        double[,] matrix_8 = new double[N_8, N_8];
        Console.WriteLine($"Введите элементы квадратной матрицы {N_8}x{N_8}:");
        for (int i = 0; i < N_8; i++)
        {
            for (int j = 0; j < N_8; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_8[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double product_8 = 1;
        for (int j = 0; j < N_8; j++)
        {
            double minCol_8 = matrix_8[0, j];
            for (int i = 1; i < N_8; i++)
            {
                if (matrix_8[i, j] < minCol_8)
                {
                    minCol_8 = matrix_8[i, j];
                }
            }
            product_8 *= minCol_8;
        }
        Console.WriteLine($"Произведение наименьших элементов каждого столбца: {product_8:F2}");

        // Задача 9
        Console.WriteLine("\n=== Задача 9 ===");
        int[,] matrix_9 = new int[5, 6];
        Console.WriteLine("Введите элементы массива 5x6:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_9[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Среднее арифметическое по столбцам:");
        for (int j = 0; j < 6; j++)
        {
            int sumCol_9 = 0;
            for (int i = 0; i < 5; i++)
            {
                sumCol_9 += matrix_9[i, j];
            }
            double avg_9 = (double)sumCol_9 / 5;
            Console.WriteLine($"Столбец {j + 1}: {avg_9:F2}");
        }

        Console.WriteLine("Максимумы и минимумы по строкам:");
        for (int i = 0; i < 5; i++)
        {
            int maxRow_9 = matrix_9[i, 0], minRow_9 = matrix_9[i, 0];
            for (int j = 1; j < 6; j++)
            {
                if (matrix_9[i, j] > maxRow_9) maxRow_9 = matrix_9[i, j];
                if (matrix_9[i, j] < minRow_9) minRow_9 = matrix_9[i, j];
            }
            Console.WriteLine($"Строка {i + 1}: max={maxRow_9}, min={minRow_9}");
        }

        // Задача 10
        Console.WriteLine("\n=== Задача 10 ===");
        int[,] matrix_10 = new int[7, 8];
        Console.WriteLine("Введите элементы массива 7x8:");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_10[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Количество нечетных элементов по столбцам:");
        for (int j = 0; j < 8; j++)
        {
            int countOdd_10 = 0;
            for (int i = 0; i < 7; i++)
            {
                if (matrix_10[i, j] % 2 != 0)
                {
                    countOdd_10++;
                }
            }
            Console.WriteLine($"Столбец {j + 1}: {countOdd_10}");
        }

        // Задача 11
        Console.WriteLine("\n=== Задача 11 ===");
        Console.Write("Введите количество строк n: ");
        int n_11 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов m: ");
        int m_11 = int.Parse(Console.ReadLine());
        int[,] matrix_11 = new int[n_11, m_11];
        Console.WriteLine($"Введите элементы массива {n_11}x{m_11}:");
        for (int i = 0; i < n_11; i++)
        {
            for (int j = 0; j < m_11; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_11[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int evenCount_11 = 0, oddCount_11 = 0;
        for (int i = 0; i < n_11; i++)
        {
            for (int j = 0; j < m_11; j++)
            {
                if (matrix_11[i, j] % 2 == 0)
                    evenCount_11++;
                else
                    oddCount_11++;
            }
        }
        Console.WriteLine($"Четных элементов: {evenCount_11}");
        Console.WriteLine($"Нечетных элементов: {oddCount_11}");

        // Задача 12
        Console.WriteLine("\n=== Задача 12 ===");
        Console.Write("Введите количество строк n: ");
        int n_12 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов m: ");
        int m_12 = int.Parse(Console.ReadLine());
        int[,] matrix_12 = new int[n_12, m_12];
        Console.WriteLine($"Введите элементы массива {n_12}x{m_12}:");
        for (int i = 0; i < n_12; i++)
        {
            for (int j = 0; j < m_12; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_12[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int count7_12 = 0;
        for (int i = 0; i < n_12; i++)
        {
            for (int j = 0; j < m_12; j++)
            {
                if (matrix_12[i, j] == 7)
                {
                    count7_12++;
                }
            }
        }
        Console.WriteLine($"Число 7 встречается {count7_12} раз");

        // Задача 13
        Console.WriteLine("\n=== Задача 13 ===");
        Console.Write("Введите количество строк n: ");
        int n_13 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов m: ");
        int m_13 = int.Parse(Console.ReadLine());
        int[,] matrix_13 = new int[n_13, m_13];
        Console.WriteLine($"Введите элементы массива {n_13}x{m_13}:");
        for (int i = 0; i < n_13; i++)
        {
            for (int j = 0; j < m_13; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_13[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Наибольшие элементы по столбцам:");
        for (int j = 0; j < m_13; j++)
        {
            int maxCol_13 = matrix_13[0, j];
            for (int i = 1; i < n_13; i++)
            {
                if (matrix_13[i, j] > maxCol_13)
                {
                    maxCol_13 = matrix_13[i, j];
                }
            }
            Console.WriteLine($"Столбец {j + 1}: {maxCol_13}");
        }

        // Задача 14
        Console.WriteLine("\n=== Задача 14 ===");
        Console.Write("Введите количество строк n: ");
        int n_14 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов m: ");
        int m_14 = int.Parse(Console.ReadLine());
        int[,] matrix_14 = new int[n_14, m_14];
        Console.WriteLine($"Введите элементы массива {n_14}x{m_14}:");
        for (int i = 0; i < n_14; i++)
        {
            for (int j = 0; j < m_14; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_14[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int minValue_14 = matrix_14[0, 0];
        int minRow_14 = 0, minCol_14 = 0;
        for (int i = 0; i < n_14; i++)
        {
            for (int j = 0; j < m_14; j++)
            {
                if (matrix_14[i, j] < minValue_14)
                {
                    minValue_14 = matrix_14[i, j];
                    minRow_14 = i;
                    minCol_14 = j;
                }
            }
        }
        Console.WriteLine($"Первый наименьший элемент: [{minRow_14},{minCol_14}] = {minValue_14}");

        // Задача 15
        Console.WriteLine("\n=== Задача 15 ===");
        Console.Write("Введите размер квадратного массива n: ");
        int n_15 = int.Parse(Console.ReadLine());
        int[,] matrix_15 = new int[n_15, n_15];
        Console.WriteLine($"Введите элементы квадратного массива {n_15}x{n_15}:");
        for (int i = 0; i < n_15; i++)
        {
            for (int j = 0; j < n_15; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                matrix_15[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int sumLastCol_15 = 0;
        for (int i = 0; i < n_15; i++)
        {
            sumLastCol_15 += matrix_15[i, n_15 - 1];
        }
        Console.WriteLine($"Сумма элементов последнего столбца: {sumLastCol_15}");

        Console.WriteLine("\nЗадачи 6-15 выполнены!");
    }

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

        #endregion
    }
}