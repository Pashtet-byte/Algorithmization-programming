using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        //1
        //int A = 1, B = 0, C = 0;

        //Console.WriteLine($"a) = {((A == 1  !(A == 1 && B == 1))  C == 1)}");
        //Console.WriteLine($"б) = {(!(A == 1  B == 1) && (B == 1  C == 1))}");
        //Console.WriteLine($"в) = {((A == 1 || (B == 1 && !(C == 1))) && C == 0)}");

        //2
        //int X = 0, Y = 1, Z = 0;

        //Console.WriteLine($"a) = {(X == 1 && (Z == 1 || Y == 1))}");
        //Console.WriteLine($"б) = {(!(X == 1)  (X == 1 && (Y == 1  Z == 1)))}");
        //Console.WriteLine($"в) = {((X == 1 || Y == 1) && Z == 1)}");

        //3
        //int x = 2, y = 1;

        //Console.WriteLine($"a) = {((!(x < y || x > y)) && (y > x))}");
        //Console.WriteLine($"б) = {(x >= 2 || Math.Pow(y, 2) != 5)}");

        //4
        //int A = 6;

        //Console.WriteLine($"Условие: A % 2 == 0  A % 3 == 0 = {(A % 2 == 0  A % 3 == 0)}");

        //5
        //int A = 3, B = 5;

        //Console.WriteLine($"Условие: A % 2 != 0 && B % 2 != 0 = {(A % 2 == 1 && B % 2 == 1)}");

        //6
        //int X = 0, Y = 0, Z = 1;

        //Console.WriteLine($"a) = {(X == 1 || Y == 1 && !(Z == 1))}");
        //Console.WriteLine($"б) = {(X == 1 && !(Y == 1))}");
        //Console.WriteLine($"в) = {!((X == 1 && Z == 1) || Y == 1)}");

        //7

        //Console.WriteLine("Область определения y = 3/(x-1): x != 1");

        //8
        //int x = 1, y = 2;

        //Console.WriteLine($"a) = {x >= 0 && (Math.Pow(y, 2) != 4)}");
        //Console.WriteLine($"б) = {(x * y != 0) || (y > x)}");

        //9
        //int x = 1, y = 2;
        //Console.WriteLine($"9a) = {!(x * y < 0) || (y > x)}");
        //Console.WriteLine($"9b) = {(x * y != 0) && (y < x)}");

        //10
        //int A = 1, B = 0, C = 1;
        //Console.WriteLine($"10a) = {A == 1 || !(A == 1 && B == 0) || C == 1}");
        //Console.WriteLine($"10b) = {A == 0 || C == 1 && !(B == 0 || C == 1)}");
        //Console.WriteLine($"10c) = {(A == 1 || B == 0 && C == 0) || A == 1}");

        //11
        //int x = 1, y = 2;
        //Console.WriteLine($"11a) = {(!(x * y < 1)) && (y > x)}");
        //int x1 = 2, y1 = 1;
        //Console.WriteLine($"11b) = {(x1 * y1 != 0) || (y1 < x1)}");

        //12
        //int A = 123;
        //Console.WriteLine($"12) = {(A >= 100 && A <= 999)}");

        //13
        //int A = 50, B = 50, C = 40;
        //Console.WriteLine($"13) = {((A < 45) && !(B < 45) && !(C < 45)) || (!(A < 45) && (B < 45) && !(C < 45)) || (!(A < 45) && !(B < 45) && (C < 45))}");

        //14
        //int A = 20;
        //Console.WriteLine($"14) = {(A % 3 != 0) && (A % 10 == 0)}");

        //15
        //int A = 100;
        //Console.WriteLine($"15) = {((A >= -137 && A <= -51) || (A >= 55 && A <= 123))}");

        //16 Записать условие, которое является истинным, когда только одно из чисел X, Y и Z кратно пяти.
        //int X = 10, Y = 16, Z = 3;
        //Console.WriteLine($"16) = {(X % 5 == 0 && Y % 5 != 0 && Z % 5 != 0) || (X % 5 != 0 && Y % 5 == 0 && Z % 5 != 0) || (X % 5 != 0 && Y % 5 != 0 && Z % 5 == 0)}");

        //17
        //int X = 70, Y = 90, Z = 60;
        //Console.WriteLine($"17) = {(X > 80 || Y > 80 || Z > 80)}");

        //18
        //bool A = true, B = false, C = false;
        //Console.WriteLine($"18a) = {A && !B || C}");
        //Console.WriteLine($"18b) = {A && (!B || C)}");
        //sssConsole.WriteLine($"18c) = {A || (!(B && C))}");

        //19
        //bool A = false, B = false, C = true;
        //Console.WriteLine($"19а) = {(!A || !B) && !C}");
        //Console.WriteLine($"19б) = {(!A || !B) && (A || B)}");
        //Console.WriteLine($"19в) = {A && B || A && C || !C}");

        //20
        //int x = 5;
        //Console.WriteLine($"20б) = {(x != 3)}");

        //21
        //bool X = false, Y = false, Z = true;
        //Console.WriteLine($"21а) = {(X && !Y) || Z}");
        //Console.WriteLine($"21б) = {X && (!Y || Z)}");
        //Console.WriteLine($"21в) = {X || (!(Y || Z))}");

        //22
        //int x = 0;
        //Console.WriteLine($"22а) = {(x > -5 && x <= 5)}");
        //double y = 5.0;
        //int x1 = 1;
        //Console.WriteLine($"22б) = {(y > -3.5 && y <= 8.1) && (x1 != 0)}");

        //23
        //int A = 20;
        //Console.WriteLine($"23) = {!((A >= -10 && A <= -1) || (A >= 2 && A <= 15))}");

        //24
        //int A = 5000;
        //Console.WriteLine($"24) = {(A >= 1000 && A <= 9999) && (A != 4999)}");

        //25
        //int A = 1, B = 2, C = 1, D = 3;
        //Console.WriteLine($"25) = {(A * D) > (C * B)}");

        //26
        //int x = -1;
        //Console.WriteLine($"26а) = {(x <= 0 || x >= 5)}"); 
        //int y = 3, x1 = 5;
        //Console.WriteLine($"26б) = {(y > 0 && y <= 6) && (x1 < 7)}");

        //27
        //int x = 4;
        //Console.WriteLine($"27а) = {(x > 3 || x < -1)}");

        //Task - 2

        // 1
        //int A = 3, B = 4;
        //Console.WriteLine($"1а) = {(A % 2 == 0) ^ (B % 2 == 0)}");
        //int A1 = 6, B1 = 9, C1 = 12;
        //Console.WriteLine($"1б) = {A1 % 3 == 0 && B1 % 3 == 0 && C1 % 3 == 0}");

        // 2
        //int N = 14;
        //Console.WriteLine($"2а) = {N % 4 == 0 || N % 7 == 0}");
        //int N2 = 15;
        //Console.WriteLine($"2б) = {N2 % 5 == 0 && N2 % 10 != 0}");

        // 3
        //int n = 2, m = 3, k = 4;
        //Console.WriteLine($"3) = {(n + m > k) && (!(n > k) || (m < 1))}"); // True (5>4 и n<=k)

        // 4
        //int N = 60;
        //Console.WriteLine($"4) = {((!(N % 3 == 0) || (N % 9 != 0)) && (!(N % 4 == 0) || (N % 5 == 0 && N % 24 == 0)))}");

        // 5
        //int n = 3, m = 2, l = 1, k = 0;
        //Console.WriteLine($"5) = {(n > 1 || (m <= l && k == 0)) && (!(n > 2) || (Math.Pow(m, 2) != 1))}");

        // 6
        //double deposit = 60000;
        //double rate = (deposit <= 50000) ? 0.16 : (deposit <= 100000) ? 0.18 : 0;
        //double payout = deposit * (1 + rate);
        //Console.WriteLine($"6) Сумма выплаты: {payout:F2} руб.");

        // 7
        //int N = 14;
        //Console.WriteLine($"7) = {N % 2 == 0 && N % 7 == 0 && N % 11 != 0 && N % 13 != 0}");

        // 8
        //int N = 70;
        //Console.WriteLine($"8) = {N % 3 != 0 && N % 7 == 0 && N % 10 == 0}");

        // 9
        //int k = -1, l = 5, m = 10, n = 2;
        //Console.WriteLine($"9) = {(k == 0 && l > m) || (k < 0 && (2 * l - 3 * n) < m) || (k > 0)}");

        // 10
        //int N = 56;
        //Console.WriteLine($"10) = {(N % 2 == 0) && (N % 3 != 0) && (N % 7 == 0) && (!(N % 5 == 0) || (N % 4 == 0)) && (!(N % 8 == 0) || (N % 11 == 0))}");
    }
}
