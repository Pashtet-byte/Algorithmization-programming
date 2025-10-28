﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace AllClassesDemo
{
    // Раздел 1: Основы ООП (1-15)
    class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Some sound");
        }
    }

    class Car
    {
        public string Brand;
        public string Model;
        public int Year;
    }

    class Person
    {
        public string Name;
        public int Age;
    }

    class Rectangle
    {
        public double Width;
        public double Height;
    }

    class Student
    {
        public string Name;
        public int Age;
        public double GPA;
    }

    class Book
    {
        public string Title;
        public string Author;
        public int Pages;
    }

    class Circle
    {
        public double Radius;
    }

    class BankAccount
    {
        public decimal Balance;
    }

    class Temperature
    {
        public double Value;
    }

    class Time
    {
        public int Hours;
        public int Minutes;
        public int Seconds;
    }

    class Point
    {
        public double X;
        public double Y;
        public double Z;
    }

    class Color
    {
        public int R;
        public int G;
        public int B;
    }

    class Email
    {
        public string Address;
    }

    class PhoneNumber
    {
        public string Number;
    }

    class URL
    {
        public string Address;
    }

    // Раздел 2: Классы и Объекты (16-30)
    class Dog
    {
        public string Name;

        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    class RectangleWithArea
    {
        public double Width;
        public double Height;

        public double GetArea()
        {
            return Width * Height;
        }
    }

    class Triangle
    {
        public double SideA;
        public double SideB;
        public double SideC;
    }

    class Employee
    {
        public string Name;
        public decimal Salary;
    }

    class Product
    {
        public string Name;
        public decimal Price;
        public int Quantity;
    }

    class StudentWithGPA
    {
        public string Name;
        public int Age;
        public double GPA;
    }

    class House
    {
        public int Rooms;
        public double Area;
    }

    class Account
    {
        public string AccountNumber;
        public decimal Balance;
    }

    class Bicycle
    {
        public int Gears;
    }

    class Computer
    {
        public string Processor;
        public int RAM;
    }

    class Flower
    {
        public string Name;
        public string Color;
    }

    class Laptop
    {
        public double ScreenSize;
        public int BatteryLife;
    }

    class Pen
    {
        public string Color;
        public string Brand;
    }

    class CoffeeCup
    {
        public double Capacity;
        public string Material;
    }

    class BookInfo
    {
        public string Title;
        public string Author;
        public int Pages;
        public string ISBN;
    }

    // Раздел 3: Члены Класса (31-45)
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class StringHelper
    {
        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    class MathHelper
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }

    class TemperatureConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }

    class LengthConverter
    {
        public double MetersToFeet(double meters)
        {
            return meters * 3.28084;
        }

        public double FeetToMeters(double feet)
        {
            return feet / 3.28084;
        }
    }

    class WeightConverter
    {
        public double KilogramsToPounds(double kg)
        {
            return kg * 2.20462;
        }

        public double PoundsToKilograms(double pounds)
        {
            return pounds / 2.20462;
        }
    }

    class ArrayHelper
    {
        public int FindMax(int[] array)
        {
            if (array.Length == 0) return 0;

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
    }

    class StringValidator
    {
        public bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }

    class NumberChecker
    {
        public bool IsPrime(int number)
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
    }

    class DateHelper
    {
        public string GetDayOfWeek(DateTime date)
        {
            return date.DayOfWeek.ToString();
        }
    }

    class FileHelper
    {
        public string ReadFile(string filePath)
        {
            try
            {
                return System.IO.File.ReadAllText(filePath);
            }
            catch
            {
                return "File not found or cannot be read";
            }
        }
    }

    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }

    class Validator
    {
        public bool IsValidPassword(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit);
        }
    }

    class Formatter
    {
        public string FormatText(string text)
        {
            return text.Trim().ToUpper();
        }
    }

    class Counter
    {
        private int count;

        public void Increment()
        {
            count++;
        }

        public void Decrement()
        {
            count--;
        }

        public int GetCount()
        {
            return count;
        }
    }

    // Раздел 4: Свойства (46-60)
    class PersonWithProperty
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class StudentWithGPAProperty
    {
        private double gpa;

        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }
    }

    class BankAccountWithProperty
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }

    class ProductWithProperty
    {
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }

    class CarWithProperty
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }

    class TemperatureWithProperty
    {
        private double celsius;

        public double Celsius
        {
            get { return celsius; }
            set { celsius = value; }
        }
    }

    class RectangleWithProperties
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
    }

    class CircleWithProperty
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
    }

    class EmployeeWithProperty
    {
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }

    class BookWithProperties
    {
        private string title;
        private string author;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
    }

    class HouseWithProperty
    {
        private double area;

        public double Area
        {
            get { return area; }
            set { area = value; }
        }
    }

    class ComputerWithProperty
    {
        private int ram;

        public int RAM
        {
            get { return ram; }
            set { ram = value; }
        }
    }

    class AccountWithProperty
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }

    class VehicleWithProperty
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    }

    class ColorWithProperties
    {
        private int red;
        private int green;
        private int blue;

        public int Red
        {
            get { return red; }
            set { red = value; }
        }

        public int Green
        {
            get { return green; }
            set { green = value; }
        }

        public int Blue
        {
            get { return blue; }
            set { blue = value; }
        }
    }

    // Раздел 5: ReadOnly Свойства (61-75)
    class PersonWithReadOnlyAge
    {
        private readonly int age;

        public int Age
        {
            get { return age; }
        }

        public PersonWithReadOnlyAge(int initialAge)
        {
            age = initialAge;
        }
    }

    class StudentWithReadOnlyID
    {
        private readonly int id;

        public int ID
        {
            get { return id; }
        }

        public StudentWithReadOnlyID(int studentId)
        {
            id = studentId;
        }
    }

    class BankAccountWithReadOnlyNumber
    {
        private readonly string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public BankAccountWithReadOnlyNumber(string accNumber)
        {
            accountNumber = accNumber;
        }
    }

    class ProductWithReadOnlyCode
    {
        private readonly string code;

        public string Code
        {
            get { return code; }
        }

        public ProductWithReadOnlyCode(string productCode)
        {
            code = productCode;
        }
    }

    class EmployeeWithReadOnlyID
    {
        private readonly int employeeId;

        public int EmployeeID
        {
            get { return employeeId; }
        }

        public EmployeeWithReadOnlyID(int id)
        {
            employeeId = id;
        }
    }

    class CarWithReadOnlyVIN
    {
        private readonly string vin;

        public string VIN
        {
            get { return vin; }
        }

        public CarWithReadOnlyVIN(string carVIN)
        {
            vin = carVIN;
        }
    }

    class HouseWithReadOnlyAddress
    {
        private readonly string address;

        public string Address
        {
            get { return address; }
        }

        public HouseWithReadOnlyAddress(string houseAddress)
        {
            address = houseAddress;
        }
    }

    class BookWithReadOnlyISBN
    {
        private readonly string isbn;

        public string ISBN
        {
            get { return isbn; }
        }

        public BookWithReadOnlyISBN(string bookISBN)
        {
            isbn = bookISBN;
        }
    }

    class ComputerWithReadOnlySerial
    {
        private readonly string serialNumber;

        public string SerialNumber
        {
            get { return serialNumber; }
        }

        public ComputerWithReadOnlySerial(string serial)
        {
            serialNumber = serial;
        }
    }

    class DocumentWithReadOnlyDate
    {
        private readonly DateTime createdDate;

        public DateTime CreatedDate
        {
            get { return createdDate; }
        }

        public DocumentWithReadOnlyDate()
        {
            createdDate = DateTime.Now;
        }
    }

    class OrderWithReadOnlyID
    {
        private readonly int orderId;

        public int OrderID
        {
            get { return orderId; }
        }

        public OrderWithReadOnlyID(int id)
        {
            orderId = id;
        }
    }

    class InvoiceWithReadOnlyNumber
    {
        private readonly string invoiceNumber;

        public string InvoiceNumber
        {
            get { return invoiceNumber; }
        }

        public InvoiceWithReadOnlyNumber(string number)
        {
            invoiceNumber = number;
        }
    }

    class UserWithReadOnlyUID
    {
        private readonly string uid;

        public string UID
        {
            get { return uid; }
        }

        public UserWithReadOnlyUID(string userId)
        {
            uid = userId;
        }
    }

    class DeviceWithReadOnlyMAC
    {
        private readonly string macAddress;

        public string MAC
        {
            get { return macAddress; }
        }

        public DeviceWithReadOnlyMAC(string mac)
        {
            macAddress = mac;
        }
    }

    class TicketWithReadOnlyNumber
    {
        private readonly int ticketNumber;

        public int TicketNumber
        {
            get { return ticketNumber; }
        }

        public TicketWithReadOnlyNumber(int number)
        {
            ticketNumber = number;
        }
    }

    // Раздел 6: WriteOnly Свойства (76-85)
    class UserWithWriteOnlyPassword
    {
        private string password;

        public string Password
        {
            set { password = value; }
        }

        public bool CheckPassword(string inputPassword)
        {
            return password == inputPassword;
        }
    }

    class BankAccountWithWriteOnlyPIN
    {
        private string pin;

        public string PIN
        {
            set { pin = value; }
        }

        public bool VerifyPIN(string inputPIN)
        {
            return pin == inputPIN;
        }
    }

    class SecureDocument
    {
        private string encryptionKey;

        public string EncryptionKey
        {
            set { encryptionKey = value; }
        }

        public string Encrypt(string data)
        {
            return $"Encrypted({data}) with key: {encryptionKey.Substring(0, 3)}...";
        }
    }

    class AccountWithWriteOnlyToken
    {
        private string token;

        public string Token
        {
            set { token = value; }
        }

        public bool IsValidToken()
        {
            return !string.IsNullOrEmpty(token);
        }
    }

    class LoggerWithWriteOnlyApiKey
    {
        private string apiKey;

        public string ApiKey
        {
            set { apiKey = value; }
        }

        public void LogWithKey(string message)
        {
            Console.WriteLine($"[API: {apiKey.Substring(0, 5)}...] {message}");
        }
    }

    class EmailService
    {
        private string smtpPassword;

        public string SMTPPassword
        {
            set { smtpPassword = value; }
        }

        public void SendEmail(string to, string subject)
        {
            Console.WriteLine($"Sending email to {to} with password: {smtpPassword.Substring(0, 3)}...");
        }
    }

    class SecureConnection
    {
        private string connectionString;

        public string ConnectionString
        {
            set { connectionString = value; }
        }

        public void Connect()
        {
            Console.WriteLine($"Connecting with: {connectionString.Substring(0, 10)}...");
        }
    }

    class Authenticator
    {
        private string secret;

        public string Secret
        {
            set { secret = value; }
        }

        public string GenerateToken()
        {
            return $"Token based on: {secret.Substring(0, 3)}...";
        }
    }

    class PaymentService
    {
        private string creditCard;

        public string CreditCard
        {
            set { creditCard = value; }
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} with card ending: {creditCard.Substring(creditCard.Length - 4)}");
        }
    }

    class VPNClient
    {
        private string vpnPassword;

        public string VPNPassword
        {
            set { vpnPassword = value; }
        }

        public void ConnectToVPN()
        {
            Console.WriteLine("Connected to VPN securely");
        }
    }

    // Раздел 7: Конструкторы (86-100)
    class PersonWithConstructor
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public PersonWithConstructor(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class StudentWithConstructor
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public StudentWithConstructor(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }

    class RectangleWithConstructor
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public RectangleWithConstructor(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double GetArea()
        {
            return Length * Width;
        }
    }

    class CircleWithConstructor
    {
        public double Radius { get; set; }

        public CircleWithConstructor(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class BankAccountWithConstructor
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccountWithConstructor(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
    }

    class CarWithConstructor
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public CarWithConstructor(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }

    class BookWithConstructor
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public BookWithConstructor(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }
    }

    class EmployeeWithConstructor
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public EmployeeWithConstructor(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    class ProductWithConstructor
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ProductWithConstructor(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    class HouseWithConstructor
    {
        public string Address { get; set; }
        public int Rooms { get; set; }

        public HouseWithConstructor(string address, int rooms)
        {
            Address = address;
            Rooms = rooms;
        }
    }

    class TriangleWithConstructor
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public TriangleWithConstructor(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }

    class TimeWithConstructor
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public TimeWithConstructor(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public string GetTime()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }
    }

    class TemperatureWithConstructor
    {
        public double Celsius { get; set; }

        public TemperatureWithConstructor(double celsius)
        {
            Celsius = celsius;
        }

        public double ToFahrenheit()
        {
            return (Celsius * 9 / 5) + 32;
        }
    }

    class ColorWithConstructor
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public ColorWithConstructor(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public string GetHexColor()
        {
            return $"#{R:X2}{G:X2}{B:X2}";
        }
    }

    class PointWithConstructor
    {
        public double X { get; set; }
        public double Y { get; set; }

        public PointWithConstructor(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ДЕМОНСТРАЦИЯ ВСЕХ 100 КЛАССОВ ===\n");

            // Раздел 1: Основы ООП (1-15)
            Console.WriteLine("=== РАЗДЕЛ 1: Основы ООП ===\n");

            // 1. Animal
            Animal animal = new Animal();
            Console.Write("1. Animal sound: ");
            animal.MakeSound();

            // 2. Car
            Car car = new Car();
            car.Brand = "Toyota";
            car.Model = "Camry";
            car.Year = 2022;
            Console.WriteLine($"2. Car: {car.Brand} {car.Model} {car.Year}");

            // 3. Person
            Person person = new Person();
            person.Name = "John";
            person.Age = 25;
            Console.WriteLine($"3. Person: {person.Name}, {person.Age} years");

            // 4. Rectangle
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5.0;
            rectangle.Height = 3.0;
            Console.WriteLine($"4. Rectangle: {rectangle.Width}x{rectangle.Height}");

            // 5. Student
            Student student1 = new Student();
            student1.Name = "Иван";
            student1.Age = 18;
            student1.GPA = 4.5;
            Console.WriteLine($"5. Student: {student1.Name}, возраст: {student1.Age}, GPA: {student1.GPA}");

            // 6. Book
            Book book = new Book();
            book.Title = "Война и мир";
            book.Author = "Лев Толстой";
            book.Pages = 1225;
            Console.WriteLine($"6. Book: {book.Title} by {book.Author}, {book.Pages} pages");

            // 7. Circle
            Circle circle = new Circle();
            circle.Radius = 5.0;
            Console.WriteLine($"7. Circle radius: {circle.Radius}");

            // 8. BankAccount
            BankAccount account = new BankAccount();
            account.Balance = 1000.50m;
            Console.WriteLine($"8. Account balance: {account.Balance}");

            // 9. Temperature
            Temperature temp = new Temperature();
            temp.Value = 25.5;
            Console.WriteLine($"9. Temperature: {temp.Value}°C");

            // 10. Time
            Time time = new Time();
            time.Hours = 14;
            time.Minutes = 30;
            time.Seconds = 45;
            Console.WriteLine($"10. Time: {time.Hours}:{time.Minutes}:{time.Seconds}");

            // 11. Point
            Point point = new Point();
            point.X = 3.0;
            point.Y = 4.0;
            point.Z = 5.0;
            Console.WriteLine($"11. Point coordinates: ({point.X}, {point.Y}, {point.Z})");

            // 12. Color
            Color color = new Color();
            color.R = 255;
            color.G = 128;
            color.B = 0;
            Console.WriteLine($"12. Color: R={color.R}, G={color.G}, B={color.B}");

            // 13. Email
            Email email = new Email();
            email.Address = "user@example.com";
            Console.WriteLine($"13. Email: {email.Address}");

            // 14. PhoneNumber
            PhoneNumber phone = new PhoneNumber();
            phone.Number = "+1234567890";
            Console.WriteLine($"14. Phone: {phone.Number}");

            // 15. URL
            URL url = new URL();
            url.Address = "https://example.com";
            Console.WriteLine($"15. URL: {url.Address}\n");

            // Раздел 2: Классы и Объекты (16-30)
            Console.WriteLine("=== РАЗДЕЛ 2: Классы и Объекты ===\n");

            // 16. Dog
            Dog dog = new Dog();
            dog.Name = "Buddy";
            Console.Write("16. Dog: ");
            dog.Bark();

            // 17. Rectangle с площадью
            RectangleWithArea rectArea = new RectangleWithArea();
            rectArea.Width = 5.0;
            rectArea.Height = 3.0;
            Console.WriteLine($"17. Rectangle area: {rectArea.GetArea()}");

            // 18. Triangle
            Triangle triangle = new Triangle();
            triangle.SideA = 3.0;
            triangle.SideB = 4.0;
            triangle.SideC = 5.0;
            Console.WriteLine($"18. Triangle sides: {triangle.SideA}, {triangle.SideB}, {triangle.SideC}");

            // 19. Employee
            Employee employee = new Employee();
            employee.Name = "Alice";
            employee.Salary = 50000;
            Console.WriteLine($"19. Employee: {employee.Name}, Salary: {employee.Salary}");

            // 20. Product
            Product product = new Product();
            product.Name = "Laptop";
            product.Price = 999.99m;
            product.Quantity = 10;
            Console.WriteLine($"20. Product: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");

            // 21. Student с GPA
            StudentWithGPA studentGPA = new StudentWithGPA();
            studentGPA.Name = "John";
            studentGPA.Age = 20;
            studentGPA.GPA = 3.8;
            Console.WriteLine($"21. Student: {studentGPA.Name}, Age: {studentGPA.Age}, GPA: {studentGPA.GPA}");

            // 22. House
            House house = new House();
            house.Rooms = 4;
            house.Area = 120.5;
            Console.WriteLine($"22. House: {house.Rooms} rooms, {house.Area} m²");

            // 23. Account
            Account bankAccount = new Account();
            bankAccount.AccountNumber = "123456789";
            bankAccount.Balance = 1500.75m;
            Console.WriteLine($"23. Account: {bankAccount.AccountNumber}, Balance: {bankAccount.Balance}");

            // 24. Bicycle
            Bicycle bicycle = new Bicycle();
            bicycle.Gears = 21;
            Console.WriteLine($"24. Bicycle gears: {bicycle.Gears}");

            // 25. Computer
            Computer computer = new Computer();
            computer.Processor = "Intel i7";
            computer.RAM = 16;
            Console.WriteLine($"25. Computer: {computer.Processor}, {computer.RAM}GB RAM");

            // 26. Flower
            Flower flower = new Flower();
            flower.Name = "Rose";
            flower.Color = "Red";
            Console.WriteLine($"26. Flower: {flower.Name}, Color: {flower.Color}");

            // 27. Laptop
            Laptop laptop = new Laptop();
            laptop.ScreenSize = 15.6;
            laptop.BatteryLife = 8;
            Console.WriteLine($"27. Laptop: {laptop.ScreenSize}\", Battery: {laptop.BatteryLife}h");

            // 28. Pen
            Pen pen = new Pen();
            pen.Color = "Blue";
            pen.Brand = "Parker";
            Console.WriteLine($"28. Pen: {pen.Brand}, Color: {pen.Color}");

            // 29. CoffeeCup
            CoffeeCup cup = new CoffeeCup();
            cup.Capacity = 350.0;
            cup.Material = "Ceramic";
            Console.WriteLine($"29. Coffee cup: {cup.Capacity}ml, {cup.Material}");

            // 30. Book с информацией
            BookInfo bookInfo = new BookInfo();
            bookInfo.Title = "1984";
            bookInfo.Author = "George Orwell";
            bookInfo.Pages = 328;
            bookInfo.ISBN = "978-0451524935";
            Console.WriteLine($"30. Book: {bookInfo.Title} by {bookInfo.Author}, {bookInfo.Pages} pages, ISBN: {bookInfo.ISBN}\n");

            // Раздел 3: Члены Класса (31-45)
            Console.WriteLine("=== РАЗДЕЛ 3: Члены Класса ===\n");

            // 31. Calculator
            Calculator calculator = new Calculator();
            int result = calculator.Add(5, 3);
            Console.WriteLine($"31. Calculator: 5 + 3 = {result}");

            // 32. StringHelper
            StringHelper stringHelper = new StringHelper();
            string reversed = stringHelper.Reverse("hello");
            Console.WriteLine($"32. StringHelper: 'hello' reversed is '{reversed}'");

            // 33. MathHelper
            MathHelper mathHelper = new MathHelper();
            int max = mathHelper.Max(10, 20);
            Console.WriteLine($"33. MathHelper: Max(10, 20) = {max}");

            // 34. TemperatureConverter
            TemperatureConverter tempConverter = new TemperatureConverter();
            double fahrenheit = tempConverter.CelsiusToFahrenheit(25);
            Console.WriteLine($"34. TemperatureConverter: 25°C = {fahrenheit}°F");

            // 35. LengthConverter
            LengthConverter lengthConverter = new LengthConverter();
            double feet = lengthConverter.MetersToFeet(10);
            Console.WriteLine($"35. LengthConverter: 10m = {feet}ft");

            // 36. WeightConverter
            WeightConverter weightConverter = new WeightConverter();
            double pounds = weightConverter.KilogramsToPounds(10);
            Console.WriteLine($"36. WeightConverter: 10kg = {pounds}lb");

            // 37. ArrayHelper
            ArrayHelper arrayHelper = new ArrayHelper();
            int[] numbers = { 3, 7, 2, 9, 1 };
            int arrayMax = arrayHelper.FindMax(numbers);
            Console.WriteLine($"37. ArrayHelper: Max in [3,7,2,9,1] = {arrayMax}");

            // 38. StringValidator
            StringValidator stringValidator = new StringValidator();
            bool isValidEmail = stringValidator.IsValidEmail("test@example.com");
            Console.WriteLine($"38. StringValidator: 'test@example.com' = {isValidEmail}");

            // 39. NumberChecker
            NumberChecker numberChecker = new NumberChecker();
            bool isPrime = numberChecker.IsPrime(7);
            Console.WriteLine($"39. NumberChecker: 7 is prime = {isPrime}");

            // 40. DateHelper
            DateHelper dateHelper = new DateHelper();
            string dayOfWeek = dateHelper.GetDayOfWeek(DateTime.Now);
            Console.WriteLine($"40. DateHelper: Today is {dayOfWeek}");

            // 41. FileHelper
            FileHelper fileHelper = new FileHelper();
            string fileContent = fileHelper.ReadFile("test.txt");
            Console.WriteLine($"41. FileHelper: {fileContent}");

            // 42. Logger
            Logger logger = new Logger();
            Console.Write("42. Logger: ");
            logger.Log("Application started");

            // 43. Validator
            Validator validator = new Validator();
            bool isValidPassword = validator.IsValidPassword("StrongPass123");
            Console.WriteLine($"43. Validator: 'StrongPass123' = {isValidPassword}");

            // 44. Formatter
            Formatter formatter = new Formatter();
            string formatted = formatter.FormatText("  hello world  ");
            Console.WriteLine($"44. Formatter: '  hello world  ' -> '{formatted}'");

            // 45. Counter
            Counter counter = new Counter();
            counter.Increment();
            counter.Increment();
            counter.Decrement();
            Console.WriteLine($"45. Counter: {counter.GetCount()}\n");

            // Раздел 4: Свойства (46-60)
            Console.WriteLine("=== РАЗДЕЛ 4: Свойства ===\n");

            // 46. Person со свойством Name
            PersonWithProperty personProp = new PersonWithProperty();
            personProp.Name = "Александр";
            Console.WriteLine($"46. Person with property: {personProp.Name}");

            // 47. Student со свойством GPA
            StudentWithGPAProperty studentProp = new StudentWithGPAProperty();
            studentProp.GPA = 4.5;
            Console.WriteLine($"47. Student GPA: {studentProp.GPA}");

            // 48. BankAccount со свойством Balance
            BankAccountWithProperty accountProp = new BankAccountWithProperty();
            accountProp.Balance = 1500.75m;
            Console.WriteLine($"48. Account Balance: {accountProp.Balance}");

            // 49. Product со свойством Price
            ProductWithProperty productProp = new ProductWithProperty();
            productProp.Price = 99.99m;
            Console.WriteLine($"49. Product Price: {productProp.Price}");

            // 50. Car со свойством Speed
            CarWithProperty carProp = new CarWithProperty();
            carProp.Speed = 120;
            Console.WriteLine($"50. Car Speed: {carProp.Speed} km/h");

            // 51. Temperature со свойством Celsius
            TemperatureWithProperty tempProp = new TemperatureWithProperty();
            tempProp.Celsius = 25.5;
            Console.WriteLine($"51. Temperature: {tempProp.Celsius}°C");

            // 52. Rectangle со свойствами Width и Height
            RectangleWithProperties rectProps = new RectangleWithProperties();
            rectProps.Width = 5.0;
            rectProps.Height = 3.0;
            Console.WriteLine($"52. Rectangle: {rectProps.Width}x{rectProps.Height}");

            // 53. Circle со свойством Radius
            CircleWithProperty circleProp = new CircleWithProperty();
            circleProp.Radius = 7.5;
            Console.WriteLine($"53. Circle Radius: {circleProp.Radius}");

            // 54. Employee со свойством Salary
            EmployeeWithProperty employeeProp = new EmployeeWithProperty();
            employeeProp.Salary = 75000;
            Console.WriteLine($"54. Employee Salary: {employeeProp.Salary}");

            // 55. Book со свойствами Title и Author
            BookWithProperties bookProps = new BookWithProperties();
            bookProps.Title = "Преступление и наказание";
            bookProps.Author = "Фёдор Достоевский";
            Console.WriteLine($"55. Book: {bookProps.Title} by {bookProps.Author}");

            // 56. House со свойством Area
            HouseWithProperty houseProp = new HouseWithProperty();
            houseProp.Area = 150.75;
            Console.WriteLine($"56. House Area: {houseProp.Area} m²");

            // 57. Computer со свойством RAM
            ComputerWithProperty computerProp = new ComputerWithProperty();
            computerProp.RAM = 32;
            Console.WriteLine($"57. Computer RAM: {computerProp.RAM} GB");

            // 58. Account со свойством Username
            AccountWithProperty accountUser = new AccountWithProperty();
            accountUser.Username = "john_doe";
            Console.WriteLine($"58. Account Username: {accountUser.Username}");

            // 59. Vehicle со свойством Brand
            VehicleWithProperty vehicleProp = new VehicleWithProperty();
            vehicleProp.Brand = "Toyota";
            Console.WriteLine($"59. Vehicle Brand: {vehicleProp.Brand}");

            // 60. Color со свойствами Red, Green, Blue
            ColorWithProperties colorProps = new ColorWithProperties();
            colorProps.Red = 255;
            colorProps.Green = 128;
            colorProps.Blue = 0;
            Console.WriteLine($"60. Color: R={colorProps.Red}, G={colorProps.Green}, B={colorProps.Blue}\n");

            // Раздел 5: ReadOnly Свойства (61-75)
            Console.WriteLine("=== РАЗДЕЛ 5: ReadOnly Свойства ===\n");

            // 61. Person со свойством Age (readonly)
            PersonWithReadOnlyAge personReadOnly = new PersonWithReadOnlyAge(30);
            Console.WriteLine($"61. Person Age: {personReadOnly.Age}");

            // 62. Student со свойством ID (readonly)
            StudentWithReadOnlyID studentReadOnly = new StudentWithReadOnlyID(101);
            Console.WriteLine($"62. Student ID: {studentReadOnly.ID}");

            // 63. BankAccount со свойством AccountNumber (readonly)
            BankAccountWithReadOnlyNumber accountReadOnly = new BankAccountWithReadOnlyNumber("123456789");
            Console.WriteLine($"63. Account Number: {accountReadOnly.AccountNumber}");

            // 64. Product со свойством Code (readonly)
            ProductWithReadOnlyCode productReadOnly = new ProductWithReadOnlyCode("PRD-001");
            Console.WriteLine($"64. Product Code: {productReadOnly.Code}");

            // 65. Employee со свойством EmployeeID (readonly)
            EmployeeWithReadOnlyID employeeReadOnly = new EmployeeWithReadOnlyID(5001);
            Console.WriteLine($"65. Employee ID: {employeeReadOnly.EmployeeID}");

            // 66. Car со свойством VIN (readonly)
            CarWithReadOnlyVIN carReadOnly = new CarWithReadOnlyVIN("1HGCM82633A123456");
            Console.WriteLine($"66. Car VIN: {carReadOnly.VIN}");

            // 67. House со свойством Address (readonly)
            HouseWithReadOnlyAddress houseReadOnly = new HouseWithReadOnlyAddress("ул. Ленина, д. 10");
            Console.WriteLine($"67. House Address: {houseReadOnly.Address}");

            // 68. Book со свойством ISBN (readonly)
            BookWithReadOnlyISBN bookReadOnly = new BookWithReadOnlyISBN("978-1234567890");
            Console.WriteLine($"68. Book ISBN: {bookReadOnly.ISBN}");

            // 69. Computer со свойством SerialNumber (readonly)
            ComputerWithReadOnlySerial computerReadOnly = new ComputerWithReadOnlySerial("SN-12345-ABC");
            Console.WriteLine($"69. Computer Serial: {computerReadOnly.SerialNumber}");

            // 70. Document со свойством CreatedDate (readonly)
            DocumentWithReadOnlyDate documentReadOnly = new DocumentWithReadOnlyDate();
            Console.WriteLine($"70. Document Created: {documentReadOnly.CreatedDate}");

            // 71. Order со свойством OrderID (readonly)
            OrderWithReadOnlyID orderReadOnly = new OrderWithReadOnlyID(1001);
            Console.WriteLine($"71. Order ID: {orderReadOnly.OrderID}");

            // 72. Invoice со свойством InvoiceNumber (readonly)
            InvoiceWithReadOnlyNumber invoiceReadOnly = new InvoiceWithReadOnlyNumber("INV-2024-001");
            Console.WriteLine($"72. Invoice Number: {invoiceReadOnly.InvoiceNumber}");

            // 73. User со свойством UID (readonly)
            UserWithReadOnlyUID userReadOnly = new UserWithReadOnlyUID("USR-001");
            Console.WriteLine($"73. User UID: {userReadOnly.UID}");

            // 74. Device со свойством MAC (readonly)
            DeviceWithReadOnlyMAC deviceReadOnly = new DeviceWithReadOnlyMAC("00:1B:44:11:3A:B7");
            Console.WriteLine($"74. Device MAC: {deviceReadOnly.MAC}");

            // 75. Ticket со свойством TicketNumber (readonly)
            TicketWithReadOnlyNumber ticketReadOnly = new TicketWithReadOnlyNumber(12345);
            Console.WriteLine($"75. Ticket Number: {ticketReadOnly.TicketNumber}\n");

            // Раздел 6: WriteOnly Свойства (76-85)
            Console.WriteLine("=== РАЗДЕЛ 6: WriteOnly Свойства ===\n");

            // 76. User со свойством Password (writeonly)
            UserWithWriteOnlyPassword userWriteOnly = new UserWithWriteOnlyPassword();
            userWriteOnly.Password = "secret123";
            bool passwordValid = userWriteOnly.CheckPassword("secret123");
            Console.WriteLine($"76. Password check: {passwordValid}");

            // 77. BankAccount со свойством PIN (writeonly)
            BankAccountWithWriteOnlyPIN accountWriteOnly = new BankAccountWithWriteOnlyPIN();
            accountWriteOnly.PIN = "1234";
            bool pinValid = accountWriteOnly.VerifyPIN("1234");
            Console.WriteLine($"77. PIN verification: {pinValid}");

            // 78. SecureDocument со свойством EncryptionKey (writeonly)
            SecureDocument secureDoc = new SecureDocument();
            secureDoc.EncryptionKey = "my-secret-key-123";
            string encrypted = secureDoc.Encrypt("Hello World");
            Console.WriteLine($"78. Encrypted: {encrypted}");

            // 79. Account со свойством Token (writeonly)
            AccountWithWriteOnlyToken tokenAccount = new AccountWithWriteOnlyToken();
            tokenAccount.Token = "abc123";
            bool tokenValid = tokenAccount.IsValidToken();
            Console.WriteLine($"79. Token valid: {tokenValid}");

            // 80. Logger со свойством ApiKey (writeonly)
            LoggerWithWriteOnlyApiKey apiLogger = new LoggerWithWriteOnlyApiKey();
            apiLogger.ApiKey = "sk-1234567890abcdef";
            Console.Write("80. ");
            apiLogger.LogWithKey("Test message");

            // 81. EmailService со свойством SMTPPassword (writeonly)
            EmailService emailService = new EmailService();
            emailService.SMTPPassword = "smtp123";
            Console.Write("81. ");
            emailService.SendEmail("test@example.com", "Hello");

            // 82. SecureConnection со свойством ConnectionString (writeonly)
            SecureConnection secureConn = new SecureConnection();
            secureConn.ConnectionString = "Server=localhost;Database=test;User=admin;Password=123456";
            Console.Write("82. ");
            secureConn.Connect();

            // 83. Authenticator со свойством Secret (writeonly)
            Authenticator authenticator = new Authenticator();
            authenticator.Secret = "my-secret-key";
            string token = authenticator.GenerateToken();
            Console.WriteLine($"83. Generated token: {token}");

            // 84. PaymentService со свойством CreditCard (writeonly)
            PaymentService paymentService = new PaymentService();
            paymentService.CreditCard = "4111111111111111";
            Console.Write("84. ");
            paymentService.ProcessPayment(99.99m);

            // 85. VPNClient со свойством VPNPassword (writeonly)
            VPNClient vpnClient = new VPNClient();
            vpnClient.VPNPassword = "vpn123";
            Console.Write("85. ");
            vpnClient.ConnectToVPN();
            Console.WriteLine();

            // Раздел 7: Конструкторы (86-100)
            Console.WriteLine("=== РАЗДЕЛ 7: Конструкторы ===\n");

            // 86. Person с конструктором
            PersonWithConstructor personConst = new PersonWithConstructor("Bob", 35);
            Console.WriteLine($"86. Person with constructor: {personConst.Name}, {personConst.Age}");

            // 87. Student с конструктором
            StudentWithConstructor studentConst = new StudentWithConstructor(102, "Alice");
            Console.WriteLine($"87. Student with constructor: ID={studentConst.ID}, Name={studentConst.Name}");

            // 88. Rectangle с конструктором
            RectangleWithConstructor rectConst = new RectangleWithConstructor(5.0, 3.0);
            Console.WriteLine($"88. Rectangle area: {rectConst.GetArea()}");

            // 89. Circle с конструктором
            CircleWithConstructor circleConst = new CircleWithConstructor(7.5);
            Console.WriteLine($"89. Circle area: {circleConst.GetArea():F2}");

            // 90. BankAccount с конструктором
            BankAccountWithConstructor accountConst = new BankAccountWithConstructor("ACC-001", 2000.00m);
            Console.WriteLine($"90. Account: {accountConst.AccountNumber}, Balance: {accountConst.Balance}");

            // 91. Car с конструктором
            CarWithConstructor carConst = new CarWithConstructor("Honda", "Civic", 2023);
            Console.WriteLine($"91. Car: {carConst.Brand} {carConst.Model} {carConst.Year}");

            // 92. Book с конструктором
            BookWithConstructor bookConst = new BookWithConstructor("Мастер и Маргарита", "Михаил Булгаков", 480);
            Console.WriteLine($"92. Book: {bookConst.Title} by {bookConst.Author}, {bookConst.Pages} pages");

            // 93. Employee с конструктором
            EmployeeWithConstructor employeeConst = new EmployeeWithConstructor("Carol", 60000);
            Console.WriteLine($"93. Employee: {employeeConst.Name}, Salary: {employeeConst.Salary}");

            // 94. Product с конструктором
            ProductWithConstructor productConst = new ProductWithConstructor("Smartphone", 699.99m);
            Console.WriteLine($"94. Product: {productConst.Name}, Price: {productConst.Price}");

            // 95. House с конструктором
            HouseWithConstructor houseConst = new HouseWithConstructor("ул. Пушкина, д. 1", 3);
            Console.WriteLine($"95. House: {houseConst.Address}, {houseConst.Rooms} rooms");

            // 96. Triangle с конструктором
            TriangleWithConstructor triangleConst = new TriangleWithConstructor(3.0, 4.0, 5.0);
            Console.WriteLine($"96. Triangle perimeter: {triangleConst.GetPerimeter()}");

            // 97. Time с конструктором
            TimeWithConstructor timeConst = new TimeWithConstructor(14, 30, 45);
            Console.WriteLine($"97. Time: {timeConst.GetTime()}");

            // 98. Temperature с конструктором
            TemperatureWithConstructor tempConst = new TemperatureWithConstructor(20.0);
            Console.WriteLine($"98. Temperature: {tempConst.Celsius}°C = {tempConst.ToFahrenheit()}°F");

            // 99. Color с конструктором
            ColorWithConstructor colorConst = new ColorWithConstructor(255, 0, 0);
            Console.WriteLine($"99. Color: {colorConst.GetHexColor()}");

            // 100. Point с конструктором
            PointWithConstructor pointConst = new PointWithConstructor(3.0, 4.0);
            Console.WriteLine($"100. Point distance to origin: {pointConst.DistanceToOrigin()}");

            Console.WriteLine("\n=== ВСЕ 100 КЛАССОВ ПРОТЕСТИРОВАНЫ УСПЕШНО! ===");
            Console.ReadLine();
        }
    }
}