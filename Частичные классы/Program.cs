﻿using System;
using System.Collections.Generic;
using System.Linq;

// ==============================================
// РАЗДЕЛ 1: ЧАСТИЧНЫЕ КЛАССЫ
// ==============================================

// 1. Person - часть 1 (поля)
partial class Person
{
    private string name;
    private int age;
    private string email;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }
}

// 1. Person - часть 2 (методы)
partial class Person
{
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Email: {Email}");
    }

    public bool IsAdult()
    {
        return Age >= 18;
    }

    public string GetGreeting()
    {
        return $"Привет, {Name}!";
    }
}

// 2. Calculator - часть 1 (сложение)
partial class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

// 2. Calculator - часть 2 (вычитание)
partial class Calculator
{
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }
}

// 3. Customer - часть 1 (свойства)
partial class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}

// 3. Customer - часть 2 (методы)
partial class Customer
{
    public bool IsValidCustomer()
    {
        return !string.IsNullOrEmpty(Name) &&
               !string.IsNullOrEmpty(Email) &&
               Email.Contains("@");
    }

    public string GetCustomerInfo()
    {
        return $"Клиент: {Name}, Email: {Email}, Телефон: {Phone}";
    }
}

// 4. Product - часть 1 (свойства)
partial class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

// 4. Product - часть 2 (методы расчетов)
partial class Product
{
    public decimal CalculateTotalValue()
    {
        return Price * Quantity;
    }

    public decimal CalculateDiscountedPrice(decimal discountPercent)
    {
        return Price * (1 - discountPercent / 100);
    }
}

// 5. Student - часть 1 (поля)
partial class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

// 5. Student - часть 2 (методы информации)
partial class Student
{
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public string GetStudentInfo()
    {
        return $"Студент: {GetFullName()}, ID: {StudentId}, Возраст: {Age}";
    }
}

// 6. Employee - часть 1 (информация)
partial class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal BaseSalary { get; set; }
}

// 6. Employee - часть 2 (расчет зарплаты)
partial class Employee
{
    public decimal CalculateSalary()
    {
        return BaseSalary + CalculateBonus();
    }

    private decimal CalculateBonus()
    {
        return BaseSalary * 0.1m;
    }
}

// 7. Rectangle - часть 1
partial class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

// 7. Rectangle - часть 2
partial class Rectangle
{
    public double GetArea()
    {
        return Width * Height;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}

// 8. BankAccount - часть 1 (операции)
partial class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accNumber, decimal initialBalance = 0)
    {
        accountNumber = accNumber;
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0) return;
        balance += amount;
        LogTransaction($"Пополнение: +{amount}");
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || balance < amount) return false;
        balance -= amount;
        LogTransaction($"Снятие: -{amount}");
        return true;
    }
}

// 8. BankAccount - часть 2 (логирование)
partial class BankAccount
{
    private void LogTransaction(string transaction)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {transaction}. Баланс: {balance:C}");
    }

    public decimal GetBalance() => balance;
}

// 9. Book - часть 1 (информация)
partial class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int Year { get; set; }
}

// 9. Book - часть 2 (поиск)
partial class Book
{
    public bool MatchesSearch(string searchTerm)
    {
        return Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
               Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
               ISBN.Contains(searchTerm);
    }
}

// 10. Car - часть 1 (характеристики)
partial class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Speed { get; set; }
}

// 10. Car - часть 2 (управление)
partial class Car
{
    public void Accelerate(double increment)
    {
        Speed += increment;
        Console.WriteLine($"{Brand} {Model} ускоряется до {Speed} км/ч");
    }

    public void Brake(double decrement)
    {
        Speed = Math.Max(0, Speed - decrement);
        Console.WriteLine($"{Brand} {Model} замедляется до {Speed} км/ч");
    }
}

// 11. House - часть 1
partial class House
{
    public string Address { get; set; }
    public int Rooms { get; set; }
    public double Area { get; set; }
}

// 11. House - часть 2
partial class House
{
    public double GetPricePerSquareMeter(decimal totalPrice)
    {
        return (double)totalPrice / Area;
    }

    public bool IsLargeHouse()
    {
        return Area > 100;
    }
}

// 12. Game - часть 1 (инициализация)
partial class Game
{
    public string Name { get; set; }
    public string Genre { get; set; }
    public bool IsRunning { get; set; }
}

// 12. Game - часть 2 (логика игры)
partial class Game
{
    public void Start()
    {
        IsRunning = true;
        Console.WriteLine($"Игра '{Name}' запущена!");
    }

    public void Stop()
    {
        IsRunning = false;
        Console.WriteLine($"Игра '{Name}' остановлена!");
    }
}

// 13. Database - часть 1 (подключение)
partial class Database
{
    public string ConnectionString { get; set; }
    public bool IsConnected { get; set; }
}

// 13. Database - часть 2 (запросы)
partial class Database
{
    public void Connect()
    {
        IsConnected = true;
        Console.WriteLine("Подключение к базе данных установлено");
    }

    public void ExecuteQuery(string query)
    {
        if (!IsConnected) return;
        Console.WriteLine($"Выполнение запроса: {query}");
    }
}

// 14. Logger - часть 1 (файл)
partial class Logger
{
    public void LogToFile(string message)
    {
        Console.WriteLine($"[FILE] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
    }
}

// 14. Logger - часть 2 (вывод)
partial class Logger
{
    public void LogToConsole(string message)
    {
        Console.WriteLine($"[CONSOLE] {DateTime.Now:HH:mm:ss} - {message}");
    }
}

// 15. Configuration - часть 1 (загрузка)
partial class Configuration
{
    public void LoadSettings()
    {
        Console.WriteLine("Настройки загружены");
    }
}

// 15. Configuration - часть 2 (сохранение)
partial class Configuration
{
    public void SaveSettings()
    {
        Console.WriteLine("Настройки сохранены");
    }
}

// ==============================================
// РАЗДЕЛ 2: ЧАСТИЧНЫЕ МЕТОДЫ
// ==============================================

// 16. Validator с частичным методом OnValidation()
partial class Validator
{
    private string data;

