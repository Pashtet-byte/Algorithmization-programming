using System;

class Program
{
    static void Main()
    {
        //4
        Console.WriteLine("Введите сторону a");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите сторону b");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите сторону c");
        double c = Convert.ToDouble(Console.ReadLine());

        bool isRight =
            Math.Abs(a * a + b * b - c * c) < 1e-6 ||
            Math.Abs(a * a + c * c - b * b) < 1e-6 ||
            Math.Abs(b * b + c * c - a * a) < 1e-6;

        if (isRight)
            Console.WriteLine("Треугольник прямоугольный");
        else
            Console.WriteLine("Треугольник не прямоугольный");

        //5
        Console.WriteLine("Введите номер месяца");
        int month = Convert.ToInt32(Console.ReadLine());

        if (month == 12 || month == 1 || month == 2)
            Console.WriteLine("Зима");
        else if (month >= 3 && month <= 5)
            Console.WriteLine("Весна");
        else if (month >= 6 && month <= 8)
            Console.WriteLine("Лето");
        else if (month >= 9 && month <= 11)
            Console.WriteLine("Осень");
        else
            Console.WriteLine("Некорректный номер месяца");

        //6
        Console.WriteLine("Введите число A");
        double A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число B");
        double B = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число C");
        double C = Convert.ToDouble(Console.ReadLine());

        if (A + B + C > 0)
        {
            A *= 2;
            B *= 2;
            C *= 2;
        }
        else
        {
            A = 0;
            B = 0;
            C = 0;
        }
        Console.WriteLine($"A = {A}, B = {B}, C = {C}");

