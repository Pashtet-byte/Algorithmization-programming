using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// ============================================
// ЗАДАЧА 1: Абстрактная фабрика для GUI
// ============================================

// Интерфейсы компонентов GUI
public interface IButton
{
    void Render();
}

public interface ITextBox
{
    void Render();
}

public interface ICheckBox
{
    void Render();
}

// Интерфейс фабрики GUI
public interface IGUIFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
    ICheckBox CreateCheckBox();
}

// Конкретные компоненты для Windows
public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("Windows Button rendered");
}

public class WindowsTextBox : ITextBox
{
    public void Render() => Console.WriteLine("Windows TextBox rendered");
}

public class WindowsCheckBox : ICheckBox
{
    public void Render() => Console.WriteLine("Windows CheckBox rendered");
}

// Конкретные компоненты для MacOS
public class MacOSButton : IButton
{
    public void Render() => Console.WriteLine("MacOS Button rendered");
}

public class MacOSTextBox : ITextBox
{
    public void Render() => Console.WriteLine("MacOS TextBox rendered");
}

public class MacOSCheckBox : ICheckBox
{
    public void Render() => Console.WriteLine("MacOS CheckBox rendered");
}

// Конкретные компоненты для Linux
public class LinuxButton : IButton
{
    public void Render() => Console.WriteLine("Linux Button rendered");
}

public class LinuxTextBox : ITextBox
{
    public void Render() => Console.WriteLine("Linux TextBox rendered");
}

public class LinuxCheckBox : ICheckBox
{
    public void Render() => Console.WriteLine("Linux CheckBox rendered");
}

// Конкретные фабрики
public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ITextBox CreateTextBox() => new WindowsTextBox();
    public ICheckBox CreateCheckBox() => new WindowsCheckBox();
}

public class MacOSFactory : IGUIFactory
{
    public IButton CreateButton() => new MacOSButton();
    public ITextBox CreateTextBox() => new MacOSTextBox();
    public ICheckBox CreateCheckBox() => new MacOSCheckBox();
}

public class LinuxFactory : IGUIFactory
{
    public IButton CreateButton() => new LinuxButton();
    public ITextBox CreateTextBox() => new LinuxTextBox();
    public ICheckBox CreateCheckBox() => new LinuxCheckBox();
}

// Приложение GUI
public class Application
{
    private readonly IGUIFactory _factory;

    public Application(IGUIFactory factory)
    {
        _factory = factory;
    }

    public void CreateUI()
    {
        Console.WriteLine("Creating UI components:");

        var button = _factory.CreateButton();
        var textBox = _factory.CreateTextBox();
        var checkBox = _factory.CreateCheckBox();

        button.Render();
        textBox.Render();
        checkBox.Render();
    }
}

// ============================================
// ЗАДАЧА 2: Система обработки платежей
// ============================================

// Абстрактный класс процессора платежей
public abstract class PaymentProcessor
{
    // Template Method - определяет общий workflow
    public void ProcessPayment(string paymentInfo)
    {
        try
        {
            Console.WriteLine($"\nProcessing payment with {GetType().Name}");

            if (!ValidatePaymentInfo(paymentInfo))
            {
                HandleError("Invalid payment information");
                return;
            }

            var transactionId = ProcessTransaction(paymentInfo);
            GenerateReceipt(transactionId);

            Console.WriteLine("Payment processed successfully!");
        }
        catch (Exception ex)
        {
            HandleError($"Payment failed: {ex.Message}");
        }
    }

    protected abstract bool ValidatePaymentInfo(string paymentInfo);
    protected abstract string ProcessTransaction(string paymentInfo);
    protected abstract void GenerateReceipt(string transactionId);
    protected abstract void HandleError(string errorMessage);
}

// Конкретные процессоры
public class CreditCardProcessor : PaymentProcessor
{
    protected override bool ValidatePaymentInfo(string paymentInfo)
    {
        Console.WriteLine("Validating credit card information...");
        return !string.IsNullOrEmpty(paymentInfo) && paymentInfo.Length >= 16;
    }

    protected override string ProcessTransaction(string paymentInfo)
    {
        Console.WriteLine("Processing credit card transaction...");
        return $"CC_{DateTime.Now.Ticks}";
    }

    protected override void GenerateReceipt(string transactionId)
    {
        Console.WriteLine($"Generating credit card receipt for transaction: {transactionId}");
    }