    public Validator(string inputData)
    {
        data = inputData;
    }

    public bool Validate()
    {
        Console.WriteLine("Начало валидации...");
        OnValidation();
        Console.WriteLine("Валидация завершена.");
        return true;
    }

    partial void OnValidation();
}

partial class Validator
{
    partial void OnValidation()
    {
        if (string.IsNullOrEmpty(data))
        {
            Console.WriteLine("Ошибка: данные пусты!");
        }
        else if (data.Length < 3)
        {
            Console.WriteLine("Ошибка: данные слишком короткие!");
        }
        else
        {
            Console.WriteLine($"✓ Данные валидны: {data}");
        }
    }
}

// 17. Logger с частичным методом OnError()
partial class ErrorLogger
{
    public void LogError(string message)
    {
        Console.WriteLine($"[ERROR] {message}");
        OnError(message);
    }

    partial void OnError(string message);
}

partial class ErrorLogger
{
    partial void OnError(string message)
    {
        Console.WriteLine($"Ошибка залогирована: {message}");
    }
}

// 18. NotificationObject с частичным методом OnPropertyChanged()
partial class NotificationObject
{
    private string propertyName;

    public string PropertyName
    {
        get { return propertyName; }
        set
        {
            if (propertyName != value)
            {
                propertyName = value;
                OnPropertyChanged();
            }
        }
    }

    partial void OnPropertyChanged();
}

partial class NotificationObject
{
    partial void OnPropertyChanged()
    {
        Console.WriteLine($"Свойство изменено: {PropertyName}");
    }
}

// 19. Application с частичным методом OnInitialize()
partial class Application
{
    public void Initialize()
    {
        Console.WriteLine("Инициализация приложения...");
        OnInitialize();
        Console.WriteLine("Приложение инициализировано");
    }

    partial void OnInitialize();
}

partial class Application
{
    partial void OnInitialize()
    {
        Console.WriteLine("Выполняется дополнительная инициализация...");
    }
}

// 20. DataManager с частичным методом OnDataLoaded()
partial class DataManager
{
    public void LoadData()
    {
        Console.WriteLine("Загрузка данных...");
        OnDataLoaded();
    }

    partial void OnDataLoaded();
}

partial class DataManager
{
    partial void OnDataLoaded()
    {
        Console.WriteLine("Данные успешно загружены");
    }
}

// 21. StateMachine с частичным методом OnStateChanged()
partial class StateMachine
{
    private string currentState;

    public string CurrentState
    {
        get { return currentState; }
        set
        {
            if (currentState != value)
            {
                currentState = value;
                OnStateChanged();
            }
        }
    }

    partial void OnStateChanged();
}

partial class StateMachine
{
    partial void OnStateChanged()
    {
        Console.WriteLine($"Состояние изменено на: {CurrentState}");
    }
}

// 22. Entity с частичным методом OnBeforeSave()
partial class Entity
{
    public void Save()
    {
        OnBeforeSave();
        Console.WriteLine("Сохранение entity...");
    }

    partial void OnBeforeSave();
}

partial class Entity
{
    partial void OnBeforeSave()
    {
        Console.WriteLine("Проверка данных перед сохранением...");
    }
}

// 23. Repository с частичным методом OnAfterDelete()
partial class Repository
{
    public void Delete(int id)
    {
        Console.WriteLine($"Удаление объекта с ID: {id}");
        OnAfterDelete(id);
    }

    partial void OnAfterDelete(int id);
}

partial class Repository
{
    partial void OnAfterDelete(int id)
    {
        Console.WriteLine($"Объект с ID {id} удален");
    }
}

// 24. DataProcessor с частичным методом OnProcessing()
partial class DataProcessor
{
    public void Process()
    {
        Console.WriteLine("Начало обработки данных...");
        OnProcessing();
        Console.WriteLine("Обработка завершена");
    }

    partial void OnProcessing();
}

partial class DataProcessor
{
    partial void OnProcessing()
    {
        Console.WriteLine("Данные обрабатываются...");
    }
}

// 25. Connection с частичным методом OnConnectionOpened()
partial class Connection
{
    public void Open()
    {
        Console.WriteLine("Открытие соединения...");
        OnConnectionOpened();
    }

    partial void OnConnectionOpened();
}

partial class Connection
{
    partial void OnConnectionOpened()
    {
        Console.WriteLine("Соединение установлено");
    }
}

// 26. Authenticator с частичным методом OnAuthenticationFailed()
partial class Authenticator
{
    public bool Authenticate(string username, string password)
    {
        if (username == "admin" && password == "123")
        {
            Console.WriteLine("Аутентификация успешна");
            return true;
        }
        else
        {
            OnAuthenticationFailed();
            return false;
        }
    }

    partial void OnAuthenticationFailed();
}

partial class Authenticator
{
    partial void OnAuthenticationFailed()
    {
        Console.WriteLine("Ошибка аутентификации!");
    }
}

// 27. Cache с частичным методом OnCacheExpired()
partial class Cache
{
    public void CheckExpiration()
    {
        Console.WriteLine("Проверка срока действия кэша...");
        OnCacheExpired();
    }

    partial void OnCacheExpired();
}

partial class Cache
{
    partial void OnCacheExpired()
    {
        Console.WriteLine("Кэш устарел, требуется обновление");
    }
}

// 28. RetryPolicy с частичным методом OnRetry()
partial class RetryPolicy
{
    public void ExecuteWithRetry(Action action, int maxRetries)
    {
        for (int i = 0; i < maxRetries; i++)
        {
            try
            {
                action();
                return;
            }
            catch
            {
                OnRetry(i + 1);
            }
        }
    }