        //7
        Console.WriteLine("Введите x0");
        double x0 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y0");
        double y0 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите x1");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y1");
        double y1 = Convert.ToDouble(Console.ReadLine());

        double dA = Math.Sqrt(x0 * x0 + y0 * y0);
        double dB = Math.Sqrt(x1 * x1 + y1 * y1);

        if (dA < dB)
            Console.WriteLine("Точка A ближе к началу координат");
        else if (dB < dA)
            Console.WriteLine("Точка B ближе к началу координат");
        else
            Console.WriteLine("Точки равноудалены от начала координат");

        //8
        Console.WriteLine("Введите сторону a");
        double a8 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите сторону b");
        double b8 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите сторону c");
        double c8 = Convert.ToDouble(Console.ReadLine());

        if (a8 == b8 || a8 == c8 || b8 == c8)
            Console.WriteLine("Треугольник равнобедренный");
        else
            Console.WriteLine("Треугольник не равнобедренный");

        //9
        Console.WriteLine("Введите стоимость минуты у первого оператора (в копейках)");
        double cost1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите скидку у первого оператора (%)");
        double disc1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите стоимость минуты у второго оператора (в копейках)");
        double cost2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите скидку у второго оператора (%)");
        double disc2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите стоимость минуты у третьего оператора (в копейках)");
        double cost3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите скидку у третьего оператора (%)");
        double disc3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите количество минут в будние дни");
        double weekMinutes = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите количество минут в выходные дни");
        double weekendMinutes = Convert.ToDouble(Console.ReadLine());

        double sum1 = weekMinutes * cost1 + weekendMinutes * cost1 * (1 - disc1 / 100.0);
        double sum2 = weekMinutes * cost2 + weekendMinutes * cost2 * (1 - disc2 / 100.0);
        double sum3 = weekMinutes * cost3 + weekendMinutes * cost3 * (1 - disc3 / 100.0);

        Console.WriteLine($"Стоимость у первого оператора: {sum1 / 100} руб.");
        Console.WriteLine($"Стоимость у второго оператора: {sum2 / 100} руб.");
        Console.WriteLine($"Стоимость у третьего оператора: {sum3 / 100} руб.");

        //10
        Console.WriteLine("Введите номер темы (1-3)");
        int theme = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите вариант (a, b или c)");
        string variant = Console.ReadLine();

        string message = "";
        if (theme == 1) message = "Новогодние";
        else if (theme == 2) message = "С Днем Рождения";
        else if (theme == 3) message = "С Днем Защитника Отечества";
        else message = "Неверная тема";

        if ((variant == "a" || variant == "b" || variant == "c") && theme >= 1 && theme <= 3)
            Console.WriteLine($"{message}, вариант {variant}");
        else
            Console.WriteLine("Неверные данные");

        //11
        Console.WriteLine("Введите число a");
        double a11 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число b");
        double b11 = Convert.ToDouble(Console.ReadLine());

        if (a11 * b11 < 0)
        {
            a11 = -a11;
            b11 = -b11;
        }
        else
        {
            a11 = 0;
            b11 = 0;
        }
        Console.WriteLine($"a = {a11}, b = {b11}");

        //12
        Console.WriteLine("Введите число A");
        double A12 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число B");
        double B12 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число C");
        double C12 = Convert.ToDouble(Console.ReadLine());

        double min = Math.Min(A12, Math.Min(B12, C12));
        Console.WriteLine($"Наименьшее число: {min}");

        //13
        Console.WriteLine("Введите число x");
        double x13 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число y");
        double y13 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число z");
        double z13 = Convert.ToDouble(Console.ReadLine());

        double avg = (x13 + y13 + z13) / 3;

        Console.WriteLine("Числа, которые больше среднего по модулю:");
        if (Math.Abs(x13) > avg) Console.WriteLine($"x = {x13}");
        if (Math.Abs(y13) > avg) Console.WriteLine($"y = {y13}");
        if (Math.Abs(z13) > avg) Console.WriteLine($"z = {z13}");

        //15
        Console.WriteLine("Введите координату x");
        double x15 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату y");
        double y15 = Convert.ToDouble(Console.ReadLine());

        if (x15 > 0 && y15 < 0)
            Console.WriteLine("Точка находится в четвертой четверти");
        else
            Console.WriteLine("Точка не находится в четвертой четверти");

        //16
        Console.WriteLine("Введите сторону a");
        double a16 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите сторону b");
        double b16 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите сторону c");
        double c16 = Convert.ToDouble(Console.ReadLine());

        double minSide = Math.Min(a16, Math.Min(b16, c16));
        double p = (a16 + b16 + c16) / 2;
        double areaTriangle = Math.Sqrt(p * (p - a16) * (p - b16) * (p - c16));
        double areaSquare = minSide * minSide;

        if (areaTriangle > areaSquare)
            Console.WriteLine("Площадь треугольника больше площади квадрата");
        else
            Console.WriteLine("Площадь квадрата больше площади треугольника");

        //17
        Console.WriteLine("Введите координату x1");
        double x17_1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату y1");
        double y17_1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату x2");
        double x17_2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату y2");
        double y17_2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату x3");
        double x17_3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату y3");
        double y17_3 = Convert.ToDouble(Console.ReadLine());

        bool inFirstQuadrant = x17_1 > 0 && y17_1 > 0 && x17_2 > 0 && y17_2 > 0 && x17_3 > 0 && y17_3 > 0;

        if (inFirstQuadrant)
            Console.WriteLine("Все точки находятся в первой четверти");
        else
            Console.WriteLine("Не все точки находятся в первой четверти");

        //18
        Console.WriteLine("Введите координату x");
        double x18 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату y");
        double y18 = Convert.ToDouble(Console.ReadLine());

        double f;
        if (Math.Abs(x18) == 2)
            f = x18 * x18;
        else if (x18 < 2)
            f = 4;
        else
            f = 2;

        double eps = 1e-3;
        if (Math.Abs(f - y18) <= eps)
            Console.WriteLine("Погрешность в пределах допустимого");
        else
            Console.WriteLine("Погрешность больше допустимой");

        //19
        Console.WriteLine("Введите широту (φ)");
        double latitude = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите долготу (λ)");
        double longitude = Convert.ToDouble(Console.ReadLine());

        string ns = latitude >= 0 ? "Северное полушарие" : "Южное полушарие";
        string ew = longitude >= 0 ? "Восточное полушарие" : "Западное полушарие";

        Console.WriteLine($"Точка находится в {ns}, {ew}");

        //20
        Console.WriteLine("Введите сторону a");
        double a20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите сторону b");
        double b20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите сторону c");
        double c20 = Convert.ToDouble(Console.ReadLine());

        if (a20 == b20 && b20 == c20)
            Console.WriteLine("Треугольник равносторонний");
        else if (Math.Abs(a20 * a20 + b20 * b20 - c20 * c20) < 1e-6 ||
                 Math.Abs(a20 * a20 + c20 * c20 - b20 * b20) < 1e-6 ||
                 Math.Abs(b20 * b20 + c20 * c20 - a20 * a20) < 1e-6)
            Console.WriteLine("Треугольник прямоугольный");
        else
            Console.WriteLine("Простой треугольник");


        //21
        Console.WriteLine("Введите число a");
        double a21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число b");
        double b21 = Convert.ToDouble(Console.ReadLine());

        if (a21 * b21 < 0)
        {
            a21 = -a21;
            b21 = -b21;
        }
        else
        {
            a21 = 0;
            b21 = 0;
        }
        Console.WriteLine($"a = {a21}, b = {b21}");

        //22
        Console.WriteLine("Введите число A");
        double A22 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число B");
        double B22 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число C");
        double C22 = Convert.ToDouble(Console.ReadLine());

        double min22 = Math.Min(A22, Math.Min(B22, C22));
        Console.WriteLine($"Наименьшее число: {min22}");

        //23
        Console.WriteLine("Введите число a");
        double a23 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число b");
        double b23 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число c");
        double c23 = Convert.ToDouble(Console.ReadLine());

        int binaryNumber = 0b1101011;

        if (a23 > binaryNumber) Console.WriteLine($"a = {a23} больше {binaryNumber}");
        if (b23 > binaryNumber) Console.WriteLine($"b = {b23} больше {binaryNumber}");
        if (c23 > binaryNumber) Console.WriteLine($"c = {c23} больше {binaryNumber}");

        //24
        Console.WriteLine("Введите число a (восьмиричная)");
        int a24 = Convert.ToInt32(Console.ReadLine(), 8);
        Console.WriteLine("Введите число b (восьмиричная)");
        int b24 = Convert.ToInt32(Console.ReadLine(), 8);
        Console.WriteLine("Введите число c (восьмиричная)");
        int c24 = Convert.ToInt32(Console.ReadLine(), 8);

        int max24 = Math.Max(a24, Math.Max(b24, c24));
        Console.WriteLine($"Наибольшее число: {max24}");

        //25
        Console.WriteLine("Введите число a (шестнадцатеричная)");
        int a25 = Convert.ToInt32(Console.ReadLine(), 16);
        Console.WriteLine("Введите число b (шестнадцатеричная)");
        int b25 = Convert.ToInt32(Console.ReadLine(), 16);
        Console.WriteLine("Введите число c (шестнадцатеричная)");
        int c25 = Convert.ToInt32(Console.ReadLine(), 16);

        int min25 = Math.Min(a25, Math.Min(b25, c25));
        Console.WriteLine($"Наименьшее число: {min25}");

        //1
        Console.WriteLine("Введите x");
        double x_1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a1_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b1_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z1_func = Convert.ToDouble(Console.ReadLine());

        double y_1;
        if (x_1 < -Math.Log(a1_func))
            y_1 = Math.Asin(x_1) + b1_func * Math.Cos(z1_func * x_1);
        else if (x_1 >= -Math.Log(a1_func) && x_1 <= b1_func)
            y_1 = Math.Pow(a1_func, 2) - Math.Cos(a1_func + z1_func * x_1);
        else
            y_1 = 12.5 * a1_func + (6 - 2 * Math.Pow(x_1, 2));

        Console.WriteLine($"y = {y_1}");

        //2
        Console.WriteLine("Введите x");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a2_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b2_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите c");
        double c2_func = Convert.ToDouble(Console.ReadLine());

        double y2;
        if (Math.Exp(a2_func + b2_func) > Math.E)
            y2 = Math.Sin(Math.Exp(a2_func + b2_func)) + Math.Pow(x2, 7);
        else if (Math.Exp(a2_func + b2_func) == Math.E)
            y2 = Math.Atan(a2_func * b2_func * c2_func) + Math.Sqrt(x2);
        else
            y2 = Math.Cos(x2) / (x2 + a2_func * b2_func * c2_func);

        Console.WriteLine($"y = {y2}");

        //3
        Console.WriteLine("Введите x");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a3_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b3_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z3_func = Convert.ToDouble(Console.ReadLine());

        double y3;
        if (x3 <= a3_func)
            y3 = 2.8 * Math.Pow(Math.Sin(a3_func * x3), 2) - b3_func * Math.Pow(x3, 2);
        else if (x3 > a3_func && x3 <= 67)
            y3 = z3_func * Math.Cos(a3_func * x3 + b3_func) + Math.Log(3);
        else
            y3 = 2.3 * Math.Exp(x3) + z3_func * a3_func * b3_func * x3;

        Console.WriteLine($"y = {y3}");

        //4
        Console.WriteLine("Введите x");
        double x4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a4_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b4_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите c");
        double c4_func = Convert.ToDouble(Console.ReadLine());

        double y4;
        if (x4 <= a4_func + c4_func)
            y4 = Math.Sin(a4_func * x4) + Math.Cos(b4_func * c4_func);
        else
            y4 = Math.Pow(a4_func, 2) + 0.002;

        Console.WriteLine($"y = {y4}");

        //5
        Console.WriteLine("Введите x");
        double x5 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a5_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b5_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите c");
        double c5_func = Convert.ToDouble(Console.ReadLine());

        double y5;
        if (x5 > a5_func)
            y5 = Math.Sin(Math.Exp(a5_func) + b5_func) + Math.Pow(x5, 7);
        else if (x5 == a5_func)
            y5 = Math.Atan(a5_func * b5_func * c5_func) + Math.Sqrt(x5);
        else
            y5 = Math.Cos(x5) / (a5_func * b5_func * c5_func);

        Console.WriteLine($"y = {y5}");

        //6
        Console.WriteLine("Введите x");
        double x6 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a6_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b6_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z6_func = Convert.ToDouble(Console.ReadLine());

        double y6;
        if (x6 <= a6_func)
            y6 = 2.8 * Math.Pow(Math.Sin(a6_func * x6), 2) - b6_func * Math.Pow(x6, 2);
        else if (x6 > a6_func && x6 <= 67)
            y6 = z6_func * Math.Cos(a6_func * x6 + b6_func) + Math.Log(3);
        else
            y6 = 2.3 * Math.Exp(x6) + z6_func * a6_func * b6_func * x6;

        Console.WriteLine($"y = {y6}");

        //7
        Console.WriteLine("Введите x");
        double x7 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a7_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b7_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите c");
        double c7_func = Convert.ToDouble(Console.ReadLine());

        double y7;
        if (x7 <= a7_func + c7_func)
            y7 = Math.Sin(a7_func * x7) + Math.Cos(b7_func * c7_func);
        else
            y7 = Math.Pow(a7_func, 2) + 0.002;

        Console.WriteLine($"y = {y7}");

        //8
        Console.WriteLine("Введите x");
        double x8 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите k");
        double k8 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите m");
        double m8 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите n");
        double n8 = Convert.ToDouble(Console.ReadLine());

        double y8;
        if (x8 <= m8 + n8)
            y8 = Math.Log(x8) + n8 * k8;
        else if (x8 > m8 + n8)
            y8 = x8 - m8 + n8;
        else
            y8 = k8 * x8 + Math.Cos(x8);

        Console.WriteLine($"y = {y8}");

        //9
        Console.WriteLine("Введите x");
        double x9 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a9_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b9_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z9_func = Convert.ToDouble(Console.ReadLine());

        double y9;
        if (x9 < a9_func)
            y9 = Math.Asin(x9) + b9_func * Math.Cos(z9_func * x9 + a9_func);
        else if (x9 >= a9_func && x9 <= 3)
            y9 = Math.Pow(a9_func + b9_func * x9, 2) - Math.Sin(a9_func + z9_func * x9);
        else
            y9 = Math.Sqrt(x9) - Math.Sin(b9_func * x9 + z9_func);

        Console.WriteLine($"y = {y9}");

        //10
        Console.WriteLine("Введите x");
        double x10 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a10_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b10_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите c");
        double c10_func = Convert.ToDouble(Console.ReadLine());

        double y10;
        if (Math.Log(a10_func) == x10)
            y10 = Math.Cos(x10 - b10_func - c10_func);
        else
            y10 = Math.Sin(x10 + a10_func - b10_func);

        Console.WriteLine($"y = {y10}");

        //11
        Console.WriteLine("Введите x");
        double x11 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a11_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b11_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z11_func = Convert.ToDouble(Console.ReadLine());

        double y11;
        if (x11 <= a11_func)
            y11 = Math.Exp(a11_func) - 3.5 * Math.Pow(Math.Cos(2 + b11_func * x11), 2);
        else if (x11 > a11_func && x11 <= 333)
            y11 = a11_func + Math.Log(a11_func + b11_func * x11) - 2 * x11;
        else
            y11 = a11_func + Math.Pow(Math.Cos(a11_func + b11_func * x11 * z11_func), 2);

        Console.WriteLine($"y = {y11}");

        //12
        Console.WriteLine("Введите x");
        double x12 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите k");
        double k12 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите m");
        double m12 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите n");
        double n12 = Convert.ToDouble(Console.ReadLine());

        double y12;
        if (3 * x12 > m12 + n12)
            y12 = Math.Log(k12 * x12 + m12 * n12);
        else if (3 * x12 == Math.Abs(m12 + n12))
            y12 = Math.Sin(k12 * a11_func * n12) + n12 * x12;
        else
            y12 = 0;

        Console.WriteLine($"y = {y12}");

        //13
        Console.WriteLine("Введите x");
        double x13_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите k");
        double k13 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите r");
        double r13 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите s");
        double s13 = Convert.ToDouble(Console.ReadLine());

        double y_13;
        if (Math.Cos(x13_func) == Math.Cos(75))
            y_13 = Math.Exp(2 * k13) + Math.Log(x13_func);
        else if (Math.Cos(x13_func) > Math.Cos(75))
            y_13 = Math.Pow(x13_func, 2) + k13 + 75 * x13_func;
        else
            y_13 = Math.Atan(k13 * x13_func + r13 * s13);

        Console.WriteLine($"y = {y_13}");

        //14
        Console.WriteLine("Введите x");
        double x14 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a14 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b14 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z14 = Convert.ToDouble(Console.ReadLine());

        double y14;
        if (x14 == 3 * a14)
            y14 = 2.53 * Math.Pow(x14, 2) + a14 * x14 - 4.5 * Math.Cos(x14 * z14);
        else if (x14 > a14 && x14 <= 3)
            y14 = Math.Pow(a14, 2) - 5.4 * x14 + Math.Log(x14 * z14);
        else
            y14 = 6.5 * Math.Pow(b14, 2) + (a14 - x14 * z14);

        Console.WriteLine($"y = {y14}");

        //15
        Console.WriteLine("Введите x");
        double x15_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a15 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b15 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите c");
        double c15 = Convert.ToDouble(Console.ReadLine());

        double y15_func;
        if (Math.Pow(x15_func, 2) == a15 + c15)
            y15_func = Math.Pow(Math.Cos(b15 * x15_func), 2) + 5.1 * Math.Pow(c15, 7);
        else if (Math.Pow(x15_func, 2) > a15 + c15)
            y15_func = Math.Cos(Math.Pow(b15, 3) * Math.Pow(x15_func, 2)) + Math.Log(b15 * x15_func - Math.Pow(a15, 2));
        else
            y15_func = 0;

        Console.WriteLine($"y = {y15_func}");

        //16
        Console.WriteLine("Введите x");
        double x16_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a16_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b16_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z16_func = Convert.ToDouble(Console.ReadLine());

        double y16_func;
        if (x16_func < 6.5)
            y16_func = Math.Log(a16_func + Math.Pow(b16_func, 2) * x16_func) + a16_func;
        else if (x16_func >= 6.5 && x16_func <= 625)
            y16_func = Math.Pow(Math.Cos(a16_func * x16_func + x16_func * z16_func), 2) + a16_func;
        else
            y16_func = 0;

        Console.WriteLine($"y = {y16_func}");

        //17
        Console.WriteLine("Введите x");
        double x17_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a17_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b17_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z17_func = Convert.ToDouble(Console.ReadLine());

        double y17_func;
        if (x17_func < a17_func)
            y17_func = a17_func + Math.Sin(b17_func * x17_func) + Math.Pow(Math.Cos(x17_func), 2);
        else if (x17_func >= a17_func && x17_func < Math.Log(b17_func))
            y17_func = -Math.Sqrt(a17_func + b17_func * x17_func + Math.Sin(z17_func * x17_func));
        else
            y17_func = Math.Log(a17_func + b17_func * x17_func + z17_func);

        Console.WriteLine($"y = {y17_func}");

        //18
        Console.WriteLine("Введите x");
        double x18_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a18_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b18_func = Convert.ToDouble(Console.ReadLine());

        double y18_func;
        if (x18_func <= -Math.Log(a18_func))
            y18_func = Math.Pow(3.5 * a18_func - 7.3 * b18_func * x18_func + Math.Sin(2 * x18_func), 2);
        else
            y18_func = Math.Tan(a18_func - x18_func - Math.Pow(x18_func, 2));

        Console.WriteLine($"y = {y18_func}");

        //19
        Console.WriteLine("Введите x");
        double x19_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a19_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b19_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите c");
        double c19_func = Convert.ToDouble(Console.ReadLine());

        double y19_func;
        if (x19_func < a19_func)
            y19_func = c19_func * Math.Sin(37 * x19_func) + b19_func * Math.Sin(c19_func * x19_func + a19_func);
        else if (x19_func >= a19_func && x19_func < 3)
            y19_func = a19_func + Math.Log(b19_func * x19_func) - Math.Pow(Math.Sin(a19_func + c19_func * x19_func), 2);
        else
            y19_func = Math.Cos(a19_func + b19_func * x19_func) + c19_func * x19_func;

        Console.WriteLine($"y = {y19_func}");

        //20
        Console.WriteLine("Введите x");
        double x20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a20_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b20_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите f");
        double f20 = Convert.ToDouble(Console.ReadLine());

        double y20;
        if (x20 <= a20_func)
            y20 = Math.Exp(x20) + f20 * Math.Cos(b20_func * x20);
        else if (x20 > a20_func && x20 <= 3)
            y20 = a20_func + Math.Cos(b20_func * x20) - Math.Log(f20);
        else
            y20 = Math.Pow(Math.Cos(a20_func + b20_func / x20), 2);

        Console.WriteLine($"y = {y20}");

        //21
        Console.WriteLine("Введите x");
        double x21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a21_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b21_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z21_func = Convert.ToDouble(Console.ReadLine());

        double y21;
        if (x21 == a21_func)
            y21 = Math.Acos(Math.Pow(x21, 2)) + b21_func * Math.Sin(z21_func * x21);
        else if (x21 > a21_func && x21 <= 4.53)
            y21 = Math.Atan(a21_func * x21 + z21_func) + Math.Pow(Math.Sin(b21_func * x21), 2);
        else
            y21 = Math.Log(a21_func * x21 - 3) + 27;

        Console.WriteLine($"y = {y21}");

        //22
        Console.WriteLine("Введите x");
        double x22 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a22_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b22_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z22_func = Convert.ToDouble(Console.ReadLine());

        double y22;
        if (x22 < a22_func)
            y22 = a22_func + b22_func * x22 + Math.Pow(Math.Sin(2 * x22), 2);
        else if (x22 >= a22_func && x22 <= b22_func)
            y22 = a22_func + Math.Log(a22_func * b22_func) - z22_func * x22 + Math.Log(x22);
        else
            y22 = Math.Pow(a22_func + Math.Tan(2 * x22), 2) + b22_func * Math.Sin(x22);

        Console.WriteLine($"y = {y22}");

        //23
        Console.WriteLine("Введите x");
        double x23 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a23_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b23_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z23_func = Convert.ToDouble(Console.ReadLine());

        double y23;
        if (x23 <= b23_func && x23 > a23_func)
            y23 = Math.Log(b23_func * z23_func * x23) + Math.Pow(z23_func * a23_func, 3);
        else if (x23 > b23_func)
            y23 = Math.Pow(a23_func * x23, 2) + b23_func * z23_func * a23_func + Math.Pow(Math.Sin(z23_func * x23), 2);
        else
            y23 = Math.Cos(a23_func * x23 + b23_func) + Math.Log(2 * x23);

        Console.WriteLine($"y = {y23}");

        //24
        Console.WriteLine("Введите x");
        double x24 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a24_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b24_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z24_func = Convert.ToDouble(Console.ReadLine());

        double y24;
        if (x24 < a24_func)
            y24 = Math.Pow(x24, 2) + (2 + 7.7 * a24_func * b24_func * x24);
        else if (x24 <= 67)
            y24 = Math.Tan(a24_func * x24 + z24_func) + Math.Cos(b24_func * x24);
        else
            y24 = Math.Log(Math.Pow(Math.Sin(a24_func + b24_func * x24 + 2 * Math.Pow(x24, 7)), 2));

        Console.WriteLine($"y = {y24}");

        //25
        Console.WriteLine("Введите x");
        double x25 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a25_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b25_func = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z25_func = Convert.ToDouble(Console.ReadLine());

        double y25;
        if (x25 < a25_func)
            y25 = a25_func + z25_func * Math.Pow(Math.Cos(b25_func * x25), 2);
        else if (x25 == b25_func)
            y25 = a25_func + Math.Pow(Math.Sin(b25_func * x25), 2) + Math.Log(2 * x25);
        else
            y25 = b25_func + a25_func - 2 * Math.Pow(a25_func - Math.Cos(x25), 2);

        Console.WriteLine($"y = {y25}");

        //26
        Console.WriteLine("Введите x");
        double x26 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z26 = Convert.ToDouble(Console.ReadLine());

        double y26;
        if (x26 < -0.5)
            y26 = Math.Pow(2 * z26 + 1, 2) - Math.Pow(3.71 - Math.Pow(x26, 3), 2);
        else if (x26 > 0.5)
            y26 = Math.Pow(Math.Sin(2 * x26), 2) - 5.111 * 357;
        else
            y26 = 3.5 * x26;

        Console.WriteLine($"y = {y26}");

        //27
        Console.WriteLine("Введите x");
        double x27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите p");
        double p27 = Convert.ToDouble(Console.ReadLine());

        double y27;
        if (x27 < 0.2)
            y27 = Math.Pow(a27 * x27, 3) + Math.Sqrt(Math.Pow(b27, 2)) + 1.7;
        else if (x27 == 0.2)
            y27 = Math.Atan(Math.Pow(2, x27) - p27);
        else
            y27 = Math.Abs(a27) + 4.3 + x27;

        Console.WriteLine($"y = {y27}");

        //28
        Console.WriteLine("Введите x");
        double x28 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a28 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b28 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите c");
        double c28 = Convert.ToDouble(Console.ReadLine());

        double y28;
        if (a28 + b28 > x28)
            y28 = Math.Sin(a28 * c28 * b28) + Math.Pow(x28, 2);
        else if (a28 + b28 == x28)
            y28 = Math.Atan(a28 * b28 * c28) + Math.Sqrt(x28);
        else
            y28 = Math.Asin(Math.Pow(Math.Cos(a28), 2) / x28);

        Console.WriteLine($"y = {y28}");

        //29
        Console.WriteLine("Введите x");
        double x29 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите k");
        double k29 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите r");
        double r29 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите s");
        double s29 = Convert.ToDouble(Console.ReadLine());

        double y29;
        if (x29 == 75)
            y29 = 1 / Math.Tan(x29 * Math.Exp(1) + Math.Log(x29));
        else if (x29 < s29)
            y29 = k29 * Math.Pow(x29, 2) + Math.Pow(Math.Sin(k29 * x29), 2);
        else
            y29 = Math.Atan(k29 * x29 + Math.Tan(75));

        Console.WriteLine($"y = {y29}");

        //30
        Console.WriteLine("Введите x");
        double x30 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a30 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b30 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите z");
        double z30 = Convert.ToDouble(Console.ReadLine());

        double y30;
        if (x30 == a30)
            y30 = a30 + Math.Atan(Math.Sin(b30 * x30)) + Math.Pow(Math.Cos(x30), 2);
        else if (x30 > a30 && x30 < b30)
            y30 = Math.Sqrt(a30 + b30 * x30) + 2 + Math.Sin(z30 * x30);
        else
            y30 = Math.Atan(a30 + b30 * x30 + z30);

        Console.WriteLine($"y = {y30}");

        Console.ReadKey();
    }
}