    protected override void HandleError(string errorMessage)
    {
        Console.WriteLine($"Credit Card Error: {errorMessage}");
    }
}

public class PayPalProcessor : PaymentProcessor
{
    protected override bool ValidatePaymentInfo(string paymentInfo)
    {
        Console.WriteLine("Validating PayPal account...");
        return !string.IsNullOrEmpty(paymentInfo) && paymentInfo.Contains("@");
    }

    protected override string ProcessTransaction(string paymentInfo)
    {
        Console.WriteLine("Processing PayPal transaction...");
        return $"PP_{DateTime.Now.Ticks}";
    }

    protected override void GenerateReceipt(string transactionId)
    {
        Console.WriteLine($"Generating PayPal receipt for transaction: {transactionId}");
    }

    protected override void HandleError(string errorMessage)
    {
        Console.WriteLine($"PayPal Error: {errorMessage}");
    }
}

public class CryptoProcessor : PaymentProcessor
{
    protected override bool ValidatePaymentInfo(string paymentInfo)
    {
        Console.WriteLine("Validating cryptocurrency wallet...");
        return !string.IsNullOrEmpty(paymentInfo) && paymentInfo.StartsWith("0x");
    }

    protected override string ProcessTransaction(string paymentInfo)
    {
        Console.WriteLine("Processing cryptocurrency transaction...");
        return $"CRYPTO_{DateTime.Now.Ticks}";
    }

    protected override void GenerateReceipt(string transactionId)
    {
        Console.WriteLine($"Generating crypto receipt for transaction: {transactionId}");
    }

    protected override void HandleError(string errorMessage)
    {
        Console.WriteLine($"Crypto Error: {errorMessage}");
    }
}

public class BankTransferProcessor : PaymentProcessor
{
    protected override bool ValidatePaymentInfo(string paymentInfo)
    {
        Console.WriteLine("Validating bank account information...");
        return !string.IsNullOrEmpty(paymentInfo) && paymentInfo.Length >= 8;
    }

    protected override string ProcessTransaction(string paymentInfo)
    {
        Console.WriteLine("Processing bank transfer...");
        return $"BANK_{DateTime.Now.Ticks}";
    }

    protected override void GenerateReceipt(string transactionId)
    {
        Console.WriteLine($"Generating bank transfer receipt for transaction: {transactionId}");
    }

    protected override void HandleError(string errorMessage)
    {
        Console.WriteLine($"Bank Transfer Error: {errorMessage}");
    }
}

// Система обработки платежей
public class PaymentSystem
{
    private readonly List<PaymentProcessor> _processors;
    private int _successfulPayments;
    private int _failedPayments;

    public PaymentSystem()
    {
        _processors = new List<PaymentProcessor>
        {
            new CreditCardProcessor(),
            new PayPalProcessor(),
            new CryptoProcessor(),
            new BankTransferProcessor()
        };
    }

    public void ProcessMultiplePayments(int count)
    {
        var random = new Random();

        for (int i = 0; i < count; i++)
        {
            var processor = _processors[random.Next(_processors.Count)];
            var paymentInfo = GenerateTestPaymentInfo(processor);

            try
            {
                processor.ProcessPayment(paymentInfo);
                _successfulPayments++;
            }
            catch
            {
                _failedPayments++;
            }
        }
    }

    private string GenerateTestPaymentInfo(PaymentProcessor processor)
    {
        return processor switch
        {
            CreditCardProcessor => "1234567890123456",
            PayPalProcessor => "user@example.com",
            CryptoProcessor => "0x742d35Cc6634C0532925a3b8D",
            BankTransferProcessor => "12345678",
            _ => "test_payment_info"
        };
    }

    public void PrintSummary()
    {
        Console.WriteLine("\n=== PAYMENT PROCESSING SUMMARY ===");
        Console.WriteLine($"Total payments processed: {_successfulPayments + _failedPayments}");
        Console.WriteLine($"Successful: {_successfulPayments}");
        Console.WriteLine($"Failed: {_failedPayments}");
        Console.WriteLine($"Success rate: {(_successfulPayments * 100.0 / (_successfulPayments + _failedPayments)):F2}%");
    }
}

// ============================================
// ЗАДАЧА 3: ИСПРАВЛЕННЫЙ IoC контейнер
// ============================================