    partial void OnRetry(int attempt);
}

partial class RetryPolicy
{
    partial void OnRetry(int attempt)
    {
        Console.WriteLine($"Повторная попытка #{attempt}");
    }
}

// 29. Request с частичным методом OnTimeout()
partial class Request
{
    public void Send()
    {
        Console.WriteLine("Отправка запроса...");
        OnTimeout();
    }

    partial void OnTimeout();
}

partial class Request
{
    partial void OnTimeout()
    {
        Console.WriteLine("Превышено время ожидания запроса");
    }
}

// 30. AsyncTask с частичным методом OnCompleted()
partial class AsyncTask
{
    public void Complete()
    {
        Console.WriteLine("Задача завершена");
        OnCompleted();
    }

    partial void OnCompleted();
}

partial class AsyncTask
{
    partial void OnCompleted()
    {
        Console.WriteLine("Выполнены пост-обработки задачи");
    }
}

// ==============================================
// РАЗДЕЛ 3: READONLY ПОЛЯ
// ==============================================

// 31. Circle с readonly полем Radius
class Circle
{
    private readonly double radius;

    public double Radius => radius;

    public Circle(double r)
    {
        if (r <= 0)
            throw new ArgumentException("Радиус должен быть положительным!");
        radius = r;
    }

    public double GetArea() => Math.PI * radius * radius;
    public double GetPerimeter() => 2 * Math.PI * radius;
}

// 32. Point с readonly полями X и Y
class Point
{
    private readonly double x;
    private readonly double y;

    public double X => x;
    public double Y => y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double DistanceTo(Point other)
    {
        return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
    }
}

// 33. Color с readonly полями Red, Green, Blue
class Color
{
    private readonly byte red;
    private readonly byte green;
    private readonly byte blue;

    public byte Red => red;
    public byte Green => green;
    public byte Blue => blue;

    public Color(byte r, byte g, byte b)
    {
        red = r;
        green = g;
        blue = b;
    }

    public string ToHex() => $"#{red:X2}{green:X2}{blue:X2}";
}

// 34. Vector с readonly полем Magnitude
class Vector
{
    private readonly double x;
    private readonly double y;
    private readonly double magnitude;

    public double X => x;
    public double Y => y;
    public double Magnitude => magnitude;

    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
        magnitude = Math.Sqrt(x * x + y * y);
    }
}

// 35. Complex для комплексных чисел
class Complex
{
    private readonly double real;
    private readonly double imaginary;

    public double Real => real;
    public double Imaginary => imaginary;

    public Complex(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public override string ToString() => $"{real} + {imaginary}i";
}

// 36. Fraction с readonly полями
class Fraction
{
    private readonly int numerator;
    private readonly int denominator;

    public int Numerator => numerator;
    public int Denominator => denominator;

    public Fraction(int num, int den)
    {
        if (den == 0)
            throw new ArgumentException("Знаменатель не может быть нулем");
        numerator = num;
        denominator = den;
    }

    public double ToDouble() => (double)numerator / denominator;
}

// 37. Date с readonly полями
class Date
{
    private readonly int day;
    private readonly int month;
    private readonly int year;

    public int Day => day;
    public int Month => month;
    public int Year => year;

    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public override string ToString() => $"{day:00}.{month:00}.{year}";
}

// 38. Time с readonly полями
class Time
{
    private readonly int hours;
    private readonly int minutes;
    private readonly int seconds;

    public int Hours => hours;
    public int Minutes => minutes;
    public int Seconds => seconds;

    public Time(int h, int m, int s)
    {
        hours = h;
        minutes = m;
        seconds = s;
    }

    public override string ToString() => $"{hours:00}:{minutes:00}:{seconds:00}";
}

// 39. Money с readonly полями
class Money
{
    private readonly decimal amount;
    private readonly string currency;

    public decimal Amount => amount;
    public string Currency => currency;

    public Money(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    public override string ToString() => $"{amount} {currency}";
}

// 40. Range с readonly полями
class Range
{
    private readonly double min;
    private readonly double max;

    public double Min => min;
    public double Max => max;

    public Range(double min, double max)
    {
        this.min = min;
        this.max = max;
    }

    public bool Contains(double value) => value >= min && value <= max;
}

// 41. Rectangle с readonly полями
class ReadOnlyRectangle
{
    private readonly double width;
    private readonly double height;

    public double Width => width;
    public double Height => height;

    public ReadOnlyRectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double GetArea() => width * height;
}

// 42. Triangle с readonly полями
class Triangle
{
    private readonly double sideA;
    private readonly double sideB;
    private readonly double sideC;

    public double SideA => sideA;
    public double SideB => sideB;
    public double SideC => sideC;

    public Triangle(double a, double b, double c)
    {
        sideA = a;
        sideB = b;
        sideC = c;
    }

    public double GetPerimeter() => sideA + sideB + sideC;
}

// 43. Coordinates с readonly полями
class Coordinates
{
    private readonly double latitude;
    private readonly double longitude;

    public double Latitude => latitude;
    public double Longitude => longitude;

    public Coordinates(double lat, double lon)
    {
        latitude = lat;
        longitude = lon;
    }

    public override string ToString() => $"{latitude}°N, {longitude}°E";
}

// 44. Version с readonly полями
class Version
{
    private readonly int major;
    private readonly int minor;
    private readonly int patch;

    public int Major => major;
    public int Minor => minor;
    public int Patch => patch;

    public Version(int major, int minor, int patch)
    {
        this.major = major;
        this.minor = minor;
        this.patch = patch;
    }

    public override string ToString() => $"{major}.{minor}.{patch}";
}

// 45. Interval с readonly полями
class Interval
{
    private readonly DateTime start;
    private readonly DateTime end;

    public DateTime Start => start;
    public DateTime End => end;

    public Interval(DateTime start, DateTime end)
    {
        this.start = start;
        this.end = end;
    }

    public TimeSpan Duration => end - start;
}

// 46. Matrix с readonly полем Order
class Matrix
{
    private readonly int order;

    public int Order => order;

