using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задания от 1 - 100");
            int task = int.Parse(Console.ReadLine());
            switch (task)
            {
                case 1:
                    Console.WriteLine("Hello world!");
                    break;
                case 2:
                    Console.WriteLine("Введите значение перемнной - a");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите значение перемнной - b");
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Выберите математическую операцию");
                    int sum = a + b;
                    Console.WriteLine("Сумма = " + sum);
                    int min = a - b;
                    Console.WriteLine("Минус = " + min);
                    int del = a / b;
                    Console.WriteLine("Деление = " + del);
                    int umn = a * b;
                    Console.WriteLine("Умножение = " + umn);
                    break;
                case 3:
                    Console.WriteLine("Введите значение перемнной - c");
                    double C = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"F = {(C * 9 / 5) + 32}");
                    break;
                case 4:
                    Console.WriteLine("Введите значение первой стороны");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите значение второй стороны");
                    int d = int.Parse(Console.ReadLine());

                    int per = 2 * (c + d);
                    Console.WriteLine("Периметр = " + per);
                    int pl = c * d;
                    Console.WriteLine("Площадь = " + pl);
                    break;
                case 5:
                    Console.WriteLine("Введите значение перемнной - a");
                    int a_1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите значение перемнной - b");
                    int b_1 = int.Parse(Console.ReadLine());

                    int ost = a_1 % b_1;
                    Console.WriteLine("Остаток от деления = " + ost);
                    break;
                case 6:
                    Console.WriteLine("Введите значение перемнной - x");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите значение перемнной - y");
                    int y = int.Parse(Console.ReadLine());

                    x = x + y;
                    y = x - y;
                    x = x - y;
                    Console.WriteLine("После обмена: x = " + x + ", y = " + y);
                    break;
                case 7:
                    Console.WriteLine("Введите три числа:");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double num3 = Convert.ToDouble(Console.ReadLine());

                    double sred = (num1 + num2 + num3) / 3;
                    Console.WriteLine("Среднее арифметическое = " + sred);
                    break;
                case 8:
                    Console.WriteLine("Введите радиус круга:");
                    double r = Convert.ToDouble(Console.ReadLine());

                    double pl_krug = Math.PI * r * r;
                    Console.WriteLine("Площадь круга = " + pl_krug);
                    break;
                case 9:
                    Console.WriteLine("Введите ваш возраст (лет):");
                    int age = int.Parse(Console.ReadLine());

                    long sec = age * 365 * 24 * 60 * 60;
                    Console.WriteLine("Ваш возраст в секундах = " + sec);
                    break;
                case 10:
                    Console.WriteLine("Введите сумму в рублях:");
                    double rub = Convert.ToDouble(Console.ReadLine());

                    double usd = rub * 0.011;
                    double eur = rub * 0.010;
                    Console.WriteLine("USD = " + usd);
                    Console.WriteLine("EUR = " + eur);
                    break;
                case 11:
                    Console.WriteLine("Введите число:");
                    int chislo = int.Parse(Console.ReadLine());

                    if (chislo % 2 == 0)
                        Console.WriteLine("Четное");
                    else
                        Console.WriteLine("Нечетное");
                    break;
                case 12:
                    Console.WriteLine("Введите три числа:");
                    int n1 = int.Parse(Console.ReadLine());
                    int n2 = int.Parse(Console.ReadLine());
                    int n3 = int.Parse(Console.ReadLine());

                    int max = n1;
                    if (n2 > max) max = n2;
                    if (n3 > max) max = n3;
                    Console.WriteLine("Максимум = " + max);
                    break;
                case 13:
                    Console.WriteLine("Введите первое число:");
                    double d1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    double d2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите операцию (+, -, *, /):");
                    char op = char.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case '+':
                            Console.WriteLine("Результат: " + (d1 + d2));
                            break;
                        case '-':
                            Console.WriteLine("Результат: " + (d1 - d2));
                            break;
                        case '*':
                            Console.WriteLine("Результат: " + (d1 * d2));
                            break;
                        case '/':
                            if (d2 != 0)
                                Console.WriteLine("Результат: " + (d1 / d2));
                            else
                                Console.WriteLine("Ошибка: деление на ноль!");
                            break;
                        default:
                            Console.WriteLine("Неизвестная операция");
                            break;
                    }
                    break;
                case 14:
                    Console.WriteLine("Введите год:");
                    int year = int.Parse(Console.ReadLine());

                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                        Console.WriteLine("Високосный");
                    else
                        Console.WriteLine("Не високосный");
                    break;
                case 15:
                    Console.WriteLine("Введите баллы (0-100):");
                    int balls = int.Parse(Console.ReadLine());

                    if (balls >= 90) Console.WriteLine("A");
                    else if (balls >= 80) Console.WriteLine("B");
                    else if (balls >= 70) Console.WriteLine("C");
                    else if (balls >= 60) Console.WriteLine("D");
                    else if (balls >= 50) Console.WriteLine("E");
                    else Console.WriteLine("F");
                    break;
                case 16:
                    Console.WriteLine("Введите час (0-23):");
                    int hour = int.Parse(Console.ReadLine());

                    if (hour >= 6 && hour < 12) Console.WriteLine("Утро");
                    else if (hour >= 12 && hour < 18) Console.WriteLine("День");
                    else if (hour >= 18 && hour < 24) Console.WriteLine("Вечер");
                    else Console.WriteLine("Ночь");
                    break;
                case 17:
                    Console.WriteLine("Введите три стороны треугольника:");
                    int s1 = int.Parse(Console.ReadLine());
                    int s2 = int.Parse(Console.ReadLine());
                    int s3 = int.Parse(Console.ReadLine());

                    if (s1 == s2 && s2 == s3) Console.WriteLine("Равносторонний");
                    else if (s1 == s2 || s1 == s3 || s2 == s3) Console.WriteLine("Равнобедренный");
                    else Console.WriteLine("Разносторонний");
                    break;
                case 18:
                    Console.WriteLine("Введите возраст:");
                    int vozrast = int.Parse(Console.ReadLine());

                    if (vozrast < 0) Console.WriteLine("Ошибка");
                    else if (vozrast <= 12) Console.WriteLine("Ребенок");
                    else if (vozrast <= 19) Console.WriteLine("Подросток");
                    else if (vozrast <= 65) Console.WriteLine("Взрослый");
                    else Console.WriteLine("Пенсионер");
                    break;
                case 19:
                    Console.WriteLine("Введите a, b, c:");
                    double aa = Convert.ToDouble(Console.ReadLine());
                    double bb = Convert.ToDouble(Console.ReadLine());
                    double cc = Convert.ToDouble(Console.ReadLine());

                    double diskr = bb * bb - 4 * aa * cc;
                    if (diskr > 0)
                    {
                        double x1 = (-bb + Math.Sqrt(diskr)) / (2 * aa);
                        double x2 = (-bb - Math.Sqrt(diskr)) / (2 * aa);
                        Console.WriteLine("x1 = " + x1 + ", x2 = " + x2);
                    }
                    else if (diskr == 0)
                    {
                        double x_1 = -bb / (2 * aa);
                        Console.WriteLine("x = " + x_1);
                    }
                    else
                    {
                        Console.WriteLine("Нет действительных корней");
                    }
                    break;
                case 20:
                    Console.WriteLine("Введите сумму покупки:");
                    double summa = Convert.ToDouble(Console.ReadLine());
                    double skidka = 0;

                    if (summa > 1000) skidka = 0.2;
                    else if (summa > 500) skidka = 0.1;
                    else if (summa > 100) skidka = 0.05;

                    double itog = summa * (1 - skidka);
                    Console.WriteLine("Итоговая сумма: " + itog);
                    break;
                case 21:
                    Console.WriteLine("Введите номер месяца (1-12):");
                    int month = int.Parse(Console.ReadLine());

                    switch (month)
                    {
                        case 1: Console.WriteLine("Январь"); break;
                        case 2: Console.WriteLine("Февраль"); break;
                        case 3: Console.WriteLine("Март"); break;
                        case 4: Console.WriteLine("Апрель"); break;
                        case 5: Console.WriteLine("Май"); break;
                        case 6: Console.WriteLine("Июнь"); break;
                        case 7: Console.WriteLine("Июль"); break;
                        case 8: Console.WriteLine("Август"); break;
                        case 9: Console.WriteLine("Сентябрь"); break;
                        case 10: Console.WriteLine("Октябрь"); break;
                        case 11: Console.WriteLine("Ноябрь"); break;
                        case 12: Console.WriteLine("Декабрь"); break;
                        default: Console.WriteLine("Неверный номер"); break;
                    }
                    break;
                case 22:
                    Console.WriteLine("Введите пароль:");
                    string pass = Console.ReadLine();

                    if (pass.Length >= 8 &&
                        pass.Any(char.IsUpper) &&
                        pass.Any(char.IsLower) &&
                        pass.Any(char.IsDigit))
                        Console.WriteLine("Надежный пароль");
                    else
                        Console.WriteLine("Слабый пароль");
                    break;
                case 23:
                    Console.WriteLine("Введите N:");
                    int N = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= N; i++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    break;
                case 24:
                    Console.WriteLine("Введите N:");
                    int N2 = int.Parse(Console.ReadLine());
                    int summa2 = 0;

                    for (int i = 1; i <= N2; i++)
                    {
                        summa2 += i;
                    }
                    Console.WriteLine("Сумма = " + summa2);
                    break;
                case 25:
                    for (int i = 1; i <= 10; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.Write(i * j + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 26:
                    Console.WriteLine("Введите число:");
                    int fact = int.Parse(Console.ReadLine());
                    int result = 1;

                    for (int i = 1; i <= fact; i++)
                    {
                        result *= i;
                    }
                    Console.WriteLine("Факториал = " + result);
                    break;
                case 27:
                    Console.WriteLine("Введите N:");
                    int fib = int.Parse(Console.ReadLine());
                    int a_fib = 0, b_fib = 1;

                    Console.Write("Числа Фибоначчи: ");
                    for (int i = 0; i < fib; i++)
                    {
                        Console.Write(a_fib + " ");
                        int temp = a_fib;
                        a_fib = b_fib;
                        b_fib = temp + b_fib;
                    }
                    Console.WriteLine();
                    break;
                case 28:
                    Console.WriteLine("Введите число:");
                    int prime = int.Parse(Console.ReadLine());
                    bool prostoe = true;

                    if (prime <= 1) prostoe = false;
                    else
                    {
                        for (int i = 2; i <= Math.Sqrt(prime); i++)
                        {
                            if (prime % i == 0)
                            {
                                prostoe = false;
                                break;
                            }
                        }
                    }

                    if (prostoe) Console.WriteLine("Простое");
                    else Console.WriteLine("Составное");
                    break;
                case 29:
                    Console.WriteLine("Введите число:");
                    int reverse = int.Parse(Console.ReadLine());
                    int reversed = 0;

                    while (reverse > 0)
                    {
                        reversed = reversed * 10 + reverse % 10;
                        reverse /= 10;
                    }
                    Console.WriteLine("Перевернутое число: " + reversed);
                    break;
                case 30:
                    Console.WriteLine("Введите число:");
                    int sum_digits = int.Parse(Console.ReadLine());
                    int sum_d = 0;

                    while (sum_digits > 0)
                    {
                        sum_d += sum_digits % 10;
                        sum_digits /= 10;
                    }
                    Console.WriteLine("Сумма цифр: " + sum_d);
                    break;
                case 31:
                    Console.WriteLine("Введите N:");
                    int N3 = int.Parse(Console.ReadLine());

                    for (int i = 2; i <= N3; i++)
                    {
                        bool isPrime = true;
                        for (int j = 2; j <= Math.Sqrt(i); j++)
                        {
                            if (i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime) Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    break;
                case 32:
                    Random rand = new Random();
                    int secret = rand.Next(1, 101);
                    int popytka = 0;
                    int userGuess = 0;

                    Console.WriteLine("Угадайте число от 1 до 100");

                    while (userGuess != secret)
                    {
                        userGuess = int.Parse(Console.ReadLine());
                        popytka++;

                        if (userGuess < secret)
                            Console.WriteLine("Больше");
                        else if (userGuess > secret)
                            Console.WriteLine("Меньше");
                        else
                            Console.WriteLine("Угадал! Попыток: " + popytka);
                    }
                    break;
                case 33:
                    Console.WriteLine("Введите высоту пирамиды:");
                    int height = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= height; i++)
                    {
                        Console.WriteLine(new string(' ', height - i) + new string('*', 2 * i - 1));
                    }
                    break;
                case 34:
                    Console.WriteLine("Введите два числа:");
                    int nod1 = int.Parse(Console.ReadLine());
                    int nod2 = int.Parse(Console.ReadLine());

                    while (nod2 != 0)
                    {
                        int temp = nod2;
                        nod2 = nod1 % nod2;
                        nod1 = temp;
                    }
                    Console.WriteLine("НОД = " + nod1);
                    break;
                case 35:
                    int[] array = new int[10];
                    Random rnd = new Random();

                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = rnd.Next(1, 101);
                    }

                    Console.WriteLine("Массив:");
                    foreach (int num in array)
                    {
                        Console.Write(num + " ");
                    }
                    Console.WriteLine();
                    break;
                case 36:
                    int[] array2 = new int[5] { 1, 2, 3, 4, 5 };
                    int sum_arr = 0;

                    foreach (int num in array2)
                    {
                        sum_arr += num;
                    }
                    Console.WriteLine("Сумма элементов: " + sum_arr);
                    break;
                case 37:
                    int[] array3 = new int[6] { 3, 7, 2, 9, 1, 5 };
                    int max_arr = array3[0];
                    int max_index = 0;

                    for (int i = 1; i < array3.Length; i++)
                    {
                        if (array3[i] > max_arr)
                        {
                            max_arr = array3[i];
                            max_index = i;
                        }
                    }
                    Console.WriteLine("Максимум: " + max_arr + ", индекс: " + max_index);
                    break;
                case 38:
                    int[] array4 = new int[5] { 1, 2, 3, 4, 5 };

                    Console.WriteLine("Исходный массив:");
                    foreach (int num in array4) Console.Write(num + " ");
                    Console.WriteLine();

                    for (int i = 0; i < array4.Length / 2; i++)
                    {
                        int temp = array4[i];
                        array4[i] = array4[array4.Length - 1 - i];
                        array4[array4.Length - 1 - i] = temp;
                    }

                    Console.WriteLine("Перевернутый массив:");
                    foreach (int num in array4) Console.Write(num + " ");
                    Console.WriteLine();
                    break;
                case 39:
                    int[] array5 = new int[6] { 1, 3, 5, 7, 9, 11 };
                    Console.WriteLine("Введите элемент для поиска:");
                    int search = int.Parse(Console.ReadLine());
                    bool found = false;

                    for (int i = 0; i < array5.Length; i++)
                    {
                        if (array5[i] == search)
                        {
                            Console.WriteLine("Найден на позиции: " + i);
                            found = true;
                            break;
                        }
                    }

                    if (!found) Console.WriteLine("Не найден");
                    break;
                case 40:
                    int[] array6 = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
                    int even = 0, odd = 0;

                    foreach (int num in array6)
                    {
                        if (num % 2 == 0) even++;
                        else odd++;
                    }
                    Console.WriteLine("Четных: " + even + ", Нечетных: " + odd);
                    break;
                case 41:
                    int[] array7 = new int[6] { 5, 2, 8, 1, 9, 3 };

                    Console.WriteLine("Исходный массив:");
                    foreach (int num in array7) Console.Write(num + " ");
                    Console.WriteLine();

                    for (int i = 0; i < array7.Length - 1; i++)
                    {
                        for (int j = 0; j < array7.Length - 1 - i; j++)
                        {
                            if (array7[j] > array7[j + 1])
                            {
                                int temp = array7[j];
                                array7[j] = array7[j + 1];
                                array7[j + 1] = temp;
                            }
                        }
                    }

                    Console.WriteLine("Отсортированный массив:");
                    foreach (int num in array7) Console.Write(num + " ");
                    Console.WriteLine();
                    break;
                case 42:
                    int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

                    Console.WriteLine("Матрица 3x3:");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(matrix[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 43:
                    int[,] matrix2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                    int diag_sum = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        diag_sum += matrix2[i, i];
                    }
                    Console.WriteLine("Сумма диагонали: " + diag_sum);
                    break;
                case 44:
                    int[][] jagged = new int[3][];
                    jagged[0] = new int[] { 1, 2 };
                    jagged[1] = new int[] { 3, 4, 5 };
                    jagged[2] = new int[] { 6, 7, 8, 9 };

                    Console.WriteLine("Зубчатый массив:");
                    for (int i = 0; i < jagged.Length; i++)
                    {
                        for (int j = 0; j < jagged[i].Length; j++)
                        {
                            Console.Write(jagged[i][j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 45:
                    int[,] matrix3 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

                    Console.WriteLine("Исходная матрица:");
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(matrix3[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Транспонированная матрица:");
                    for (int j = 0; j < 3; j++)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            Console.Write(matrix3[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 46:
                    int[] arr1 = new int[] { 1, 3, 5 };
                    int[] arr2 = new int[] { 2, 4, 6 };
                    int[] merged = new int[arr1.Length + arr2.Length];

                    Array.Copy(arr1, merged, arr1.Length);
                    Array.Copy(arr2, 0, merged, arr1.Length, arr2.Length);
                    Array.Sort(merged);

                    Console.WriteLine("Объединенный массив:");
                    foreach (int num in merged) Console.Write(num + " ");
                    Console.WriteLine();
                    break;
                case 47:
                    Console.WriteLine("Введите два числа:");
                    int p1 = int.Parse(Console.ReadLine());
                    int p2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Сумма: " + Sum(p1, p2));
                    break;
                case 48:
                    Console.WriteLine("Введите число:");
                    int ch = int.Parse(Console.ReadLine());
                    Console.WriteLine("Четное: " + IsEven(ch));
                    break;
                case 49:
                    Console.WriteLine("Введите число:");
                    int f = int.Parse(Console.ReadLine());
                    Console.WriteLine("Факториал: " + Factorial(f));
                    break;
                case 50:
                    Console.WriteLine("Результат: " + Multiply(5));
                    Console.WriteLine("Результат: " + Multiply(5, 3));
                    break;
                case 51:
                    int[] arr_max = new int[] { 3, 7, 2, 9, 1 };
                    Console.WriteLine("Максимум: " + FindMax(arr_max));
                    break;
                case 52:
                    int number = 5;
                    Square_1(ref number);
                    Console.WriteLine("Квадрат: " + number);
                    break;
                case 53:
                    int result_out;
                    Divide(10, 3, out result_out);
                    Console.WriteLine("Результат деления: " + result_out);
                    break;
                case 54:
                    int[] sort_arr = new int[] { 5, 2, 8, 1, 9 };
                    SortArray(sort_arr);
                    Console.WriteLine("Отсортированный массив:");
                    foreach (int num in sort_arr) Console.Write(num + " ");
                    Console.WriteLine();
                    break;
                case 55:
                    Console.WriteLine("Введите строку:");
                    string str = Console.ReadLine();
                    Console.WriteLine("Палиндром: " + IsPalindrome(str));
                    break;
                case 56:
                    Console.WriteLine("Сумма: " + SumParams(1, 2, 3, 4, 5));
                    Console.WriteLine("Сумма: " + SumParams(10, 20));
                    break;
                case 57:
                    Console.WriteLine("Введите число:");
                    int n_fact = int.Parse(Console.ReadLine());
                    Console.WriteLine("Факториал: " + FactorialRec(n_fact));
                    break;
                case 58:
                    Console.WriteLine("Введите N:");
                    int n_fib = int.Parse(Console.ReadLine());
                    Console.WriteLine("Фибоначчи: " + FibonacciRec(n_fib));
                    break;
                case 59:
                    Console.WriteLine("Введите число:");
                    int n_sum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Сумма цифр: " + SumDigitsRec(n_sum));
                    break;
                case 60:
                    Console.WriteLine("Введите основание и степень:");
                    int base_num = int.Parse(Console.ReadLine());
                    int power = int.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + PowerRec(base_num, power));
                    break;
                case 61:
                    Console.WriteLine("Введите два числа:");
                    int a_nod = int.Parse(Console.ReadLine());
                    int b_nod = int.Parse(Console.ReadLine());
                    Console.WriteLine("НОД: " + GCDRec(a_nod, b_nod));
                    break;
                case 62:
                    Console.WriteLine("Введите строку:");
                    string str_rev = Console.ReadLine();
                    Console.WriteLine("Перевернутая: " + ReverseStringRec(str_rev));
                    break;
                case 63:
                    int[] bin_arr = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
                    Console.WriteLine("Введите элемент для поиска:");
                    int bin_search = int.Parse(Console.ReadLine());
                    int index = BinarySearchRec(bin_arr, bin_search, 0, bin_arr.Length - 1);
                    if (index != -1)
                        Console.WriteLine("Найден на позиции: " + index);
                    else
                        Console.WriteLine("Не найден");
                    break;
                case 64:
                    int[] arr_sum = new int[] { 1, 2, 3, 4, 5 };
                    Console.WriteLine("Сумма массива: " + ArraySumRec(arr_sum, 0));
                    break;
                case 65:
                    Console.WriteLine("Введите количество дисков:");
                    int disks = int.Parse(Console.ReadLine());
                    HanoiTowers(disks, 'A', 'C', 'B');
                    break;
                case 66:
                    Console.WriteLine("Введите строку:");
                    string str_pal = Console.ReadLine();
                    Console.WriteLine("Палиндром: " + IsPalindromeRec(str_pal, 0, str_pal.Length - 1));
                    break;
                case 67:
                    int[] sel_arr = new int[] { 64, 25, 12, 22, 11 };
                    SelectionSort(sel_arr);
                    Console.WriteLine("Сортировка выбором:");
                    foreach (int num in sel_arr) Console.Write(num + " ");
                    Console.WriteLine();
                    break;
                case 68:
                    int[] ins_arr = new int[] { 12, 11, 13, 5, 6 };
                    InsertionSort(ins_arr);
                    Console.WriteLine("Сортировка вставками:");
                    foreach (int num in ins_arr) Console.Write(num + " ");
                    Console.WriteLine();
                    break;
                case 69:
                    int[] quick_arr = new int[] { 10, 7, 8, 9, 1, 5 };
                    QuickSort(quick_arr, 0, quick_arr.Length - 1);
                    Console.WriteLine("Быстрая сортировка:");
                    foreach (int num in quick_arr) Console.Write(num + " ");
                    Console.WriteLine();
                    break;
                case 70:
                    int[] merge_arr = new int[] { 38, 27, 43, 3, 9, 82, 10 };
                    MergeSort(merge_arr, 0, merge_arr.Length - 1);
                    Console.WriteLine("Сортировка слиянием:");
                    foreach (int num in merge_arr) Console.Write(num + " ");
                    Console.WriteLine();
                    break;
                case 71:
                    int[] lin_arr = new int[] { 2, 3, 4, 10, 40 };
                    Console.WriteLine("Введите элемент для поиска:");
                    int lin_search = int.Parse(Console.ReadLine());
                    int lin_index = LinearSearch(lin_arr, lin_search);
                    if (lin_index != -1)
                        Console.WriteLine("Найден на позиции: " + lin_index);
                    else
                        Console.WriteLine("Не найден");
                    break;
                case 72:
                    int[] bin_arr2 = new int[] { 2, 3, 4, 10, 40 };
                    Console.WriteLine("Введите элемент для поиска:");
                    int bin_search2 = int.Parse(Console.ReadLine());
                    int bin_index = BinarySearch(bin_arr2, bin_search2);
                    if (bin_index != -1)
                        Console.WriteLine("Найден на позиции: " + bin_index);
                    else
                        Console.WriteLine("Не найден");
                    break;
                case 73:
                    int[] minmax_arr = new int[] { 3, 5, 1, 8, 2, 9, 4 };
                    FindMinMax(minmax_arr, out int min_val, out int max_val);
                    Console.WriteLine("Минимум: " + min_val + ", Максимум: " + max_val);
                    break;
                case 74:
                    Console.WriteLine("Введите N:");
                    int n_erat = int.Parse(Console.ReadLine());
                    SieveOfEratosthenes(n_erat);
                    break;
                case 75:
                    Console.WriteLine("Введите две строки:");
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    Console.WriteLine("Анаграмма: " + IsAnagram(str1, str2));
                    break;
                case 76:
                    int[] kadane_arr = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
                    int max_sum = KadaneAlgorithm(kadane_arr);
                    Console.WriteLine("Максимальная сумма подмассива: " + max_sum);
                    break;
                case 77:
                    int[] dup_arr = new int[] { 1, 2, 3, 4, 2, 5, 6, 3, 7 };
                    FindDuplicates(dup_arr);
                    break;
                case 78:
                    Student student = new Student();
                    student.Name = "Иван";
                    student.Age = 20;
                    student.DisplayInfo();
                    break;
                case 79:
                    BankAccount account = new BankAccount();
                    account.Deposit(1000);
                    account.Withdraw(500);
                    Console.WriteLine("Баланс: " + account.GetBalance());
                    break;
                case 80:
                    Dog dog = new Dog();
                    dog.Speak();
                    Cat cat = new Cat();
                    cat.Speak();
                    break;
                case 81:
                    Rectangle rect = new Rectangle(5, 3);
                    Console.WriteLine("Площадь: " + rect.GetArea());
                    break;
                case 82:
                    Console.WriteLine("Количество созданных объектов: " + Counter.GetCount());
                    Counter c1 = new Counter();
                    Counter c2 = new Counter();
                    Console.WriteLine("Количество созданных объектов: " + Counter.GetCount());
                    break;
                case 83:
                    Shape shape1 = new Circle(5);
                    Shape shape2 = new Square(4);
                    Console.WriteLine("Площадь круга: " + shape1.GetArea());
                    Console.WriteLine("Площадь квадрата: " + shape2.GetArea());
                    break;
                case 84:
                    Person[] people = new Person[]
                    {
                        new Person("Анна", 25),
                        new Person("Борис", 30),
                        new Person("Виктор", 20)
                    };
                    Array.Sort(people);
                    Console.WriteLine("Отсортированные люди:");
                    foreach (Person p in people) Console.WriteLine(p.Name + " - " + p.Age);
                    break;
                case 85:
                    Book book = new Book();
                    book.Title = "Война и мир";
                    book.Price = -100; // Попытка установить отрицательную цену
                    Console.WriteLine("Цена: " + book.Price);
                    break;
                case 86:
                    ComplexNumber cn1 = new ComplexNumber(1, 2);
                    ComplexNumber cn2 = new ComplexNumber(3, 4);
                    ComplexNumber sum_cn = cn1 + cn2;
                    Console.WriteLine("Сумма: " + sum_cn);
                    break;
                case 87:
                    Car car = new Car();
                    car.StartEngine();
                    break;
                case 88:
                    ShoppingList list = new ShoppingList();
                    list[0] = "Хлеб";
                    list[1] = "Молоко";
                    Console.WriteLine("Первый элемент: " + list[0]);
                    break;
                case 89:
                    SafeDivision();
                    break;
                case 90:
                    WriteToFile();
                    break;
                case 91:
                    ReadFromFile();
                    break;
                case 92:
                    ReadLineByLine();
                    break;
                case 93:
                    CountLines();
                    break;
                case 94:
                    AppendToFile();
                    break;
                case 95:
                    CopyFile();
                    break;
                case 96:
                    SearchInFile();
                    break;
                case 97:
                    WriteArrayToFile();
                    break;
                case 98:
                    ReadNumbersFromFile();
                    break;
                case 99:
                    FileStatistics();
                    break;
                case 100:
                    Console.WriteLine("Поздравляем! Вы завершили все 100 заданий!");
                    break;
                default:
                    Console.WriteLine("Задание с таким номером не найдено");
                    break;
            }

            Console.ReadKey();
        }

        // МЕТОДЫ ДЛЯ ЗАДАНИЙ 47-56
        static int Sum(int a, int b) => a + b;
        static bool IsEven(int n) => n % 2 == 0;
        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++) result *= i;
            return result;
        }
        static int Multiply(int a, int b = 2) => a * b;
        static int FindMax(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr) if (num > max) max = num;
            return max;
        }
        static void Square_1(ref int x) => x = x * x;
        static void Divide(int a, int b, out int result) => result = a / b;
        static void SortArray(int[] arr) => Array.Sort(arr);
        static bool IsPalindrome(string str)
        {
            string clean = str.Replace(" ", "").ToLower();
            return clean == new string(clean.Reverse().ToArray());
        }
        static int SumParams(params int[] numbers) => numbers.Sum();

        // РЕКУРСИВНЫЕ МЕТОДЫ ДЛЯ ЗАДАНИЙ 57-66
        static int FactorialRec(int n) => n <= 1 ? 1 : n * FactorialRec(n - 1);
        static int FibonacciRec(int n) => n <= 1 ? n : FibonacciRec(n - 1) + FibonacciRec(n - 2);
        static int SumDigitsRec(int n) => n == 0 ? 0 : n % 10 + SumDigitsRec(n / 10);
        static int PowerRec(int baseNum, int power) => power == 0 ? 1 : baseNum * PowerRec(baseNum, power - 1);
        static int GCDRec(int a, int b) => b == 0 ? a : GCDRec(b, a % b);
        static string ReverseStringRec(string str) => str.Length == 0 ? "" : ReverseStringRec(str.Substring(1)) + str[0];
        static int BinarySearchRec(int[] arr, int target, int left, int right)
        {
            if (left > right) return -1;
            int mid = (left + right) / 2;
            if (arr[mid] == target) return mid;
            return arr[mid] > target ?
                BinarySearchRec(arr, target, left, mid - 1) :
                BinarySearchRec(arr, target, mid + 1, right);
        }
        static int ArraySumRec(int[] arr, int index) => index >= arr.Length ? 0 : arr[index] + ArraySumRec(arr, index + 1);
        static void HanoiTowers(int n, char from, char to, char aux)
        {
            if (n == 1)
            {
                Console.WriteLine($"Переместить диск 1 с {from} на {to}");
                return;
            }
            HanoiTowers(n - 1, from, aux, to);
            Console.WriteLine($"Переместить диск {n} с {from} на {to}");
            HanoiTowers(n - 1, aux, to, from);
        }
        static bool IsPalindromeRec(string str, int left, int right)
        {
            if (left >= right) return true;
            if (str[left] != str[right]) return false;
            return IsPalindromeRec(str, left + 1, right - 1);
        }

        // АЛГОРИТМЫ ДЛЯ ЗАДАНИЙ 67-77
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[minIndex]) minIndex = j;
                int temp = arr[i]; arr[i] = arr[minIndex]; arr[minIndex] = temp;
            }
        }
        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i]; arr[i] = arr[j]; arr[j] = temp;
                }
            }
            int temp2 = arr[i + 1]; arr[i + 1] = arr[high]; arr[high] = temp2;
            return i + 1;
        }
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }
        static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[arr.Length];
            Array.Copy(arr, temp, arr.Length);

            int i = left, j = mid + 1, k = left;
            while (i <= mid && j <= right)
            {
                if (temp[i] <= temp[j]) arr[k++] = temp[i++];
                else arr[k++] = temp[j++];
            }
            while (i <= mid) arr[k++] = temp[i++];
            while (j <= right) arr[k++] = temp[j++];
        }
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == target) return i;
            return -1;
        }
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == target) return mid;
                if (arr[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
        static void FindMinMax(int[] arr, out int min, out int max)
        {
            min = max = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        }
        static void SieveOfEratosthenes(int n)
        {
            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++) isPrime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                        isPrime[i] = false;
                }
            }

            Console.WriteLine("Простые числа до " + n + ":");
            for (int i = 2; i <= n; i++)
                if (isPrime[i]) Console.Write(i + " ");
            Console.WriteLine();
        }
        static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;
            char[] chars1 = str1.ToLower().ToCharArray();
            char[] chars2 = str2.ToLower().ToCharArray();
            Array.Sort(chars1);
            Array.Sort(chars2);
            return new string(chars1) == new string(chars2);
        }
        static int KadaneAlgorithm(int[] arr)
        {
            int maxSoFar = arr[0], maxEndingHere = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }
        static void FindDuplicates(int[] arr)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (count.ContainsKey(num)) count[num]++;
                else count[num] = 1;
            }

            Console.WriteLine("Повторяющиеся элементы:");
            foreach (var pair in count)
                if (pair.Value > 1) Console.WriteLine(pair.Key + " - " + pair.Value + " раз(а)");
        }

        // КЛАССЫ ДЛЯ ЗАДАНИЙ 78-89
        class Student
        {
            public string Name;
            public int Age;

            public void DisplayInfo()
            {
                Console.WriteLine($"Студент: {Name}, Возраст: {Age}");
            }
        }

        class BankAccount
        {
            private double balance;

            public void Deposit(double amount)
            {
                balance += amount;
            }

            public void Withdraw(double amount)
            {
                if (amount <= balance)
                    balance -= amount;
                else
                    Console.WriteLine("Недостаточно средств");
            }

            public double GetBalance()
            {
                return balance;
            }
        }

        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("Животное издает звук");
            }
        }

        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Гав!");
            }
        }

        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Мяу!");
            }
        }

        class Rectangle
        {
            private double width, height;

            public Rectangle(double w, double h)
            {
                width = w;
                height = h;
            }

            public double GetArea()
            {
                return width * height;
            }
        }

        class Counter
        {
            private static int count;

            public Counter()
            {
                count++;
            }

            public static int GetCount()
            {
                return count;
            }
        }

        abstract class Shape
        {
            public abstract double GetArea();
        }

        class Circle : Shape
        {
            private double radius;

            public Circle(double r)
            {
                radius = r;
            }

            public override double GetArea()
            {
                return Math.PI * radius * radius;
            }
        }

        class Square : Shape
        {
            private double side;

            public Square(double s)
            {
                side = s;
            }

            public override double GetArea()
            {
                return side * side;
            }
        }

        class Person : IComparable<Person>
        {
            public string Name;
            public int Age;

            public Person(string n, int a)
            {
                Name = n;
                Age = a;
            }

            public int CompareTo(Person other)
            {
                return Age.CompareTo(other.Age);
            }
        }

        class Book
        {
            private string title;
            private double price;

            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            public double Price
            {
                get { return price; }
                set
                {
                    if (value >= 0)
                        price = value;
                    else
                        Console.WriteLine("Цена не может быть отрицательной");
                }
            }
        }

        class ComplexNumber
        {
            public double Real, Imaginary;

            public ComplexNumber(double r, double i)
            {
                Real = r;
                Imaginary = i;
            }

            public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
            {
                return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
            }

            public override string ToString()
            {
                return $"{Real} + {Imaginary}i";
            }
        }

        class Engine
        {
            public void Start()
            {
                Console.WriteLine("Двигатель запущен");
            }
        }

        class Car
        {
            private Engine engine = new Engine();

            public void StartEngine()
            {
                engine.Start();
            }
        }

        class ShoppingList
        {
            private string[] items = new string[10];

            public string this[int index]
            {
                get { return items[index]; }
                set { items[index] = value; }
            }
        }

        static void SafeDivision()
        {
            try
            {
                Console.WriteLine("Введите два числа:");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Результат: " + (x / y));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат числа!");
            }
        }

        // ФАЙЛОВЫЕ ОПЕРАЦИИ ДЛЯ ЗАДАНИЙ 90-99
        static void WriteToFile()
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("test.txt"))
            {
                writer.WriteLine("Привет, мир!");
                writer.WriteLine("Это тестовый файл.");
            }
            Console.WriteLine("Файл записан.");
        }

        static void ReadFromFile()
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader("test.txt"))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("Содержимое файла:\n" + content);
            }
        }

        static void ReadLineByLine()
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader("test.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        static void CountLines()
        {
            int count = 0;
            using (System.IO.StreamReader reader = new System.IO.StreamReader("test.txt"))
            {
                while (reader.ReadLine() != null)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество строк: " + count);
        }

        static void AppendToFile()
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("test.txt", true))
            {
                writer.WriteLine("Добавленная строка");
            }
            Console.WriteLine("Текст добавлен в файл.");
        }

        static void CopyFile()
        {
            System.IO.File.Copy("test.txt", "test_copy.txt", true);
            Console.WriteLine("Файл скопирован.");
        }

        static void SearchInFile()
        {
            Console.WriteLine("Введите слово для поиска:");
            string word = Console.ReadLine();
            using (System.IO.StreamReader reader = new System.IO.StreamReader("test.txt"))
            {
                string line;
                int lineNumber = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(word))
                    {
                        Console.WriteLine($"Найдено в строке {lineNumber}: {line}");
                    }
                    lineNumber++;
                }
            }
        }

        static void WriteArrayToFile()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("array.txt"))
            {
                foreach (int num in numbers)
                {
                    writer.WriteLine(num);
                }
            }
            Console.WriteLine("Массив записан в файл.");
        }

        static void ReadNumbersFromFile()
        {
            List<int> numbers = new List<int>();
            using (System.IO.StreamReader reader = new System.IO.StreamReader("array.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numbers.Add(int.Parse(line));
                }
            }
            Console.WriteLine("Прочитанные числа: " + string.Join(", ", numbers));
        }

        static void FileStatistics()
        {
            string text = System.IO.File.ReadAllText("test.txt");
            int lines = text.Split('\n').Length;
            int words = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int chars = text.Length;
            Console.WriteLine($"Строк: {lines}, Слов: {words}, Символов: {chars}");
        }
    }
}