public enum Lifecycle
{
    Transient,
    Singleton,
    Scoped
}

public interface IServiceProvider
{
    T GetService<T>();
    object GetService(Type serviceType);
}

public class Container : IServiceProvider
{
    private readonly Dictionary<Type, ServiceRegistration> _registrations = new();
    private readonly Dictionary<Type, object> _singletons = new();
    private readonly Dictionary<Type, object> _scopedInstances = new();
    private readonly Container _parent;

    public Container()
    {
        // Регистрируем сам контейнер
        _registrations[typeof(Container)] = new ServiceRegistration(typeof(Container), typeof(Container), Lifecycle.Singleton);
        _registrations[typeof(IServiceProvider)] = new ServiceRegistration(typeof(IServiceProvider), typeof(Container), Lifecycle.Singleton);
        _singletons[typeof(Container)] = this;
        _singletons[typeof(IServiceProvider)] = this;
    }

    private Container(Container parent)
    {
        _parent = parent;
        // Копируем регистрации из родителя
        foreach (var registration in parent._registrations)
        {
            _registrations[registration.Key] = registration.Value;
        }
    }

    public void Register<TInterface, TImplementation>(Lifecycle lifecycle = Lifecycle.Transient)
        where TImplementation : TInterface
    {
        _registrations[typeof(TInterface)] = new ServiceRegistration(typeof(TInterface), typeof(TImplementation), lifecycle);
    }

    public void Register<TImplementation>(Lifecycle lifecycle = Lifecycle.Transient)
    {
        _registrations[typeof(TImplementation)] = new ServiceRegistration(typeof(TImplementation), typeof(TImplementation), lifecycle);
    }

    public T GetService<T>()
    {
        return (T)GetService(typeof(T));
    }

    public object GetService(Type serviceType)
    {
        // Проверяем циклические зависимости
        if (_currentResolutionStack.Contains(serviceType))
        {
            throw new InvalidOperationException($"Circular dependency detected for type {serviceType.Name}");
        }

        _currentResolutionStack.Push(serviceType);

        try
        {
            return ResolveService(serviceType);
        }
        finally
        {
            _currentResolutionStack.Pop();
        }
    }

    private readonly Stack<Type> _currentResolutionStack = new();

    private object ResolveService(Type serviceType)
    {
        // Если запрашиваем контейнер
        if (serviceType == typeof(Container) || serviceType == typeof(IServiceProvider))
            return this;

        // Ищем регистрацию
        if (!_registrations.TryGetValue(serviceType, out var registration))
        {
            // Попробуем зарегистрировать автоматически, если это конкретный тип
            if (serviceType.IsClass && !serviceType.IsAbstract)
            {
                registration = new ServiceRegistration(serviceType, serviceType, Lifecycle.Transient);
                _registrations[serviceType] = registration;
            }
            else
            {
                throw new InvalidOperationException($"No registration found for type {serviceType.Name}");
            }
        }

        return registration.Lifecycle switch
        {
            Lifecycle.Singleton => GetOrCreateSingleton(registration),
            Lifecycle.Scoped => GetOrCreateScoped(registration),
            Lifecycle.Transient => CreateInstance(registration.ImplementationType),
            _ => throw new InvalidOperationException($"Unknown lifecycle: {registration.Lifecycle}")
        };
    }

    private object GetOrCreateSingleton(ServiceRegistration registration)
    {
        // Для синглтонов используем родительский контейнер, если есть
        var targetContainer = _parent ?? this;

        lock (targetContainer._singletons)
        {
            if (!targetContainer._singletons.TryGetValue(registration.InterfaceType, out var instance))
            {
                instance = CreateInstance(registration.ImplementationType);
                targetContainer._singletons[registration.InterfaceType] = instance;
            }
            return instance;
        }
    }

    private object GetOrCreateScoped(ServiceRegistration registration)
    {
        // Scoped instances хранятся в текущем контейнере
        lock (_scopedInstances)
        {
            if (!_scopedInstances.TryGetValue(registration.InterfaceType, out var instance))
            {
                instance = CreateInstance(registration.ImplementationType);
                _scopedInstances[registration.InterfaceType] = instance;
            }
            return instance;
        }
    }

    private object CreateInstance(Type implementationType)
    {
        var constructors = implementationType.GetConstructors();

        if (constructors.Length == 0)
            throw new InvalidOperationException($"No public constructors found for {implementationType.Name}");