    public Matrix(int order)
    {
        this.order = order;
    }

    public int GetTotalElements() => order * order;
}

// 47. Person с readonly полем BirthDate
class PersonWithBirthDate
{
    private readonly DateTime birthDate;

    public DateTime BirthDate => birthDate;

    public PersonWithBirthDate(DateTime birthDate)
    {
        this.birthDate = birthDate;
    }

    public int GetAge()
    {
        var today = DateTime.Today;
        int age = today.Year - birthDate.Year;
        if (birthDate.Date > today.AddYears(-age)) age--;
        return age;
    }
}

// 48. Employee с readonly полем EmployeeID
class EmployeeWithID
{
    private readonly int employeeID;

    public int EmployeeID => employeeID;

    public EmployeeWithID(int id)
    {
        employeeID = id;
    }
}

// 49. Document с readonly полями
class Document
{
    private readonly int documentID;
    private readonly DateTime createdDate;

    public int DocumentID => documentID;
    public DateTime CreatedDate => createdDate;

    public Document(int id)
    {
        documentID = id;
        createdDate = DateTime.Now;
    }
}

// 50. ISBN с readonly полем Code
class ISBN
{
    private readonly string code;

    public string Code => code;

    public ISBN(string code)
    {
        this.code = code;
    }

    public override string ToString() => code;
}

// ==============================================
// РАЗДЕЛ 4: ОСНОВНЫЕ ПАРАДИГМЫ ООП
// ==============================================

// ИНКАПСУЛЯЦИЯ

// 51. BankAccount с приватными полями
class BankAccountEncapsulated
{
    private string accountNumber;
    private decimal balance;
    private string ownerName;

    public BankAccountEncapsulated(string accNumber, string owner, decimal initialBalance = 0)
    {
        accountNumber = accNumber;
        ownerName = owner;
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма должна быть положительной");
        balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || balance < amount)
            return false;
        balance -= amount;
        return true;
    }

    public decimal GetBalance() => balance;
    public string GetAccountInfo() => $"Счет: {accountNumber}, Владелец: {ownerName}";
}

// 52. Person с приватными полями
class PersonEncapsulated
{
    private string name;
    private int age;
    private string email;

    public string Name
    {
        get { return name; }
        set { name = value ?? throw new ArgumentNullException(nameof(value)); }
    }

    public int Age
    {
        get { return age; }
        set { age = value >= 0 ? value : throw new ArgumentException("Возраст не может быть отрицательным"); }
    }

    public string Email
    {
        get { return email; }
        set { email = IsValidEmail(value) ? value : throw new ArgumentException("Неверный формат email"); }
    }

    private bool IsValidEmail(string email) => email?.Contains("@") == true;
}

// 53. Password с валидацией
class Password
{
    private string password;

    public void SetPassword(string newPassword)
    {
        if (IsValidPassword(newPassword))
            password = newPassword;
        else
            throw new ArgumentException("Пароль не соответствует требованиям");
    }

    private bool IsValidPassword(string password)
    {
        return !string.IsNullOrEmpty(password) &&
               password.Length >= 8 &&
               password.Any(char.IsUpper) &&
               password.Any(char.IsLower) &&
               password.Any(char.IsDigit);
    }

    public bool Verify(string inputPassword) => password == inputPassword;
}

// 54. Email с проверкой корректности
class Email
{
    private string address;

    public string Address
    {
        get { return address; }
        set
        {
            if (IsValidEmail(value))
                address = value;
            else
                throw new ArgumentException("Неверный формат email");
        }
    }

    private bool IsValidEmail(string email)
    {
        return !string.IsNullOrEmpty(email) &&
               email.Contains("@") &&
               email.Contains(".") &&
               email.Length > 5;
    }
}

// 55. Temperature с преобразованием
class TemperatureEncapsulated
{
    private double celsius;

    public double Celsius
    {
        get => celsius;
        set => celsius = value;
    }

    public double Fahrenheit
    {
        get => celsius * 9 / 5 + 32;
        set => celsius = (value - 32) * 5 / 9;
    }

    public double Kelvin
    {
        get => celsius + 273.15;
        set => celsius = value - 273.15;
    }
}

// НАСЛЕДОВАНИЕ

// 56. Animal и Dog
class Animal
{
    protected string name;
    protected int age;

    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Издаёт звук");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}");
    }
}

class Dog : Animal
{
    private string breed;

    public Dog(string name, int age, string breed) : base(name, age)
    {
        this.breed = breed;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Гав! Гав!");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Порода: {breed}");
    }

    public void Fetch()
    {
        Console.WriteLine($"{name} приносит мяч!");
    }
}

// 57. Vehicle, Car и Motorcycle
class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public virtual void Start()
    {
        Console.WriteLine($"{Brand} {Model} заводится");
    }
}

class Car1 : Vehicle
{
    public int Doors { get; set; }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Двигатель автомобиля работает");
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public override void Start()
    {
        Console.WriteLine($"{Brand} {Model} - мотоцикл заведен");
    }
}

// 58. Shape, Circle и Rectangle
abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

class CircleShape : Shape
{
    public double Radius { get; set; }

    public CircleShape(double radius) { Radius = radius; }

    public override double CalculateArea() => Math.PI * Radius * Radius;
    public override double CalculatePerimeter() => 2 * Math.PI * Radius;
}

class RectangleShape : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public RectangleShape(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea() => Width * Height;
    public override double CalculatePerimeter() => 2 * (Width + Height);
}

// 59. Employee, Manager и Developer
class EmployeeBase
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public virtual void Work()
    {
        Console.WriteLine($"{Name} выполняет работу");
    }
}

class Manager : EmployeeBase
{
    public string Department { get; set; }

    public override void Work()
    {
        Console.WriteLine($"{Name} управляет отделом {Department}");
    }

    public void ConductMeeting()
    {
        Console.WriteLine($"{Name} проводит собрание");
    }
}

