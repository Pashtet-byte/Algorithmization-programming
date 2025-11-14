using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompleteGenericsDemo
{
    // ==================== РАЗДЕЛ 1: GENERICS (ЗАДАНИЯ 1-25) ====================

    // Задание 1: Generic класс Stack
    public class Stack<T>
    {
        private List<T> _items = new List<T>();
        public void Push(T item) => _items.Add(item);
        public T Pop()
        {
            if (_items.Count == 0) throw new InvalidOperationException("Стек пуст");
            var item = _items[^1];
            _items.RemoveAt(_items.Count - 1);
            return item;
        }
        public T Peek() => _items.Count == 0 ? throw new InvalidOperationException("Стек пуст") : _items[^1];
        public int Count => _items.Count;
        public void Display() => Console.WriteLine($"Стек: [{string.Join(", ", _items)}]");
        public void Clear() => _items.Clear();
    }

    // Задание 2: Generic класс Queue
    public class Queue<T>
    {
        private List<T> _items = new List<T>();
        public void Enqueue(T item) => _items.Add(item);
        public T Dequeue()
        {
            if (_items.Count == 0) throw new InvalidOperationException("Очередь пуста");
            var item = _items[0];
            _items.RemoveAt(0);
            return item;
        }
        public T Peek() => _items.Count == 0 ? throw new InvalidOperationException("Очередь пуста") : _items[0];
        public int Count => _items.Count;
        public void Display() => Console.WriteLine($"Очередь: [{string.Join(", ", _items)}]");
        public void Clear() => _items.Clear();
    }

    // Задание 3: Generic метод для поиска в массиве
    public static class ArraySearch
    {
        public static int FindIndex<T>(T[] array, T element) where T : IEquatable<T>
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i].Equals(element)) return i;
            return -1;
        }
    }

    // Задание 4: Generic класс Pair
    public class Pair<T>
    {
        public T First { get; set; }
        public T Second { get; set; }
        public Pair(T first, T second) { First = first; Second = second; }
        public override string ToString() => $"({First}, {Second})";
        public void Swap() => (First, Second) = (Second, First);
    }

    // Задание 5: Generic метод для обмена значений
    public static class SwapHelper
    {
        public static void Swap<T>(ref T a, ref T b) => (a, b) = (b, a);
        public static (T, T) SwapAndReturn<T>(T a, T b) => (b, a);
    }

    // Задание 6: Generic класс Cache
    public class Cache<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _storage = new Dictionary<TKey, TValue>();
        public void Set(TKey key, TValue value) => _storage[key] = value;
        public TValue Get(TKey key) => _storage.TryGetValue(key, out TValue value) ? value : default;
        public bool Contains(TKey key) => _storage.ContainsKey(key);
        public void Clear() => _storage.Clear();
    }

    // Задание 7: Generic класс LinkedList
    public class LinkedList<T>
    {
        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node(T data) => Data = data;
        }
        public Node Head { get; private set; }
        public void Add(T data)
        {
            var newNode = new Node(data);
            if (Head == null) Head = newNode;
            else
            {
                var current = Head;
                while (current.Next != null) current = current.Next;
                current.Next = newNode;
            }
        }
        public void Display()
        {
            var current = Head;
            var items = new List<T>();
            while (current != null) { items.Add(current.Data); current = current.Next; }
            Console.WriteLine($"Список: [{string.Join(" -> ", items)}]");
        }
    }

    // Задание 8: Generic метод для сортировки
    public static class SortHelper
    {
        public static void BubbleSort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - i - 1; j++)
                    if (array[j].CompareTo(array[j + 1]) > 0)
                        Swap(ref array[j], ref array[j + 1]);
        }
        private static void Swap<T>(ref T a, ref T b) => (a, b) = (b, a);
    }

    // Задание 9: Generic интерфейс IRepository
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        private List<T> _entities = new List<T>();
        public void Add(T entity) => _entities.Add(entity);
        public T GetById(int id) => id >= 0 && id < _entities.Count ? _entities[id] : null;
        public IEnumerable<T> GetAll() => _entities;
    }

    // Задание 10: Generic класс Matrix
    public class Matrix<T>
    {
        private T[,] _matrix;
        public int Rows { get; }
        public int Columns { get; }
        public Matrix(int rows, int columns) { Rows = rows; Columns = columns; _matrix = new T[rows, columns]; }
        public T this[int row, int col]
        {
            get => _matrix[row, col];
            set => _matrix[row, col] = value;
        }
        public void Display()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                    Console.Write($"{_matrix[i, j]}\t");
                Console.WriteLine();
            }
        }
    }

    // Задание 11: Generic метод для конвертации коллекции
    public static class CollectionConverter
    {
        public static List<TOut> Convert<TIn, TOut>(IEnumerable<TIn> collection, Func<TIn, TOut> converter)
            => collection.Select(converter).ToList();
    }

    // Задание 12: Generic класс History
    public class History<T>
    {
        private Stack<T> _history = new Stack<T>();
        private Stack<T> _future = new Stack<T>();
        public void Add(T item) { _history.Push(item); _future.Clear(); }
        public T Undo()
        {
            if (_history.Count == 0) return default;
            var item = _history.Pop();
            _future.Push(item);
            return item;
        }
        public T Redo()
        {
            if (_future.Count == 0) return default;
            var item = _future.Pop();
            _history.Push(item);
            return item;
        }
    }

    // Задание 13: Generic метод для фильтрации
    public static class FilterHelper
    {
        public static IEnumerable<T> Filter<T>(IEnumerable<T> collection, Predicate<T> predicate)
            => collection.Where(item => predicate(item));
    }

    // Задание 14: Generic класс Graph
    public class Graph<T> where T : IEquatable<T>
    {
        private Dictionary<T, List<T>> _adjacencyList = new Dictionary<T, List<T>>();
        public void AddVertex(T vertex) => _adjacencyList[vertex] = new List<T>();
        public void AddEdge(T source, T destination)
        {
            if (!_adjacencyList.ContainsKey(source)) AddVertex(source);
            if (!_adjacencyList.ContainsKey(destination)) AddVertex(destination);
            _adjacencyList[source].Add(destination);
            _adjacencyList[destination].Add(source);
        }
    }

    // Задание 15: Generic метод для поиска минимума и максимума
    public static class MinMaxFinder
    {
        public static (T min, T max) FindMinMax<T>(IEnumerable<T> collection) where T : IComparable<T>
        {
            if (!collection.Any()) throw new ArgumentException("Коллекция пуста");
            T min = collection.First(), max = collection.First();
            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0) min = item;
                if (item.CompareTo(max) > 0) max = item;
            }
            return (min, max);
        }
    }

    // Задание 16: Generic класс Container с ограничениями
    public class Container<T> where T : class, new()
    {
        private T _item = new T();
        public T Item { get => _item; set => _item = value ?? throw new ArgumentNullException(); }
        public void Reset() => _item = new T();
    }

    // Задание 17: Generic метод для обхода дерева
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();
        public TreeNode(T data) => Data = data;
        public void AddChild(TreeNode<T> child) => Children.Add(child);
    }

    public static class TreeTraversal
    {
        public static void Traverse<T>(TreeNode<T> root, Action<T> action)
        {
            if (root == null) return;
            action(root.Data);
            foreach (var child in root.Children) Traverse(child, action);
        }
    }

    // Задание 18: Generic интерфейс IComparer
    public interface IGenericComparer<T>
    {
        int Compare(T x, T y);
    }

    // Задание 19: Generic класс EventDispatcher
    public class EventDispatcher<T>
    {
        private event Action<T> OnEvent;
        public void Subscribe(Action<T> handler) => OnEvent += handler;
        public void Unsubscribe(Action<T> handler) => OnEvent -= handler;
        public void Dispatch(T eventData) => OnEvent?.Invoke(eventData);
    }

    // Задание 20: Generic метод для клонирования
    public static class CloneHelper
    {
        public static T Clone<T>(T obj) where T : ICloneable => (T)obj.Clone();
    }

    // Задание 21: Generic класс Converter
    public class Converter<TIn, TOut>
    {
        private readonly Func<TIn, TOut> _conversionFunction;
        public Converter(Func<TIn, TOut> conversionFunction) => _conversionFunction = conversionFunction;
        public TOut Convert(TIn input) => _conversionFunction(input);
    }

    // Задание 22: Generic метод для валидации
    public static class Validator
    {
        public static bool Validate<T>(T value, Predicate<T> validationRule) => validationRule(value);
    }

    // Задание 23: Generic класс Handler
    public class Handler<TRequest, TResponse>
    {
        private readonly Func<TRequest, TResponse> _handleFunction;
        public Handler(Func<TRequest, TResponse> handleFunction) => _handleFunction = handleFunction;
        public TResponse Handle(TRequest request) => _handleFunction(request);
    }

    // Задание 24: Generic метод для группировки по типам
    public static class TypeGrouper
    {
        public static Dictionary<Type, List<object>> GroupByType(IEnumerable<object> items)
            => items.GroupBy(item => item.GetType()).ToDictionary(g => g.Key, g => g.ToList());
    }

    // Задание 25: Generic класс Pipeline
    public class Pipeline<T>
    {
        private List<Func<T, T>> _stages = new List<Func<T, T>>();
        public Pipeline<T> AddStage(Func<T, T> stage) { _stages.Add(stage); return this; }
        public T Execute(T input)
        {
            T result = input;
            foreach (var stage in _stages) result = stage(result);
            return result;
        }
    }

    // ==================== РАЗДЕЛ 2: VARIANCE (ЗАДАНИЯ 26-50) ====================

    // Задание 26: Ковариантный интерфейс IProducer
    public interface IProducer<out T>
    {
        T Produce();
    }

    // Задание 27: Контрвариантный интерфейс IConsumer
    public interface IConsumer<in T>
    {
        void Consume(T item);
    }

    // Задание 28: Пример ковариантности с IEnumerable
    public class Animal { public string Name { get; set; } }
    public class Dog : Animal { }
    public class Puppy : Dog { }

    // Задание 29: Контрвариантный делегат Action
    public class ContravarianceDemo
    {
        public static void RegisterAnimalHandler(Action<Animal> handler) => handler(new Animal { Name = "Тест" });
    }

    // Задание 30: Ковариантный делегат Func
    public class FuncCovarianceDemo
    {
        public static void UseAnimalFactory(Func<Animal> factory) => Console.WriteLine($"Создано: {factory().Name}");
    }

    // Задание 31: Иерархия классов для демонстрации вариантности
    public class AnimalHierarchy
    {
        public static void Demo()
        {
            Animal animal = new Animal { Name = "Животное" };
            Dog dog = new Dog { Name = "Собака" };
            Puppy puppy = new Puppy { Name = "Щенок" };
        }
    }

    // Задание 32: Пример ошибки при нарушении правил вариантности
    // public interface IViolation<in T> { T GetItem(); } // Ошибка компиляции

    // Задание 33: Generic интерфейс с ковариантными параметрами
    public interface IReadOnlyRepository<out T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }

    // Задание 34: Контрвариантный компаратор
    public interface IGenericComparerContravariant<in T>
    {
        int Compare(T x, T y);
    }

    // Задание 35: Пример ковариантности с коллекциями
    public class CollectionVarianceDemo
    {
        public static void Demo()
        {
            IEnumerable<Dog> dogs = new List<Dog> { new Dog { Name = "Rex" } };
            IEnumerable<Animal> animals = dogs; // Ковариантность
        }
    }

    // Задание 36: Generic класс с поддержкой вариантности
    public class VariantWrapper<T> : IProducer<T>, IConsumer<T>
    {
        private T _value;
        public T Produce() => _value;
        public void Consume(T item) => _value = item;
    }

    // Задание 37: Ковариантный Factory
    public interface IAnimalFactory<out T> where T : Animal
    {
        T Create();
    }

    public class DogFactory : IAnimalFactory<Dog>
    {
        public Dog Create() => new Dog { Name = "Собака" };
    }

    // Задание 38: Контрвариантный обработчик EventHandler
    public interface IEventHandler<in TEvent>
    {
        void Handle(TEvent @event);
    }

    // Задание 39: Пример безопасного приведения типов
    public class SafeCastingDemo
    {
        public static void ProcessAsAnimal<T>(T animal) where T : Animal
        {
            Animal baseAnimal = animal; // Безопасное приведение
        }
    }

    // Задание 40: Интерфейс Repository с ковариантностью
    public interface ICovariantRepository<out T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
    }

    // Задание 41: Контрвариантный validator
    public interface IValidator<in T>
    {
        bool Validate(T item);
    }

    // Задание 42: Комбинирование ковариантности и контрвариантности
    public interface IProcessor<in TInput, out TOutput>
    {
        TOutput Process(TInput input);
    }

    // Задание 43: Generic метод с ограничениями для вариантности
    public class VarianceConstraints
    {
        public static void ProcessProducers<T>(IEnumerable<IProducer<T>> producers) where T : Animal
        {
            foreach (var producer in producers) producer.Produce();
        }
    }

    // Задание 44: Ковариантный интерфейс для итераторов
    public interface IIterator<out T>
    {
        T Current { get; }
        bool MoveNext();
    }

    // Задание 45: Контрвариантный интерфейс для обработки ошибок
    public interface IErrorHandler<in TError>
    {
        void HandleError(TError error);
    }

    // Задание 46: Пример вариантности в делегатах
    public class DelegateVarianceDemo
    {
        public static void Demo()
        {
            Func<Dog> dogFactory = () => new Dog();
            Func<Animal> animalFactory = dogFactory; // Ковариантность
        }
    }

    // Задание 47: Generic класс с явным указанием вариантности
    public class VariantContainer<T> : IProducer<T>, IConsumer<T>
    {
        private T _value;
        public T Produce() => _value;
        public void Consume(T item) => _value = item;
    }

    // Задание 48: Интерфейс для преобразования данных с вариантностью
    public interface ITransformer<in TInput, out TOutput>
    {
        TOutput Transform(TInput input);
    }

    // Задание 49: Система типов с поддержкой ковариантности
    public class TypeSystemWithVariance
    {
        public static void ProcessAnimalProducers(IEnumerable<IProducer<Animal>> producers)
        {
            foreach (var producer in producers) producer.Produce();
        }
    }

    // Задание 50: Generic интерфейс с multiple вариантными параметрами
    public interface IVariantRepository<in TKey, out TValue>
    {
        TValue Get(TKey key);
    }

    // ==================== РАЗДЕЛ 3: NULLABLE TYPES (ЗАДАНИЯ 51-75) ====================

    // Задание 51: Nullable тип int?
    public class NullableIntDemo
    {
        public static void Demo()
        {
            int? nullableInt = null;
            int? anotherNullable = 42;
            Console.WriteLine($"nullableInt: {nullableInt?.ToString() ?? "null"}");
            Console.WriteLine($"anotherNullable: {anotherNullable}");
        }
    }

    // Задание 52: Методы для работы с nullable типами
    public static class NullableHelper
    {
        public static T? CreateNullable<T>(T value) where T : struct => value;
        public static bool HasValue<T>(T? nullable) where T : struct => nullable.HasValue;
        public static T GetValueOrDefault<T>(T? nullable, T defaultValue = default) where T : struct
            => nullable ?? defaultValue;
    }

    // Задание 53: Generic метод для работы с Nullable
    public static class GenericNullableHelper
    {
        public static void ProcessNullable<T>(T? value) where T : struct
        {
            if (value.HasValue) Console.WriteLine($"Значение: {value.Value}");
            else Console.WriteLine("Значение отсутствует");
        }
    }

    // Задание 54: Проверка nullable значения перед использованием
    public static class NullableSafety
    {
        public static void SafeAccess<T>(T? nullable, Action<T> action) where T : struct
        {
            if (nullable.HasValue) action(nullable.Value);
            else Console.WriteLine("Попытка доступа к null значению предотвращена");
        }
    }

    // Задание 55: Пример использования Nullable в структурах
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y) { X = x; Y = y; }
        public override string ToString() => $"({X}, {Y})";
    }

    // Задание 56: Метод для конвертации между nullable типами
    public static class NullableConverter
    {
        public static TTarget? Convert<TSource, TTarget>(TSource? source, Func<TSource, TTarget> converter)
            where TSource : struct where TTarget : struct
            => source.HasValue ? converter(source.Value) : (TTarget?)null;
    }

    // Задание 57: Класс для работы с опциональными значениями
    public class Optional<T>
    {
        private readonly T _value;
        private readonly bool _hasValue;
        public Optional() { _hasValue = false; _value = default; }
        public Optional(T value) { _value = value; _hasValue = true; }
        public bool HasValue => _hasValue;
        public T Value => _hasValue ? _value : throw new InvalidOperationException("Значение отсутствует");
        public T GetValueOrDefault(T defaultValue = default) => _hasValue ? _value : defaultValue;
    }

    // Задание 58: Методы Equals и GetHashCode для nullable типов
    public static class NullableComparer
    {
        public static bool AreEqual<T>(T? first, T? second) where T : struct, IEquatable<T>
        {
            if (!first.HasValue && !second.HasValue) return true;
            if (first.HasValue && second.HasValue) return first.Value.Equals(second.Value);
            return false;
        }
    }

    // Задание 59: Пример использования nullable типов в свойствах класса
    public class UserProfile
    {
        public string Username { get; set; }
        public int? Age { get; set; }
        public decimal? Salary { get; set; }
        public string GetProfileInfo() => $"Пользователь: {Username}, Возраст: {Age?.ToString() ?? "не указан"}";
    }

    // Задание 60: Валидация данных с использованием nullable типов
    public static class DataValidator
    {
        public static (bool isValid, string error) ValidateAge(int? age)
        {
            if (!age.HasValue) return (false, "Возраст обязателен");
            return (age >= 0 && age <= 150, "Возраст должен быть от 0 до 150");
        }
    }

    // Задание 61: Метод для получения значения или значения по умолчанию
    public static class DefaultValueProvider
    {
        public static T GetValueOrDefault<T>(T? nullable, T defaultValue = default) where T : struct
            => nullable ?? defaultValue;
    }

    // Задание 62: Коллекция nullable значений
    public class NullableCollection<T> where T : struct
    {
        private List<T?> _items = new List<T?>();
        public void Add(T? item) => _items.Add(item);
        public IEnumerable<T> GetNonNullValues() => _items.Where(item => item.HasValue).Select(item => item.Value);
    }

    // Задание 63: Пример преобразования null в значение по умолчанию
    public static class NullToDefaultConverter
    {
        public static T ConvertNullToDefault<T>(T? nullable) where T : struct => nullable ?? default;
    }

    // Задание 64: Система для работы с опциональными параметрами
    public class Configuration
    {
        private Dictionary<string, object> _settings = new Dictionary<string, object>();
        public void SetSetting<T>(string key, T value) where T : struct => _settings[key] = value;
        public T? GetSetting<T>(string key) where T : struct
            => _settings.TryGetValue(key, out object value) && value is T typedValue ? typedValue : (T?)null;
    }

    // Задание 65: Метод для создания nullable копии объекта
    public static class NullableCopyCreator
    {
        public static T? CreateNullableCopy<T>(T value) where T : struct => value;
    }

    // Задание 66: Сравнение nullable значений
    public class NullableValueComparer<T> where T : struct, IComparable<T>
    {
        public static int Compare(T? x, T? y)
        {
            if (!x.HasValue && !y.HasValue) return 0;
            if (!x.HasValue) return -1;
            if (!y.HasValue) return 1;
            return x.Value.CompareTo(y.Value);
        }
    }

    // Задание 67: Пример использования nullable в LINQ запросах
    public static class NullableLinqDemo
    {
        public static void Demo()
        {
            var numbers = new int?[] { 1, null, 3, null, 5 };
            var nonNullNumbers = numbers.Where(n => n.HasValue).Select(n => n.Value);
            Console.WriteLine($"Не-null числа: [{string.Join(", ", nonNullNumbers)}]");
        }
    }

    // Задание 68: Обработка исключений при работе с nullable
    public static class NullableExceptionHandler
    {
        public static T SafeGetValue<T>(T? nullable, string errorMessage = "Значение отсутствует") where T : struct
        {
            try { return nullable ?? throw new InvalidOperationException(errorMessage); }
            catch (InvalidOperationException ex) { Console.WriteLine($"Ошибка: {ex.Message}"); return default; }
        }
    }

    // Задание 69: Метод для фильтрации null значений из коллекции
    public static class NullFilter
    {
        public static IEnumerable<T> FilterNulls<T>(IEnumerable<T?> source) where T : struct
            => source.Where(item => item.HasValue).Select(item => item.Value);
    }

    // Задание 70: Класс Wrapper для обеспечения nullability
    public class NullableWrapper<T> where T : struct
    {
        private T? _value;
        public bool HasValue => _value.HasValue;
        public T Value => _value ?? throw new InvalidOperationException("Значение отсутствует");
        public void SetValue(T value) => _value = value;
        public T GetValueOrDefault(T defaultValue = default) => _value ?? defaultValue;
    }

    // Задание 71: Пример использования nullable типов в генериках
    public class GenericNullableUsage<T> where T : struct
    {
        private T? _storage;
        public void Store(T value) => _storage = value;
        public T? Retrieve() => _storage;
    }

    // Задание 72: Мэпер для преобразования null значений
    public static class NullableMapper
    {
        public static TTarget Map<TSource, TTarget>(TSource? source, Func<TSource, TTarget> mapper, TTarget defaultValue = default)
            where TSource : struct => source.HasValue ? mapper(source.Value) : defaultValue;
    }

    // Задание 73: Система для работы с отсутствующими значениями
    public class MissingValueHandler<T> where T : struct
    {
        private T? _value;
        public void SetValue(T value) => _value = value;
        public void MarkAsMissing() => _value = null;
        public T GetValue() => _value ?? default;
        public bool IsMissing => !_value.HasValue;
    }

    // Задание 74: Логирование nullable значений
    public static class NullableLogger
    {
        public static void LogValue<T>(string name, T? value) where T : struct
        {
            Console.WriteLine(value.HasValue ? $"{name}: {value.Value}" : $"{name}: [NULL]");
        }
    }

    // Задание 75: Пример кеширования nullable результатов
    public class NullableCache<TKey, TValue> where TValue : struct
    {
        private Dictionary<TKey, TValue?> _cache = new Dictionary<TKey, TValue?>();
        public TValue? Get(TKey key) => _cache.TryGetValue(key, out TValue? value) ? value : null;
        public void Set(TKey key, TValue? value) => _cache[key] = value;
    }

    // ==================== РАЗДЕЛ 4: NULL-COALESCING (ЗАДАНИЯ 76-100) ====================

    // Задание 76: Оператор ?? для строк
    public static class StringNullCoalescing
    {
        public static void Demo()
        {
            string nullString = null;
            string result = nullString ?? "Default String";
            Console.WriteLine($"Результат: '{result}'");
        }
    }

    // Задание 77: Использование ?? для обработки null значений
    public static class NullCoalescingHelper
    {
        public static T GetValueOrDefault<T>(T value, T defaultValue) where T : class => value ?? defaultValue;
        public static string SafeToString(object obj) => obj?.ToString() ?? "[NULL]";
    }

    // Задание 78: Цепочка операторов ??
    public static class ChainNullCoalescing
    {
        public static T FirstNonNull<T>(params T[] values) where T : class
            => values.FirstOrDefault(value => value != null);
    }

    // Задание 79: Метод для получения первого не-null значения
    public static class FirstNonNullFinder
    {
        public static T FindFirstNonNull<T>(IEnumerable<T> sequence, T defaultValue = default) where T : class
            => sequence.FirstOrDefault(item => item != null) ?? defaultValue;
    }

    // Задание 80: Оператор ??= (null-coalescing assignment)
    public static class NullCoalescingAssignment
    {
        public static void Demo()
        {
            string text = null;
            text ??= "Default Text";
            Console.WriteLine($"text: {text}");
        }
    }

    // Задание 81: Использование ?? в условных выражениях
    public static class ConditionalNullCoalescing
    {
        public static string GetDisplayName(string name, string fallback)
            => (name != null && name.Length > 0 ? name : fallback) ?? "Anonymous";
    }

    // Задание 82: Метод для установки значения только если null
    public static class SetIfNullHelper
    {
        public static void SetIfNull<T>(ref T field, T value) where T : class => field ??= value;
    }

    // Задание 83: Использование ?? с коллекциями
    public static class CollectionNullCoalescing
    {
        public static IEnumerable<T> GetSafeCollection<T>(IEnumerable<T> collection) => collection ?? Enumerable.Empty<T>();
    }

    // Задание 84: Пример ?? в LINQ выражениях
    public static class LinqNullCoalescing
    {
        public static void Demo()
        {
            var users = new[] { new { Name = "Alice", Age = (int?)25 }, new { Name = "Bob", Age = (int?)null } };
            var namesWithAge = users.Select(u => $"{u.Name} ({(u.Age?.ToString() ?? "Unknown")})");
            Console.WriteLine($"Пользователи: {string.Join(", ", namesWithAge)}");
        }
    }

    // Задание 85: Обработка null ссылок на объекты через ??
    public static class ObjectNullCoalescing
    {
        public static string GetProductName(Product product) => product?.Name ?? "Unnamed Product";
    }

    public class Product { public string Name { get; set; } public decimal Price { get; set; } }

    // Задание 86: Метод для установки значения свойства если null
    public static class PropertyNullCoalescing
    {
        public static void InitializeIfNull<T>(ref T property, T value) where T : class => property ??= value;
    }

    // Задание 87: Использование ?? в обработчиках событий
    public static class EventNullCoalescing
    {
        public static void SafeInvoke<T>(EventHandler<T> handler, object sender, T args) where T : EventArgs
            => handler?.Invoke(sender, args);
    }

    // Задание 88: Пример ?? при парсинге данных
    public static class ParsingNullCoalescing
    {
        public static int? SafeParseInt(string input) => int.TryParse(input, out int result) ? result : (int?)null;
        public static int ParseIntWithFallback(string input, int fallback = 0) => int.TryParse(input, out int result) ? result : fallback;
    }

    // Задание 89: Цепочка вызовов с ?? (null-safe navigation)
    public static class NullSafeNavigation
    {
        public static string GetDeepValue(Company company) => company?.Department?.Manager?.Name ?? "No Manager";
    }

    public class Company { public Department Department { get; set; } }
    public class Department { public Employee Manager { get; set; } }
    public class Employee { public string Name { get; set; } }

    // Задание 90: Метод для работы с null в коллекциях через ??
    public static class CollectionNullSafety
    {
        public static IEnumerable<T> ConcatSafe<T>(IEnumerable<T> first, IEnumerable<T> second)
            => (first ?? Enumerable.Empty<T>()).Concat(second ?? Enumerable.Empty<T>());
    }

    // Задание 91: Использование ?? для параметров метода
    public static class MethodParameterNullCoalescing
    {
        public static void ProcessItems(IEnumerable<string> items, string defaultItem = "default")
        {
            var safeItems = items ?? new[] { defaultItem };
            foreach (var item in safeItems) Console.WriteLine($"Обработка: {item}");
        }
    }

    // Задание 92: Пример ?? с методом Invoke на делегатах
    public static class DelegateNullCoalescing
    {
        public static void SafeInvoke(Action action, Action defaultAction = null)
            => (action ?? defaultAction ?? (() => Console.WriteLine("No action")))?.Invoke();
    }

    // Задание 93: Обработка null в асинхронных методах через ??
    public static class AsyncNullCoalescing
    {
        public static async Task<string> GetDataAsync(string source, string fallbackSource)
        {
            await Task.Delay(100);
            return source ?? fallbackSource ?? "Default Data";
        }
    }

    // Задание 94: Пример ?? при работе с конфигурацией
    public static class ConfigurationNullCoalescing
    {
        public class AppConfig { public string DatabaseConnection { get; set; } public int? Timeout { get; set; } }
        public static AppConfig GetSafeConfig(AppConfig userConfig, AppConfig defaultConfig) => new AppConfig
        {
            DatabaseConnection = userConfig?.DatabaseConnection ?? defaultConfig?.DatabaseConnection ?? "Default",
            Timeout = userConfig?.Timeout ?? defaultConfig?.Timeout ?? 30
        };
    }

    // Задание 95: Использование ?? для установки значений по умолчанию
    public static class DefaultValueSetter
    {
        public static T SetDefaultIfNull<T>(T value, T defaultValue) where T : class => value ?? defaultValue;
    }

    // Задание 96: Метод для преобразования null в пустую коллекцию
    public static class EmptyCollectionConverter
    {
        public static IEnumerable<T> AsEmptyIfNull<T>(IEnumerable<T> collection) => collection ?? Enumerable.Empty<T>();
    }

    // Задание 97: Логирование с использованием ?? для сообщений
    public static class NullSafeLogger
    {
        public static void LogInfo(string message, string category = null)
        {
            string logMessage = $"[{category ?? "General"}] {message ?? "No message"}";
            Console.WriteLine(logMessage);
        }
    }

    // Задание 98: Пример ?? при работе с базой данных
    public static class DatabaseNullCoalescing
    {
        public class DatabaseRecord { public string Name { get; set; } public int? Age { get; set; } }
        public static string GetRecordDisplay(DatabaseRecord record) => $@"
Name: {record?.Name ?? "Unknown"}
Age: {record?.Age?.ToString() ?? "Not specified"}";
    }

    // Задание 99: Использование ?? в конструкторах классов
    public class SmartClass
    {
        private string _name;
        private List<int> _numbers;
        public SmartClass(string name, List<int> numbers)
        {
            _name = name ?? "Default Name";
            _numbers = numbers ?? new List<int> { 1, 2, 3 };
        }
    }

    // Задание 100: Метод для валидации и установки значений через ??
    public static class ValidationAndAssignment
    {
        public static bool TrySetValue<T>(ref T field, T newValue, T defaultValue = default) where T : class
        {
            field = newValue ?? defaultValue;
            return newValue != null;
        }
    }

    // ==================== ОСНОВНОЙ КОД ДЛЯ ДЕМОНСТРАЦИИ ====================

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" РЕАЛИЗАЦИЯ ЗАДАЧ ПО GENERICS, VARIANCE, NULLABLE И NULL-COALESCING\n");

            // Демонстрация Generics
            Console.WriteLine("=== GENERICS ДЕМО ===");
            var stack = new Stack<int>();
            stack.Push(1); stack.Push(2); stack.Push(3);
            stack.Display();
            Console.WriteLine($"Pop: {stack.Pop()}");
            stack.Display();

            var (min, max) = MinMaxFinder.FindMinMax(new[] { 5, 2, 8, 1, 9 });
            Console.WriteLine($"Min: {min}, Max: {max}");

            // Демонстрация Variance
            Console.WriteLine("\n=== VARIANCE ДЕМО ===");
            IEnumerable<Dog> dogs = new List<Dog> { new Dog { Name = "Rex" } };
            IEnumerable<Animal> animals = dogs;
            Console.WriteLine("Ковариантность работает!");

            // Демонстрация Nullable
            Console.WriteLine("\n=== NULLABLE ДЕМО ===");
            int? nullableInt = null;
            Console.WriteLine($"Nullable int: {nullableInt?.ToString() ?? "null"}");
            Console.WriteLine($"With default: {nullableInt ?? 100}");

            // Демонстрация Null-coalescing
            Console.WriteLine("\n=== NULL-COALESCING ДЕМО ===");
            string test = null;
            Console.WriteLine($"Result: {test ?? "Default Value"}");

            Console.ReadLine();
        }
    }
}