        var constructor = constructors[0];
        var parameters = constructor.GetParameters();
        var parameterInstances = new object[parameters.Length];

        for (int i = 0; i < parameters.Length; i++)
        {
            parameterInstances[i] = GetService(parameters[i].ParameterType);
        }

        return constructor.Invoke(parameterInstances);
    }

    public Container CreateScope()
    {
        return new Container(this);
    }

    private record ServiceRegistration(Type InterfaceType, Type ImplementationType, Lifecycle Lifecycle);
}

// Тестовые классы для IoC контейнера
public interface IRepository<T>
{
    void Add(T item);
    T Get(int id);
}

public class UserRepository : IRepository<User>
{
    private readonly List<User> _users = new();
    private static int _instanceCount = 0;
    public int InstanceId { get; }

    public UserRepository()
    {
        InstanceId = ++_instanceCount;
        Console.WriteLine($"UserRepository instance {InstanceId} created");
    }

    public void Add(User item) => _users.Add(item);
    public User Get(int id) => _users.FirstOrDefault(u => u.Id == id);
}

public class ProductRepository : IRepository<Product>
{
    private readonly List<Product> _products = new();
    private static int _instanceCount = 0;
    public int InstanceId { get; }

    public ProductRepository()
    {
        InstanceId = ++_instanceCount;
        Console.WriteLine($"ProductRepository instance {InstanceId} created");
    }

    public void Add(Product item) => _products.Add(item);
    public Product Get(int id) => _products.FirstOrDefault(p => p.Id == id);
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public interface IUserService
{
    void CreateUser(string name);
    User GetUser(int id);
}

public class UserService : IUserService
{
    private readonly IRepository<User> _userRepository;

    public UserService(IRepository<User> userRepository)
    {
        _userRepository = userRepository;
        Console.WriteLine($"UserService created with UserRepository instance {((UserRepository)userRepository).InstanceId}");
    }

    public void CreateUser(string name)
    {
        var user = new User { Id = new Random().Next(1000), Name = name };
        _userRepository.Add(user);
        Console.WriteLine($"User created: {name}");
    }

    public User GetUser(int id) => _userRepository.Get(id);
}

public interface IProductService
{
    void CreateProduct(string name, decimal price);
    Product GetProduct(int id);
}

public class ProductService : IProductService
{
    private readonly IRepository<Product> _productRepository;

    public ProductService(IRepository<Product> productRepository)
    {
        _productRepository = productRepository;
        Console.WriteLine($"ProductService created with ProductRepository instance {((ProductRepository)productRepository).InstanceId}");
    }

    public void CreateProduct(string name, decimal price)
    {
        var product = new Product { Id = new Random().Next(1000), Name = name, Price = price };
        _productRepository.Add(product);
        Console.WriteLine($"Product created: {name} - ${price}");
    }

    public Product GetProduct(int id) => _productRepository.Get(id);
}

public interface IOrderService
{
    void CreateOrder(int userId, int productId);
}

public class OrderService : IOrderService
{
    private readonly IUserService _userService;
    private readonly IProductService _productService;

    public OrderService(IUserService userService, IProductService productService)
    {
        _userService = userService;
        _productService = productService;
        Console.WriteLine("OrderService created");
    }

    public void CreateOrder(int userId, int productId)
    {
        var user = _userService.GetUser(userId);
        var product = _productService.GetProduct(productId);

        if (user != null && product != null)
        {
            Console.WriteLine($"Order created: User {user.Name} ordered {product.Name}");
        }
        else
        {
            Console.WriteLine("Order failed: user or product not found");
        }
    }
}

// Демонстрационные классы для тестирования циклических зависимостей
public class ServiceA
{
    public ServiceA(ServiceB serviceB)
    {
        Console.WriteLine("ServiceA created");
    }
}

public class ServiceB
{
    public ServiceB(ServiceC serviceC)
    {
        Console.WriteLine("ServiceB created");
    }
}

public class ServiceC
{
    public ServiceC(ServiceA serviceA)
    {
        Console.WriteLine("ServiceC created");
    }
}

// ============================================
// ГЛАВНАЯ ПРОГРАММА
// ============================================

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ТЕСТИРОВАНИЕ АБСТРАКТНОЙ ФАБРИКИ GUI ===");
        TestGUIFactory();