class Developer : EmployeeBase
{
    public string ProgrammingLanguage { get; set; }

    public override void Work()
    {
        Console.WriteLine($"{Name} пишет код на {ProgrammingLanguage}");
    }

    public void DebugCode()
    {
        Console.WriteLine($"{Name} отлаживает код");
    }
}

// 60. Account, SavingsAccount и CheckingAccount
class Account
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public virtual bool Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
}

class SavingsAccount : Account
{
    public decimal InterestRate { get; set; }

    public void ApplyInterest()
    {
        Balance += Balance * InterestRate;
    }

    public override bool Withdraw(decimal amount)
    {
        // Сберегательный счет может иметь ограничения на снятие
        if (Balance - amount >= 100) // Минимальный баланс 100
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
}

class CheckingAccount : Account
{
    public decimal OverdraftLimit { get; set; }

    public override bool Withdraw(decimal amount)
    {
        // Текущий счет может иметь овердрафт
        if (Balance + OverdraftLimit >= amount)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
}

// ПОЛИМОРФИЗМ

// 61. Animal с виртуальным методом
class AnimalPoly
{
    protected string name;

    public AnimalPoly(string name)
    {
        this.name = name;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Издаёт звук");
    }
}

class DogPoly : AnimalPoly
{
    public DogPoly(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Гав! Гав!");
    }
}

class CatPoly : AnimalPoly
{
    public CatPoly(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Мяу!");
    }
}

// 62. Абстрактный класс Shape
abstract class ShapeAbstract
{
    public abstract double CalculateArea();

    public void DisplayArea()
    {
        Console.WriteLine($"Площадь: {CalculateArea():F2}");
    }
}

class CircleAbstract : ShapeAbstract
{
    public double Radius { get; set; }

    public CircleAbstract(double radius) { Radius = radius; }

    public override double CalculateArea() => Math.PI * Radius * Radius;
}

// 63. Интерфейс IPayable
interface IPayable
{
    decimal CalculatePayment();
    void ProcessPayment();
}

class EmployeePayable : IPayable
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public decimal CalculatePayment() => Salary;
    public void ProcessPayment()
    {
        Console.WriteLine($"Выплата {CalculatePayment():C} сотруднику {Name}");
    }
}

class ContractorPayable : IPayable
{
    public string Name { get; set; }
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public decimal CalculatePayment() => HourlyRate * HoursWorked;
    public void ProcessPayment()
    {
        Console.WriteLine($"Выплата {CalculatePayment():C} подрядчику {Name}");
    }
}

// 64. Виртуальное свойство Price
class ProductVirtual
{
    public string Name { get; set; }
    public virtual decimal Price { get; set; }

    public virtual decimal CalculateTotal(int quantity) => Price * quantity;
}

class DigitalProduct : ProductVirtual
{
    public override decimal Price
    {
        get => base.Price * 0.8m;
        set => base.Price = value;
    }

    public override decimal CalculateTotal(int quantity)
    {
        return base.CalculateTotal(quantity) * 0.9m;
    }
}

// 65. Полиморфный массив Shape
class ShapePoly
{
    public virtual double CalculateArea() => 0;
}

class CirclePoly : ShapePoly
{
    public double Radius { get; set; }
    public CirclePoly(double radius) { Radius = radius; }
    public override double CalculateArea() => Math.PI * Radius * Radius;
}

class SquarePoly : ShapePoly
{
    public double Side { get; set; }
    public SquarePoly(double side) { Side = side; }
    public override double CalculateArea() => Side * Side;
}

// АБСТРАКЦИЯ

// 66. Абстрактный класс DatabaseConnection
abstract class DatabaseConnection
{
    protected string connectionString;

    public DatabaseConnection(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public abstract void Connect();
    public abstract void Disconnect();
    public abstract void ExecuteQuery(string query);
}

class SqlConnection : DatabaseConnection
{
    public SqlConnection(string connectionString) : base(connectionString) { }

    public override void Connect()
    {
        Console.WriteLine("Подключение к SQL Server...");
    }

    public override void Disconnect()
    {
        Console.WriteLine("Отключение от SQL Server...");
    }

    public override void ExecuteQuery(string query)
    {
        Console.WriteLine($"Выполнение SQL запроса: {query}");
    }
}

// 67. Интерфейс IRepository
interface IRepository<T>
{
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
    T GetById(int id);
    IEnumerable<T> GetAll();
}

class UserRepository : IRepository<User>
{
    private List<User> users = new List<User>();

    public void Add(User user) => users.Add(user);
    public void Update(User user)
    {
        var existing = users.FirstOrDefault(u => u.Id == user.Id);
        if (existing != null)
        {
            users.Remove(existing);
            users.Add(user);
        }
    }
    public void Delete(int id) => users.RemoveAll(u => u.Id == id);
    public User GetById(int id) => users.FirstOrDefault(u => u.Id == id);
    public IEnumerable<User> GetAll() => users;
}

class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

// 68. Абстрактный класс Logger
abstract class LoggerAbstract
{
    public abstract void Log(string message);
    public abstract void LogError(string error);
}

class FileLogger : LoggerAbstract
{
    public override void Log(string message)
    {
        Console.WriteLine($"[FILE LOG] {message}");
    }

    public override void LogError(string error)
    {
        Console.WriteLine($"[FILE ERROR] {error}");
    }
}

// 69. Интерфейс IValidator
interface IValidator
{
    bool Validate(object obj);
    string GetErrorMessage();
}

class EmailValidator : IValidator
{
    public bool Validate(object obj)
    {
        if (obj is string email)
        {
            return !string.IsNullOrEmpty(email) &&
                   email.Contains("@") &&
                   email.Contains(".");
        }
        return false;
    }

    public string GetErrorMessage() => "Неверный формат email";
}

// 70. Абстрактный класс PaymentProcessor
abstract class PaymentProcessor
{
    public abstract bool ProcessPayment(decimal amount);
    public abstract string GetPaymentMethod();
}

class CreditCardProcessor : PaymentProcessor
{
    public override bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Обработка платежа по карте на сумму {amount:C}");
        return true;
    }

