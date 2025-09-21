using System;

class Program
{
    static void Main()
    {
        //16
        Console.Write("Введите первую сторону: ");
        double a16 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вторую сторону: ");
        double b16 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите третью сторону: ");
        double c16 = Convert.ToDouble(Console.ReadLine());

        bool canFormTriangle = (a16 + b16 > c16) && (a16 + c16 > b16) && (b16 + c16 > a16);
        Console.WriteLine($"Можно построить треугольник: {canFormTriangle}");

        //17
        Console.Write("Введите x: ");
        double x17 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y: ");
        double y17 = Convert.ToDouble(Console.ReadLine());

        double fx17;
        if (Math.Abs(x17) > 1)
        {
            fx17 = Math.Pow(Math.Sin(Math.Pow(x17, 3)), 2);
        }
        else
        {
            fx17 = Math.Sqrt(6 * Math.Asin(Math.Pow(x17, 7)) + 4.5 * Math.Pow(x17, 6) + 4 * Math.Pow(x17, 2) + 2);
        }

        bool onCurve = Math.Abs(fx17 - y17) < 0.001;
        Console.WriteLine($"Точка лежит на кривой: {onCurve}");

        //18
        Console.Write("Введите x: ");
        double x18 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y: ");
        double y18 = Convert.ToDouble(Console.ReadLine());

        bool inArea18 = (y18 >= 0) && (y18 <= 2 - x18 * x18);
        Console.WriteLine($"Точка в области: {inArea18}");

        //19
        Console.Write("Введите x: ");
        double x19 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y: ");
        double y19 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите радиус R: ");
        double R19 = Convert.ToDouble(Console.ReadLine());

        double distance19 = Math.Sqrt(x19 * x19 + y19 * y19);
        bool insideCircle = distance19 <= R19;
        Console.WriteLine($"Точка внутри окружности: {insideCircle}");

        //20
        Console.Write("Введите сторону a: ");
        double a20 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону b: ");
        double b20 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону c: ");
        double c20 = Convert.ToDouble(Console.ReadLine());

        bool isRight = (a20 * a20 + b20 * b20 == c20 * c20) ||
                      (a20 * a20 + c20 * c20 == b20 * b20) ||
                      (b20 * b20 + c20 * c20 == a20 * a20);

        Console.WriteLine($"Треугольник прямоугольный: {isRight}");

        //21
        Console.Write("Введите энергию W (кВ): ");
        double W = Convert.ToDouble(Console.ReadLine()) * 1000;
        Console.Write("Введите минимальный радиус (см): ");
        double rMin = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите максимальный радиус (см): ");
        double rMax = Convert.ToDouble(Console.ReadLine());

        double m = 9.1e-31;
        double q = 1.6e-19;

        double v = Math.Sqrt(2 * m * W);
        double B_min = (m * v) / (q * rMax / 100);
        double B_max = (m * v) / (q * rMin / 100);

        Console.WriteLine($"Диапазон индукции B: от {B_min} до {B_max} Тл");

        //22
        Console.Write("Введите точку a: ");
        double a22 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите точку b: ");
        double b22 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите точку c: ");
        double c22 = Convert.ToDouble(Console.ReadLine());

        double distB = Math.Abs(b22);
        double distC = Math.Abs(c22);

        if (distB < distC)
        {
            Console.WriteLine("Точка b ближе к оси");
        }
        else if (distB > distC)
        {
            Console.WriteLine("Точка c ближе к оси");
        }
        else
        {
            Console.WriteLine("Точки равноудалены от оси");
        }

        //23
        Console.Write("Введите число a: ");
        int a23 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b23 = Convert.ToInt32(Console.ReadLine());

        bool aDividesB = b23 % a23 == 0;
        bool bDividesA = a23 % b23 == 0;

        Console.WriteLine($"{a23} является делителем {b23}: {aDividesB}");
        Console.WriteLine($"{b23} является делителем {a23}: {bDividesA}");

        //24
        Console.Write("Введите число a: ");
        int a24 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b24 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число c: ");
        int c24 = Convert.ToInt32(Console.ReadLine());

        bool ravn = (a24 == b24) || (a24 == c24) || (b24 == c24);
        Console.WriteLine($"Есть пара равных чисел: {ravn}");

        //25
        Console.WriteLine("\n=== Задача 25 ===");
        Console.Write("Введите скорость электрона (Мм/с): ");
        double v25 = Convert.ToDouble(Console.ReadLine()) * 1e6;
        Console.Write("Введите индукцию B (мТл): ");
        double B25 = Convert.ToDouble(Console.ReadLine()) * 1e-3;

        double m25 = 9.1e-31;
        double q25 = 1.6e-19;

        double r25 = (m25 * v25) / (q25 * B25);
        bool inRing = (r25 >= 0.005) && (r25 <= 0.015);

        Console.WriteLine($"Радиус траектории: {r25} м");
        Console.WriteLine($"Попадает в кольцо: {inRing}");

        //26
        Console.Write("Введите первое число: ");
        double num26_1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num26_2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите третье число: ");
        double num26_3 = Convert.ToDouble(Console.ReadLine());

        double average = (num26_1 + num26_2 + num26_3) / 3;

        Console.WriteLine("Числа по модулю больше среднего:");
        if (Math.Abs(num26_1) > average) 
        {
            Console.WriteLine(num26_1);
        }
        if (Math.Abs(num26_2) > average)
        {
            Console.WriteLine(num26_2);
        }
        if (Math.Abs(num26_3) > average)
        {
            Console.WriteLine(num26_3);
        }

        //27
        Console.Write("Введите текущее время (0-24): ");
        int time27 = Convert.ToInt32(Console.ReadLine());

        if (time27 >= 6 && time27 < 12)
        {
            Console.WriteLine("Утро");
        }
        else if (time27 >= 12 && time27 < 18)
        {
            Console.WriteLine("День");
        }
        else if (time27 >= 18 && time27 < 24)
        {
            Console.WriteLine("Вечер");
        }
        else if (time27 >= 0 && time27 < 6)
        {
            Console.WriteLine("Ночь");
        }
        else
        {
            Console.WriteLine("Некорректное время");
        }

        //28
        double mv = 4.86e27;
        double rv = 6175 * 100000;
        double mz = 5.98e27;
        double rz = 6371 * 100000;
        double ms = 5.68e29;
        double rs = 5775000000;
        double G = 6.7e-8;

        double gv = G * mv / (rv * rv);
        double gz = G * mz / (rz * rz);
        double gs = G * ms / (rs * rs);

        double maxG = Math.Max(gv, Math.Max(gz, gs));
        string planet;

        if (maxG == gv) planet = "Венера";
        else if (maxG == gz) planet = "Земля";
        else planet = "Сатурн";

        Console.WriteLine($"Наибольшее ускорение свободного падения у {planet}");

        //1
        Console.Write("Введите a: ");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите c: ");
        double c1 = Convert.ToDouble(Console.ReadLine());

        if (a1 == 0)
        {
            Console.WriteLine("a не может быть равно 0");
        }
        else
        {
            double discriminant = b1 * b1 - 4 * a1 * c1;

            if (discriminant > 0)
            {
                double x1 = (-b1 + Math.Sqrt(discriminant)) / (2 * a1);
                double x2 = (-b1 - Math.Sqrt(discriminant)) / (2 * a1);
                Console.WriteLine($"Два корня: x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x = -b1 / (2 * a1);
                Console.WriteLine($"Один корень: x = {x}");
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
            }
        }

        //2
        Console.Write("Введите двухзначное число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите цифру a: ");
        int digitA = Convert.ToInt32(Console.ReadLine());

        int firstDigit2 = num2 / 10;
        int secondDigit2 = num2 % 10;

        bool has5 = (firstDigit2 == 5) || (secondDigit2 == 5);
        bool hasA = (firstDigit2 == digitA) || (secondDigit2 == digitA);

        Console.WriteLine($"Содержит цифру 5: {has5}");
        Console.WriteLine($"Содержит цифру {digitA}: {hasA}");

        //3
        Console.Write("Введите двухзначное число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int firstDigit3 = num3 / 10;
        int secondDigit3 = num3 % 10;

        bool has3and7 = (firstDigit3 == 3 && secondDigit3 == 7) || (firstDigit3 == 7 && secondDigit3 == 3);
        bool has4and8or9 = (firstDigit3 == 4 && secondDigit3 == 8) ||
                          (firstDigit3 == 8 && secondDigit3 == 4) ||
                          (firstDigit3 == 9) || (secondDigit3 == 9);

        Console.WriteLine($"Содержит цифры 3 и 7: {has3and7}");
        Console.WriteLine($"Содержит 4 и 8 или 9: {has4and8or9}");

        //4
        Console.Write("Введите число от 1 до 99: ");
        int kopeks = Convert.ToInt32(Console.ReadLine());

        string form;
        if (kopeks % 10 == 1 && kopeks != 11)
        {
            form = "копейка";
        }
        else if ((kopeks % 10 >= 2 && kopeks % 10 <= 4) && !(kopeks >= 12 && kopeks <= 14))
        {
            form = "копейки";
        }
        else
        {
            form = "копеек";
        }

        Console.WriteLine($"{kopeks} {form}");

        //5
        Console.Write("Введите четырехзначное число: ");
        int num5 = Convert.ToInt32(Console.ReadLine());

        int digit1 = num5 / 1000;
        int digit2 = (num5 / 100) % 10;
        int digit3 = (num5 / 10) % 10;
        int digit4 = num5 % 10;

        bool isPalindrome = (digit1 == digit4) && (digit2 == digit3);
        Console.WriteLine($"Является палиндромом: {isPalindrome}");

        //6
        Console.Write("Введите шестизначное число: ");
        int num6 = Convert.ToInt32(Console.ReadLine());

        int firstHalf = num6 / 1000;
        int secondHalf = num6 % 1000;

        int sumFirst = (firstHalf / 100) + ((firstHalf / 10) % 10) + (firstHalf % 10);
        int sumSecond = (secondHalf / 100) + ((secondHalf / 10) % 10) + (secondHalf % 10);

        bool isLucky = sumFirst == sumSecond;
        Console.WriteLine($"Счастливое число: {isLucky}");

        //7
        Console.Write("Введите день года (1-365): ");
        int day = Convert.ToInt32(Console.ReadLine());

        string[] daysOfWeek = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
        int dayIndex = (day - 1) % 7;

        Console.WriteLine($"День недели: {daysOfWeek[dayIndex]}");

        //8
        Console.Write("Введите угол a (в градусах): ");
        double alpha = Convert.ToDouble(Console.ReadLine()) * Math.PI / 180;
        Console.Write("Введите начальную скорость v0: ");
        double v0 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите расстояние до цели R: ");
        double R = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите высоту цели H: ");
        double H = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите размер цели h: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double time = R / (v0 * Math.Cos(alpha));
        double y = v0 * time * Math.Sin(alpha) - 9.8 * time * time / 2;

        bool hit = (y >= H) && (y <= H + h);
        Console.WriteLine($"Снаряд попадает в цель: {hit}");

        //9
        Console.Write("Введите трехзначное число: ");
        int num9 = Convert.ToInt32(Console.ReadLine());

        int d1 = num9 / 100;
        int d2 = (num9 / 10) % 10;
        int d3 = num9 % 10;

        int sum9 = d1 + d2 + d3;
        int product9 = d1 * d2 * d3;

        bool sum = sum9 >= 10 && sum9 <= 99;
        bool product = product9 >= 100 && product9 <= 999;

        Console.WriteLine($"Сумма цифр - двухзначное число: {sum}");
        Console.WriteLine($"Произведение цифр - трехзначное число: {product}");

        //10
        Console.Write("Введите трехзначное число: ");
        int num10 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b10 = Convert.ToInt32(Console.ReadLine());

        int d1_10 = num10 / 100;
        int d2_10 = (num10 / 10) % 10;
        int d3_10 = num10 % 10;

        int product10 = d1_10 * d2_10 * d3_10;
        int sum10 = d1_10 + d2_10 + d3_10;

        bool productG = product10 > b10;
        bool sumD = sum10 % 3 == 0;

        Console.WriteLine($"Произведение цифр больше {b10}: {productG}");
        Console.WriteLine($"Сумма цифр кратна 3: {sumD}");

        //11
        Console.Write("Введите трехзначное число: ");
        int num11 = Convert.ToInt32(Console.ReadLine());

        int d1_11 = num11 / 100;
        int d2_11 = (num11 / 10) % 10;
        int d3_11 = num11 % 10;

        bool allSame = (d1_11 == d2_11) && (d2_11 == d3_11);
        bool hasSame = (d1_11 == d2_11) || (d1_11 == d3_11) || (d2_11 == d3_11);

        Console.WriteLine($"Все цифры одинаковые: {allSame}");
        Console.WriteLine($"Есть одинаковые цифры: {hasSame}");

        //12
        Console.Write("Введите x: ");
        double x12 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y: ");
        double y12 = Convert.ToDouble(Console.ReadLine());

        bool inArea = (y12 <= 2 - x12 * x12) && (y12 >= -2);
        Console.WriteLine($"Точка в области: {inArea}");

        //13
        Console.Write("Введите x1: ");
        double x13_1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y1: ");
        double y13_1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите x2: ");
        double x13_2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y2: ");
        double y13_2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите x3: ");
        double x13_3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y3: ");
        double y13_3 = Convert.ToDouble(Console.ReadLine());

        double slopeAB = (y13_2 - y13_1) / (x13_2 - x13_1);
        double slopePerpendicular = -1 / slopeAB;

        double expectedY = y13_3 + slopePerpendicular * (x13_1 - x13_3);
        bool canDraw = Math.Abs(expectedY - y13_1) < 0.001;

        Console.WriteLine($"Можно провести перпендикуляр: {canDraw}");

        //14
        Console.Write("Введите средний балл (3-5): ");
        double averageScore = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите стаж работы (лет): ");
        int experience = Convert.ToInt32(Console.ReadLine());

        double coefficient = 1.0;
        if (experience < 2) coefficient = 1.3;
        else if (experience >= 2 && experience <= 5) coefficient = 1.6;

        double rating = averageScore * coefficient;
        bool accepted = rating >= 4.5;

        Console.WriteLine($"Рейтинг: {rating}");
        Console.WriteLine($"Принят в магистратуру: {accepted}");

        //15
        Console.Write("Введите x1: ");
        int x15_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите y1: ");
        int y15_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите x2: ");
        int x15_2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите y2: ");
        int y15_2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите x3: ");
        int x15_3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите y3: ");
        int y15_3 = Convert.ToInt32(Console.ReadLine());

        int x4, y4;
        if (x15_1 == x15_2)
        {
            x4 = x15_3;
            y4 = (y15_1 == y15_3) ? y15_2 : y15_1;
        }
        else if (x15_1 == x15_3)
        {
            x4 = x15_2;
            y4 = (y15_1 == y15_2) ? y15_3 : y15_1;
        }
        else
        {
            x4 = x15_1;
            y4 = (y15_2 == y15_3) ? y15_1 : y15_2;
        }

        Console.WriteLine($"Четвертая вершина: ({x4}, {y4})");

        //16
        Console.Write("Введите четырехзначное число: ");
        int num16 = Convert.ToInt32(Console.ReadLine());

        int firstTwo = num16 / 100;
        int lastTwo = num16 % 100;

        int sumFirstTwo = (firstTwo / 10) + (firstTwo % 10);
        int sumLastTwo = (lastTwo / 10) + (lastTwo % 10);
        int totalSum = sumFirstTwo + sumLastTwo;

        bool sums = sumFirstTwo == sumLastTwo;
        bool sumDiv = totalSum % 7 == 0;

        Console.WriteLine($"Сумма первых двух равна сумме последних: {sums}");
        Console.WriteLine($"Сумма цифр кратна 7: {sumDiv}");

        //17
        Console.Write("Введите четырехзначное число: ");
        int num17 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число a: ");
        int a17 = Convert.ToInt32(Console.ReadLine());

        int digit1_17 = num17 / 1000;
        int digit2_17 = (num17 / 100) % 10;
        int digit3_17 = (num17 / 10) % 10;
        int digit4_17 = num17 % 10;

        int product17 = digit1_17 * digit2_17 * digit3_17 * digit4_17;

        bool divisible = product17 % 3 == 0;
        bool divisibleB = product17 % a17 == 0;

        Console.WriteLine($"Произведение цифр кратно 3: {divisible}");
        Console.WriteLine($"Произведение цифр кратно {a17}: {divisibleB}");

        //18
        Console.Write("Введите a: ");
        double a18 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b: ");
        double b18 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите c: ");
        double c18 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите d: ");
        double d18 = Convert.ToDouble(Console.ReadLine());

        bool fitsParallel = (a18 <= c18 && b18 <= d18) || (a18 <= d18 && b18 <= c18);
        bool fitsRotated = (a18 <= Math.Sqrt(c18 * c18 + d18 * d18)) && (b18 <= Math.Min(c18, d18));

        bool canPlace = fitsParallel || fitsRotated;
        Console.WriteLine($"Можно поместить прямоугольник: {canPlace}");

        //19
        Console.Write("Введите a: ");
        double a19 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b: ");
        double b19 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите c: ");
        double c19 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите x: ");
        double x19_1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y: ");
        double y19_1 = Convert.ToDouble(Console.ReadLine());

        bool fits1 = (a19 <= x19 && b19 <= y19) || (a19 <= y19 && b19 <= x19);
        bool fits2 = (a19 <= x19 && c19 <= y19) || (a19 <= y19 && c19 <= x19);
        bool fits3 = (b19 <= x19 && c19 <= y19) || (b19 <= y19 && c19 <= x19);

        bool canPass = fits1 || fits2 || fits3;
        Console.WriteLine($"Кирпич проходит в отверстие: {canPass}");

        Console.ReadKey();
    }
}