        Console.WriteLine("\n=== ТЕСТИРОВАНИЕ СИСТЕМЫ ПЛАТЕЖЕЙ ===");
        TestPaymentSystem();

        Console.WriteLine("\n=== ТЕСТИРОВАНИЕ IOC КОНТЕЙНЕРА ===");
        TestIoCContainer();

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static void TestGUIFactory()
    {
        // Тестируем разные фабрики
        var factories = new IGUIFactory[]
        {
            new WindowsFactory(),
            new MacOSFactory(),
            new LinuxFactory()
        };

        foreach (var factory in factories)
        {
            var app = new Application(factory);
            app.CreateUI();
            Console.WriteLine("---");
        }
    }

    static void TestPaymentSystem()
    {
        var paymentSystem = new PaymentSystem();
        paymentSystem.ProcessMultiplePayments(50);
        paymentSystem.PrintSummary();
    }

    static void TestIoCContainer()
    {
        var container = new Container();

        // Регистрируем сервисы с разными жизненными циклами
        container.Register<IRepository<User>, UserRepository>(Lifecycle.Singleton);
        container.Register<IRepository<Product>, ProductRepository>(Lifecycle.Transient);
        container.Register<IUserService, UserService>(Lifecycle.Scoped);
        container.Register<IProductService, ProductService>(Lifecycle.Scoped);
        container.Register<IOrderService, OrderService>(Lifecycle.Transient);

        Console.WriteLine("=== Тестирование внедрения зависимостей ===");

        // Получаем сервисы
        var userService = container.GetService<IUserService>();
        var productService = container.GetService<IProductService>();
        var orderService = container.GetService<IOrderService>();

        // Используем сервисы
        userService.CreateUser("John Doe");
        productService.CreateProduct("Laptop", 999.99m);
        orderService.CreateOrder(1, 1);

        Console.WriteLine("\n=== Тестирование жизненных циклов ===");

        // Singleton должен быть тем же экземпляром
        var repo1 = container.GetService<IRepository<User>>();
        var repo2 = container.GetService<IRepository<User>>();
        Console.WriteLine($"Singleton repositories are same: {repo1 == repo2}");

        // Transient должны быть разными экземплярами
        var productRepo1 = container.GetService<IRepository<Product>>();
        var productRepo2 = container.GetService<IRepository<Product>>();
        Console.WriteLine($"Transient repositories are same: {productRepo1 == productRepo2}");

        Console.WriteLine("\n=== Тестирование области видимости (Scoped) ===");
        var scope1 = container.CreateScope();
        var scopedService1 = scope1.GetService<IUserService>();
        var scopedService2 = scope1.GetService<IUserService>();
        Console.WriteLine($"Scoped services in same scope are same: {scopedService1 == scopedService2}");

        var scope2 = container.CreateScope();
        var scopedService3 = scope2.GetService<IUserService>();
        Console.WriteLine($"Scoped services in different scopes are same: {scopedService1 == scopedService3}");

        Console.WriteLine("\n=== Тестирование обнаружения циклических зависимостей ===");
        try
        {
            container.Register<ServiceA>(Lifecycle.Transient);
            container.Register<ServiceB>(Lifecycle.Transient);
            container.Register<ServiceC>(Lifecycle.Transient);

            var cyclicService = container.GetService<ServiceA>();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Обнаружена циклическая зависимость: {ex.Message}");
        }

        Console.WriteLine("\n=== Тестирование сложных зависимостей ===");
        // Создаем дополнительные сервисы для демонстрации
        container.Register<EmailService>(Lifecycle.Transient);
        container.Register<NotificationService>(Lifecycle.Scoped);

        var notificationService = container.GetService<NotificationService>();
        notificationService.SendWelcome("test@example.com");
    }
}
public class EmailService
{
    public EmailService()
    {
        Console.WriteLine("EmailService created");
    }

    public void SendEmail(string to, string message)
    {
        Console.WriteLine($"Email sent to {to}: {message}");
    }
}

public class NotificationService
{
    private readonly EmailService _emailService;
    private readonly IUserService _userService;

    public NotificationService(EmailService emailService, IUserService userService)
    {
        _emailService = emailService;
        _userService = userService;
        Console.WriteLine("NotificationService created");
    }

    public void SendWelcome(string email)
    {
        _emailService.SendEmail(email, "Welcome to our service!");
        Console.WriteLine("Welcome notification sent");
    }
}