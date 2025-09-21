using System;

class Program
{
    static void Main()
    {
        //1
        Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double sumSq = a * a + b * b;
        double sqSum = (a + b) * (a + b);

        if (sumSq > sqSum)
        {
            Console.WriteLine("Сумма квадратов больше");
        }
        else if (sumSq < sqSum)
        {
            Console.WriteLine("Квадрат суммы больше");
        }
        else
        {
            Console.WriteLine("Равны");
        }

        //2
        Console.Write("Введите зарплату: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите стаж: ");
        int exp = Convert.ToInt32(Console.ReadLine());

        double bonus = 0;
        if (exp >= 2 && exp < 5)
        {
            bonus = salary * 0.02;
        }
        else if (exp >= 5 && exp < 10)
        {
            bonus = salary * 0.05;
        }

        Console.WriteLine($"Надбавка: {bonus}");
        Console.WriteLine($"Итого: {salary + bonus}");

        //3
        Console.Write("Введите x0: ");
        double x0 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y0: ");
        double y0 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        double dist1 = Math.Sqrt(x0 * x0 + y0 * y0);
        double dist2 = Math.Sqrt(x1 * x1 + y1 * y1);

        if (dist1 > dist2)
        {
            Console.WriteLine("Точка A дальше");
        }
        else if (dist1 < dist2)
        {
            Console.WriteLine("Точка B дальше");
        }
        else
        {
            Console.WriteLine("Одинаково");
        }

        //4
        Console.Write("Введите сторону a: ");
        double sideA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону b: ");
        double sideB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону c: ");
        double sideC = Convert.ToDouble(Console.ReadLine());

        bool right = (sideA * sideA + sideB * sideB == sideC * sideC) ||
                    (sideA * sideA + sideC * sideC == sideB * sideB) ||
                    (sideB * sideB + sideC * sideC == sideA * sideA);

        if (right)
        {
            Console.WriteLine("Прямоугольный");
        }
        else
        {
            Console.WriteLine("Не прямоугольный");
        }

        //5
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите третье число: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        if (num1 > 0)
        {
            num1 = num1 * num1;
        }
        if (num2 > 0)
        {
            num2 = num2 * num2;
        }
        if (num3 > 0)
        {
            num3 = num3 * num3;
        }

        Console.WriteLine($"{num1}, {num2}, {num3}");

        //6
        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Первая четверть");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Вторая четверть");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Третья четверть");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Четвертая четверть");
        }
        else
        {
            Console.WriteLine("На оси");
        }

        //7
        Console.Write("Введите x: ");
        double xPoint = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y: ");
        double yPoint = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите радиус: ");
        double r = Convert.ToDouble(Console.ReadLine());

        double dist = Math.Sqrt(xPoint * xPoint + yPoint * yPoint);
        if (dist <= r)
        {
            Console.WriteLine("Внутри окружности");
        }
        else
        {
            Console.WriteLine("Снаружи");
        }

        //8
        Console.Write("Введите a1: ");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите c1: ");
        double c1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите a2: ");
        double a2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите c2: ");
        double c2 = Convert.ToDouble(Console.ReadLine());

        double p1 = (a1 + b1 + c1) / 2;
        double area1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));

        double p2 = (a2 + b2 + c2) / 2;
        double area2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));

        if (area1 > area2)
        {
            Console.WriteLine("Первый треугольник больше");
        }
        else if (area1 < area2)
        {
            Console.WriteLine("Второй треугольник больше");
        }
        else
        {
            Console.WriteLine("Равны");
        }

        //9
        Console.Write("Введите сторону квадрата: ");
        double side = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите радиус: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double squareArea = side * side;
        double circleArea = Math.PI * radius * radius;

        if (squareArea > circleArea)
        {
            Console.WriteLine("Квадрат больше");
        }
        else if (squareArea < circleArea)
        {
            Console.WriteLine("Круг больше");
        }
        else
        {
            Console.WriteLine("Равны");
        }

        //10
        Console.Write("Введите первое число: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите третье число: ");
        double n3 = Convert.ToDouble(Console.ReadLine());

        if (n1 > 0)
        {
            n1 = n1 * n1 * n1;
        }
        else
        {
            n1 = 0;
        }
        if (n2 > 0)
        {
            n2 = n2 * n2 * n2;
        }
        else
        {
            n2 = 0;
        }
        if (n3 > 0)
        {
            n3 = n3 * n3 * n3;
        }
        else
        {
            n3 = 0;
        }

        Console.WriteLine($"{n1}, {n2}, {n3}");

        //11
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Четное");
        }
        if (number % 10 == 3)
        {
            Console.WriteLine("Оканчивается на 3");
        }

        //12
        Console.Write("Введите x: ");
        double x12 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y: ");
        double y12 = Convert.ToDouble(Console.ReadLine());

        if (x12 > 0 && y12 > 0)
        {
            Console.WriteLine("В первой четверти");
        }
        else
        {
            Console.WriteLine("Не в первой четверти");
        }

        //13
        Console.Write("Введите сумму вклада: ");
        double money = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите срок (6 или 12): ");
        int months = Convert.ToInt32(Console.ReadLine());

        double percent = 0;
        if (months == 6)
        {
            percent = 0.06;
        }
        else if (months == 12)
        {
            percent = 0.08;
        }

        double monthly = money * percent / 12;
        Console.WriteLine($"Ежемесячно: {monthly}");

        //14
        Console.Write("Введите первое число: ");
        double m1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double m2 = Convert.ToDouble(Console.ReadLine());

        double diffSq = Math.Abs(m1 * m1 - m2 * m2);
        double sqDiff = Math.Abs((m1 - m2) * (m1 - m2));

        if (diffSq > sqDiff)
        {
            Console.WriteLine("Разность квадратов больше");
        }
        else if (diffSq < sqDiff)
        {
            Console.WriteLine("Квадрат разности больше");
        }
        else
        {
            Console.WriteLine("Равны");
        }

        //15
        Console.Write("Введите x0: ");
        double x15_0 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y0: ");
        double y15_0 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите x1: ");
        double x15_1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y1: ");
        double y15_1 = Convert.ToDouble(Console.ReadLine());

        double dist15_1 = Math.Sqrt(x15_0 * x15_0 + y15_0 * y15_0);
        double dist15_2 = Math.Sqrt(x15_1 * x15_1 + y15_1 * y15_1);

        if (dist15_1 < dist15_2)
        {
            Console.WriteLine("Точка A ближе");
        }
        else if (dist15_1 > dist15_2)
        {
            Console.WriteLine("Точка B ближе");
        }
        else
        {
            Console.WriteLine("Одинаково");
        }

        //16
        Console.Write("Введите x: ");
        double x16 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y: ");
        double y16 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите внутренний радиус r: ");
        double r16 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите внешний радиус R: ");
        double R16 = Convert.ToDouble(Console.ReadLine());

        double distance16 = Math.Sqrt(x16 * x16 + y16 * y16);
        if (distance16 >= r16 && distance16 <= R16)
        {
            Console.WriteLine("Точка внутри тора");
        }
        else
        {
            Console.WriteLine("Точка вне тора");
        }

        //17
        Console.Write("Введите x: ");
        double x17 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y: ");
        double y17 = Convert.ToDouble(Console.ReadLine());

        if (x17 > 0 && y17 < 0)
        {
            Console.WriteLine("Точка в четвертой четверти");
        }
        else
        {
            Console.WriteLine("Точка не в четвертой четверти");
        }

        //18
        Console.Write("Введите сторону a: ");
        double a18 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону b: ");
        double b18 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону c: ");
        double c18 = Convert.ToDouble(Console.ReadLine());

        if (a18 == b18 || a18 == c18 || b18 == c18)
        {
            Console.WriteLine("Треугольник равнобедренный");
        }
        else
        {
            Console.WriteLine("Треугольник не равнобедренный");
        }

        //19
        Console.Write("Введите a: ");
        int a19 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите b: ");
        int b19 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите c: ");
        int c19 = Convert.ToInt32(Console.ReadLine());

        bool isPythagorean = (c19 * c19 == a19 * a19 + b19 * b19) ||
                            (a19 * a19 == b19 * b19 + c19 * c19) ||
                            (b19 * b19 == a19 * a19 + c19 * c19);

        if (isPythagorean)
        {
            Console.WriteLine("Числа являются тройкой Пифагора");
        }
        else
        {
            Console.WriteLine("Числа не являются тройкой Пифагора");
        }

        //20
        Console.Write("Введите первую скорость (л/с): ");
        double speed1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вторую скорость (м³/мин): ");
        double speed2 = Convert.ToDouble(Console.ReadLine());

        double speed1_m3s = speed1 * 0.001;
        double speed2_m3s = speed2 / 60;

        if (speed1_m3s > speed2_m3s)
        {
            Console.WriteLine("Первая скорость больше");
        }
        else if (speed1_m3s < speed2_m3s)
        {
            Console.WriteLine("Вторая скорость больше");
        }
        else
        {
            Console.WriteLine("Скорости равны");
        }

        //21
        Console.Write("Введите площадь круга: ");
        double circleArea21 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите площадь квадрата: ");
        double squareArea21 = Convert.ToDouble(Console.ReadLine());

        double circleDiameter = 2 * Math.Sqrt(circleArea21 / Math.PI);
        double squareSide = Math.Sqrt(squareArea21);

        double squareDiagonal = squareSide * Math.Sqrt(2);
        double circleDiameter2 = 2 * Math.Sqrt(circleArea21 / Math.PI);

        bool circleInSquare = circleDiameter <= squareSide;
        bool squareInCircle = squareDiagonal <= circleDiameter2;

        Console.WriteLine($"Круг уместится в квадрате: {circleInSquare}");
        Console.WriteLine($"Квадрат уместится в круге: {squareInCircle}");

        //22
        Console.Write("Введите массу первого тела: ");
        double mass1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите объем первого тела: ");
        double volume1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите массу второго тела: ");
        double mass2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите объем второго тела: ");
        double volume2 = Convert.ToDouble(Console.ReadLine());

        double density1 = mass1 / volume1;
        double density2 = mass2 / volume2;

        if (density1 > density2)
        {
            Console.WriteLine("Первый материал имеет большую плотность");
        }
        else if (density1 < density2)
        {
            Console.WriteLine("Второй материал имеет большую плотность");
        }
        else
        {
            Console.WriteLine("Плотности материалов равны");
        }

        //23
        Console.Write("Введите скорость в км/ч: ");
        double kmh = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите скорость в м/с: ");
        double ms = Convert.ToDouble(Console.ReadLine());

        double msConverted = kmh * 1000 / 3600;

        if (msConverted > ms)
        {
            Console.WriteLine("Скорость в км/ч больше");
        }
        else if (msConverted < ms)
        {
            Console.WriteLine("Скорость в м/с больше");
        }
        else
        {
            Console.WriteLine("Скорости равны");
        }

        //24
        Console.Write("Введите площадь треугольника: ");
        double triangleArea = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите площадь круга: ");
        double circleArea24 = Convert.ToDouble(Console.ReadLine());

        double a24 = Math.Sqrt(4 * triangleArea / Math.Sqrt(3));

        double r24 = Math.Sqrt(circleArea24 / Math.PI);

        double rInscribed = a24 * Math.Sqrt(3) / 6;

        double rCircumscribed = a24 * Math.Sqrt(3) / 3;

        bool circleInTriangle = r24 <= rInscribed;
        bool triangleInCircle = rCircumscribed <= r24;

        Console.WriteLine($"Круг уместится в треугольнике: {circleInTriangle}");
        Console.WriteLine($"Треугольник уместится в круге: {triangleInCircle}");

        //25
        Console.Write("Введите сопротивление первого участка: ");
        double resistance1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите напряжение первого участка: ");
        double voltage1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сопротивление второго участка: ");
        double resistance2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите напряжение второго участка: ");
        double voltage2 = Convert.ToDouble(Console.ReadLine());

        double current1 = voltage1 / resistance1;
        double current2 = voltage2 / resistance2;

        if (current1 < current2)
        {
            Console.WriteLine("Меньший ток на первом участке");
        }
        else if (current1 > current2)
        {
            Console.WriteLine("Меньший ток на втором участке");
        }
        else
        {
            Console.WriteLine("Токи равны");
        }

        //26
        double mv = 4.86e27;
        double rv = 617500000;
        double mc = 5.68e29;
        double rs = 5775000000;
        double G = 6.7e-8;

        double gv = G * mv / (rv * rv);
        double gs = G * mc / (rs * rs);

        if (gv > gs)
        {
            Console.WriteLine("Венера имеет большее ускорение свободного падения");
        }
        else if (gv < gs)
        {
            Console.WriteLine("Сатурн имеет большее ускорение свободного падения");
        }
        else
        {
            Console.WriteLine("Ускорения равны");
        }

        //27
        Console.Write("Введите текущее время (0-24): ");
        int time = Convert.ToInt32(Console.ReadLine());

        if (time >= 0 && time < 12)
        {
            Console.WriteLine("am");
        }
        else if (time >= 12 && time <= 24)
        {
            Console.WriteLine("pm");
        }
        else
        {
            Console.WriteLine("Некорректное время");
        }

        //28
        Console.Write("Введите долготу: ");
        double longitude = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите широту: ");
        double latitude = Convert.ToDouble(Console.ReadLine());

        if (longitude >= 0)
        {
            Console.WriteLine("Восточное полушарие");
        }
        else
        {
            Console.WriteLine("Западное полушарие");
        }

        //29
        double sirius = 8.14e12;
        double arcturus_pc = 103;

        double arcturus_km = arcturus_pc * 3.08567758e13;

        if (sirius > arcturus_km)
        {
            Console.WriteLine("Сириус дальше");
        }
        else if (sirius < arcturus_km)
        {
            Console.WriteLine("Арктур дальше");
        }
        else
        {
            Console.WriteLine("Расстояния равны");
        }

        //30
        Console.Write("Введите натуральное число: ");
        int number30 = Convert.ToInt32(Console.ReadLine());

        if (number30 % 2 == 0)
        {
            Console.WriteLine("Число четное");
        }
        if (number30 % 10 == 7)
        {
            Console.WriteLine("Число оканчивается на 7");
        }
        if (number30 % 2 != 0 && number30 % 10 != 7)
        {
            Console.WriteLine("Число нечетное и не оканчивается на 7");
        }

        Console.ReadKey();
    }
}