    public override string GetPaymentMethod() => "Credit Card";
}

// ==============================================
// РАЗДЕЛ 5: ДИАГРАММЫ КЛАССОВ UML
// ==============================================

// 71. Система управления библиотекой
class BookUML
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string AuthorName { get; set; }
    public int Year { get; set; }
    public bool IsAvailable { get; set; } = true;
}

class AuthorUML
{
    public string Name { get; set; }
    public string Country { get; set; }
    public List<BookUML> Books { get; set; } = new List<BookUML>();
}

class LibraryUML
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<BookUML> Books { get; set; } = new List<BookUML>();

    public void AddBook(BookUML book) => Books.Add(book);
    public bool BorrowBook(string isbn)
    {
        var book = Books.FirstOrDefault(b => b.ISBN == isbn && b.IsAvailable);
        if (book != null)
        {
            book.IsAvailable = false;
            return true;
        }
        return false;
    }
}

// 72. Система управления школой
class StudentUML
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Grade { get; set; }
    public List<CourseUML> Courses { get; set; } = new List<CourseUML>();
}

class TeacherUML
{
    public int TeacherId { get; set; }
    public string Name { get; set; }
    public string Subject { get; set; }
    public List<CourseUML> Courses { get; set; } = new List<CourseUML>();
}

class CourseUML
{
    public string CourseCode { get; set; }
    public string Name { get; set; }
    public TeacherUML Teacher { get; set; }
    public List<StudentUML> Students { get; set; } = new List<StudentUML>();
}

// 73. E-commerce система
class ProductUML
{
    public string ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

class OrderUML
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public CustomerUML Customer { get; set; }
    public List<OrderItemUML> Items { get; set; } = new List<OrderItemUML>();

    public decimal TotalAmount => Items.Sum(item => item.Subtotal);
}

class OrderItemUML
{
    public ProductUML Product { get; set; }
    public int Quantity { get; set; }
    public decimal Subtotal => Product.Price * Quantity;
}

class CustomerUML
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<OrderUML> Orders { get; set; } = new List<OrderUML>();
}

// 74. Система управления проектами
class ProjectUML
{
    public string ProjectId { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<TaskUML> Tasks { get; set; } = new List<TaskUML>();
    public TeamUML Team { get; set; }
}

class TaskUML
{
    public string TaskId { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public DeveloperUML Assignee { get; set; }
}

class TeamUML
{
    public string TeamId { get; set; }
    public string Name { get; set; }
    public List<DeveloperUML> Members { get; set; } = new List<DeveloperUML>();
}

class DeveloperUML
{
    public int DeveloperId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }
}

// 75. Система управления больницей
class DoctorUML
{
    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }
    public List<AppointmentUML> Appointments { get; set; } = new List<AppointmentUML>();
}

class PatientUML
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<AppointmentUML> Appointments { get; set; } = new List<AppointmentUML>();
}

class AppointmentUML
{
    public int AppointmentId { get; set; }
    public DateTime Date { get; set; }
    public DoctorUML Doctor { get; set; }
    public PatientUML Patient { get; set; }
    public string Reason { get; set; }
}

// 76. Игровая система
class CharacterUML
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public InventoryUML Inventory { get; set; }
}

class InventoryUML
{
    public int Capacity { get; set; }
    public List<ItemUML> Items { get; set; } = new List<ItemUML>();
}

class ItemUML
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Value { get; set; }
}

// 77. Система управления рестораном
class MenuUML
{
    public string Name { get; set; }
    public List<DishUML> Dishes { get; set; } = new List<DishUML>();
}

class DishUML
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}

class RestaurantOrderUML
{
    public int OrderId { get; set; }
    public DateTime OrderTime { get; set; }
    public List<DishUML> Dishes { get; set; } = new List<DishUML>();
    public decimal Total => Dishes.Sum(d => d.Price);
}

// 78. Система бронирования отелей
class HotelUML
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<RoomUML> Rooms { get; set; } = new List<RoomUML>();
}

class RoomUML
{
    public int RoomNumber { get; set; }
    public string Type { get; set; }
    public decimal PricePerNight { get; set; }
    public bool IsAvailable { get; set; } = true;
}

class BookingUML
{
    public int BookingId { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public RoomUML Room { get; set; }
    public decimal TotalPrice => Room.PricePerNight * (CheckOut - CheckIn).Days;
}

// 79. Система управления транспортом
class VehicleUML
{
    public string LicensePlate { get; set; }
    public string Model { get; set; }
    public int Capacity { get; set; }
}

class DriverUML
{
    public int DriverId { get; set; }
    public string Name { get; set; }
    public string LicenseNumber { get; set; }
}

class RouteUML
{
    public string RouteId { get; set; }
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }
    public double Distance { get; set; }
}

// 80. Система управления банком
class BankUML
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<BankAccountUML> Accounts { get; set; } = new List<BankAccountUML>();
}

class BankAccountUML
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public string AccountType { get; set; }
}

class TransactionUML
{
    public int TransactionId { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Type { get; set; }
}

// 81. Система управления школьной оценкой
class GradeUML
{
    public int GradeId { get; set; }
    public string Subject { get; set; }
    public int Score { get; set; }
    public DateTime Date { get; set; }
}

class StudentGradeUML
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public List<GradeUML> Grades { get; set; } = new List<GradeUML>();
}

class SubjectUML
{
    public string Name { get; set; }
    public string Teacher { get; set; }
}

// 82. Система управления событиями
class EventUML
{
    public int EventId { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public VenueUML Venue { get; set; }
    public List<AttendeeUML> Attendees { get; set; } = new List<AttendeeUML>();
}

class AttendeeUML
{
    public int AttendeeId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

class VenueUML
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int Capacity { get; set; }
}

// 83. Система управления социальной сетью
class UserUML
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public List<PostUML> Posts { get; set; } = new List<PostUML>();
}

