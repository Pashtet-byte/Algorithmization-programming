using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        // Тестирование всех методов
        TestAllMethods();
    }

    static void TestAllMethods()
    {
        Console.WriteLine("=== ТЕСТИРОВАНИЕ МЕТОДОВ ===");

        // Тестирование методов из блока 1
        Console.WriteLine($"1. Square(5) = {Square(5)}");
        Console.WriteLine($"2. Sum(10, 20) = {Sum(10, 20)}");
        Console.WriteLine($"3. GetStringLength('Hello') = {GetStringLength("Hello")}");

        // Тестирование методов из блока 2 (рекурсия)
        Console.WriteLine($"129. Factorial(5) = {Factorial(5)}");
        Console.WriteLine($"115. Fibonacci(6) = {Fibonacci(6)}");

        // Тестирование методов из блока 3 (перегрузка)
        PrintInfo("Тестовая строка");
        PrintInfo(42);
        PrintInfo(3.14);

        // Тестирование методов из блока 4 (опциональные параметры)
        Console.WriteLine($"301. SQL: {BuildSQLQuery(table: "Users", where: "Age > 18")}");

        Console.WriteLine("=== ТЕСТИРОВАНИЕ ЗАВЕРШЕНО ===");
    }

    // БЛОК 1: ОСНОВНЫЕ МЕТОДЫ (1-100)

    // Задача 1: Напишите метод, возвращающий квадрат числа
    static int Square(int n)
    {
        return n * n;
    }

    // Задача 2: Напишите метод, вычисляющий сумму двух целых чисел
    static int Sum(int a, int b)
    {
        return a + b;
    }

    // Задача 3: Реализуйте метод, возвращающий длину строки
    static int GetStringLength(string str)
    {
        if (str == null)
            return 0;
        return str.Length;
    }

    // Задача 4: Создайте метод для вычисления НОД двух чисел
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Задача 5: Создайте метод для вычисления НОД двух чисел
    static int GCD_Recursive(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD_Recursive(b, a % b);
    }

    // Задача 6: Создайте метод, выводящий таблицу умножения числа
    static void PrintMultiplicationTable(int n)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }

    // Задача 7: Напишите метод, возвращающий квадрат числа
    static double Square(double n)
    {
        return n * n;
    }

    // Задача 8: Реализуйте метод для реверса строки
    static string ReverseString(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    // Задача 9: Реализуйте метод для нахождения максимума из трех чисел
    static int MaxOfThree(int a, int b, int c)
    {
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;
    }

    // Задача 10: Напишите метод для вычисления суммы элементов массива
    static int SumArray(int[] array)
    {
        if (array == null || array.Length == 0)
            return 0;

        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }

    // Задача 11: Создайте метод, находящий минимум в массиве
    static int FindMin(int[] array)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Массив не может быть пустым");

        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        return min;
    }

    // Задача 12: Создайте метод, определяющий, является ли число четным
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Задача 13: Напишите метод, вычисляющий сумму двух целых чисел
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Задача 14: Реализуйте метод для нахождения максимума из трех чисел
    static int MaximumOfThree(int x, int y, int z)
    {
        return Math.Max(x, Math.Max(y, z));
    }

    // Задача 15: Напишите метод, проверяющий, является ли число простым
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Задача 16: Создайте метод для вычисления НОД двух чисел
    static int FindGCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Задача 17: Создайте метод, проверяющий, содержится ли элемент в массиве
    static bool ContainsElement(int[] array, int element)
    {
        foreach (int item in array)
        {
            if (item == element)
                return true;
        }
        return false;
    }

    // Задача 18: Создайте метод, возвращающий абсолютное значение числа
    static int AbsoluteValue(int number)
    {
        return Math.Abs(number);
    }

    // Задача 19: Напишите метод, вычисляющий сумму двух целых чисел
    static int CalculateSum(int a, int b)
    {
        return a + b;
    }

    // Задача 20: Реализуйте метод для реверса строки
    static string StringReverse(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Задача 21: Напишите метод, проверяющий, является ли число простым
    static bool CheckPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // Задача 22: Реализуйте метод для реверса строки
    static string ReverseText(string text)
    {
        return new string(text.Reverse().ToArray());
    }

    // Задача 23: Создайте метод, находящий минимум в массиве
    static int ArrayMin(int[] arr)
    {
        return arr.Min();
    }

    // Задача 24: Создайте метод для вычисления НОД двух чисел
    static int GreatestCommonDivisor(int a, int b)
    {
        return b == 0 ? a : GreatestCommonDivisor(b, a % b);
    }

    // Задача 25: Реализуйте метод для сортировки массива по возрастанию
    static int[] SortArray(int[] array)
    {
        int[] sorted = (int[])array.Clone();
        Array.Sort(sorted);
        return sorted;
    }

    // Задача 26: Напишите метод для вычисления суммы элементов массива
    static int ArraySum(int[] numbers)
    {
        return numbers.Sum();
    }

    // Задача 27: Реализуйте метод, возвращающий длину строки
    static int StringLength(string s)
    {
        return s.Length;
    }

    // Задача 28: Напишите метод, вычисляющий сумму двух целых чисел
    static int SumTwoNumbers(int x, int y)
    {
        return x + y;
    }

    // Задача 29: Реализуйте метод для конкатенации двух строк
    static string Concatenate(string str1, string str2)
    {
        return str1 + str2;
    }

    // Задача 30: Создайте метод, находящий минимум в массиве
    static int GetMinValue(int[] values)
    {
        int min = values[0];
        foreach (int val in values)
        {
            if (val < min) min = val;
        }
        return min;
    }

    // Задача 31: Создайте метод для вычисления площади прямоугольника
    static double RectangleArea(double length, double width)
    {
        return length * width;
    }

    // Задача 32: Реализуйте метод, возвращающий длину строки
    static int GetLength(string input)
    {
        return input?.Length ?? 0;
    }

    // Задача 33: Создайте метод, выводящий таблицу умножения числа
    static void DisplayMultiplicationTable(int number)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} × {i} = {number * i}");
        }
    }

    // Задача 34: Напишите метод, проверяющий, является ли число простым
    static bool IsPrimeNumber(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // Задача 35: Создайте метод для вычисления площади прямоугольника
    static double CalculateArea(double l, double w)
    {
        return l * w;
    }

    // Задача 36: Напишите метод, возвращающий квадрат числа
    static int PowerOfTwo(int num)
    {
        return num * num;
    }

    // Задача 37: Реализуйте метод для нахождения максимума из трех чисел
    static int FindMax(int a, int b, int c)
    {
        return new[] { a, b, c }.Max();
    }

    // Задача 38: Напишите метод для подсчета количества гласных в строке
    static int CountVowels(string text)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        return text.Count(c => vowels.Contains(c));
    }

    // Задача 39: Напишите метод, возвращающий квадрат числа
    static double CalculateSquare(double x)
    {
        return x * x;
    }

    // Задача 40: Реализуйте метод, определяющий, является ли строка палиндромом
    static bool IsPalindrome(string str)
    {
        string clean = new string(str.ToLower().Where(char.IsLetterOrDigit).ToArray());
        return clean.SequenceEqual(clean.Reverse());
    }

    // Задача 41: Реализуйте метод, определяющий, является ли строка палиндромом
    static bool CheckPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right]) return false;
            left++;
            right--;
        }
        return true;
    }

    // Задача 42: Создайте метод, возвращающий абсолютное значение числа
    static double AbsValue(double num)
    {
        return Math.Abs(num);
    }

    // Задача 43: Реализуйте метод, возвращающий длину строки
    static int TextLength(string txt)
    {
        return txt == null ? 0 : txt.Length;
    }

    // Задача 44: Создайте метод, определяющий, является ли число четным
    static bool EvenCheck(int n)
    {
        return n % 2 == 0;
    }

    // Задача 45: Реализуйте метод для сортировки массива по возрастанию
    static void SortAscending(int[] arr)
    {
        Array.Sort(arr);
    }

    // Задача 46: Реализуйте метод для реверса строки
    static string Reverse(string s)
    {
        return new string(s.Reverse().ToArray());
    }

    // Задача 47: Напишите метод, возвращающий квадрат числа
    static int SquareNumber(int n)
    {
        return n * n;
    }

    // Задача 48: Напишите метод для подсчета количества гласных в строке
    static int VowelCount(string input)
    {
        string vowels = "aeiouAEIOU";
        return input.Count(c => vowels.Contains(c));
    }

    // Задача 49: Реализуйте метод для нахождения максимума из трех чисел
    static int MaxThree(int x, int y, int z)
    {
        return Math.Max(Math.Max(x, y), z);
    }

    // Задача 50: Реализуйте метод для реверса строки
    static string InvertString(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    // Задача 51: Напишите метод для преобразования градусов Цельсия в Фаренгейт
    static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    // Задача 52: Создайте метод, возвращающий абсолютное значение числа
    static int Absolute(int num)
    {
        return num < 0 ? -num : num;
    }

    // Задача 53: Реализуйте метод, определяющий, является ли строка палиндромом
    static bool PalindromeCheck(string text)
    {
        string reversed = new string(text.Reverse().ToArray());
        return text.Equals(reversed);
    }

    // Задача 54: Напишите метод для вычисления суммы элементов массива
    static int TotalSum(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr) sum += num;
        return sum;
    }

    // Задача 55: Напишите метод, проверяющий, является ли число простым
    static bool PrimeCheck(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    // Задача 56: Реализуйте метод для нахождения максимума из трех чисел
    static int TripleMax(int a, int b, int c)
    {
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;
    }

    // Задача 57: Создайте метод, определяющий, является ли число четным
    static bool IsEvenNumber(int number)
    {
        return number % 2 == 0;
    }

    // Задача 58: Создайте метод для вычисления НОД двух чисел
    static int ComputeGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Задача 59: Напишите метод для преобразования градусов Цельсия в Фаренгейт
    static double ConvertToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Задача 60: Реализуйте метод для нахождения максимума из трех чисел
    static int GetMaximum(int x, int y, int z)
    {
        return x > y ? (x > z ? x : z) : (y > z ? y : z);
    }

    // Задача 61: Создайте метод для вычисления НОД двух чисел
    static int FindGCD2(int a, int b)
    {
        return b == 0 ? a : FindGCD2(b, a % b);
    }

    // Задача 62: Напишите метод, возвращающий квадрат числа
    static int SquareInt(int n)
    {
        return n * n;
    }

    // Задача 63: Напишите метод для подсчета количества гласных в строке
    static int CountVowels2(string text)
    {
        int count = 0;
        foreach (char c in text.ToLower())
        {
            if ("aeiou".Contains(c))
                count++;
        }
        return count;
    }

    // Задача 64: Реализуйте метод, возвращающий длину строки
    static int GetStringLength2(string str)
    {
        return str == null ? 0 : str.Length;
    }

    // Задача 65: Реализуйте метод для сортировки массива по возрастанию
    static int[] SortArrayAscending(int[] array)
    {
        Array.Sort(array);
        return array;
    }

    // Задача 66: Реализуйте метод, определяющий, является ли строка палиндромом
    static bool IsPalindrome2(string str)
    {
        string clean = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        return clean.SequenceEqual(clean.Reverse());
    }

    // Задача 67: Реализуйте метод для конкатенации двух строк
    static string ConcatStrings(string s1, string s2)
    {
        return string.Concat(s1, s2);
    }

    // Задача 68: Реализуйте метод, определяющий, является ли строка палиндромом
    static bool CheckPalindrome2(string s)
    {
        return s.SequenceEqual(s.Reverse());
    }

    // Задача 69: Реализуйте метод, определяющий, является ли строка палиндромом
    static bool IsPalindrome3(string text)
    {
        for (int i = 0; i < text.Length / 2; i++)
        {
            if (text[i] != text[text.Length - 1 - i])
                return false;
        }
        return true;
    }

    // Задача 70: Напишите метод, проверяющий, является ли число простым
    static bool IsPrime70(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // Задача 71: Реализуйте метод, возвращающий длину строки
    static int StringLength71(string s)
    {
        return s.Length;
    }

    // Задача 72: Реализуйте метод для нахождения максимума из трех чисел
    static int MaxOfThree72(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    // Задача 73: Создайте метод, возвращающий абсолютное значение числа
    static double Absolute73(double x)
    {
        return x < 0 ? -x : x;
    }

    // Задача 74: Реализуйте метод для конкатенации двух строк
    static string JoinStrings(string a, string b)
    {
        return a + b;
    }

    // Задача 75: Реализуйте метод для реверса строки
    static string Reverse75(string str)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
            sb.Append(str[i]);
        return sb.ToString();
    }

    // Задача 76: Создайте метод для вычисления НОД двух чисел
    static int GCD76(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a;
    }

    // Задача 77: Реализуйте метод для конкатенации двух строк
    static string Concatenate77(string str1, string str2)
    {
        return $"{str1}{str2}";
    }

    // Задача 78: Реализуйте метод для сортировки массива по возрастанию
    static void SortArray78(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    // Задача 79: Напишите метод для подсчета количества гласных в строке
    static int CountVowels79(string text)
    {
        return text.ToLower().Count(c => "aeiou".Contains(c));
    }

    // Задача 80: Реализуйте метод, возвращающий длину строки
    static int GetLength80(string s)
    {
        return s?.Length ?? 0;
    }

    // Задача 81: Реализуйте метод для реверса строки
    static string ReverseString81(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    // Задача 82: Создайте метод для вычисления НОД двух чисел
    static int GCD82(int a, int b)
    {
        return b == 0 ? a : GCD82(b, a % b);
    }

    // Задача 83: Создайте метод для вычисления площади прямоугольника
    static double Area83(double length, double width)
    {
        return length * width;
    }

    // Задача 84: Создайте метод, определяющий, является ли число четным
    static bool IsEven84(int n)
    {
        return (n & 1) == 0;
    }

    // Задача 85: Создайте метод для вычисления НОД двух чисел
    static int GCD85(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Задача 86: Создайте метод, определяющий, является ли число четным
    static bool Even86(int num)
    {
        return num % 2 == 0;
    }

    // Задача 87: Создайте метод для вычисления площади прямоугольника
    static double RectangleArea87(double l, double w)
    {
        return l * w;
    }

    // Задача 88: Напишите метод для подсчета количества гласных в строке
    static int VowelCount88(string str)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";
        foreach (char c in str)
        {
            if (vowels.Contains(c))
                count++;
        }
        return count;
    }

    // Задача 89: Реализуйте метод, возвращающий длину строки
    static int Length89(string text)
    {
        return text.Length;
    }

    // Задача 90: Реализуйте метод для нахождения максимума из трех чисел
    static int Max90(int a, int b, int c)
    {
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;
    }

    // Задача 91: Напишите метод, проверяющий, является ли число простым
    static bool IsPrime91(int number)
    {
        if (number <= 1) return false;
        if (number == 2 || number == 3) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    // Задача 92: Напишите метод для вычисления суммы элементов массива
    static int SumArray92(int[] arr)
    {
        return arr.Sum();
    }

    // Задача 93: Создайте метод для вычисления площади прямоугольника
    static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }

    // Задача 94: Напишите метод, проверяющий, является ли число простым
    static bool Prime94(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // Задача 95: Напишите метод для вычисления среднего арифметического массива
    static double Average(int[] array)
    {
        if (array == null || array.Length == 0)
            return 0;
        return (double)array.Sum() / array.Length;
    }

    // Задача 96: Напишите метод для подсчета количества гласных в строке
    static int CountVowels96(string text)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        return text.ToLower().Count(c => vowels.Contains(c));
    }

    // Задача 97: Реализуйте метод для сортировки массива по возрастанию
    static int[] Sort97(int[] arr)
    {
        return arr.OrderBy(x => x).ToArray();
    }

    // Задача 98: Создайте метод, выводящий таблицу умножения числа
    static void MultiplicationTable98(int n)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} * {i} = {n * i}");
        }
    }

    // Задача 99: Реализуйте метод, возвращающий длину строки
    static int GetStringLength99(string s)
    {
        return s == null ? 0 : s.Length;
    }

    // Задача 100: Создайте метод, выводящий таблицу умножения числа
    static void PrintTable100(int number)
    {
        Console.WriteLine($"Таблица умножения для {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} × {i} = {number * i}");
        }
    }

    // БЛОК 2: РЕКУРСИЯ (101-200)

    // Задача 101: Создайте рекурсивную функцию для проверки, является ли строка палиндромом
    static bool IsPalindromeRecursive(string str)
    {
        if (str.Length <= 1) return true;
        if (str[0] != str[str.Length - 1]) return false;
        return IsPalindromeRecursive(str.Substring(1, str.Length - 2));
    }

    // Задача 102: Напишите рекурсивную функцию для генерации всех подмножеств множества
    static List<List<int>> GenerateSubsets(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();
        GenerateSubsetsHelper(nums, 0, new List<int>(), result);
        return result;
    }

    static void GenerateSubsetsHelper(int[] nums, int index, List<int> current, List<List<int>> result)
    {
        result.Add(new List<int>(current));
        for (int i = index; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            GenerateSubsetsHelper(nums, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }

    // Задача 103: Напишите рекурсивную функцию для генерации всех подмножеств множества
    static List<List<T>> GetSubsets<T>(List<T> set)
    {
        List<List<T>> subsets = new List<List<T>>();
        GetSubsetsHelper(set, 0, new List<T>(), subsets);
        return subsets;
    }

    static void GetSubsetsHelper<T>(List<T> set, int index, List<T> current, List<List<T>> subsets)
    {
        if (index == set.Count)
        {
            subsets.Add(new List<T>(current));
            return;
        }

        // Не включаем текущий элемент
        GetSubsetsHelper(set, index + 1, current, subsets);

        // Включаем текущий элемент
        current.Add(set[index]);
        GetSubsetsHelper(set, index + 1, current, subsets);
        current.RemoveAt(current.Count - 1);
    }

    // Задача 104: Напишите рекурсивный метод для вычисления суммы цифр числа
    static int SumDigitsRecursive(int number)
    {
        if (number == 0) return 0;
        return number % 10 + SumDigitsRecursive(number / 10);
    }

    // Задача 105: Реализуйте рекурсивный метод для вычисления биномиального коэффициента
    static int BinomialCoefficient(int n, int k)
    {
        if (k == 0 || k == n) return 1;
        return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
    }

    // Задача 106: Создайте рекурсивную функцию для вычисления произведения элементов массива
    static long ProductRecursive(int[] array, int index = 0)
    {
        if (index >= array.Length) return 1;
        return array[index] * ProductRecursive(array, index + 1);
    }

    // Задача 107: Реализуйте рекурсивный метод для вычисления биномиального коэффициента
    static int BinomialCoefficient2(int n, int k)
    {
        if (k > n) return 0;
        if (k == 0 || k == n) return 1;
        return BinomialCoefficient2(n - 1, k - 1) + BinomialCoefficient2(n - 1, k);
    }

    // Задача 108: Реализуйте рекурсивный метод для проверки отсортированности массива
    static bool IsSortedRecursive(int[] array, int index = 0)
    {
        if (index >= array.Length - 1) return true;
        if (array[index] > array[index + 1]) return false;
        return IsSortedRecursive(array, index + 1);
    }

    // Задача 109: Напишите рекурсивную функцию для поиска максимума в массиве
    static int FindMaxRecursive(int[] array, int index = 0)
    {
        if (index == array.Length - 1) return array[index];
        int maxOfRest = FindMaxRecursive(array, index + 1);
        return Math.Max(array[index], maxOfRest);
    }

    // Задача 110: Создайте рекурсивную функцию для проверки, является ли строка палиндромом
    static bool IsPalindromeRecursive2(string s)
    {
        if (s.Length <= 1) return true;
        if (char.ToLower(s[0]) != char.ToLower(s[s.Length - 1])) return false;
        return IsPalindromeRecursive2(s.Substring(1, s.Length - 2));
    }

    // Задача 111: Создайте рекурсивный метод для нахождения НОД двух чисел
    static int GCDRecursive(int a, int b)
    {
        if (b == 0) return a;
        return GCDRecursive(b, a % b);
    }

    // Задача 112: Создайте рекурсивный метод для решения задачи Ханойской башни
    static void TowerOfHanoi(int n, char fromRod, char toRod, char auxRod)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from rod {fromRod} to rod {toRod}");
            return;
        }
        TowerOfHanoi(n - 1, fromRod, auxRod, toRod);
        Console.WriteLine($"Move disk {n} from rod {fromRod} to rod {toRod}");
        TowerOfHanoi(n - 1, auxRod, toRod, fromRod);
    }

    // Задача 113: Реализуйте рекурсивную функцию для вычисления треугольника Паскаля
    static int PascalTriangle(int row, int col)
    {
        if (col == 0 || col == row) return 1;
        return PascalTriangle(row - 1, col - 1) + PascalTriangle(row - 1, col);
    }

    // Задача 114: Напишите рекурсивный метод для вычисления суммы чисел от 1 до N
    static int SumToN(int n)
    {
        if (n <= 0) return 0;
        return n + SumToN(n - 1);
    }

    // Задача 115: Создайте рекурсивную функцию для вычисления чисел Фибоначчи
    static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // Задача 116: Реализуйте рекурсивную функцию для вычисления степени числа
    static double Power(double x, int n)
    {
        if (n == 0) return 1;
        if (n < 0) return 1 / Power(x, -n);
        return x * Power(x, n - 1);
    }

    // Задача 117: Создайте рекурсивный метод для нахождения НОД двух чисел
    static int GCD117(int a, int b)
    {
        return b == 0 ? a : GCD117(b, a % b);
    }

    // Задача 118: Напишите рекурсивную функцию для реверса строки
    static string ReverseRecursive(string str)
    {
        if (string.IsNullOrEmpty(str)) return str;
        return ReverseRecursive(str.Substring(1)) + str[0];
    }

    // Задача 119: Создайте рекурсивную функцию для вычисления произведения элементов массива
    static int Product(int[] arr, int index = 0)
    {
        if (index >= arr.Length) return 1;
        return arr[index] * Product(arr, index + 1);
    }

    // Задача 120: Создайте рекурсивную функцию для проверки вхождения подстроки в строку
    static bool ContainsSubstring(string text, string substring, int textIndex = 0, int subIndex = 0)
    {
        if (subIndex == substring.Length) return true;
        if (textIndex == text.Length) return false;

        if (text[textIndex] == substring[subIndex])
            return ContainsSubstring(text, substring, textIndex + 1, subIndex + 1);
        else
            return ContainsSubstring(text, substring, textIndex + 1, 0);
    }

    // Задача 121: Напишите рекурсивный метод для вычисления суммы чисел от 1 до N
    static int Sum1ToN(int n)
    {
        return n <= 0 ? 0 : n + Sum1ToN(n - 1);
    }

    // Задача 122: Реализуйте рекурсивный метод для проверки отсортированности массива
    static bool IsSorted(int[] arr, int index = 0)
    {
        if (index >= arr.Length - 1) return true;
        return arr[index] <= arr[index + 1] && IsSorted(arr, index + 1);
    }

    // Задача 123: Реализуйте рекурсивный метод для проверки отсортированности массива
    static bool CheckSorted(int[] array, int index = 0)
    {
        if (index == array.Length - 1) return true;
        if (array[index] > array[index + 1]) return false;
        return CheckSorted(array, index + 1);
    }

    // Задача 124: Создайте рекурсивную функцию для проверки вхождения подстроки в строку
    static bool SubstringExists(string str, string substr, int pos = 0)
    {
        if (pos + substr.Length > str.Length) return false;
        if (str.Substring(pos, substr.Length) == substr) return true;
        return SubstringExists(str, substr, pos + 1);
    }

    // Задача 125: Напишите рекурсивный метод для преобразования числа в двоичную систему
    static string ToBinary(int n)
    {
        if (n == 0) return "0";
        if (n == 1) return "1";
        return ToBinary(n / 2) + (n % 2).ToString();
    }

    // Задача 126: Создайте рекурсивный метод для решения задачи Ханойской башни
    static void Hanoi(int disks, string source, string target, string auxiliary)
    {
        if (disks > 0)
        {
            Hanoi(disks - 1, source, auxiliary, target);
            Console.WriteLine($"Move disk {disks} from {source} to {target}");
            Hanoi(disks - 1, auxiliary, target, source);
        }
    }

    // Задача 127: Напишите рекурсивный метод для вычисления суммы цифр числа
    static int DigitSum(int num)
    {
        if (num == 0) return 0;
        return num % 10 + DigitSum(num / 10);
    }

    // Задача 128: Напишите рекурсивную функцию для генерации всех подмножеств множества
    static List<List<int>> GetAllSubsets(int[] set)
    {
        var result = new List<List<int>>();
        GenerateSubsets(set, 0, new List<int>(), result);
        return result;
    }

    static void GenerateSubsets(int[] set, int index, List<int> current, List<List<int>> result)
    {
        if (index == set.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        // Не включаем элемент
        GenerateSubsets(set, index + 1, current, result);

        // Включаем элемент
        current.Add(set[index]);
        GenerateSubsets(set, index + 1, current, result);
        current.RemoveAt(current.Count - 1);
    }

    // Задача 129: Реализуйте рекурсивный метод для вычисления факториала числа
    static long Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    // Задача 130: Реализуйте рекурсивную функцию для вычисления степени числа
    static double Power130(double baseNum, int exponent)
    {
        if (exponent == 0) return 1;
        if (exponent < 0) return 1 / Power130(baseNum, -exponent);
        return baseNum * Power130(baseNum, exponent - 1);
    }

    // Задача 131: Напишите рекурсивную функцию для генерации всех подмножеств множества
    static List<List<T>> PowerSet<T>(List<T> list)
    {
        List<List<T>> result = new List<List<T>>();
        PowerSetHelper(list, 0, new List<T>(), result);
        return result;
    }

    static void PowerSetHelper<T>(List<T> list, int index, List<T> current, List<List<T>> result)
    {
        result.Add(new List<T>(current));
        for (int i = index; i < list.Count; i++)
        {
            current.Add(list[i]);
            PowerSetHelper(list, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }

    // Задача 132: Напишите рекурсивный метод для вычисления суммы цифр числа
    static int SumOfDigits(int n)
    {
        if (n == 0) return 0;
        return (n % 10) + SumOfDigits(n / 10);
    }

    // Задача 133: Создайте рекурсивный метод для обхода массива и вывода его элементов
    static void PrintArrayRecursive(int[] arr, int index = 0)
    {
        if (index >= arr.Length) return;
        Console.WriteLine(arr[index]);
        PrintArrayRecursive(arr, index + 1);
    }

    // Задача 134: Реализуйте рекурсивную функцию для вычисления степени числа
    static double Pow(double x, int n)
    {
        if (n == 0) return 1;
        if (n < 0) return 1 / Pow(x, -n);
        return x * Pow(x, n - 1);
    }

    // Задача 135: Реализуйте рекурсивную функцию Аккермана
    static int Ackermann(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return Ackermann(m - 1, 1);
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    // Задача 136: Создайте рекурсивную функцию для вычисления произведения элементов массива
    static long ArrayProduct(int[] array, int index = 0)
    {
        if (index >= array.Length) return 1;
        return array[index] * ArrayProduct(array, index + 1);
    }

    // Задача 137: Напишите рекурсивную функцию для реверса строки
    static string ReverseStringRecursive(string s)
    {
        if (s.Length <= 1) return s;
        return ReverseStringRecursive(s.Substring(1)) + s[0];
    }

    // Задача 138: Напишите рекурсивный метод для преобразования числа в двоичную систему
    static string DecimalToBinary(int n)
    {
        if (n == 0) return "";
        return DecimalToBinary(n / 2) + (n % 2).ToString();
    }

    // Задача 139: Реализуйте рекурсивный метод для вычисления факториала числа
    static long Factorial139(int number)
    {
        return number <= 1 ? 1 : number * Factorial139(number - 1);
    }

    // Задача 140: Напишите рекурсивный метод для вычисления суммы цифр числа
    static int SumDigits140(int num)
    {
        return num == 0 ? 0 : num % 10 + SumDigits140(num / 10);
    }

    // Задача 141: Создайте рекурсивный метод для решения задачи Ханойской башни
    static void SolveHanoi(int n, char from, char to, char aux)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {from} to {to}");
            return;
        }
        SolveHanoi(n - 1, from, aux, to);
        Console.WriteLine($"Move disk {n} from {from} to {to}");
        SolveHanoi(n - 1, aux, to, from);
    }

    // Задача 142: Напишите рекурсивную функцию для реверса строки
    static string Reverse142(string str)
    {
        if (str.Length == 0) return "";
        return Reverse142(str.Substring(1)) + str[0];
    }

    // Задача 143: Создайте рекурсивный метод для решения задачи Ханойской башни
    static void HanoiTower(int n, string source, string destination, string auxiliary)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {source} to {destination}");
            return;
        }
        HanoiTower(n - 1, source, auxiliary, destination);
        Console.WriteLine($"Move disk {n} from {source} to {destination}");
        HanoiTower(n - 1, auxiliary, destination, source);
    }

    // Задача 144: Реализуйте рекурсивную функцию для вычисления степени числа
    static double Power144(double b, int e)
    {
        if (e == 0) return 1;
        return b * Power144(b, e - 1);
    }

    // Задача 145: Реализуйте рекурсивную функцию Аккермана
    static int Ackermann145(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return Ackermann145(m - 1, 1);
        return Ackermann145(m - 1, Ackermann145(m, n - 1));
    }

    // Задача 146: Создайте рекурсивный метод для решения задачи Ханойской башни
    static void TowerHanoi(int disks, char from, char to, char aux)
    {
        if (disks == 1)
        {
            Console.WriteLine($"Move disk 1 from {from} to {to}");
            return;
        }
        TowerHanoi(disks - 1, from, aux, to);
        Console.WriteLine($"Move disk {disks} from {from} to {to}");
        TowerHanoi(disks - 1, aux, to, from);
    }

    // Задача 147: Создайте рекурсивную функцию для проверки вхождения подстроки в строку
    static bool ContainsRecursive(string text, string pattern, int start = 0)
    {
        if (start + pattern.Length > text.Length) return false;
        if (text.Substring(start, pattern.Length) == pattern) return true;
        return ContainsRecursive(text, pattern, start + 1);
    }

    // Задача 148: Реализуйте рекурсивный метод для подсчета количества цифр в числе
    static int CountDigits(int number)
    {
        if (number == 0) return 0;
        return 1 + CountDigits(number / 10);
    }

    // Задача 149: Создайте рекурсивный метод для нахождения НОД двух чисел
    static int GCD149(int a, int b)
    {
        return b == 0 ? a : GCD149(b, a % b);
    }

    // Задача 150: Напишите рекурсивную функцию для поиска максимума в массиве
    static int MaxRecursive(int[] arr, int index = 0)
    {
        if (index == arr.Length - 1) return arr[index];
        return Math.Max(arr[index], MaxRecursive(arr, index + 1));
    }

    // Задача 151: Напишите рекурсивную функцию для реверса строки
    static string Reverse151(string s)
    {
        return s.Length == 0 ? s : Reverse151(s.Substring(1)) + s[0];
    }

    // Задача 152: Напишите рекурсивную функцию для генерации всех подмножеств множества
    static List<List<int>> GeneratePowerSet(int[] nums)
    {
        var result = new List<List<int>>();
        GeneratePowerSetHelper(nums, 0, new List<int>(), result);
        return result;
    }

    static void GeneratePowerSetHelper(int[] nums, int index, List<int> current, List<List<int>> result)
    {
        result.Add(new List<int>(current));
        for (int i = index; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            GeneratePowerSetHelper(nums, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }

    // Задача 153: Создайте рекурсивный метод для решения задачи Ханойской башни
    static void Hanoi153(int n, char source, char target, char auxiliary)
    {
        if (n > 0)
        {
            Hanoi153(n - 1, source, auxiliary, target);
            Console.WriteLine($"Move disk {n} from {source} to {target}");
            Hanoi153(n - 1, auxiliary, target, source);
        }
    }

    // Задача 154: Реализуйте рекурсивный метод для вычисления факториала числа
    static long Factorial154(int n)
    {
        return n <= 1 ? 1 : n * Factorial154(n - 1);
    }

    // Задача 155: Создайте рекурсивную функцию для проверки вхождения подстроки в строку
    static bool FindSubstring(string text, string substring, int textIndex = 0)
    {
        if (textIndex + substring.Length > text.Length) return false;
        if (text.Substring(textIndex, substring.Length) == substring) return true;
        return FindSubstring(text, substring, textIndex + 1);
    }

    // Задача 156: Создайте рекурсивный метод для обхода массива и вывода его элементов
    static void TraverseArray(int[] array, int index = 0)
    {
        if (index >= array.Length) return;
        Console.Write($"{array[index]} ");
        TraverseArray(array, index + 1);
    }

    // Задача 157: Реализуйте рекурсивную функцию для вычисления треугольника Паскаля
    static int Pascal(int row, int col)
    {
        if (col == 0 || col == row) return 1;
        return Pascal(row - 1, col - 1) + Pascal(row - 1, col);
    }

    // Задача 158: Реализуйте рекурсивный метод для вычисления факториала числа
    static long Factorial158(int num)
    {
        if (num <= 1) return 1;
        return num * Factorial158(num - 1);
    }

    // Задача 159: Реализуйте рекурсивную функцию для вычисления степени числа
    static double Power159(double x, int n)
    {
        if (n == 0) return 1;
        return x * Power159(x, n - 1);
    }

    // Задача 160: Напишите рекурсивную функцию для поиска максимума в массиве
    static int FindMax160(int[] arr, int index = 0)
    {
        if (index == arr.Length - 1) return arr[index];
        int maxRest = FindMax160(arr, index + 1);
        return Math.Max(arr[index], maxRest);
    }

    // Задача 161: Реализуйте рекурсивную функцию Аккермана
    static int Ackermann161(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return Ackermann161(m - 1, 1);
        return Ackermann161(m - 1, Ackermann161(m, n - 1));
    }

    // Задача 162: Создайте рекурсивную функцию для проверки, является ли строка палиндромом
    static bool IsPalindrome162(string s)
    {
        if (s.Length <= 1) return true;
        return s[0] == s[s.Length - 1] && IsPalindrome162(s.Substring(1, s.Length - 2));
    }

    // Задача 163: Создайте рекурсивную функцию для вычисления чисел Фибоначчи
    static int Fib(int n)
    {
        if (n <= 1) return n;
        return Fib(n - 1) + Fib(n - 2);
    }

    // Задача 164: Создайте рекурсивную функцию для проверки, является ли строка палиндромом
    static bool Palindrome164(string str)
    {
        if (str.Length <= 1) return true;
        if (str[0] != str[str.Length - 1]) return false;
        return Palindrome164(str.Substring(1, str.Length - 2));
    }

    // Задача 165: Реализуйте рекурсивный метод для вычисления биномиального коэффициента
    static int Binomial(int n, int k)
    {
        if (k == 0 || k == n) return 1;
        return Binomial(n - 1, k - 1) + Binomial(n - 1, k);
    }

    // Задача 166: Напишите рекурсивный метод для вычисления суммы чисел от 1 до N
    static int Sum166(int n)
    {
        return n == 0 ? 0 : n + Sum166(n - 1);
    }

    // Задача 167: Напишите рекурсивный метод для вычисления суммы чисел от 1 до N
    static int SumToN167(int n)
    {
        if (n <= 0) return 0;
        return n + SumToN167(n - 1);
    }

    // Задача 168: Реализуйте рекурсивную функцию для вычисления треугольника Паскаля
    static int Pascal168(int row, int col)
    {
        if (col == 0 || col == row) return 1;
        return Pascal168(row - 1, col - 1) + Pascal168(row - 1, col);
    }

    // Задача 169: Напишите рекурсивный метод для вычисления суммы чисел от 1 до N
    static int Sum169(int n)
    {
        return n <= 0 ? 0 : n + Sum169(n - 1);
    }

    // Задача 170: Напишите рекурсивную функцию для генерации всех подмножеств множества
    static List<List<int>> Subsets170(int[] nums)
    {
        var result = new List<List<int>>();
        SubsetsHelper170(nums, 0, new List<int>(), result);
        return result;
    }

    static void SubsetsHelper170(int[] nums, int index, List<int> current, List<List<int>> result)
    {
        result.Add(new List<int>(current));
        for (int i = index; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            SubsetsHelper170(nums, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }

    // Задача 171: Создайте рекурсивный метод для нахождения НОД двух чисел
    static int GCD171(int a, int b)
    {
        return b == 0 ? a : GCD171(b, a % b);
    }

    // Задача 172: Создайте рекурсивный метод для нахождения НОД двух чисел
    static int GCD172(int a, int b)
    {
        if (b == 0) return a;
        return GCD172(b, a % b);
    }

    // Задача 173: Реализуйте рекурсивную функцию для вычисления треугольника Паскаля
    static int Pascal173(int n, int k)
    {
        if (k == 0 || k == n) return 1;
        return Pascal173(n - 1, k - 1) + Pascal173(n - 1, k);
    }

    // Задача 174: Напишите рекурсивную функцию для генерации всех подмножеств множества
    static List<List<T>> GetSubsets174<T>(List<T> set)
    {
        List<List<T>> subsets = new List<List<T>>();
        GetSubsetsHelper174(set, 0, new List<T>(), subsets);
        return subsets;
    }

    static void GetSubsetsHelper174<T>(List<T> set, int index, List<T> current, List<List<T>> subsets)
    {
        subsets.Add(new List<T>(current));
        for (int i = index; i < set.Count; i++)
        {
            current.Add(set[i]);
            GetSubsetsHelper174(set, i + 1, current, subsets);
            current.RemoveAt(current.Count - 1);
        }
    }

    // Задача 175: Напишите рекурсивную функцию для реверса строки
    static string Reverse175(string str)
    {
        if (str.Length == 0) return str;
        return Reverse175(str.Substring(1)) + str[0];
    }

    // Задача 176: Напишите рекурсивный метод для вычисления суммы цифр числа
    static int SumDigits176(int num)
    {
        if (num == 0) return 0;
        return num % 10 + SumDigits176(num / 10);
    }

    // Задача 177: Создайте рекурсивный метод для решения задачи Ханойской башни
    static void Hanoi177(int n, char from, char to, char aux)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {from} to {to}");
            return;
        }
        Hanoi177(n - 1, from, aux, to);
        Console.WriteLine($"Move disk {n} from {from} to {to}");
        Hanoi177(n - 1, aux, to, from);
    }

    // Задача 178: Создайте рекурсивную функцию для проверки вхождения подстроки в строку
    static bool ContainsSubstring178(string text, string substring)
    {
        if (text.Length < substring.Length) return false;
        if (text.StartsWith(substring)) return true;
        return ContainsSubstring178(text.Substring(1), substring);
    }

    // Задача 179: Создайте рекурсивную функцию для вычисления произведения элементов массива
    static long Product179(int[] arr, int index = 0)
    {
        if (index >= arr.Length) return 1;
        return arr[index] * Product179(arr, index + 1);
    }

    // Задача 180: Реализуйте рекурсивный метод для подсчета количества цифр в числе
    static int DigitCount(int number)
    {
        if (number == 0) return 0;
        return 1 + DigitCount(number / 10);
    }

    // Задача 181: Напишите рекурсивную функцию для генерации всех подмножеств множества
    static List<List<int>> GenerateAllSubsets(int[] set)
    {
        var result = new List<List<int>>();
        GenerateSubsets181(set, 0, new List<int>(), result);
        return result;
    }

    static void GenerateSubsets181(int[] set, int index, List<int> current, List<List<int>> result)
    {
        if (index == set.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        // Не включаем текущий элемент
        GenerateSubsets181(set, index + 1, current, result);

        // Включаем текущий элемент
        current.Add(set[index]);
        GenerateSubsets181(set, index + 1, current, result);
        current.RemoveAt(current.Count - 1);
    }

    // Задача 182: Реализуйте рекурсивный метод для подсчета количества цифр в числе
    static int CountDigits182(int n)
    {
        if (n == 0) return 0;
        return 1 + CountDigits182(n / 10);
    }

    // Задача 183: Реализуйте рекурсивную функцию Аккермана
    static int Ackermann183(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return Ackermann183(m - 1, 1);
        return Ackermann183(m - 1, Ackermann183(m, n - 1));
    }

    // Задача 184: Реализуйте рекурсивный метод для проверки отсортированности массива
    static bool IsSorted184(int[] arr, int index = 0)
    {
        if (index >= arr.Length - 1) return true;
        return arr[index] <= arr[index + 1] && IsSorted184(arr, index + 1);
    }

    // Задача 185: Напишите рекурсивную функцию для поиска максимума в массиве
    static int Max185(int[] array, int index = 0)
    {
        if (index == array.Length - 1) return array[index];
        return Math.Max(array[index], Max185(array, index + 1));
    }

    // Задача 186: Напишите рекурсивный метод для преобразования числа в двоичную систему
    static string ToBinary186(int n)
    {
        if (n == 0) return "0";
        if (n == 1) return "1";
        return ToBinary186(n / 2) + (n % 2);
    }

    // Задача 187: Создайте рекурсивный метод для решения задачи Ханойской башни
    static void Hanoi187(int disks, string source, string target, string auxiliary)
    {
        if (disks > 0)
        {
            Hanoi187(disks - 1, source, auxiliary, target);
            Console.WriteLine($"Move disk {disks} from {source} to {target}");
            Hanoi187(disks - 1, auxiliary, target, source);
        }
    }

    // Задача 188: Напишите рекурсивный метод для преобразования числа в двоичную систему
    static string DecimalToBinary188(int n)
    {
        if (n == 0) return "";
        return DecimalToBinary188(n / 2) + (n % 2).ToString();
    }

    // Задача 189: Реализуйте рекурсивную функцию для вычисления степени числа
    static double Power189(double x, int n)
    {
        if (n == 0) return 1;
        return x * Power189(x, n - 1);
    }

    // Задача 190: Создайте рекурсивную функцию для проверки, является ли строка палиндромом
    static bool IsPalindrome190(string s)
    {
        if (s.Length <= 1) return true;
        return s[0] == s[s.Length - 1] && IsPalindrome190(s.Substring(1, s.Length - 2));
    }

    // Задача 191: Создайте рекурсивную функцию для проверки, является ли строка палиндромом
    static bool Palindrome191(string str)
    {
        if (str.Length <= 1) return true;
        if (str[0] != str[str.Length - 1]) return false;
        return Palindrome191(str.Substring(1, str.Length - 2));
    }

    // Задача 192: Напишите рекурсивный метод для вычисления суммы чисел от 1 до N
    static int Sum192(int n)
    {
        return n <= 0 ? 0 : n + Sum192(n - 1);
    }

    // Задача 193: Создайте рекурсивный метод для обхода массива и вывода его элементов
    static void PrintArray193(int[] arr, int index = 0)
    {
        if (index >= arr.Length) return;
        Console.WriteLine(arr[index]);
        PrintArray193(arr, index + 1);
    }

    // Задача 194: Реализуйте рекурсивный метод для вычисления факториала числа
    static long Factorial194(int n)
    {
        return n <= 1 ? 1 : n * Factorial194(n - 1);
    }

    // Задача 195: Реализуйте рекурсивный метод для вычисления биномиального коэффициента
    static int Binomial195(int n, int k)
    {
        if (k == 0 || k == n) return 1;
        return Binomial195(n - 1, k - 1) + Binomial195(n - 1, k);
    }

    // Задача 196: Напишите рекурсивную функцию для генерации всех подмножеств множества
    static List<List<int>> GetSubsets196(int[] set)
    {
        var result = new List<List<int>>();
        Subsets196(set, 0, new List<int>(), result);
        return result;
    }

    static void Subsets196(int[] set, int index, List<int> current, List<List<int>> result)
    {
        result.Add(new List<int>(current));
        for (int i = index; i < set.Length; i++)
        {
            current.Add(set[i]);
            Subsets196(set, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }

    // Задача 197: Создайте рекурсивную функцию для проверки, является ли строка палиндромом
    static bool IsPalindrome197(string s)
    {
        if (s.Length <= 1) return true;
        return s[0] == s[s.Length - 1] && IsPalindrome197(s.Substring(1, s.Length - 2));
    }

    // Задача 198: Реализуйте рекурсивный метод для вычисления биномиального коэффициента
    static int Binomial198(int n, int k)
    {
        if (k == 0 || k == n) return 1;
        return Binomial198(n - 1, k - 1) + Binomial198(n - 1, k);
    }

    // Задача 199: Создайте рекурсивную функцию для проверки, является ли строка палиндромом
    static bool Palindrome199(string str)
    {
        if (str.Length <= 1) return true;
        if (str[0] != str[str.Length - 1]) return false;
        return Palindrome199(str.Substring(1, str.Length - 2));
    }

    // Задача 200: Реализуйте рекурсивный метод для вычисления факториала числа
    static long Factorial200(int n)
    {
        return n <= 1 ? 1 : n * Factorial200(n - 1);
    }

    // БЛОК 3: ПЕРЕГРУЗКА МЕТОДОВ (201-300)

    // Задача 201: Напишите перегруженные методы для вывода информации разных типов
    static void PrintInfo(string message)
    {
        Console.WriteLine($"String: {message}");
    }

    static void PrintInfo(int number)
    {
        Console.WriteLine($"Int: {number}");
    }

    static void PrintInfo(double number)
    {
        Console.WriteLine($"Double: {number}");
    }

    static void PrintInfo(bool value)
    {
        Console.WriteLine($"Bool: {value}");
    }

    // Задача 202: Реализуйте перегрузку метода для вычисления площади (круг, прямоугольник)
    static double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static double CalculateArea1(double length, double width)
    {
        return length * width;
    }

    // Задача 203: Реализуйте перегрузку метода для умножения (int, double, decimal)
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static decimal Multiply(decimal a, decimal b)
    {
        return a * b;
    }

    // Задача 204: Напишите перегруженные методы для вывода информации разных типов
    static void Display(string text)
    {
        Console.WriteLine($"Text: {text}");
    }

    static void Display(int num)
    {
        Console.WriteLine($"Number: {num}");
    }

    static void Display(char c)
    {
        Console.WriteLine($"Character: {c}");
    }

    // Задача 205: Реализуйте перегрузку метода для вычисления площади (круг, прямоугольник)
    static double GetArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static double GetArea(double length, double width)
    {
        return length * width;
    }

    static double GetArea(double baseLength, double height, string shape)
    {
        return 0.5 * baseLength * height;
    }

    // Задача 206: Реализуйте перегруженные методы для вычисления расстояния (2D, 3D точки)
    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    }

    // Задача 207: Напишите перегруженные методы для вывода информации разных типов
    static void Show(object obj)
    {
        Console.WriteLine($"Object: {obj}");
    }

    static void Show(string str)
    {
        Console.WriteLine($"String: {str}");
    }

    static void Show(int num)
    {
        Console.WriteLine($"Integer: {num}");
    }

    // Задача 208: Реализуйте перегруженные методы для работы с коллекциями (добавление элементов)
    static void AddToList(List<int> list, int item)
    {
        list.Add(item);
    }

    static void AddToList(List<string> list, string item)
    {
        list.Add(item);
    }

    static void AddToList(List<double> list, params double[] items)
    {
        list.AddRange(items);
    }

    // Задача 209: Реализуйте перегрузку метода для умножения (int, double, decimal)
    static int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }

    static double MultiplyNumbers(double a, double b)
    {
        return a * b;
    }

    static decimal MultiplyNumbers(decimal a, decimal b)
    {
        return a * b;
    }

    // Задача 210: Напишите перегруженные методы для форматирования даты разными способами
    static string FormatDate(DateTime date)
    {
        return date.ToString("yyyy-MM-dd");
    }

    static string FormatDate(DateTime date, string format)
    {
        return date.ToString(format);
    }

    static string FormatDate(int year, int month, int day)
    {
        return new DateTime(year, month, day).ToString("dd/MM/yyyy");
    }

    // Задача 211: Создайте перегрузку метода для вычисления скидки (процент, фиксированная сумма)
    static double CalculateDiscount(double price, double discountPercent)
    {
        return price * (1 - discountPercent / 100);
    }

    static double CalculateDiscount(double price, int fixedDiscount)
    {
        return Math.Max(0, price - fixedDiscount);
    }

    // Задача 212: Создайте перегруженные методы для работы с массивами разных типов
    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    static void PrintArray(string[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    static void PrintArray(double[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    // Задача 213: Напишите перегрузку метода для валидации данных (email, телефон, URL)
    static bool Validate(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }

    static bool Validate(string phone, bool isPhone)
    {
        return phone.Length >= 10 && phone.All(char.IsDigit);
    }

    static bool Validate(Uri url)
    {
        return url.IsWellFormedOriginalString();
    }

    // Задача 214: Реализуйте перегруженные методы для конкатенации строк (2, 3, 4 строки)
    static string Concatenate1(string a, string b)
    {
        return a + b;
    }

    static string Concatenate1(string a, string b, string c)
    {
        return a + b + c;
    }

    static string Concatenate1(string a, string b, string c, string d)
    {
        return a + b + c + d;
    }

    // Задача 215: Создайте перегруженные методы для шифрования текста разными алгоритмами
    static string Encrypt(string text)
    {
        // Простой шифр Цезаря
        return new string(text.Select(c => (char)(c + 3)).ToArray());
    }

    static string Encrypt(string text, string algorithm)
    {
        if (algorithm == "reverse")
            return new string(text.Reverse().ToArray());
        return text;
    }

    // Задача 216: Создайте перегруженные методы для шифрования текста разными алгоритмами
    static string EncryptText(string input)
    {
        return new string(input.Reverse().ToArray());
    }

    static string EncryptText(string input, int shift)
    {
        return new string(input.Select(c => (char)(c + shift)).ToArray());
    }

    // Задача 217: Создайте перегрузку метода для вычисления скидки (процент, фиксированная сумма)
    static double ApplyDiscount(double amount, double percentage)
    {
        return amount * (1 - percentage / 100);
    }

    static double ApplyDiscount(double amount, int fixedAmount)
    {
        return amount - fixedAmount;
    }

    // Задача 218: Реализуйте перегрузку метода для умножения (int, double, decimal)
    static int Multiply218(int x, int y) => x * y;
    static double Multiply218(double x, double y) => x * y;
    static decimal Multiply218(decimal x, decimal y) => x * y;

    // Задача 219: Создайте перегрузку метода для вычисления скидки (процент, фиксированная сумма)
    static double GetDiscountedPrice(double price, double discountPercent)
    {
        return price * (1 - discountPercent / 100);
    }

    static double GetDiscountedPrice(double price, int discountAmount)
    {
        return Math.Max(0, price - discountAmount);
    }

    // Задача 220: Реализуйте перегрузку метода для вычисления периметра разных фигур
    static double CalculatePerimeter(double side)
    {
        return 4 * side; // Квадрат
    }

    static double CalculatePerimeter(double length, double width)
    {
        return 2 * (length + width); // Прямоугольник
    }

    static double CalculatePerimeter(double a, double b, double c)
    {
        return a + b + c; // Треугольник
    }

    // Задача 221: Создайте перегруженные методы для работы с массивами разных типов
    static T[] CreateArray<T>(T item, int count)
    {
        T[] array = new T[count];
        for (int i = 0; i < count; i++)
            array[i] = item;
        return array;
    }

    static int[] CreateArray(int start, int count)
    {
        int[] array = new int[count];
        for (int i = 0; i < count; i++)
            array[i] = start + i;
        return array;
    }

    // Задача 222: Создайте перегрузку метода для поиска максимума (2, 3, 4 числа)
    static int FindMaximum(int a, int b)
    {
        return Math.Max(a, b);
    }

    static int FindMaximum(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    static int FindMaximum(int a, int b, int c, int d)
    {
        return Math.Max(Math.Max(a, b), Math.Max(c, d));
    }

    // Задача 223: Создайте перегрузку метода для поиска максимума (2, 3, 4 числа)
    static int Max(int x, int y) => x > y ? x : y;
    static int Max(int x, int y, int z) => Max(Max(x, y), z);
    static int Max(int a, int b, int c, int d) => Max(Max(a, b), Max(c, d));

    // Задача 224: Реализуйте перегрузку метода для вычисления периметра разных фигур
    static double Perimeter(double side) => 4 * side;
    static double Perimeter(double l, double w) => 2 * (l + w);
    static double Perimeter(double a, double b, double c) => a + b + c;

    // Задача 225: Напишите перегрузку метода для преобразования температуры (Celsius, Fahrenheit, Kelvin)
    static double ConvertTemperature(double celsius) => celsius;
    static double ConvertTemperature(double value, string from, string to)
    {
        if (from == "C" && to == "F") return value * 9 / 5 + 32;
        if (from == "F" && to == "C") return (value - 32) * 5 / 9;
        if (from == "C" && to == "K") return value + 273.15;
        return value;
    }

    // Задача 226: Реализуйте перегрузку метода для вычисления периметра разных фигур
    static double GetPerimeter(double radius)
    {
        return 2 * Math.PI * radius; // Окружность
    }

    static double GetPerimeter(double side1, double side2)
    {
        return 2 * (side1 + side2); // Прямоугольник
    }

    // Задача 227: Реализуйте перегрузку метода для вычисления периметра разных фигур
    static double ComputePerimeter(double a) => 4 * a;
    static double ComputePerimeter(double a, double b) => 2 * (a + b);
    static double ComputePerimeter(double a, double b, double c) => a + b + c;

    // Задача 228: Напишите перегруженные методы для парсинга строк в числа разных типов
    static int ParseToInt(string str) => int.Parse(str);
    static double ParseToDouble(string str) => double.Parse(str);
    static decimal ParseToDecimal(string str) => decimal.Parse(str);

    // Задача 229: Реализуйте перегрузку метода для вычисления площади (круг, прямоугольник)
    static double Area(double radius) => Math.PI * radius * radius;
    static double Area(double length, double width) => length * width;

    // Задача 230: Создайте перегрузку метода для поиска максимума (2, 3, 4 числа)
    static int Maximum(int a, int b) => a > b ? a : b;
    static int Maximum(int a, int b, int c) => Maximum(Maximum(a, b), c);
    static int Maximum(int a, int b, int c, int d) => Maximum(Maximum(a, b), Maximum(c, d));

    // Задача 231: Реализуйте перегрузку метода для вычисления площади (круг, прямоугольник)
    static double CalculateArea231(double r) => Math.PI * r * r;
    static double CalculateArea231(double l, double w) => l * w;

    // Задача 232: Создайте перегруженные методы для сортировки (по возрастанию/убыванию)
    static int[] Sort(int[] array, bool ascending = true)
    {
        var sorted = array.OrderBy(x => x);
        return ascending ? sorted.ToArray() : sorted.Reverse().ToArray();
    }

    static string[] Sort(string[] array, bool ascending = true)
    {
        var sorted = array.OrderBy(x => x);
        return ascending ? sorted.ToArray() : sorted.Reverse().ToArray();
    }

    // Задача 233: Реализуйте перегруженные методы для вычисления расстояния (2D, 3D точки)
    static double Distance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    }

    // Задача 234: Создайте перегрузку метода для поиска максимума (2, 3, 4 числа)
    static int FindMax(int a, int b) => Math.Max(a, b);
    static int FindMax1(int a, int b, int c) => Math.Max(a, Math.Max(b, c));
    static int FindMax(int a, int b, int c, int d) => Math.Max(Math.Max(a, b), Math.Max(c, d));

    // Задача 235: Реализуйте перегрузку метода для умножения (int, double, decimal)
    static int Product(int a, int b) => a * b;
    static double Product(double a, double b) => a * b;
    static decimal Product(decimal a, decimal b) => a * b;

    // Задача 236: Создайте перегруженные методы для работы с массивами разных типов
    static void FillArray(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] = value;
    }

    static void FillArray(string[] array, string value)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] = value;
    }

    // Задача 237: Создайте перегруженные методы для работы с массивами разных типов
    static T GetFirstElement<T>(T[] array) => array[0];
    static string GetFirstElement(string[] array) => array[0];

    // Задача 238: Напишите перегрузку метода для валидации данных (email, телефон, URL)
    static bool IsValid(string email) => email.Contains("@") && email.Contains(".");
    static bool IsValid(string phone, int dummy) => phone.Length >= 10;
    static bool IsValid(Uri uri) => uri.IsAbsoluteUri;

    // Задача 239: Напишите перегруженные методы для парсинга строк в числа разных типов
    static int ParseValue(string str) => int.Parse(str);
    static double ParseValue(string str, bool isDouble) => double.Parse(str);
    static decimal ParseValue(string str, string type) => decimal.Parse(str);

    // Задача 240: Реализуйте перегруженные методы для конкатенации строк (2, 3, 4 строки)
    static string Combine(string a, string b) => a + b;
    static string Combine(string a, string b, string c) => a + b + c;
    static string Combine(string a, string b, string c, string d) => a + b + c + d;

    // Задача 241: Реализуйте перегрузку метода для вычисления периметра разных фигур
    static double Perimeter241(double s) => 4 * s;
    static double Perimeter241(double l, double w) => 2 * (l + w);
    static double Perimeter241(double a, double b, double c) => a + b + c;

    // Задача 242: Напишите перегрузку метода для вычисления объема (куб, параллелепипед, цилиндр)
    static double CalculateVolume(double side) => Math.Pow(side, 3); // Куб
    static double CalculateVolume(double length, double width, double height) => length * width * height; // Параллелепипед
    static double CalculateVolume(double radius, double height) => Math.PI * radius * radius * height; // Цилиндр

    // Задача 243: Напишите перегруженные методы для форматирования даты разными способами
    static string Format(DateTime date) => date.ToString("yyyy-MM-dd");
    static string Format(DateTime date, string pattern) => date.ToString(pattern);
    static string Format(int day, int month, int year) => $"{day:00}/{month:00}/{year}";

    // Задача 244: Напишите перегруженные методы для парсинга строк в числа разных типов
    static int ConvertToInt(string input) => int.Parse(input);
    static long ConvertToLong(string input) => long.Parse(input);
    static double ConvertToDouble(string input) => double.Parse(input);

    // Задача 245: Реализуйте перегрузку метода для умножения (int, double, decimal)
    static int Times(int a, int b) => a * b;
    static double Times(double a, double b) => a * b;
    static decimal Times(decimal a, decimal b) => a * b;

    // Задача 246: Напишите перегруженные методы для вывода информации разных типов
    static void Output(string message) => Console.WriteLine($"Message: {message}");
    static void Output(int number) => Console.WriteLine($"Number: {number}");
    static void Output(double value) => Console.WriteLine($"Value: {value}");

    // Задача 247: Напишите перегруженные методы для парсинга строк в числа разных типов
    static int ToNumber(string str) => int.Parse(str);
    static double ToNumber(string str, bool isDouble) => double.Parse(str);

    // Задача 248: Напишите перегрузку метода для валидации данных (email, телефон, URL)
    static bool ValidateInput(string email) => email.Contains("@");
    static bool ValidateInput(string phone, string type) => phone.Length == 11;
    static bool ValidateInput(Uri url) => url.Scheme == "http" || url.Scheme == "https";

    // Задача 249: Создайте перегрузку метода для поиска максимума (2, 3, 4 числа)
    static int GetMax(int a, int b) => Math.Max(a, b);
    static int GetMax(int a, int b, int c) => Math.Max(a, Math.Max(b, c));
    static int GetMax(int a, int b, int c, int d) => Math.Max(Math.Max(a, b), Math.Max(c, d));

    // Задача 250: Реализуйте перегрузку метода для вычисления площади (круг, прямоугольник)
    static double ComputeArea(double radius) => Math.PI * radius * radius;
    static double ComputeArea(double length, double width) => length * width;

    // Задача 251: Напишите перегрузку метода для валидации данных (email, телефон, URL)
    static bool CheckValidity(string email) => email.Contains("@") && email.Contains(".");
    static bool CheckValidity(string phone, bool isPhone) => phone.All(char.IsDigit);
    static bool CheckValidity(Uri uri) => uri.IsWellFormedOriginalString();

    // Задача 252: Создайте перегруженные методы для сложения двух и трех чисел
    static int AddNumbers(int a, int b) => a + b;
    static int AddNumbers(int a, int b, int c) => a + b + c;
    static double AddNumbers(double a, double b) => a + b;

    // Задача 253: Напишите перегруженные методы для вывода информации разных типов
    static void PrintValue(string text) => Console.WriteLine($"Text: {text}");
    static void PrintValue(int num) => Console.WriteLine($"Integer: {num}");
    static void PrintValue(char ch) => Console.WriteLine($"Char: {ch}");

    // Задача 254: Реализуйте перегрузку метода для умножения (int, double, decimal)
    static int Multiply254(int x, int y) => x * y;
    static double Multiply254(double x, double y) => x * y;
    static decimal Multiply254(decimal x, decimal y) => x * y;

    // Задача 255: Напишите перегрузку метода для вычисления объема (куб, параллелепипед, цилиндр)
    static double Volume(double side) => side * side * side;
    static double Volume(double l, double w, double h) => l * w * h;
    static double Volume(double radius, double height) => Math.PI * radius * radius * height;

    // Задача 256: Реализуйте перегрузку метода для вычисления периметра разных фигур
    static double CalculatePerimeter256(double s) => 4 * s;
    static double CalculatePerimeter256(double l, double w) => 2 * (l + w);
    static double CalculatePerimeter256(double a, double b, double c) => a + b + c;

    // Задача 257: Создайте перегрузку метода для вычисления скидки (процент, фиксированная сумма)
    static double ApplyDiscount257(double price, double percent) => price * (1 - percent / 100);
    static double ApplyDiscount257(double price, int fixedDiscount) => price - fixedDiscount;

    // Задача 258: Создайте перегрузку метода для вычисления скидки (процент, фиксированная сумма)
    static double Discount(double price, double percentage) => price * (1 - percentage / 100);
    static double Discount(double price, int amount) => Math.Max(0, price - amount);

    // Задача 259: Создайте перегруженные методы для работы с массивами разных типов
    static void Initialize(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++) array[i] = value;
    }

    static void Initialize(string[] array, string value)
    {
        for (int i = 0; i < array.Length; i++) array[i] = value;
    }

    // Задача 260: Создайте перегруженные методы для сортировки (по возрастанию/убыванию)
    static int[] SortArray(int[] array, string order)
    {
        var sorted = array.OrderBy(x => x);
        return order == "desc" ? sorted.Reverse().ToArray() : sorted.ToArray();
    }

    static string[] SortArray(string[] array, string order)
    {
        var sorted = array.OrderBy(x => x);
        return order == "desc" ? sorted.Reverse().ToArray() : sorted.ToArray();
    }

    // Задача 261: Реализуйте перегрузку метода для вычисления площади (круг, прямоугольник)
    static double Area261(double radius) => Math.PI * radius * radius;
    static double Area261(double length, double width) => length * width;

    // Задача 262: Напишите перегрузку метода для вычисления объема (куб, параллелепипед, цилиндр)
    static double ComputeVolume(double side) => Math.Pow(side, 3);
    static double ComputeVolume(double l, double w, double h) => l * w * h;
    static double ComputeVolume(double r, double h) => Math.PI * r * r * h;

    // Задача 263: Создайте перегруженные методы для сортировки (по возрастанию/убыванию)
    static void Sort263(int[] arr, bool ascending = true)
    {
        Array.Sort(arr);
        if (!ascending) Array.Reverse(arr);
    }

    static void Sort263(string[] arr, bool ascending = true)
    {
        Array.Sort(arr);
        if (!ascending) Array.Reverse(arr);
    }

    // Задача 264: Создайте перегруженные методы для сложения двух и трех чисел
    static int Sum264(int a, int b) => a + b;
    static int Sum264(int a, int b, int c) => a + b + c;
    static double Sum264(double a, double b) => a + b;

    // Задача 265: Создайте перегруженные методы для сортировки (по возрастанию/убыванию)
    static int[] OrderBy(int[] array, bool descending = false)
    {
        return descending ? array.OrderByDescending(x => x).ToArray() : array.OrderBy(x => x).ToArray();
    }

    static string[] OrderBy(string[] array, bool descending = false)
    {
        return descending ? array.OrderByDescending(x => x).ToArray() : array.OrderBy(x => x).ToArray();
    }

    // Задача 266: Напишите перегруженные методы для форматирования даты разными способами
    static string FormatDate266(DateTime dt) => dt.ToString("dd/MM/yyyy");
    static string FormatDate266(DateTime dt, string format) => dt.ToString(format);

    // Задача 267: Напишите перегруженные методы для парсинга строк в числа разных типов
    static int Parse267(string s) => int.Parse(s);
    static double Parse267(string s, bool isDouble) => double.Parse(s);

    // Задача 268: Создайте перегрузку метода для поиска элемента (массив, список)
    static bool Contains(int[] array, int value) => array.Contains(value);
    static bool Contains(List<int> list, int value) => list.Contains(value);

    // Задача 269: Реализуйте перегрузку метода для вычисления периметра разных фигур
    static double Perimeter269(double a) => 4 * a;
    static double Perimeter269(double a, double b) => 2 * (a + b);
    static double Perimeter269(double a, double b, double c) => a + b + c;

    // Задача 270: Напишите перегрузку метода для валидации данных (email, телефон, URL)
    static bool IsValid270(string email) => email.Contains("@");
    static bool IsValid270(string phone, int code) => phone.Length >= 10;
    static bool IsValid270(Uri link) => link.IsAbsoluteUri;

    // Задача 271: Создайте перегрузку метода для вычисления скидки (процент, фиксированная сумма)
    static double CalculateDiscountedPrice(double price, double discount) => price * (1 - discount / 100);
    static double CalculateDiscountedPrice(double price, int reduction) => price - reduction;

    // Задача 272: Реализуйте перегруженные методы для конкатенации строк (2, 3, 4 строки)
    static string Merge(string a, string b) => a + b;
    static string Merge(string a, string b, string c) => a + b + c;
    static string Merge(string a, string b, string c, string d) => a + b + c + d;

    // Задача 273: Создайте перегруженные методы для работы с массивами разных типов
    static void SetAllValues(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++) arr[i] = value;
    }

    static void SetAllValues(string[] arr, string value)
    {
        for (int i = 0; i < arr.Length; i++) arr[i] = value;
    }

    // Задача 274: Создайте перегрузку метода для поиска элемента (массив, список)
    static bool Exists(int[] array, int item) => Array.Exists(array, x => x == item);
    static bool Exists(List<string> list, string item) => list.Contains(item);

    // Задача 275: Создайте перегруженные методы для работы с массивами разных типов
    static T GetLast<T>(T[] array) => array[^1];
    static string GetLast(string[] array) => array[^1];

    // Задача 276: Реализуйте перегрузку метода для вычисления площади (круг, прямоугольник)
    static double GetArea276(double radius) => Math.PI * radius * radius;
    static double GetArea276(double length, double width) => length * width;

    // Задача 277: Создайте перегруженные методы для шифрования текста разными алгоритмами
    static string Encrypt277(string text) => new string(text.Reverse().ToArray());
    static string Encrypt277(string text, int key) => new string(text.Select(c => (char)(c + key)).ToArray());

    // Задача 278: Напишите перегрузку метода для валидации данных (email, телефон, URL)
    static bool Validate278(string input) => input.Contains("@");
    static bool Validate278(string input, string type) => type == "phone" ? input.Length == 11 : false;

    // Задача 279: Реализуйте перегрузку метода для вычисления площади (круг, прямоугольник)
    static double Area279(double r) => Math.PI * r * r;
    static double Area279(double l, double w) => l * w;

    // Задача 280: Реализуйте перегруженные методы для вычисления расстояния (2D, 3D точки)
    static double Distance280(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static double Distance280(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    }

    // Задача 281: Реализуйте перегрузку метода для вычисления площади (круг, прямоугольник)
    static double CalculateArea281(double radius) => Math.PI * radius * radius;
    static double CalculateArea281(double length, double width) => length * width;

    // Задача 282: Реализуйте перегрузку метода для вычисления площади (круг, прямоугольник)
    static double Area282(double r) => Math.PI * r * r;
    static double Area282(double l, double w) => l * w;

    // Задача 283: Создайте перегруженные методы для шифрования текста разными алгоритмами
    static string Cipher(string text) => new string(text.Select(c => (char)(c + 1)).ToArray());
    static string Cipher(string text, string method) => method == "reverse" ? new string(text.Reverse().ToArray()) : text;

    // Задача 284: Создайте перегрузку метода для вычисления скидки (процент, фиксированная сумма)
    static double ApplyDiscount284(double price, double percent) => price * (1 - percent / 100);
    static double ApplyDiscount284(double price, int fixedDisc) => price - fixedDisc;

    // Задача 285: Реализуйте перегруженные методы для работы с коллекциями (добавление элементов)
    static void AddElement(List<int> list, int element) => list.Add(element);
    static void AddElement(List<string> list, string element) => list.Add(element);

    // Задача 286: Реализуйте перегруженные методы для работы с коллекциями (добавление элементов)
    static void Append(List<int> collection, int item) => collection.Add(item);
    static void Append(List<string> collection, string item) => collection.Add(item);

    // Задача 287: Напишите перегрузку метода для вычисления объема (куб, параллелепипед, цилиндр)
    static double Volume287(double side) => side * side * side;
    static double Volume287(double l, double w, double h) => l * w * h;
    static double Volume287(double r, double h) => Math.PI * r * r * h;

    // Задача 288: Реализуйте перегрузку метода для вычисления площади (круг, прямоугольник)
    static double Area288(double radius) => Math.PI * radius * radius;
    static double Area288(double length, double width) => length * width;

    // Задача 289: Реализуйте перегруженные методы для работы с коллекциями (добавление элементов)
    static void Insert(List<int> list, int value) => list.Add(value);
    static void Insert(List<double> list, double value) => list.Add(value);

    // Задача 290: Напишите перегруженные методы для вывода информации разных типов
    static void Display290(string msg) => Console.WriteLine($"String: {msg}");
    static void Display290(int num) => Console.WriteLine($"Int: {num}");
    static void Display290(bool flag) => Console.WriteLine($"Bool: {flag}");

    // Задача 291: Напишите перегрузку метода для вычисления объема (куб, параллелепипед, цилиндр)
    static double CalculateVolume291(double a) => a * a * a;
    static double CalculateVolume291(double l, double w, double h) => l * w * h;
    static double CalculateVolume291(double r, double h) => Math.PI * r * r * h;

    // Задача 292: Напишите перегруженные методы для вывода информации разных типов
    static void Print292(string text) => Console.WriteLine(text);
    static void Print292(int number) => Console.WriteLine(number);
    static void Print292(double value) => Console.WriteLine(value);

    // Задача 293: Реализуйте перегрузку метода для генерации случайных чисел (диапазон, количество)
    static int GenerateRandom(int max) => new Random().Next(max);
    static int GenerateRandom(int min, int max) => new Random().Next(min, max);
    static int[] GenerateRandom(int count, int min, int max)
    {
        Random rand = new Random();
        int[] result = new int[count];
        for (int i = 0; i < count; i++)
            result[i] = rand.Next(min, max);
        return result;
    }

    // Задача 294: Напишите перегруженные методы для вывода информации разных типов
    static void Show294(object obj) => Console.WriteLine(obj);
    static void Show294(string str) => Console.WriteLine($"String: {str}");

    // Задача 295: Реализуйте перегрузку метода для умножения (int, double, decimal)
    static int Multiply295(int a, int b) => a * b;
    static double Multiply295(double a, double b) => a * b;
    static decimal Multiply295(decimal a, decimal b) => a * b;

    // Задача 296: Создайте перегруженные методы для сортировки (по возрастанию/убыванию)
    static int[] Sort296(int[] arr) => arr.OrderBy(x => x).ToArray();
    static int[] Sort296(int[] arr, bool descending) => descending ? arr.OrderByDescending(x => x).ToArray() : arr.OrderBy(x => x).ToArray();

    // Задача 297: Создайте перегрузку метода для поиска максимума (2, 3, 4 числа)
    static int Max297(int a, int b) => Math.Max(a, b);
    static int Max297(int a, int b, int c) => Math.Max(a, Math.Max(b, c));

    // Задача 298: Создайте перегруженные методы для шифрования текста разными алгоритмами
    static string Encrypt298(string text) => new string(text.Reverse().ToArray());
    static string Encrypt298(string text, int shift) => new string(text.Select(c => (char)(c + shift)).ToArray());

    // Задача 299: Реализуйте перегрузку метода для умножения (int, double, decimal)
    static int Multiply299(int x, int y) => x * y;
    static double Multiply299(double x, double y) => x * y;

    // Задача 300: Создайте перегруженные методы для шифрования текста разными алгоритмами
    static string Encrypt300(string input) => new string(input.Reverse().ToArray());
    static string Encrypt300(string input, string method) => method == "caesar" ? new string(input.Select(c => (char)(c + 3)).ToArray()) : input;

    // БЛОК 4: ОПЦИОНАЛЬНЫЕ И ИМЕНОВАННЫЕ ПАРАМЕТРЫ (301-400)

    // Задача 301: Реализуйте метод с именованными параметрами для построения SQL-запроса
    static string BuildSQLQuery(string table, string columns = "*", string where = "", string orderBy = "")
    {
        string query = $"SELECT {columns} FROM {table}";
        if (!string.IsNullOrEmpty(where))
            query += $" WHERE {where}";
        if (!string.IsNullOrEmpty(orderBy))
            query += $" ORDER BY {orderBy}";
        return query;
    }

    // Задача 302: Реализуйте метод с именованными параметрами для создания пользователя
    static string CreateUser(string username, string email, string password, bool isActive = true, string role = "user")
    {
        return $"User created: {username}, Email: {email}, Active: {isActive}, Role: {role}";
    }

    // Задача 303: Реализуйте метод с именованными параметрами для построения SQL-запроса
    static string BuildQuery(string table, string select = "*", string condition = "", string sort = "")
    {
        string sql = $"SELECT {select} FROM {table}";
        if (!string.IsNullOrEmpty(condition))
            sql += $" WHERE {condition}";
        if (!string.IsNullOrEmpty(sort))
            sql += $" ORDER BY {sort}";
        return sql;
    }

    // Задача 304: Напишите метод с опциональными параметрами для форматирования строки
    static string FormatString(string format, params object[] args)
    {
        return string.Format(format, args);
    }

    // Задача 305: Реализуйте метод с именованными параметрами для создания графика (ширина, высота, цвет)
    static string CreateChart(int width = 800, int height = 600, string color = "blue", string title = "Chart")
    {
        return $"Chart: {title}, Size: {width}x{height}, Color: {color}";
    }

    // Задача 306: Создайте метод с опциональными параметрами для генерации пароля (длина, символы)
    static string GeneratePassword(int length = 8, bool useNumbers = true, bool useSpecial = false)
    {
        const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string numbers = "0123456789";
        const string special = "!@#$%^&*";

        string chars = letters;
        if (useNumbers) chars += numbers;
        if (useSpecial) chars += special;

        Random random = new Random();
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    // Задача 307: Создайте метод с опциональными параметрами для генерации пароля (длина, символы)
    static string GeneratePassword307(int length = 12, bool includeNumbers = true, bool includeSymbols = true)
    {
        string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (includeNumbers) chars += "0123456789";
        if (includeSymbols) chars += "!@#$%^&*";

        Random rand = new Random();
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[rand.Next(s.Length)]).ToArray());
    }

    // Задача 308: Реализуйте метод с опциональным параметром для округления чисел (количество знаков)
    static double RoundNumber(double number, int decimals = 0)
    {
        return Math.Round(number, decimals);
    }

    // Задача 309: Реализуйте метод с опциональными параметрами для создания файла (путь, расширение)
    static string CreateFile(string name, string path = ".", string extension = "txt")
    {
        return System.IO.Path.Combine(path, $"{name}.{extension}");
    }

    // Задача 310: Напишите метод с опциональным параметром для поиска в массиве (начальный индекс)
    static int FindInArray(int[] array, int value, int startIndex = 0)
    {
        for (int i = startIndex; i < array.Length; i++)
        {
            if (array[i] == value)
                return i;
        }
        return -1;
    }

    // Задача 311: Создайте метод с опциональными параметрами для подключения к базе данных
    static string ConnectToDatabase(string server, string database, string username = "sa", string password = "", int timeout = 30)
    {
        return $"Server={server};Database={database};User Id={username};Timeout={timeout}";
    }

    // Задача 312: Реализуйте метод с опциональными параметрами для создания файла (путь, расширение)
    static string CreateFilePath(string filename, string directory = "", string ext = "txt")
    {
        return string.IsNullOrEmpty(directory) ? $"{filename}.{ext}" : $"{directory}/{filename}.{ext}";
    }

    // Задача 313: Реализуйте метод с именованными параметрами для настройки логирования
    static string SetupLogging(string level = "INFO", string output = "console", string format = "text")
    {
        return $"Logging: Level={level}, Output={output}, Format={format}";
    }

    // Задача 314: Напишите метод с опциональным параметром для поиска в массиве (начальный индекс)
    static int SearchArray(string[] array, string value, int start = 0)
    {
        for (int i = start; i < array.Length; i++)
        {
            if (array[i] == value)
                return i;
        }
        return -1;
    }

    // Задача 315: Создайте метод с опциональным параметром для пагинации (страница, размер)
    static (int skip, int take) GetPagination(int page = 1, int pageSize = 10)
    {
        return ((page - 1) * pageSize, pageSize);
    }

    // Задача 316: Реализуйте метод с опциональным параметром для вывода сообщения с префиксом
    static void LogMessage(string message, string prefix = "INFO")
    {
        Console.WriteLine($"[{prefix}] {message}");
    }

    // Задача 317: Создайте метод с именованными параметрами для отправки email (тема, текст, вложения)
    static string SendEmail(string to, string subject, string body, string attachments = "", bool isHtml = false)
    {
        return $"To: {to}, Subject: {subject}, HTML: {isHtml}, Attachments: {attachments}";
    }

    // Задача 318: Напишите метод с опциональными параметрами для валидации формы
    static bool ValidateForm(string username, string email, string password, bool checkUsername = true, bool checkEmail = true)
    {
        bool valid = true;
        if (checkUsername) valid &= !string.IsNullOrEmpty(username);
        if (checkEmail) valid &= email.Contains("@");
        return valid;
    }

    // Задача 319: Реализуйте метод с опциональными параметрами для создания файла (путь, расширение)
    static string GenerateFileName(string name, string folder = "documents", string extension = "pdf")
    {
        return $"{folder}/{name}.{extension}";
    }

    // Задача 320: Напишите метод с опциональными параметрами для форматирования строки
    static string FormatText(string text, bool uppercase = false, bool trim = true)
    {
        if (trim) text = text.Trim();
        if (uppercase) text = text.ToUpper();
        return text;
    }

    // Задача 321: Создайте метод с опциональным параметром для вычисления степени числа
    static double Power321(double number, int exponent = 2)
    {
        return Math.Pow(number, exponent);
    }

    // Задача 322: Напишите метод с опциональными параметрами для валидации формы
    static (bool isValid, string[] errors) ValidateForm322(string email, string password, bool validateEmail = true, bool validatePassword = true)
    {
        List<string> errors = new List<string>();

        if (validateEmail && !email.Contains("@"))
            errors.Add("Invalid email");

        if (validatePassword && password.Length < 6)
            errors.Add("Password too short");

        return (errors.Count == 0, errors.ToArray());
    }

    // Задача 323: Реализуйте метод с именованными параметрами для построения SQL-запроса
    static string BuildSQL323(string table, string fields = "*", string whereClause = "", string orderBy = "ID")
    {
        string sql = $"SELECT {fields} FROM {table}";
        if (!string.IsNullOrEmpty(whereClause))
            sql += $" WHERE {whereClause}";
        if (!string.IsNullOrEmpty(orderBy))
            sql += $" ORDER BY {orderBy}";
        return sql;
    }

    // Задача 324: Создайте метод с опциональными параметрами для генерации пароля (длина, символы)
    static string CreatePassword(int length = 10, bool useUppercase = true, bool useDigits = true)
    {
        string chars = "abcdefghijklmnopqrstuvwxyz";
        if (useUppercase) chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (useDigits) chars += "0123456789";

        Random random = new Random();
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    // Задача 325: Создайте метод с именованными параметрами для расчета стоимости заказа
    static decimal CalculateOrder(decimal subtotal, decimal taxRate = 0.1m, decimal discount = 0, decimal shipping = 5.0m)
    {
        return subtotal * (1 + taxRate) - discount + shipping;
    }

    // Задача 326: Напишите метод с опциональными параметрами для форматирования строки
    static string Format326(string text, int maxLength = 100, string ellipsis = "...")
    {
        if (text.Length <= maxLength) return text;
        return text.Substring(0, maxLength - ellipsis.Length) + ellipsis;
    }

    // Задача 327: Напишите метод с именованными параметрами для создания конфигурации приложения
    static string CreateAppConfig(string appName, string version = "1.0", bool debug = false, string environment = "production")
    {
        return $"App: {appName}, Version: {version}, Debug: {debug}, Environment: {environment}";
    }

    // Задача 328: Создайте метод с опциональными параметрами для подключения к базе данных
    static string CreateConnectionString(string server, string database, int port = 1433, int timeout = 30)
    {
        return $"Server={server},{port};Database={database};Timeout={timeout}";
    }

    // Задача 329: Реализуйте метод с опциональным параметром для округления чисел (количество знаков)
    static decimal RoundDecimal(decimal number, int precision = 2)
    {
        return Math.Round(number, precision);
    }

    // Задача 330: Напишите метод с опциональным параметром для поиска в массиве (начальный индекс)
    static int FindValue(int[] array, int value, int fromIndex = 0)
    {
        for (int i = fromIndex; i < array.Length; i++)
        {
            if (array[i] == value) return i;
        }
        return -1;
    }

    // Задача 331: Реализуйте метод с опциональным параметром для вывода сообщения с префиксом
    static void PrintWithPrefix(string message, string prefix = ">", bool addTimestamp = false)
    {
        string timestamp = addTimestamp ? $"[{DateTime.Now:HH:mm:ss}] " : "";
        Console.WriteLine($"{timestamp}{prefix} {message}");
    }

    // Задача 332: Напишите метод с именованными параметрами для фильтрации данных
    static IEnumerable<T> FilterData<T>(IEnumerable<T> data, int? skip = null, int? take = null, Func<T, bool> predicate = null)
    {
        var result = data;
        if (predicate != null) result = result.Where(predicate);
        if (skip.HasValue) result = result.Skip(skip.Value);
        if (take.HasValue) result = result.Take(take.Value);
        return result;
    }

    // Задача 333: Напишите метод с опциональными параметрами для форматирования строки
    static string Format333(string input, bool toUpper = false, int? maxLength = null)
    {
        if (toUpper) input = input.ToUpper();
        if (maxLength.HasValue && input.Length > maxLength.Value)
            input = input.Substring(0, maxLength.Value);
        return input;
    }

    // Задача 334: Реализуйте метод с именованными параметрами для настройки логирования
    static string ConfigureLogging(string logLevel = "INFO", string filePath = "app.log", int maxSize = 1024)
    {
        return $"LogLevel: {logLevel}, File: {filePath}, MaxSize: {maxSize}MB";
    }

    // Задача 335: Напишите метод с именованными параметрами для фильтрации данных
    static List<T> Filter335<T>(List<T> list, int page = 1, int pageSize = 10, string sortBy = "Id")
    {
        return list.Skip((page - 1) * pageSize).Take(pageSize).ToList();
    }

    // Задача 336: Создайте метод с именованными параметрами для отправки email (тема, текст, вложения)
    static string SendEmail336(string recipient, string subject, string body, bool isUrgent = false, string cc = "")
    {
        return $"To: {recipient}, Subject: {(isUrgent ? "URGENT: " : "")}{subject}, CC: {cc}";
    }

    // Задача 337: Напишите метод с именованными параметрами для создания отчета (дата, автор, заголовок)
    static string CreateReport(string title, string author = "System", DateTime? date = null, string format = "PDF")
    {
        return $"Report: {title}, Author: {author}, Date: {date ?? DateTime.Now}, Format: {format}";
    }

    // Задача 338: Напишите метод с опциональными параметрами для валидации формы
    static bool ValidateForm338(string email, string password, int minPasswordLength = 8, bool requireSpecialChar = false)
    {
        bool valid = email.Contains("@");
        valid &= password.Length >= minPasswordLength;
        if (requireSpecialChar) valid &= password.Any(ch => !char.IsLetterOrDigit(ch));
        return valid;
    }

    // Задача 339: Напишите метод с именованными параметрами для создания конфигурации приложения
    static string GetAppConfig(string appName, string version = "1.0.0", string environment = "Development")
    {
        return $"App: {appName} v{version} ({environment})";
    }

    // Задача 340: Создайте метод с именованными параметрами для отправки email (тема, текст, вложения)
    static string PrepareEmail(string to, string subject, string message, int priority = 1, bool readReceipt = false)
    {
        return $"To: {to}, Subject: {subject}, Priority: {priority}, ReadReceipt: {readReceipt}";
    }

    // Задача 341: Реализуйте метод с именованными параметрами для построения SQL-запроса
    static string BuildQuery341(string table, string columns = "*", string condition = "", int? limit = null)
    {
        string query = $"SELECT {columns} FROM {table}";
        if (!string.IsNullOrEmpty(condition)) query += $" WHERE {condition}";
        if (limit.HasValue) query += $" LIMIT {limit}";
        return query;
    }

    // Задача 342: Реализуйте метод с опциональным параметром для округления чисел (количество знаков)
    static double RoundTo(double number, int decimalPlaces = 0)
    {
        return Math.Round(number, decimalPlaces);
    }

    // Задача 343: Создайте метод с опциональным параметром для вычисления степени числа
    static double CalculatePower(double number, int power = 2)
    {
        return Math.Pow(number, power);
    }

    // Задача 344: Напишите метод с именованными параметрами для создания конфигурации приложения
    static string CreateConfiguration(string appName, bool enableLogging = true, int maxConnections = 100, string theme = "light")
    {
        return $"App: {appName}, Logging: {enableLogging}, MaxConnections: {maxConnections}, Theme: {theme}";
    }

    // Задача 345: Создайте метод с именованными параметрами для отправки email (тема, текст, вложения)
    static string ComposeEmail(string recipient, string subject, string body, string attachment = "", string bcc = "")
    {
        return $"To: {recipient}, Subject: {subject}, Attachment: {attachment}, BCC: {bcc}";
    }

    // Задача 346: Создайте метод с именованными параметрами для расчета стоимости заказа
    static decimal CalculateTotal(decimal basePrice, int quantity = 1, decimal tax = 0.08m, decimal discount = 0)
    {
        return (basePrice * quantity * (1 + tax)) - discount;
    }

    // Задача 347: Реализуйте метод с опциональным параметром для вывода сообщения с префиксом
    static void WriteMessage(string text, string level = "INFO", bool includeDate = false)
    {
        string date = includeDate ? $"[{DateTime.Now:yyyy-MM-dd}] " : "";
        Console.WriteLine($"{date}[{level}] {text}");
    }

    // Задача 348: Напишите метод с опциональным параметром для поиска в массиве (начальный индекс)
    static int IndexOf(int[] array, int value, int start = 0)
    {
        for (int i = start; i < array.Length; i++)
            if (array[i] == value) return i;
        return -1;
    }

    // Задача 349: Создайте метод с именованными параметрами для расчета стоимости заказа
    static decimal ComputeOrderTotal(decimal subtotal, decimal shipping = 0, decimal taxRate = 0.1m, decimal coupon = 0)
    {
        return (subtotal * (1 + taxRate)) + shipping - coupon;
    }

    // Задача 350: Создайте метод с именованными параметрами для расчета стоимости заказа
    static decimal GetOrderTotal(decimal price, int quantity = 1, decimal discount = 0, decimal tax = 0.07m)
    {
        return (price * quantity - discount) * (1 + tax);
    }

    // Задача 351: Напишите метод с именованными параметрами для создания конфигурации приложения
    static string BuildConfig(string appName, string version = "1.0", string environment = "Production", bool debug = false)
    {
        return $"{appName} v{version} - {environment} (Debug: {debug})";
    }

    // Задача 352: Реализуйте метод с опциональным параметром для вывода сообщения с префиксом
    static void Log352(string message, string category = "General", bool timestamp = true)
    {
        string time = timestamp ? $"{DateTime.Now:HH:mm:ss} " : "";
        Console.WriteLine($"{time}[{category}] {message}");
    }

    // Задача 353: Напишите метод с опциональным параметром для поиска в массиве (начальный индекс)
    static int FindIndex(string[] array, string value, int startIndex = 0)
    {
        for (int i = startIndex; i < array.Length; i++)
            if (array[i] == value) return i;
        return -1;
    }

    // Задача 354: Создайте метод с именованными параметрами для отправки email (тема, текст, вложения)
    static string CreateEmail(string to, string subject, string body, bool isHtml = false, int priority = 3)
    {
        return $"To: {to}, Subject: {subject}, HTML: {isHtml}, Priority: {priority}";
    }

    // Задача 355: Реализуйте метод с именованными параметрами для построения SQL-запроса
    static string SQLQuery(string table, string select = "*", string where = "", string groupBy = "")
    {
        string query = $"SELECT {select} FROM {table}";
        if (!string.IsNullOrEmpty(where)) query += $" WHERE {where}";
        if (!string.IsNullOrEmpty(groupBy)) query += $" GROUP BY {groupBy}";
        return query;
    }

    // Задача 356: Создайте метод с опциональными параметрами для подключения к базе данных
    static string DatabaseConnection(string server, string database, string user = "admin", int port = 5432)
    {
        return $"Server={server};Port={port};Database={database};User={user}";
    }

    // Задача 357: Реализуйте метод с опциональными параметрами для создания файла (путь, расширение)
    static string MakeFilePath(string name, string folder = "uploads", string extension = "jpg")
    {
        return $"{folder}/{name}.{extension}";
    }

    // Задача 358: Создайте метод с опциональными параметрами для подключения к базе данных
    static string GetConnectionString(string host, string dbName, int timeout = 30, bool pooled = true)
    {
        return $"Host={host};Database={dbName};Timeout={timeout};Pooling={pooled}";
    }

    // Задача 359: Напишите метод с опциональным параметром для поиска в массиве (начальный индекс)
    static int Search(int[] array, int target, int from = 0)
    {
        for (int i = from; i < array.Length; i++)
            if (array[i] == target) return i;
        return -1;
    }

    // Задача 360: Реализуйте метод с опциональным параметром для округления чисел (количество знаков)
    static double Round360(double value, int digits = 0)
    {
        return Math.Round(value, digits);
    }

    // Задача 361: Создайте метод с именованными параметрами для HTTP-запроса (метод, заголовки, тело)
    static string CreateHttpRequest(string url, string method = "GET", string headers = "", string body = "")
    {
        return $"{method} {url} | Headers: {headers} | Body: {body}";
    }

    // Задача 362: Напишите метод с опциональным параметром для поиска в массиве (начальный индекс)
    static int Find362<T>(T[] array, T value, int start = 0)
    {
        for (int i = start; i < array.Length; i++)
            if (EqualityComparer<T>.Default.Equals(array[i], value)) return i;
        return -1;
    }

    // Задача 363: Реализуйте метод с именованными параметрами для создания пользователя
    static string CreateUser363(string username, string email, bool isActive = true, string role = "user", DateTime? created = null)
    {
        return $"User: {username} ({email}) - Role: {role}, Active: {isActive}, Created: {created ?? DateTime.Now}";
    }

    // Задача 364: Напишите метод с опциональными параметрами для форматирования строки
    static string Format364(string text, bool capitalize = false, bool removeSpaces = false)
    {
        if (capitalize) text = text.ToUpper();
        if (removeSpaces) text = text.Replace(" ", "");
        return text;
    }

    // Задача 365: Реализуйте метод с именованными параметрами для создания графика (ширина, высота, цвет)
    static string CreateGraph(int width = 600, int height = 400, string color = "red", string type = "bar")
    {
        return $"{type} chart: {width}x{height}, Color: {color}";
    }

    // Задача 366: Напишите метод с опциональным параметром для поиска в массиве (начальный индекс)
    static int FindPosition(string[] array, string value, int startFrom = 0)
    {
        for (int i = startFrom; i < array.Length; i++)
            if (array[i] == value) return i;
        return -1;
    }

    // Задача 367: Реализуйте метод с именованными параметрами для создания пользователя
    static string RegisterUser(string username, string password, string email = "", bool emailVerified = false)
    {
        return $"User: {username}, Email: {email}, Verified: {emailVerified}";
    }

    // Задача 368: Создайте метод с опциональным параметром для вычисления степени числа
    static double Power368(double baseNumber, int exponent = 2)
    {
        return Math.Pow(baseNumber, exponent);
    }

    // Задача 369: Реализуйте метод с опциональными параметрами для создания файла (путь, расширение)
    static string GenerateFile369(string name, string location = "root", string fileType = "txt")
    {
        return $"{location}/{name}.{fileType}";
    }

    // Задача 370: Реализуйте метод с опциональным параметром для вывода сообщения с префиксом
    static void Output370(string message, string prefix = "LOG", bool newLine = true)
    {
        string output = $"[{prefix}] {message}";
        if (newLine) Console.WriteLine(output);
        else Console.Write(output);
    }

    // Задача 371: Напишите метод с опциональным параметром для поиска в массиве (начальный индекс)
    static int FindItem<T>(List<T> list, T item, int startIndex = 0)
    {
        for (int i = startIndex; i < list.Count; i++)
            if (EqualityComparer<T>.Default.Equals(list[i], item)) return i;
        return -1;
    }

    // Задача 372: Напишите метод с именованными параметрами для создания отчета (дата, автор, заголовок)
    static string GenerateReport(string title, string createdBy = "System", DateTime? reportDate = null, string format = "HTML")
    {
        return $"{title} - by {createdBy} on {reportDate ?? DateTime.Today} ({format})";
    }

    // Задача 373: Напишите метод с опциональными параметрами для валидации формы
    static bool ValidateForm373(string username, string email, bool checkUsername = true, bool checkEmail = true)
    {
        bool valid = true;
        if (checkUsername) valid &= !string.IsNullOrEmpty(username);
        if (checkEmail) valid &= email.Contains("@");
        return valid;
    }

    // Задача 374: Напишите метод с именованными параметрами для создания конфигурации приложения
    static string AppConfig374(string name, string version = "1.0", bool enableCache = true, int timeout = 30)
    {
        return $"{name} v{version} - Cache: {enableCache}, Timeout: {timeout}s";
    }

    // Задача 375: Реализуйте метод с именованными параметрами для создания графика (ширина, высота, цвет)
    static string CreatePlot(int width = 800, int height = 600, string backgroundColor = "white", string title = "")
    {
        return $"Plot: {title} ({width}x{height}), BG: {backgroundColor}";
    }

    // Задача 376: Напишите метод с именованными параметрами для создания конфигурации приложения
    static string GetConfig376(string appName, string environment = "development", bool debugMode = false, string logLevel = "INFO")
    {
        return $"{appName} [{environment}] - Debug: {debugMode}, Log: {logLevel}";
    }

    // Задача 377: Создайте метод с опциональным параметром для вычисления степени числа
    static double CalculateExponent(double number, int power = 3)
    {
        return Math.Pow(number, power);
    }

    // Задача 378: Создайте метод с именованными параметрами для расчета стоимости заказа
    static decimal CalculateOrder378(decimal unitPrice, int quantity = 1, decimal tax = 0.05m, decimal discount = 0)
    {
        return (unitPrice * quantity - discount) * (1 + tax);
    }

    // Задача 379: Напишите метод с опциональными параметрами для форматирования строки
    static string ProcessText(string text, bool trim = true, bool toLower = false, int? maxChars = null)
    {
        if (trim) text = text.Trim();
        if (toLower) text = text.ToLower();
        if (maxChars.HasValue && text.Length > maxChars.Value)
            text = text.Substring(0, maxChars.Value);
        return text;
    }

    // Задача 380: Реализуйте метод с опциональным параметром для вывода сообщения с префиксом
    static void Print380(string message, string level = "INFO", bool showThread = false)
    {
        string thread = showThread ? $"[Thread-{System.Threading.Thread.CurrentThread.ManagedThreadId}]" : "";
        Console.WriteLine($"{thread}[{level}] {message}");
    }

    // Задача 381: Напишите метод с именованными параметрами для создания конфигурации приложения
    static string BuildAppConfig(string name, string version = "1.0.0", string environment = "Production")
    {
        return $"Application: {name} {version} - Environment: {environment}";
    }

    // Задача 382: Реализуйте метод с именованными параметрами для создания пользователя
    static string CreateUserAccount(string username, string email, string role = "user", bool isEnabled = true)
    {
        return $"Account: {username} <{email}> - Role: {role}, Enabled: {isEnabled}";
    }

    // Задача 383: Напишите метод с именованными параметрами для фильтрации данных
    static IEnumerable<T> Filter383<T>(IEnumerable<T> source, int pageNumber = 1, int pageSize = 20, string sortField = "Id")
    {
        return source.Skip((pageNumber - 1) * pageSize).Take(pageSize);
    }

    // Задача 384: Создайте метод с опциональными параметрами для генерации пароля (длина, символы)
    static string GeneratePassword384(int length = 16, bool includeUpper = true, bool includeNumbers = true, bool includeSpecial = true)
    {
        string chars = "abcdefghijklmnopqrstuvwxyz";
        if (includeUpper) chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (includeNumbers) chars += "0123456789";
        if (includeSpecial) chars += "!@#$%^&*";

        Random rand = new Random();
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[rand.Next(s.Length)]).ToArray());
    }

    // Задача 385: Напишите метод с именованными параметрами для создания конфигурации приложения
    static string CreateAppSettings(string appName, bool enableSSL = true, int port = 8080, string environment = "Development")
    {
        return $"{appName} - SSL: {enableSSL}, Port: {port}, Env: {environment}";
    }

    // Задача 386: Реализуйте метод с опциональным параметром для вывода сообщения с префиксом
    static void Log386(string message, string severity = "INFO", bool logToFile = false)
    {
        string output = $"[{severity}] {message}";
        Console.WriteLine(output);
        if (logToFile)
        {
            // Здесь была бы запись в файл
        }
    }

    // Задача 387: Реализуйте метод с именованными параметрами для создания графика (ширина, высота, цвет)
    static string CreateChart387(int width = 1000, int height = 800, string colorScheme = "default", bool showGrid = true)
    {
        return $"Chart: {width}x{height}, Colors: {colorScheme}, Grid: {showGrid}";
    }

    // Задача 388: Реализуйте метод с опциональным параметром для вывода сообщения с префиксом
    static void WriteLog(string message, string category = "Application", bool error = false)
    {
        string prefix = error ? "ERROR" : "INFO";
        Console.WriteLine($"[{prefix}][{category}] {message}");
    }

    // Задача 389: Реализуйте метод с именованными параметрами для создания пользователя
    static string NewUser(string username, string email, DateTime? created = null, bool verified = false)
    {
        return $"Username: {username}, Email: {email}, Created: {created ?? DateTime.Now}, Verified: {verified}";
    }

    // Задача 390: Создайте метод с именованными параметрами для отправки email (тема, текст, вложения)
    static string SendEmail390(string to, string subject, string body, string replyTo = "", bool highPriority = false)
    {
        return $"To: {to}, Subject: {subject}, Reply-To: {replyTo}, Priority: {(highPriority ? "High" : "Normal")}";
    }

    // Задача 391: Напишите метод с именованными параметрами для фильтрации данных
    static List<T> FilterList<T>(List<T> items, int skip = 0, int take = 10, Func<T, bool> where = null)
    {
        var result = items;
        if (where != null) result = result.Where(where).ToList();
        return result.Skip(skip).Take(take).ToList();
    }

    // Задача 392: Реализуйте метод с именованными параметрами для создания пользователя
    static string CreateUser392(string userName, string emailAddress, string phone = "", bool isActive = true)
    {
        return $"User: {userName}, Email: {emailAddress}, Phone: {phone}, Active: {isActive}";
    }

    // Задача 393: Напишите метод с именованными параметрами для фильтрации данных
    static IQueryable<T> Filter393<T>(IQueryable<T> query, int page = 1, int size = 25, string orderBy = "Id")
    {
        return query.Skip((page - 1) * size).Take(size);
    }

    // Задача 394: Создайте метод с опциональными параметрами для подключения к базе данных
    static string CreateDbConnection(string host, string database, string user = "sa", int port = 1433, int timeout = 30)
    {
        return $"Data Source={host},{port};Initial Catalog={database};User ID={user};Connection Timeout={timeout}";
    }

    // Задача 395: Реализуйте метод с именованными параметрами для настройки логирования
    static string SetupLogger(string logFile = "app.log", string level = "INFO", int maxFileSize = 1024, bool consoleOutput = true)
    {
        return $"LogFile: {logFile}, Level: {level}, MaxSize: {maxFileSize}MB, Console: {consoleOutput}";
    }

    // Задача 396: Создайте метод с именованными параметрами для расчета стоимости заказа
    static decimal CalculateOrder396(decimal price, int quantity = 1, decimal discountPercentage = 0, decimal taxPercentage = 0.08m)
    {
        decimal subtotal = price * quantity;
        decimal discount = subtotal * (discountPercentage / 100);
        return (subtotal - discount) * (1 + taxPercentage);
    }

    // Задача 397: Напишите метод с именованными параметрами для фильтрации данных
    static IEnumerable<T> Paginate<T>(IEnumerable<T> data, int pageIndex = 0, int pageSize = 10, string sortBy = null)
    {
        var result = data;
        if (!string.IsNullOrEmpty(sortBy))
        {
            // Сортировка будет реализована здесь
        }
        return result.Skip(pageIndex * pageSize).Take(pageSize);
    }

    // Задача 398: Напишите метод с именованными параметрами для создания конфигурации приложения
    static string GetApplicationConfig(string appName, string version = "1.0", bool enableFeatures = true, string mode = "Standard")
    {
        return $"{appName} v{version} - Features: {enableFeatures}, Mode: {mode}";
    }

    // Задача 399: Реализуйте метод с именованными параметрами для создания графика (ширина, высота, цвет)
    static string CreateGraph399(int width = 1200, int height = 800, string theme = "light", bool interactive = true)
    {
        return $"Graph: {width}x{height}, Theme: {theme}, Interactive: {interactive}";
    }

    // Задача 400: Реализуйте метод с именованными параметрами для построения SQL-запроса
    static string BuildSQL400(string table, string columns = "*", string where = "", string orderBy = "", int? top = null)
    {
        string query = $"SELECT ";
        if (top.HasValue) query += $"TOP {top} ";
        query += $"{columns} FROM {table}";
        if (!string.IsNullOrEmpty(where)) query += $" WHERE {where}";
        if (!string.IsNullOrEmpty(orderBy)) query += $" ORDER BY {orderBy}";
        return query;
    }
}