class PostUML
{
    public int PostId { get; set; }
    public string Content { get; set; }
    public DateTime PostedAt { get; set; }
    public UserUML Author { get; set; }
    public List<CommentUML> Comments { get; set; } = new List<CommentUML>();
}

class CommentUML
{
    public int CommentId { get; set; }
    public string Content { get; set; }
    public UserUML Author { get; set; }
}

// 84. Система управления спортивной лигой
class TeamUML1
{
    public string TeamId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public List<PlayerUML> Players { get; set; } = new List<PlayerUML>();
}

class PlayerUML
{
    public int PlayerId { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public int Number { get; set; }
}

class MatchUML
{
    public int MatchId { get; set; }
    public DateTime Date { get; set; }
    public TeamUML1 HomeTeam { get; set; }
    public TeamUML1 AwayTeam { get; set; }
    public string Score { get; set; }
}

// 85. Система управления кино
class MovieUML
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
    public List<ActorUML> Cast { get; set; } = new List<ActorUML>();
}

class ActorUML
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
}

class CinemaUML
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<MovieUML> Movies { get; set; } = new List<MovieUML>();
}

// ==============================================
// РАЗДЕЛ 6: ОТНОШЕНИЯ МЕЖДУ КЛАССАМИ
// ==============================================

// САМОАССОЦИАЦИЯ

// 86. Person с самоассоциацией
class PersonSelf
{
    public string Name { get; set; }
    public PersonSelf Manager { get; set; }
    public List<PersonSelf> Subordinates { get; set; } = new List<PersonSelf>();

    public void AddSubordinate(PersonSelf subordinate)
    {
        Subordinates.Add(subordinate);
        subordinate.Manager = this;
    }
}

// 87. Node для древовидной структуры
class Node
{
    public string Value { get; set; }
    public Node Parent { get; set; }
    public List<Node> Children { get; set; } = new List<Node>();

    public void AddChild(Node child)
    {
        Children.Add(child);
        child.Parent = this;
    }
}

// 88. Employee с ссылкой на менеджера
class EmployeeSelf
{
    public string Name { get; set; }
    public EmployeeSelf Manager { get; set; }
    public List<EmployeeSelf> TeamMembers { get; set; } = new List<EmployeeSelf>();
}

// 89. Category с родительской категорией
class Category
{
    public string Name { get; set; }
    public Category ParentCategory { get; set; }
    public List<Category> SubCategories { get; set; } = new List<Category>();
}

// 90. TreeNode для представления дерева
class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }
}

// 91. LinkedListNode с ссылкой на следующий узел
class LinkedListNode
{
    public int Value { get; set; }
    public LinkedListNode Next { get; set; }
}

// АССОЦИАЦИЯ

// 92. Student и Course с ассоциацией
class StudentAssoc
{
    public string Name { get; set; }
    public int StudentID { get; set; }
    public List<CourseAssoc> Courses { get; set; } = new List<CourseAssoc>();

    public void EnrollInCourse(CourseAssoc course)
    {
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
            course.EnrollStudent(this);
        }
    }
}

class CourseAssoc
{
    public string Name { get; set; }
    public string Code { get; set; }
    public List<StudentAssoc> Students { get; set; } = new List<StudentAssoc>();

    public void EnrollStudent(StudentAssoc student)
    {
        if (!Students.Contains(student))
        {
            Students.Add(student);
        }
    }
}

// 93. Doctor и Patient с ассоциацией
class DoctorAssoc
{
    public string Name { get; set; }
    public string Specialization { get; set; }
    public List<PatientAssoc> Patients { get; set; } = new List<PatientAssoc>();
}

class PatientAssoc
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DoctorAssoc Doctor { get; set; }
}

// 94. Author и Book с ассоциацией
class AuthorAssoc
{
    public string Name { get; set; }
    public List<BookAssoc> Books { get; set; } = new List<BookAssoc>();
}

class BookAssoc
{
    public string Title { get; set; }
    public AuthorAssoc Author { get; set; }
}

// 95. Teacher и Class с ассоциацией
class TeacherAssoc
{
    public string Name { get; set; }
    public string Subject { get; set; }
    public List<ClassAssoc> Classes { get; set; } = new List<ClassAssoc>();
}

class ClassAssoc
{
    public string Name { get; set; }
    public TeacherAssoc Teacher { get; set; }
}

// 96. Company и Employee с ассоциацией
class CompanyAssoc
{
    public string Name { get; set; }
    public List<EmployeeAssoc> Employees { get; set; } = new List<EmployeeAssoc>();
}

class EmployeeAssoc
{
    public string Name { get; set; }
    public string Position { get; set; }
    public CompanyAssoc Company { get; set; }
}

// 97. Library и Book с ассоциацией
class LibraryAssoc
{
    public string Name { get; set; }
    public List<BookLibrary> Books { get; set; } = new List<BookLibrary>();
}

class BookLibrary
{
    public string Title { get; set; }
    public LibraryAssoc Library { get; set; }
}

// 98. Team и Player с ассоциацией
class TeamAssoc
{
    public string Name { get; set; }
    public List<PlayerAssoc> Players { get; set; } = new List<PlayerAssoc>();
}

class PlayerAssoc
{
    public string Name { get; set; }
    public string Position { get; set; }
    public TeamAssoc Team { get; set; }
}

// 99. Order и Product с ассоциацией
class OrderAssoc
{
    public int OrderId { get; set; }
    public List<ProductOrder> Products { get; set; } = new List<ProductOrder>();
}

class ProductOrder
{
    public string Name { get; set; }
    public List<OrderAssoc> Orders { get; set; } = new List<OrderAssoc>();
}

// 100. Project и Developer с ассоциацией
class ProjectAssoc
{
    public string Name { get; set; }
    public List<DeveloperAssoc> Developers { get; set; } = new List<DeveloperAssoc>();
}

class DeveloperAssoc
{
    public string Name { get; set; }
    public List<ProjectAssoc> Projects { get; set; } = new List<ProjectAssoc>();
}

// ==============================================
// ГЛАВНАЯ ПРОГРАММА ДЛЯ ТЕСТИРОВАНИЯ
// ==============================================

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ТЕСТИРОВАНИЕ ===\n");

        // Тестирование частичных классов
        TestPartialClasses();

        // Тестирование частичных методов
        TestPartialMethods();

        // Тестирование readonly полей
        TestReadOnlyFields();

        // Тестирование ООП парадигм
        TestOOPParadigms();

        // Тестирование UML классов
        TestUMLClasses();

        // Тестирование отношений между классами
        TestClassRelationships();
    }

    static void TestPartialClasses()
    {
        Console.WriteLine("1. ТЕСТИРОВАНИЕ ЧАСТИЧНЫХ КЛАССОВ:");

        // Person
        Person person = new Person();
        person.Name = "Иван Петров";
        person.Age = 25;
        person.Email = "ivan@example.com";
        person.DisplayInfo();
        Console.WriteLine($"Совершеннолетний: {person.IsAdult()}");
        Console.WriteLine(person.GetGreeting());

        // Calculator
        Calculator calc = new Calculator();
        Console.WriteLine($"5 + 3 = {calc.Add(5, 3)}");
        Console.WriteLine($"10.5 + 2.3 = {calc.Add(10.5, 2.3)}");
        Console.WriteLine($"10 - 4 = {calc.Subtract(10, 4)}");

        // BankAccount
        BankAccount account = new BankAccount("123456", 1000);
        account.Deposit(500);
        account.Withdraw(200);
        Console.WriteLine($"Баланс: {account.GetBalance():C}");

        Console.WriteLine();
    }

    static void TestPartialMethods()
    {
        Console.WriteLine("2. ТЕСТИРОВАНИЕ ЧАСТИЧНЫХ МЕТОДОВ:");

        Validator validator1 = new Validator("Привет");
        validator1.Validate();

        Validator validator2 = new Validator("Hi");
        validator2.Validate();

        Validator validator3 = new Validator("");
        validator3.Validate();

        ErrorLogger logger = new ErrorLogger();
        logger.LogError("Тестовая ошибка");

        NotificationObject obj = new NotificationObject();
        obj.PropertyName = "TestProperty";

        Console.WriteLine();
    }

    static void TestReadOnlyFields()
    {
        Console.WriteLine("3. ТЕСТИРОВАНИЕ READONLY ПОЛЕЙ:");

        Circle circle = new Circle(5);
        Console.WriteLine($"Круг: радиус={circle.Radius}, площадь={circle.GetArea():F2}");

        Point p1 = new Point(0, 0);
        Point p2 = new Point(3, 4);
        Console.WriteLine($"Расстояние между точками: {p1.DistanceTo(p2):F2}");

        Color color = new Color(255, 128, 0);
        Console.WriteLine($"Цвет: {color.ToHex()}");

        Fraction fraction = new Fraction(1, 2);
        Console.WriteLine($"Дробь: {fraction.Numerator}/{fraction.Denominator} = {fraction.ToDouble()}");

        Console.WriteLine();
    }

    static void TestOOPParadigms()
    {
        Console.WriteLine("4. ТЕСТИРОВАНИЕ ООП ПАРАДИГМ:");

        // Наследование
        Dog dog = new Dog("Шарик", 3, "Лабрадор");
        dog.DisplayInfo();
        dog.MakeSound();
        dog.Fetch();

        // Полиморфизм
        AnimalPoly[] animals = new AnimalPoly[]
        {
            new DogPoly("Бобик"),
            new CatPoly("Мурка")
        };

        foreach (var animal in animals)
        {
            animal.MakeSound();
        }

        // Абстракция
        List<IPayable> payables = new List<IPayable>
        {
            new EmployeePayable { Name = "Иван", Salary = 50000 },
            new ContractorPayable { Name = "Петр", HourlyRate = 1000, HoursWorked = 40 }
        };

        foreach (var payable in payables)
        {
            payable.ProcessPayment();
        }

        Console.WriteLine();
    }

    static void TestUMLClasses()
    {
        Console.WriteLine("5. ТЕСТИРОВАНИЕ UML КЛАССОВ:");

        // Библиотечная система
        BookUML book = new BookUML { ISBN = "123", Title = "Война и мир", AuthorName = "Толстой", Year = 1869 };
        LibraryUML library = new LibraryUML { Name = "Центральная библиотека" };
        library.AddBook(book);
        Console.WriteLine($"Книга '{book.Title}' добавлена в библиотеку '{library.Name}'");

        // E-commerce система
        ProductUML product = new ProductUML { Name = "Ноутбук", Price = 50000 };
        CustomerUML customer = new CustomerUML { Name = "Алексей" };
        OrderUML order = new OrderUML { OrderId = 1 };

        Console.WriteLine($"Клиент {customer.Name} заказал {product.Name} за {product.Price:C}");

        Console.WriteLine();
    }

    static void TestClassRelationships()
    {
        Console.WriteLine("6. ТЕСТИРОВАНИЕ ОТНОШЕНИЙ МЕЖДУ КЛАССАМИ:");

        // Самоассоциация
        PersonSelf boss = new PersonSelf { Name = "Директор" };
        PersonSelf employee = new PersonSelf { Name = "Сотрудник" };
        boss.AddSubordinate(employee);
        Console.WriteLine($"{employee.Name} подчиняется {boss.Name}");

        // Ассоциация
        StudentAssoc student = new StudentAssoc { Name = "Мария", StudentID = 101 };
        CourseAssoc course = new CourseAssoc { Name = "Математика", Code = "MATH101" };
        student.EnrollInCourse(course);
        Console.WriteLine($"Студент {student.Name} записан на курс {course.Name}");

        Console.WriteLine();
    }
}