using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using static Boxing.VarianceTasks;

namespace Boxing
{
    // Методы расширения должны быть на верхнем уровне namespace
    public static class DaysOfWeekExtensions
    {
        public static bool IsWeekend(this DaysOfWeek day)
        {
            return day == DaysOfWeek.Saturday || day == DaysOfWeek.Sunday;
        }
    }

    public static class EnumDescriptionExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute?.Description ?? value.ToString();
        }
    }

    public static class OrderStatusTransitions
    {
        private static readonly Dictionary<OrderStatus, OrderStatus[]> _allowedTransitions =
            new Dictionary<OrderStatus, OrderStatus[]>
            {
                [OrderStatus.Pending] = new[] { OrderStatus.Processing, OrderStatus.Cancelled },
                [OrderStatus.Processing] = new[] { OrderStatus.Completed, OrderStatus.Cancelled },
                [OrderStatus.Completed] = Array.Empty<OrderStatus>(),
                [OrderStatus.Cancelled] = Array.Empty<OrderStatus>()
            };

        public static bool CanTransitionTo(this OrderStatus current, OrderStatus next)
        {
            return _allowedTransitions[current].Contains(next);
        }

        public static OrderStatus[] GetPossibleTransitions(this OrderStatus current)
        {
            return _allowedTransitions[current];
        }
    }

    public static class CyclicEnum
    {
        public static T Next<T>(this T value) where T : Enum
        {
            T[] values = Enum.GetValues(typeof(T)).Cast<T>().ToArray();
            int currentIndex = Array.IndexOf(values, value);
            int nextIndex = (currentIndex + 1) % values.Length;
            return values[nextIndex];
        }
    }

    public static class ColorExtensions
    {
        public static (int r, int g, int b) GetRGB(this Color color)
        {
            return color switch
            {
                Color.Red => (255, 0, 0),
                Color.Green => (0, 255, 0),
                Color.Blue => (0, 0, 255),
                _ => (0, 0, 0)
            };
        }
    }

    public static class FlagsCounter
    {
        public static int CountSetFlags<T>(this T flags) where T : Enum
        {
            int value = Convert.ToInt32(flags);
            int count = 0;

            while (value != 0)
            {
                count++;
                value &= value - 1;
            }

            return count;
        }
    }

    public static class PriorityExtensions
    {
        public static bool IsHigherThan(this Priority current, Priority other)
        {
            return current > other;
        }
    }

    public static class EnumLocalization
    {
        private static readonly Dictionary<Color, string> _russianNames = new()
        {
            [Color.Red] = "Красный",
            [Color.Green] = "Зеленый",
            [Color.Blue] = "Синий"
        };

        public static string GetLocalizedName(this Color color)
        {
            return _russianNames.GetValueOrDefault(color, color.ToString());
        }
    }

    public static class StatusIcons
    {
        public static string GetIcon(this OrderStatus status)
        {
            return status switch
            {
                OrderStatus.Pending => "⏳",
                OrderStatus.Processing => "⚙️",
                OrderStatus.Completed => "✅",
                OrderStatus.Cancelled => "❌",
                _ => "📄"
            };
        }
    }

    public static class TrafficLightController
    {
        public static TrafficLight Next(this TrafficLight current)
        {
            return current switch
            {
                TrafficLight.Red => TrafficLight.Green,
                TrafficLight.Green => TrafficLight.Yellow,
                TrafficLight.Yellow => TrafficLight.Red,
                _ => TrafficLight.Red
            };
        }

        public static string GetDescription(this TrafficLight light)
        {
            return light switch
            {
                TrafficLight.Red => "🔴 Красный - СТОП",
                TrafficLight.Yellow => "🟡 Желтый - ВНИМАНИЕ",
                TrafficLight.Green => "🟢 Зеленый - МОЖНО ЕХАТЬ",
                _ => "Неизвестно"
            };
        }
    }

    public static class PaymentMethodExtensions
    {
        private static readonly Dictionary<PaymentMethod, decimal> _processingFees = new()
        {
            [PaymentMethod.CreditCard] = 0.03m,
            [PaymentMethod.PayPal] = 0.029m,
            [PaymentMethod.BankTransfer] = 0.01m,
            [PaymentMethod.Cash] = 0m
        };

        public static decimal CalculateProcessingFee(this PaymentMethod method, decimal amount)
        {
            return amount * _processingFees[method];
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<Animal> AsAnimals(this IEnumerable<Dog> dogs)
        {
            foreach (Dog dog in dogs)
                yield return dog;
        }
    }

    // Добавляем метод расширения для Dog
    public static class DogExtensions
    {
        public static void Accept<T>(this Dog dog, IVisitor<T> visitor) where T : Animal
        {
            if (visitor is IVisitor<Dog> dogVisitor)
            {
                dogVisitor.Visit(dog);
            }
        }
    }

    #region Раздел 1: Упаковка и распаковка (Задания 1-20)

    public class BoxingUnboxingTasks
    {
        // Задание 1: Упаковка int в object с измерением производительности
        public static void Task1_BoxingPerformance()
        {
            Console.WriteLine("=== Задание 1: Упаковка int в object ===");

            int value = 42;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 1000000; i++)
            {
                object boxed = value; // Упаковка
            }

            sw.Stop();
            Console.WriteLine($"1,000,000 операций упаковки заняли: {sw.ElapsedMilliseconds} мс");
        }

        // Задание 2: Распаковка с проверкой типа
        public static void Task2_SafeUnboxing()
        {
            Console.WriteLine("\n=== Задание 2: Распаковка с проверкой типа ===");

            object boxedInt = 100;
            object boxedString = "100";

            // Безопасная распаковка с проверкой
            if (boxedInt is int intValue)
            {
                Console.WriteLine($"Успешная распаковка int: {intValue}");
            }

            if (boxedString is int invalidInt)
            {
                Console.WriteLine($"Это не выполнится");
            }
            else
            {
                Console.WriteLine("Невозможно распаковать string в int");
            }

            // Использование as с nullable
            int? nullableResult = boxedInt as int?;
            Console.WriteLine($"Распаковка через as: {nullableResult}");
        }

        // Задание 3: Безопасная распаковка в различные типы
        public static void Task3_SafeUnboxToVariousTypes(object obj)
        {
            Console.WriteLine("\n=== Задание 3: Безопасная распаковка в различные типы ===");

            switch (obj)
            {
                case int i:
                    Console.WriteLine($"Int: {i}, Квадрат: {i * i}");
                    break;
                case double d:
                    Console.WriteLine($"Double: {d}, Округлено: {Math.Round(d)}");
                    break;
                case float f:
                    Console.WriteLine($"Float: {f}");
                    break;
                case decimal dec:
                    Console.WriteLine($"Decimal: {dec}");
                    break;
                case bool b:
                    Console.WriteLine($"Bool: {b}, Инверсия: {!b}");
                    break;
                case char c:
                    Console.WriteLine($"Char: '{c}', Код: {(int)c}");
                    break;
                case string s:
                    Console.WriteLine($"String: '{s}', Длина: {s.Length}");
                    break;
                case DateTime dt:
                    Console.WriteLine($"DateTime: {dt:yyyy-MM-dd HH:mm:ss}");
                    break;
                case null:
                    Console.WriteLine("Null object");
                    break;
                default:
                    Console.WriteLine($"Неизвестный тип: {obj?.GetType().Name ?? "null"}");
                    break;
            }
        }

        // Задание 4: Сравнение производительности
        public static void Task4_PerformanceComparison()
        {
            Console.WriteLine("\n=== Задание 4: Сравнение производительности ===");
            const int iterations = 100000;

            Stopwatch sw = new Stopwatch();

            // С упаковкой
            sw.Start();
            ArrayList withBoxing = new ArrayList();
            for (int i = 0; i < iterations; i++)
            {
                withBoxing.Add(i); // Упаковка
            }
            sw.Stop();
            long withBoxingTime = sw.ElapsedMilliseconds;

            // Без упаковки
            sw.Restart();
            List<int> withoutBoxing = new List<int>();
            for (int i = 0; i < iterations; i++)
            {
                withoutBoxing.Add(i); // Без упаковки
            }
            sw.Stop();
            long withoutBoxingTime = sw.ElapsedMilliseconds;

            Console.WriteLine($"ArrayList (с упаковкой): {withBoxingTime} мс");
            Console.WriteLine($"List<int> (без упаковки): {withoutBoxingTime} мс");
            Console.WriteLine($"Разница: {withBoxingTime - withoutBoxingTime} мс");
        }

        // Задание 5: ArrayList с упаковкой различных типов
        public static void Task5_ArrayListBoxing()
        {
            Console.WriteLine("\n=== Задание 5: ArrayList с упаковкой ===");

            ArrayList arrayList = new ArrayList();

            // Добавление различных типов значений (упаковка)
            arrayList.Add(42);              // int
            arrayList.Add(3.14159);         // double
            arrayList.Add(true);            // bool
            arrayList.Add('X');             // char
            arrayList.Add(DateTime.Now);    // DateTime
            arrayList.Add(100m);            // decimal

            Console.WriteLine("Содержимое ArrayList:");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"[{i}] = {arrayList[i]}, Тип: {arrayList[i].GetType().Name}");
            }
        }

        // Задание 6: Подсчет операций упаковки
        public static void Task6_CountBoxingOperations()
        {
            Console.WriteLine("\n=== Задание 6: Подсчет операций упаковки ===");

            int boxingCount = 0;
            int value = 10;

            // Эмуляция отслеживания упаковки
            object boxed1 = value; boxingCount++;
            ArrayList list = new ArrayList();
            list.Add(value); boxingCount++;
            list.Add(20); boxingCount++;

            Console.WriteLine($"Подсчитано операций упаковки: {boxingCount}");
        }

        // Задание 7: Сравнение List и ArrayList
        public static void Task7_ListVsArrayList()
        {
            Console.WriteLine("\n=== Задание 7: Сравнение List и ArrayList ===");
            const int count = 10000;

            Stopwatch sw = new Stopwatch();

            // ArrayList
            sw.Start();
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < count; i++)
            {
                arrayList.Add(i); // Упаковка
            }
            sw.Stop();
            long arrayListTime = sw.ElapsedMilliseconds;

            // List<int>
            sw.Restart();
            List<int> list = new List<int>();
            for (int i = 0; i < count; i++)
            {
                list.Add(i); // Без упаковки
            }
            sw.Stop();
            long listTime = sw.ElapsedMilliseconds;

            Console.WriteLine($"ArrayList: {arrayListTime} мс");
            Console.WriteLine($"List<int>: {listTime} мс");
        }

        // Задание 8: InvalidCastException при неправильной распаковке
        public static void Task8_InvalidCastException()
        {
            Console.WriteLine("\n=== Задание 8: InvalidCastException ===");

            try
            {
                object boxedDouble = 3.14;
                int unboxed = (int)boxedDouble; // InvalidCastException
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Поймана InvalidCastException: {ex.Message}");
            }
        }

        // Задание 9: params object[] с упакованными значениями
        public static void Task9_ParamsObject(params object[] values)
        {
            Console.WriteLine("\n=== Задание 9: params object[] ===");

            Console.WriteLine($"Получено {values.Length} значений:");

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"[{i}] Тип: {values[i]?.GetType().Name ?? "null"}, Значение: {values[i]}");
            }
        }

        // Задание 10: Упаковка структуры в интерфейс
        public interface IMeasurable
        {
            int GetValue();
            void SetValue(int value);
        }

        public struct Measurement : IMeasurable
        {
            public int Value;

            public int GetValue() => Value;
            public void SetValue(int value) => Value = value;
        }

        public static void Task10_StructToInterfaceBoxing()
        {
            Console.WriteLine("\n=== Задание 10: Упаковка структуры в интерфейс ===");

            Measurement measurement = new Measurement { Value = 100 };
            IMeasurable measurable = measurement; // Упаковка

            Console.WriteLine($"До изменения: {measurable.GetValue()}");
            measurable.SetValue(200);
            Console.WriteLine($"После изменения в интерфейсе: {measurable.GetValue()}");
            Console.WriteLine($"Оригинальная структура: {measurement.Value}");
        }

        // Задание 11: Проверка упакованного типа значения
        public static void Task11_IsBoxedValueType(object obj)
        {
            Console.WriteLine("\n=== Задание 11: Проверка упакованного типа ===");

            bool isBoxedValueType = obj != null && obj.GetType().IsValueType;
            Console.WriteLine($"Объект {(isBoxedValueType ? "является" : "не является")} упакованным типом значения");
        }

        // Задание 12: Упаковка nullable типов
        public static void Task12_NullableBoxing()
        {
            Console.WriteLine("\n=== Задание 12: Упаковка nullable типов ===");

            int? nullableInt = 42;
            int? nullInt = null;

            object boxedNotNull = nullableInt;
            object boxedNull = nullInt;

            Console.WriteLine($"int? 42 → {boxedNotNull} ({boxedNotNull?.GetType().Name})");
            Console.WriteLine($"int? null → {boxedNull} ({boxedNull?.GetType()?.Name})");
        }

        // Задание 13: Профилировщик упаковки (упрощенный)
        public static class BoxingProfiler
        {
            private static int _boxingCount = 0;

            public static void TrackBoxing(object obj)
            {
                if (obj != null && obj.GetType().IsValueType)
                {
                    _boxingCount++;
                }
            }

            public static void PrintStats()
            {
                Console.WriteLine($"Операций упаковки: {_boxingCount}");
            }

            public static void Reset()
            {
                _boxingCount = 0;
            }
        }

        public static void Task13_BoxingProfiler()
        {
            Console.WriteLine("\n=== Задание 13: Профилировщик упаковки ===");

            BoxingProfiler.Reset();

            int value = 10;
            object boxed = value; BoxingProfiler.TrackBoxing(boxed);
            ArrayList list = new ArrayList();
            list.Add(value); BoxingProfiler.TrackBoxing(value);

            BoxingProfiler.PrintStats();
        }

        // Задание 14: Generics для избежания упаковки
        public static void Task14_GenericsNoBoxing()
        {
            Console.WriteLine("\n=== Задание 14: Generics для избежания упаковки ===");

            GenericContainer<int> intContainer = new GenericContainer<int>(42);

            Console.WriteLine($"int контейнер: {intContainer.GetValue()} (тип: {intContainer.GetValue().GetType().Name})");
        }

        public class GenericContainer<T>
        {
            private T _value;

            public GenericContainer(T value)
            {
                _value = value;
            }

            public T GetValue() => _value;
        }

        // Задание 15: Сравнение упакованных значений
        public static void Task15_CompareBoxedValues()
        {
            Console.WriteLine("\n=== Задание 15: Сравнение упакованных значений ===");

            object boxed1 = 100;
            object boxed2 = 100;

            Console.WriteLine($"boxed1.Equals(boxed2): {boxed1.Equals(boxed2)}");
        }

        // Задание 16: Упаковка enum
        public enum Status { Active, Inactive, Pending }

        public static void Task16_EnumBoxing()
        {
            Console.WriteLine("\n=== Задание 16: Упаковка enum ===");

            Status status = Status.Active;
            object boxedEnum = status;

            Console.WriteLine($"Исходный enum: {status}");
            Console.WriteLine($"Упакованный: {boxedEnum}");

            Status unboxedEnum = (Status)boxedEnum;
            Console.WriteLine($"Распакованный: {unboxedEnum}");
        }

        // Задание 17: Clone через упаковку
        public struct Point
        {
            public int X, Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public Point CloneViaBoxing()
            {
                object boxed = this;
                return (Point)boxed;
            }

            public override string ToString() => $"({X}, {Y})";
        }

        public static void Task17_CloneViaBoxing()
        {
            Console.WriteLine("\n=== Задание 17: Clone через упаковку ===");

            Point original = new Point(10, 20);
            Point cloned = original.CloneViaBoxing();

            Console.WriteLine($"Оригинал: {original}");
            Console.WriteLine($"Клон: {cloned}");
        }

        // Задание 18: Benchmarking упаковки/распаковки
        public static void Task18_BoxingUnboxingBenchmark()
        {
            Console.WriteLine("\n=== Задание 18: Benchmarking упаковки/распаковки ===");
            const int iterations = 1000000;

            Stopwatch sw = new Stopwatch();

            // С упаковкой/распаковкой
            sw.Start();
            int sumWithBoxing = 0;
            for (int i = 0; i < iterations; i++)
            {
                object boxed = i;
                sumWithBoxing += (int)boxed;
            }
            sw.Stop();
            long withBoxingTime = sw.ElapsedMilliseconds;

            // Без упаковки/распаковки
            sw.Restart();
            int sumWithoutBoxing = 0;
            for (int i = 0; i < iterations; i++)
            {
                sumWithoutBoxing += i;
            }
            sw.Stop();
            long withoutBoxingTime = sw.ElapsedMilliseconds;

            Console.WriteLine($"С упаковкой/распаковкой: {withBoxingTime} мс");
            Console.WriteLine($"Без упаковки/распаковки: {withoutBoxingTime} мс");
        }

        // Задание 19: Кеширование упакованных значений
        public static class BoxedValueCache
        {
            private static readonly Dictionary<int, object> _intCache = new Dictionary<int, object>();

            public static object GetCachedInt(int value)
            {
                if (!_intCache.ContainsKey(value))
                {
                    _intCache[value] = value;
                }
                return _intCache[value];
            }
        }

        public static void Task19_BoxedValueCaching()
        {
            Console.WriteLine("\n=== Задание 19: Кеширование упакованных значений ===");

            object cached1 = BoxedValueCache.GetCachedInt(42);
            object cached2 = BoxedValueCache.GetCachedInt(42);

            Console.WriteLine($"cached1 == cached2 (ссылки): {object.ReferenceEquals(cached1, cached2)}");
        }

        // Задание 20: Изменение упакованного значения через интерфейс
        public interface IModifiable
        {
            int Value { get; set; }
        }

        public struct ModifiableStruct : IModifiable
        {
            public int Value { get; set; }
        }

        public static void Task20_ModifyBoxedValue()
        {
            Console.WriteLine("\n=== Задание 20: Изменение упакованного значения ===");

            ModifiableStruct original = new ModifiableStruct { Value = 10 };
            IModifiable boxed = original;

            Console.WriteLine($"До изменения - оригинал: {original.Value}, упакованный: {boxed.Value}");

            boxed.Value = 20;

            Console.WriteLine($"После изменения - оригинал: {original.Value}, упакованный: {boxed.Value}");
        }
    }

    #endregion

    #region Раздел 2: Виды упаковки (Задания 21-40)

    public class BoxingTypesTasks
    {
        // Задание 21: Явная упаковка
        public static void Task21_ExplicitBoxing()
        {
            Console.WriteLine("\n=== Задание 21: Явная упаковка ===");

            int value = 42;
            object explicitlyBoxed = (object)value;

            Console.WriteLine($"Явная упаковка: {explicitlyBoxed}");
        }

        public static void ProcessObject(object obj)
        {
            Console.WriteLine($"Обработан: {obj} (тип: {obj.GetType().Name})");
        }

        // Задание 22: Неявная упаковка при передаче параметров
        public static void Task22_ImplicitBoxingInParameters()
        {
            Console.WriteLine("\n=== Задание 22: Неявная упаковка в параметрах ===");

            int intValue = 100;
            ProcessObject(intValue);
        }

        // Задание 23: Упаковка при вызове виртуальных методов
        public static void Task23_VirtualMethodBoxing()
        {
            Console.WriteLine("\n=== Задание 23: Упаковка в виртуальных методах ===");

            int value = 42;

            string str1 = value.ToString();

            object boxed = value;
            string str2 = boxed.ToString();

            Console.WriteLine($"ToString без упаковки: {str1}");
            Console.WriteLine($"ToString с упаковкой: {str2}");
        }

        // Задание 24: Упаковка при приведении к интерфейсу IComparable
        public static void Task24_InterfaceCastBoxing()
        {
            Console.WriteLine("\n=== Задание 24: Упаковка при приведении к IComparable ===");

            int value = 42;
            IComparable comparable = value;

            int result = comparable.CompareTo(42);
            Console.WriteLine($"Сравнение 42 с 42: {result}");
        }

        // Задание 25: Упаковка в LINQ
        public static void Task25_LinqBoxing()
        {
            Console.WriteLine("\n=== Задание 25: Упаковка в LINQ ===");

            int[] numbers = { 1, 2, 3, 4, 5 };

            var boxedNumbers = numbers.Select(n => (object)n);

            Console.WriteLine("Упакованные числа:");
            foreach (var number in boxedNumbers)
            {
                Console.WriteLine($"{number} ({number.GetType().Name})");
            }
        }

        // Задание 26: Упаковка в нетипизированных коллекциях
        public static void Task26_UntypedCollectionBoxing()
        {
            Console.WriteLine("\n=== Задание 26: Упаковка в нетипизированных коллекциях ===");

            Hashtable hashtable = new Hashtable();
            ArrayList arrayList = new ArrayList();

            hashtable.Add("number", 42);
            arrayList.Add(123);

            Console.WriteLine("Hashtable содержимое:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key} = {entry.Value}");
            }
        }

        // Задание 27: Упаковка в Reflection
        public static void Task27_ReflectionBoxing()
        {
            Console.WriteLine("\n=== Задание 27: Упаковка в Reflection ===");

            MethodInfo absMethod = typeof(Math).GetMethod("Abs", new[] { typeof(int) });

            int value = -42;
            object[] parameters = { value };

            object result = absMethod.Invoke(null, parameters);

            Console.WriteLine($"Abs(-42) через Reflection: {result}");
        }

        // Задание 28: Упаковка в делегатах
        public static void Task28_DelegateBoxing()
        {
            Console.WriteLine("\n=== Задание 28: Упаковка в делегатах ===");

            Func<object, object> processor = obj =>
            {
                if (obj is int i)
                    return i * 2;
                return obj;
            };

            int value = 21;
            object result = processor(value);

            Console.WriteLine($"Обработано: {result}");
        }

        // Задание 29: Упаковка в событиях EventArgs
        public class ValueEventArgs : EventArgs
        {
            public object Value { get; }

            public ValueEventArgs(object value)
            {
                Value = value;
            }
        }

        public static void Task29_EventBoxing()
        {
            Console.WriteLine("\n=== Задание 29: Упаковка в событиях ===");

            int data = 100;
            var eventArgs = new ValueEventArgs(data);

            Console.WriteLine($"EventArgs значение: {eventArgs.Value}");
        }

        // Задание 30: Упаковка с операторами is и as
        public static void Task30_IsAsBoxing()
        {
            Console.WriteLine("\n=== Задание 30: Упаковка с is/as ===");

            int value = 42;

            if (value is int)
            {
                Console.WriteLine("value is int: true");
            }

            int? nullable = value as int?;
            Console.WriteLine($"value as int?: {nullable}");
        }

        // Задание 31: Упаковка с dynamic
        public static void Task31_DynamicBoxing()
        {
            Console.WriteLine("\n=== Задание 31: Упаковка с dynamic ===");

            int intValue = 42;
            dynamic dynamicInt = intValue;

            Console.WriteLine($"dynamic int: {dynamicInt}");
        }

        // Задание 32: Упаковка при сериализации структур
        public static void Task32_SerializationBoxing()
        {
            Console.WriteLine("\n=== Задание 32: Упаковка при сериализации ===");

            BoxingUnboxingTasks.Point point = new BoxingUnboxingTasks.Point(10, 20);
            object serialized = point;

            BoxingUnboxingTasks.Point deserialized = (BoxingUnboxingTasks.Point)serialized;

            Console.WriteLine($"Оригинал: {point}");
            Console.WriteLine($"После упаковки/распаковки: {deserialized}");
        }

        // Задание 33: Упаковка в String.Format
        public static void Task33_StringFormatBoxing()
        {
            Console.WriteLine("\n=== Задание 33: Упаковка в String.Format ===");

            int age = 25;
            double salary = 50000.75;

            string formatted = String.Format(
                "Возраст: {0}, Зарплата: {1:C}",
                age, salary
            );

            Console.WriteLine("String.Format результат:");
            Console.WriteLine(formatted);
        }

        // Задание 34: Упаковка Nullable<T> в object
        public static void Task34_NullableToObjectBoxing()
        {
            Console.WriteLine("\n=== Задание 34: Упаковка Nullable в object ===");

            int? nullableInt = 42;
            object boxedInt = nullableInt;

            Console.WriteLine($"int? 42 → {boxedInt}");
        }

        // Задание 35: Упаковка в методе Equals
        public static void Task35_EqualsBoxing()
        {
            Console.WriteLine("\n=== Задание 35: Упаковка в Equals ===");

            int value1 = 42;
            int value2 = 42;

            bool equals1 = value1.Equals(value2);

            Console.WriteLine($"42.Equals(42): {equals1}");
        }

        // Задание 36: Упаковка в атрибутах
        public class SampleAttribute : Attribute
        {
            public object Value { get; }

            public SampleAttribute(object value)
            {
                Value = value;
            }
        }

        [Sample(42)]
        public class DecoratedClass { }

        public static void Task36_AttributeBoxing()
        {
            Console.WriteLine("\n=== Задание 36: Упаковка в атрибутах ===");

            var attributes = typeof(DecoratedClass).GetCustomAttributes(typeof(SampleAttribute), false);

            foreach (SampleAttribute attr in attributes)
            {
                Console.WriteLine($"Атрибут значение: {attr.Value}");
            }
        }

        // Задание 37: Упаковка в MethodInfo.Invoke
        public static void Task37_MethodInfoInvokeBoxing()
        {
            Console.WriteLine("\n=== Задание 37: Упаковка в MethodInfo.Invoke ===");

            MethodInfo maxMethod = typeof(Math).GetMethod("Max", new[] { typeof(int), typeof(int) });

            int a = 10, b = 20;
            object[] parameters = { a, b };

            object result = maxMethod.Invoke(null, parameters);

            Console.WriteLine($"Max(10, 20) через Reflection: {result}");
        }

        // Задание 38: Упаковка в WeakReference
        public static void Task38_WeakReferenceBoxing()
        {
            Console.WriteLine("\n=== Задание 38: Упаковка в WeakReference ===");

            int value = 100;
            object boxed = value;

            WeakReference weakRef = new WeakReference(boxed);

            if (weakRef.IsAlive && weakRef.Target != null)
            {
                Console.WriteLine($"WeakReference содержит: {weakRef.Target}");
            }
        }

        // Задание 39: Упаковка в ConditionalWeakTable
        public static void Task39_ConditionalWeakTableBoxing()
        {
            Console.WriteLine("\n=== Задание 39: Упаковка в ConditionalWeakTable ===");

            var table = new ConditionalWeakTable<object, object>();
            int keyValue = 42;
            int dataValue = 100;

            object boxedKey = keyValue;
            object boxedData = dataValue;

            table.Add(boxedKey, boxedData);

            if (table.TryGetValue(boxedKey, out object retrieved))
            {
                Console.WriteLine($"Найдено в таблице: {retrieved}");
            }
        }

        // Задание 40: Сравнение видов упаковки по производительности
        public static void Task40_BoxingTypesPerformance()
        {
            Console.WriteLine("\n=== Задание 40: Сравнение видов упаковки ===");
            const int iterations = 100000;

            Stopwatch sw = new Stopwatch();

            // 1. Прямая упаковка
            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                object boxed = i;
            }
            sw.Stop();
            long directBoxingTime = sw.ElapsedMilliseconds;

            // 2. Упаковка в массиве
            sw.Restart();
            object[] array = new object[iterations];
            for (int i = 0; i < iterations; i++)
            {
                array[i] = i;
            }
            sw.Stop();
            long arrayBoxingTime = sw.ElapsedMilliseconds;

            Console.WriteLine($"Прямая упаковка: {directBoxingTime} мс");
            Console.WriteLine($"Упаковка в массив: {arrayBoxingTime} мс");
        }
    }

    #endregion

    #region Раздел 3: DateTime и TimeSpan (Задания 41-60)

    public class DateTimeTimeSpanTasks
    {
        // Задание 41: Вычисление возраста
        public static void Task41_CalculateAge()
        {
            Console.WriteLine("\n=== Задание 41: Вычисление возраста ===");

            DateTime birthDate = new DateTime(1990, 5, 15);
            DateTime currentDate = DateTime.Now;

            int age = currentDate.Year - birthDate.Year;
            if (currentDate < birthDate.AddYears(age))
                age--;

            Console.WriteLine($"Дата рождения: {birthDate:yyyy-MM-dd}");
            Console.WriteLine($"Возраст: {age} лет");
        }

        // Задание 42: Калькулятор рабочих дней
        public static void Task42_BusinessDaysCalculator()
        {
            Console.WriteLine("\n=== Задание 42: Калькулятор рабочих дней ===");

            DateTime start = new DateTime(2024, 1, 1);
            DateTime end = new DateTime(2024, 1, 15);

            int businessDays = 0;
            DateTime current = start;

            while (current <= end)
            {
                if (current.DayOfWeek != DayOfWeek.Saturday && current.DayOfWeek != DayOfWeek.Sunday)
                {
                    businessDays++;
                }
                current = current.AddDays(1);
            }

            Console.WriteLine($"Период: {start:yyyy-MM-dd} - {end:yyyy-MM-dd}");
            Console.WriteLine($"Рабочих дней: {businessDays}");
        }

        // Задание 43: Дней до конца года
        public static void Task43_DaysUntilEndOfYear()
        {
            Console.WriteLine("\n=== Задание 43: Дней до конца года ===");

            DateTime current = DateTime.Now;
            DateTime endOfYear = new DateTime(current.Year, 12, 31);
            TimeSpan remaining = endOfYear - current;

            Console.WriteLine($"Текущая дата: {current:yyyy-MM-dd}");
            Console.WriteLine($"До конца года: {remaining.Days} дней");
        }

        // Задание 44: Форматирование в различных культурах
        public static void Task44_DateTimeFormatting()
        {
            Console.WriteLine("\n=== Задание 44: Форматирование в различных культурах ===");

            DateTime now = DateTime.Now;

            CultureInfo[] cultures = {
                new CultureInfo("en-US"),
                new CultureInfo("ru-RU"),
                new CultureInfo("de-DE")
            };

            foreach (var culture in cultures)
            {
                Console.WriteLine($"{culture.Name}: {now.ToString(culture)}");
            }
        }

        // Задание 45: Разница между датами в годах, месяцах, днях
        public static void Task45_DateDifferenceDetailed()
        {
            Console.WriteLine("\n=== Задание 45: Разница между датами ===");

            DateTime date1 = new DateTime(2020, 3, 15);
            DateTime date2 = new DateTime(2024, 1, 10);

            int years = date2.Year - date1.Year;
            int months = date2.Month - date1.Month;
            int days = date2.Day - date1.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(date2.Year, date2.Month == 1 ? 12 : date2.Month - 1);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            Console.WriteLine($"Дата 1: {date1:yyyy-MM-dd}");
            Console.WriteLine($"Дата 2: {date2:yyyy-MM-dd}");
            Console.WriteLine($"Разница: {years} лет, {months} месяцев, {days} дней");
        }

        // Задание 46: Парсинг строк в DateTime
        public static void Task46_DateTimeParsing()
        {
            Console.WriteLine("\n=== Задание 46: Парсинг строк в DateTime ===");

            string[] dateStrings = {
                "2024-01-15",
                "15/01/2024",
                "January 15, 2024"
            };

            foreach (string dateString in dateStrings)
            {
                if (DateTime.TryParse(dateString, out DateTime result))
                {
                    Console.WriteLine($"'{dateString}' -> {result:yyyy-MM-dd}");
                }
            }
        }

        // Задание 47: Добавление рабочих дней
        public static void Task47_AddBusinessDays()
        {
            Console.WriteLine("\n=== Задание 47: Добавление рабочих дней ===");

            DateTime startDate = new DateTime(2024, 1, 10);
            int businessDaysToAdd = 5;

            DateTime result = startDate;
            int added = 0;

            while (added < businessDaysToAdd)
            {
                result = result.AddDays(1);
                if (result.DayOfWeek != DayOfWeek.Saturday && result.DayOfWeek != DayOfWeek.Sunday)
                {
                    added++;
                }
            }

            Console.WriteLine($"Начальная дата: {startDate:yyyy-MM-dd}");
            Console.WriteLine($"Добавить рабочих дней: {businessDaysToAdd}");
            Console.WriteLine($"Результат: {result:yyyy-MM-dd}");
        }

        // Задание 48: Проверка високосного года
        public static void Task48_LeapYearCheck()
        {
            Console.WriteLine("\n=== Задание 48: Проверка високосного года ===");

            int[] years = { 2020, 2021, 2024 };

            foreach (int year in years)
            {
                bool isLeap = DateTime.IsLeapYear(year);
                Console.WriteLine($"{year} {(isLeap ? "високосный" : "не високосный")}");
            }
        }

        // Задание 49: Первый и последний день месяца
        public static void Task49_MonthBoundaries()
        {
            Console.WriteLine("\n=== Задание 49: Первый и последний день месяца ===");

            DateTime date = DateTime.Now;
            DateTime firstDay = new DateTime(date.Year, date.Month, 1);
            DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

            Console.WriteLine($"Текущая дата: {date:yyyy-MM-dd}");
            Console.WriteLine($"Первый день месяца: {firstDay:yyyy-MM-dd}");
            Console.WriteLine($"Последний день месяца: {lastDay:yyyy-MM-dd}");
        }

        // Задание 50: Таймер обратного отсчета
        public static void Task50_CountdownTimer()
        {
            Console.WriteLine("\n=== Задание 50: Таймер обратного отсчета ===");

            TimeSpan duration = TimeSpan.FromSeconds(3);
            DateTime endTime = DateTime.Now.Add(duration);

            Console.WriteLine($"Обратный отсчет {duration.TotalSeconds} секунд...");

            while (DateTime.Now < endTime)
            {
                TimeSpan remaining = endTime - DateTime.Now;
                Console.WriteLine($"Осталось: {remaining:ss} сек.");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Время вышло!");
        }

        // Задание 51: Конвертация UTC и локального времени
        public static void Task51_TimeZoneConversion()
        {
            Console.WriteLine("\n=== Задание 51: Конвертация UTC и локального времени ===");

            DateTime utcNow = DateTime.UtcNow;
            DateTime localNow = DateTime.Now;

            Console.WriteLine($"UTC время: {utcNow:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Локальное время: {localNow:yyyy-MM-dd HH:mm:ss}");
        }

        // Задание 52: Определение квартала года
        public static void Task52_GetQuarter()
        {
            Console.WriteLine("\n=== Задание 52: Определение квартала года ===");

            DateTime date = new DateTime(2024, 4, 20);
            int quarter = (date.Month - 1) / 3 + 1;

            Console.WriteLine($"{date:yyyy-MM-dd} → {quarter} квартал");
        }

        // Задание 53: Сравнение дат с точностью до дня
        public static void Task53_DateComparisonDayPrecision()
        {
            Console.WriteLine("\n=== Задание 53: Сравнение дат с точностью до дня ===");

            DateTime date1 = new DateTime(2024, 1, 15, 10, 30, 0);
            DateTime date2 = new DateTime(2024, 1, 15, 14, 45, 0);

            bool sameDay = date1.Date == date2.Date;

            Console.WriteLine($"Дата 1 и Дата 2 в один день: {sameDay}");
        }

        // Задание 54: Секундомер с DateTime
        public static void Task54_DateTimeStopwatch()
        {
            Console.WriteLine("\n=== Задание 54: Секундомер с DateTime ===");

            DateTime start = DateTime.Now;

            Thread.Sleep(1000);

            DateTime end = DateTime.Now;
            TimeSpan elapsed = end - start;

            Console.WriteLine($"Прошло времени: {elapsed.TotalSeconds:F2} секунд");
        }

        // Задание 55: Продолжительность между TimeSpan
        public static void Task55_TimeSpanDuration()
        {
            Console.WriteLine("\n=== Задание 55: Продолжительность между TimeSpan ===");

            TimeSpan start = new TimeSpan(8, 30, 0);
            TimeSpan end = new TimeSpan(17, 45, 0);

            TimeSpan duration = end - start;

            Console.WriteLine($"Начало: {start:hh\\:mm}");
            Console.WriteLine($"Конец: {end:hh\\:mm}");
            Console.WriteLine($"Продолжительность: {duration:hh\\:mm}");
        }

        // Задание 56: Округление DateTime
        public static void Task56_DateTimeRounding()
        {
            Console.WriteLine("\n=== Задание 56: Округление DateTime ===");

            DateTime original = new DateTime(2024, 1, 15, 14, 37, 29);

            DateTime roundedToHour = new DateTime(original.Year, original.Month, original.Day, original.Hour, 0, 0);
            if (original.Minute >= 30) roundedToHour = roundedToHour.AddHours(1);

            Console.WriteLine($"Оригинал: {original:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Округлено до часа: {roundedToHour:yyyy-MM-dd HH:mm:ss}");
        }

        // Задание 57: Неделя года по ISO 8601
        public static void Task57_IsoWeekNumber()
        {
            Console.WriteLine("\n=== Задание 57: Неделя года по ISO 8601 ===");

            DateTime date = new DateTime(2024, 1, 8);
            CultureInfo culture = CultureInfo.InvariantCulture;
            Calendar calendar = culture.Calendar;
            int week = calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            Console.WriteLine($"{date:yyyy-MM-dd} → {week} неделя ISO 8601");
        }

        // Задание 58: Планировщик задач
        public static void Task58_TaskScheduler()
        {
            Console.WriteLine("\n=== Задание 58: Планировщик задач ===");

            DateTime baseTime = DateTime.Now;

            TimeSpan interval = TimeSpan.FromMinutes(1);
            DateTime nextRun = baseTime + interval;

            Console.WriteLine($"Базовое время: {baseTime:HH:mm:ss}");
            Console.WriteLine($"Следующее выполнение: {nextRun:HH:mm:ss}");
        }

        // Задание 59: Работа с TimeZoneInfo
        public static void Task59_TimeZoneInfoDemo()
        {
            Console.WriteLine("\n=== Задание 59: Работа с TimeZoneInfo ===");

            try
            {
                TimeZoneInfo localZone = TimeZoneInfo.Local;
                Console.WriteLine($"Локальная зона: {localZone.DisplayName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        // Задание 60: DateRange класс
        public static void Task60_DateRangeClass()
        {
            Console.WriteLine("\n=== Задание 60: DateRange класс ===");

            DateRange range1 = new DateRange(new DateTime(2024, 1, 1), new DateTime(2024, 1, 31));

            Console.WriteLine($"Диапазон 1: {range1}");
            Console.WriteLine($"Длительность: {range1.Duration.Days} дней");
        }

        public class DateRange
        {
            public DateTime Start { get; }
            public DateTime End { get; }

            public DateRange(DateTime start, DateTime end)
            {
                if (start > end) throw new ArgumentException("Start must be before end");
                Start = start;
                End = end;
            }

            public bool Contains(DateTime date) => date >= Start && date <= End;
            public TimeSpan Duration => End - Start;

            public override string ToString() => $"{Start:yyyy-MM-dd} - {End:yyyy-MM-dd}";
        }
    }

    #endregion

    #region Раздел 4: Ковариантность и контрвариантность (Задания 61-80)

    // Иерархия классов для демонстрации вариантности
    public class Animal
    {
        public string Name { get; set; }
        public virtual void Speak() => Console.WriteLine("Животное издает звук");
    }

    public class Dog : Animal
    {
        public override void Speak() => Console.WriteLine("Собака гавкает: Гав-гав!");
    }

    public class Cat : Animal
    {
        public override void Speak() => Console.WriteLine("Кошка мяукает: Мяу!");
    }

    public class VarianceTasks
    {
        // Задание 61: Ковариантный интерфейс IProducer
        public static void Task61_CovariantInterface()
        {
            Console.WriteLine("\n=== Задание 61: Ковариантный интерфейс IProducer ===");

            IProducer<Dog> dogProducer = new DogProducer();
            IProducer<Animal> animalProducer = dogProducer;

            Animal animal = animalProducer.Produce();
            animal.Speak();
        }

        public interface IProducer<out T>
        {
            T Produce();
        }

        public class DogProducer : IProducer<Dog>
        {
            public Dog Produce() => new Dog { Name = "Бобик" };
        }

        // Задание 62: Контрвариантный интерфейс IConsumer
        public static void Task62_ContravariantInterface()
        {
            Console.WriteLine("\n=== Задание 62: Контрвариантный интерфейс IConsumer ===");

            IConsumer<Animal> animalConsumer = new AnimalConsumer();
            IConsumer<Dog> dogConsumer = animalConsumer;

            Dog dog = new Dog { Name = "Шарик" };
            dogConsumer.Consume(dog);
        }

        public interface IConsumer<in T>
        {
            void Consume(T item);
        }

        public class AnimalConsumer : IConsumer<Animal>
        {
            public void Consume(Animal animal)
            {
                Console.WriteLine($"Потребляем животное: {animal.Name}");
            }
        }

        // Задание 63: Ковариантность с IEnumerable
        public static void Task63_IEnumerableCovariance()
        {
            Console.WriteLine("\n=== Задание 63: Ковариантность с IEnumerable ===");

            List<Dog> dogs = new List<Dog>
            {
                new Dog { Name = "Бобик" },
                new Dog { Name = "Шарик" }
            };

            IEnumerable<Animal> animals = dogs;

            Console.WriteLine("Животные через ковариантность:");
            foreach (Animal animal in animals)
            {
                animal.Speak();
            }
        }

        // Задание 64: Делегат с ковариантным возвращаемым типом
        public static void Task64_CovariantDelegate()
        {
            Console.WriteLine("\n=== Задание 64: Делегат с ковариантным возвращаемым типом ===");

            Func<Dog> getDog = () => new Dog { Name = "Рекс" };

            Func<Animal> getAnimal = getDog;

            Animal animal = getAnimal();
            animal.Speak();
        }

        // Задание 65: Делегат с контрвариантными параметрами
        public static void Task65_ContravariantDelegate()
        {
            Console.WriteLine("\n=== Задание 65: Делегат с контрвариантными параметрами ===");

            Action<Animal> processAnimal = animal =>
            {
                Console.WriteLine($"Обрабатываем животное: {animal.Name}");
            };

            Action<Dog> processDog = processAnimal;

            Dog dog = new Dog { Name = "Дружок" };
            processDog(dog);
        }

        // Задание 66: Иерархия классов для демонстрации вариантности
        public static void Task66_ClassHierarchy()
        {
            Console.WriteLine("\n=== Задание 66: Иерархия классов ===");

            Animal animal = new Animal { Name = "Животное" };
            Dog dog = new Dog { Name = "Собака" };
            Cat cat = new Cat { Name = "Кошка" };

            animal.Speak();
            dog.Speak();
            cat.Speak();
        }

        // Задание 67: Ковариантный метод расширения
        public static void Task67_CovariantExtension()
        {
            Console.WriteLine("\n=== Задание 67: Ковариантный метод расширения ===");

            List<Dog> dogs = new List<Dog>
            {
                new Dog { Name = "Бобик" },
                new Dog { Name = "Шарик" }
            };

            IEnumerable<Animal> animals = dogs.AsAnimals();

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Животное: {animal.Name}");
            }
        }

        // Задание 68: Контрвариантный компаратор
        public static void Task68_ContravariantComparer()
        {
            Console.WriteLine("\n=== Задание 68: Контрвариантный компаратор ===");

            IComparer<Animal> animalComparer = new AnimalNameComparer();
            IComparer<Dog> dogComparer = animalComparer;

            Dog dog1 = new Dog { Name = "Альма" };
            Dog dog2 = new Dog { Name = "Бобик" };

            int result = dogComparer.Compare(dog1, dog2);
            Console.WriteLine($"Сравнение '{dog1.Name}' и '{dog2.Name}': {result}");
        }

        public class AnimalNameComparer : IComparer<Animal>
        {
            public int Compare(Animal x, Animal y)
            {
                return string.Compare(x?.Name, y?.Name);
            }
        }

        // Задание 69: Ошибка при нарушении правил вариантности
        public static void Task69_VarianceViolation()
        {
            Console.WriteLine("\n=== Задание 69: Ошибка при нарушении правил вариантности ===");

            Console.WriteLine("Интерфейс с нарушением вариантности не скомпилируется");
        }

        // Задание 70: Generic класс с ковариантным параметром
        public static void Task70_CovariantGenericClass()
        {
            Console.WriteLine("\n=== Задание 70: Generic класс с ковариантным параметром ===");

            ICage<Dog> dogCage = new Cage<Dog>(new Dog { Name = "Рекс" });
            ICage<Animal> animalCage = dogCage;

            Animal animal = animalCage.GetAnimal();
            Console.WriteLine($"Животное в клетке: {animal.Name}");
        }

        public interface ICage<out T> where T : Animal
        {
            T GetAnimal();
        }

        public class Cage<T> : ICage<T> where T : Animal
        {
            private readonly T _animal;

            public Cage(T animal)
            {
                _animal = animal;
            }

            public T GetAnimal() => _animal;
        }

        // Задание 71: Action делегат с контрвариантностью
        public static void Task71_ContravariantAction()
        {
            Console.WriteLine("\n=== Задание 71: Action делегат с контрвариантностью ===");

            Action<Animal> feedAnimal = animal =>
            {
                Console.WriteLine($"Кормим {animal.Name}");
            };

            Action<Dog> feedDog = feedAnimal;

            Dog dog = new Dog { Name = "Барбос" };
            feedDog(dog);
        }

        // Задание 72: Func делегат с ковариантностью
        public static void Task72_CovariantFunc()
        {
            Console.WriteLine("\n=== Задание 72: Func делегат с ковариантностью ===");

            Func<Dog> createDog = () => new Dog { Name = "Лорд" };

            Func<Animal> createAnimal = createDog;

            Animal animal = createAnimal();
            Console.WriteLine($"Создано животное: {animal.Name}");
        }

        // Задание 73: Интерфейс репозитория с вариантными параметрами
        public static void Task73_VariantRepository()
        {
            Console.WriteLine("\n=== Задание 73: Интерфейс репозитория с вариантными параметрами ===");

            IRepository<Animal> animalRepo = new AnimalRepository();
            IRepository<Dog> dogRepo = animalRepo;

            Dog dog = new Dog { Name = "Чарли" };
            dogRepo.Save(dog);
        }

        public interface IRepository<in T> where T : Animal
        {
            void Save(T entity);
        }

        public class AnimalRepository : IRepository<Animal>
        {
            public void Save(Animal entity)
            {
                Console.WriteLine($"Сохранено животное: {entity.Name}");
            }
        }

        // Задание 74: Factory паттерн с ковариантностью
        public static void Task74_CovariantFactory()
        {
            Console.WriteLine("\n=== Задание 74: Factory паттерн с ковариантностью ===");

            IFactory<Dog> dogFactory = new DogFactory();
            IFactory<Animal> animalFactory = dogFactory;

            Animal animal = animalFactory.Create();
            animal.Speak();
        }

        public interface IFactory<out T> where T : Animal
        {
            T Create();
        }

        public class DogFactory : IFactory<Dog>
        {
            public Dog Create() => new Dog { Name = "Фабричная собака" };
        }

        // Задание 75: Вариантность в событиях
        public static void Task75_VarianceInEvents()
        {
            Console.WriteLine("\n=== Задание 75: Вариантность в событиях ===");

            EventPublisher publisher = new EventPublisher();

            publisher.AnimalEvent += (sender, e) =>
            {
                Console.WriteLine($"Обработчик получил животное");
            };

            publisher.PublishEvent();
        }

        public class AnimalEventArgs : EventArgs
        {
            public Animal Animal { get; }

            public AnimalEventArgs(Animal animal)
            {
                Animal = animal;
            }
        }

        public class EventPublisher
        {
            public event EventHandler<AnimalEventArgs> AnimalEvent;

            public void PublishEvent()
            {
                Dog dog = new Dog { Name = "Событийная собака" };
                AnimalEvent?.Invoke(this, new AnimalEventArgs(dog));
            }
        }

        // Задание 76: Контрвариантный visitor pattern
        public static void Task76_ContravariantVisitor()
        {
            Console.WriteLine("\n=== Задание 76: Контрвариантный visitor pattern ===");

            IVisitor<Animal> animalVisitor = new AnimalVisitor();
            IVisitor<Dog> dogVisitor = animalVisitor;

            Dog dog = new Dog { Name = "Посетитель" };
            dog.Accept(dogVisitor);
        }

        public interface IVisitor<in T> where T : Animal
        {
            void Visit(T element);
        }

        public class AnimalVisitor : IVisitor<Animal>
        {
            public void Visit(Animal animal)
            {
                Console.WriteLine($"Посещаем животное: {animal.Name}");
            }
        }

        // Задание 77: Ковариантный интерфейс для коллекций только для чтения
        public static void Task77_CovariantReadOnlyCollection()
        {
            Console.WriteLine("\n=== Задание 77: Ковариантный интерфейс для коллекций только для чтения ===");

            IReadOnlyCollection<Dog> dogs = new ReadOnlyCollection<Dog>(new[]
            {
                new Dog { Name = "Рекс" },
                new Dog { Name = "Барсик" }
            });

            IReadOnlyCollection<Animal> animals = dogs;

            Console.WriteLine("Животные в коллекции:");
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"  {animals[i].Name}");
            }
        }

        public interface IReadOnlyCollection<out T>
        {
            int Count { get; }
            T this[int index] { get; }
        }

        public class ReadOnlyCollection<T> : IReadOnlyCollection<T>
        {
            private readonly T[] _items;

            public ReadOnlyCollection(T[] items)
            {
                _items = items;
            }

            public int Count => _items.Length;
            public T this[int index] => _items[index];
        }

        // Задание 78: Безопасное приведение типов с использованием вариантности
        public static void Task78_SafeCastingWithVariance()
        {
            Console.WriteLine("\n=== Задание 78: Безопасное приведение типов с использованием вариантности ===");

            List<Animal> animals = new List<Animal>
            {
                new Dog { Name = "Собака" },
                new Cat { Name = "Кошка" }
            };

            IEnumerable<Dog> dogs = animals.OfType<Dog>();

            Console.WriteLine("Собаки в коллекции:");
            foreach (Dog dog in dogs)
            {
                Console.WriteLine($"  {dog.Name}");
            }
        }

        // Задание 79: Комбинирование ковариантности и контрвариантности
        public static void Task79_CombinedVariance()
        {
            Console.WriteLine("\n=== Задание 79: Комбинирование ковариантности и контрвариантности ===");

            IConverter<Dog, Animal> dogToAnimalConverter = new AnimalConverter();

            IConverter<Dog, Animal> puppyToMammalConverter = dogToAnimalConverter;

            Dog dog = new Dog { Name = "Собака" };
            Animal animal = puppyToMammalConverter.Convert(dog);

            Console.WriteLine($"Конвертировано: {animal.Name}");
        }

        public interface IConverter<in TInput, out TOutput>
        {
            TOutput Convert(TInput input);
        }

        public class AnimalConverter : IConverter<Dog, Animal>
        {
            public Animal Convert(Dog input)
            {
                return input;
            }
        }

        // Задание 80: Generic метод с ограничениями для поддержки вариантности
        public static void Task80_GenericMethodWithConstraints()
        {
            Console.WriteLine("\n=== Задание 80: Generic метод с ограничениями для поддержки вариантности ===");

            List<Dog> dogs = new List<Dog>
            {
                new Dog { Name = "Рекс" },
                new Dog { Name = "Бобик" }
            };

            ProcessAnimals(dogs);
        }

        public static void ProcessAnimals<T>(IEnumerable<T> animals) where T : Animal
        {
            Console.WriteLine("Обработка животных:");
            foreach (T animal in animals)
            {
                Console.WriteLine($"  {animal.Name}");
            }
        }
    }

    #endregion

    #region Раздел 5: Перечисления (Задания 81-100)

    // Enum definitions moved to top level
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum OrderStatus
    {
        None = 0,
        Pending = 1,
        Processing = 2,
        Completed = 3,
        Cancelled = 4
    }

    [Flags]
    public enum FilePermissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4,

        ReadWrite = Read | Write
    }

    public enum Color
    {
        [Description("Красный цвет")]
        Red,

        [Description("Зеленый цвет")]
        Green,

        [Description("Синий цвет")]
        Blue
    }

    public enum SmallEnum : byte
    {
        Value0 = 0,
        Value1 = 1,
        Value2 = 2
    }

    [Flags]
    public enum UserRoles
    {
        None = 0,
        User = 1,
        Moderator = 2,
        Admin = 4
    }

    public enum Priority
    {
        Low,
        Normal,
        High
    }

    public enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }

    public enum PaymentMethod
    {
        CreditCard,
        PayPal,
        BankTransfer,
        Cash
    }

    public static class EnumHelper
    {
        public static IEnumerable<T> GetValues<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }

    public static class EnumValidator
    {
        public static bool IsValid<T>(T value) where T : Enum
        {
            return Enum.IsDefined(typeof(T), value);
        }
    }

    public static class GenericEnumParser
    {
        public static T? TryParseEnum<T>(string value, bool ignoreCase = true) where T : struct, Enum
        {
            return Enum.TryParse(value, ignoreCase, out T result) ? result : null;
        }
    }

    public static class FlagCombinations
    {
        public static IEnumerable<T> GetAllCombinations<T>() where T : Enum
        {
            if (!typeof(T).IsDefined(typeof(FlagsAttribute), false))
                throw new InvalidOperationException("Enum must have Flags attribute");

            T[] values = Enum.GetValues(typeof(T)).Cast<T>().ToArray();
            int count = values.Length;
            int total = 1 << count;

            for (int i = 0; i < total; i++)
            {
                T combination = (T)(object)i;
                if (IsValidCombination(combination, values))
                    yield return combination;
            }
        }

        private static bool IsValidCombination<T>(T combination, T[] values) where T : Enum
        {
            int intValue = Convert.ToInt32(combination);
            int validFlags = 0;

            foreach (T value in values)
            {
                validFlags |= Convert.ToInt32(value);
            }

            return (intValue & ~validFlags) == 0;
        }
    }

    public class EnumTasks
    {
        // Задание 81: DaysOfWeek enum
        public static void Task81_DaysOfWeek()
        {
            Console.WriteLine("\n=== Задание 81: DaysOfWeek enum ===");

            DaysOfWeek today = DaysOfWeek.Wednesday;

            Console.WriteLine($"Сегодня: {today}");
            Console.WriteLine($"Это выходной: {today.IsWeekend()}");
        }

        // Задание 82: Enum с явными значениями
        public static void Task82_EnumWithExplicitValues()
        {
            Console.WriteLine("\n=== Задание 82: Enum с явными значениями ===");

            Console.WriteLine("Статусы заказа:");
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                Console.WriteLine($"  {status} = {(int)status}");
            }
        }

        // Задание 83: Флаговое перечисление
        public static void Task83_FlagsEnum()
        {
            Console.WriteLine("\n=== Задание 83: Флаговое перечисление ===");

            FilePermissions userPermissions = FilePermissions.Read | FilePermissions.Write;

            Console.WriteLine($"Права пользователя: {userPermissions}");

            bool canRead = userPermissions.HasFlag(FilePermissions.Read);
            Console.WriteLine($"Пользователь может читать: {canRead}");
        }

        // Задание 84: Конвертация enum в строку и обратно
        public static void Task84_EnumStringConversion()
        {
            Console.WriteLine("\n=== Задание 84: Конвертация enum в строку и обратно ===");

            OrderStatus status = OrderStatus.Processing;

            string statusString = status.ToString();
            Console.WriteLine($"Enum в строку: '{statusString}'");

            if (Enum.TryParse<OrderStatus>("Completed", out OrderStatus parsedStatus))
            {
                Console.WriteLine($"Строка в enum: {parsedStatus}");
            }
        }

        // Задание 85: Enum с атрибутом Description
        public static void Task85_EnumWithDescription()
        {
            Console.WriteLine("\n=== Задание 85: Enum с атрибутом Description ===");

            Console.WriteLine("Цвета с описаниями:");
            foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine($"  {color}: {color.GetDescription()}");
            }
        }

        // Задание 86: Extension method для получения всех значений
        public static void Task86_EnumValuesExtension()
        {
            Console.WriteLine("\n=== Задание 86: Extension method для получения всех значений ===");

            Console.WriteLine("Все значения DaysOfWeek:");
            foreach (var day in EnumHelper.GetValues<DaysOfWeek>())
            {
                Console.WriteLine($"  {day}");
            }
        }

        // Задание 87: Проверка валидности значения enum
        public static void Task87_EnumValidation()
        {
            Console.WriteLine("\n=== Задание 87: Проверка валидности значения enum ===");

            OrderStatus validStatus = OrderStatus.Completed;
            OrderStatus invalidStatus = (OrderStatus)99;

            Console.WriteLine($"validStatus валиден: {EnumValidator.IsValid(validStatus)}");
            Console.WriteLine($"invalidStatus валиден: {EnumValidator.IsValid(invalidStatus)}");
        }

        // Задание 88: OrderStatus с методами переходов
        public static void Task88_OrderStatusTransitions()
        {
            Console.WriteLine("\n=== Задание 88: OrderStatus с методами переходов ===");

            OrderStatus current = OrderStatus.Pending;

            Console.WriteLine($"Текущий статус: {current}");
            Console.WriteLine($"Возможные переходы: {string.Join(", ", current.GetPossibleTransitions())}");
        }

        // Задание 89: Generic метод для парсинга строки в любой enum
        public static void Task89_GenericEnumParser()
        {
            Console.WriteLine("\n=== Задание 89: Generic метод для парсинга строки в любой enum ===");

            string colorString = "Green";

            Color? color = GenericEnumParser.TryParseEnum<Color>(colorString);

            Console.WriteLine($"'{colorString}' -> {color}");
        }

        // Задание 90: Enum с базовым типом byte
        public static void Task90_EnumWithByteBase()
        {
            Console.WriteLine("\n=== Задание 90: Enum с базовым типом byte ===");

            Console.WriteLine("SmallEnum значения:");
            foreach (SmallEnum value in Enum.GetValues(typeof(SmallEnum)))
            {
                Console.WriteLine($"  {value} = {(byte)value}");
            }
        }

        // Задание 91: Получение следующего значения в enum циклически
        public static void Task91_CyclicEnum()
        {
            Console.WriteLine("\n=== Задание 91: Циклическое перечисление ===");

            DaysOfWeek current = DaysOfWeek.Friday;

            Console.WriteLine($"Текущий день: {current}");
            Console.WriteLine($"Следующий день: {current.Next()}");
        }

        // Задание 92: Enum Color с методом получения RGB значений
        public static void Task92_ColorWithRGB()
        {
            Console.WriteLine("\n=== Задание 92: Color с RGB значениями ===");

            Console.WriteLine("RGB значения цветов:");
            foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                var rgb = color.GetRGB();
                Console.WriteLine($"  {color}: R={rgb.r}, G={rgb.g}, B={rgb.b}");
            }
        }

        // Задание 93: Флаговое перечисление UserRoles
        public static void Task93_UserRolesFlags()
        {
            Console.WriteLine("\n=== Задание 93: Флаговое перечисление UserRoles ===");

            UserRoles user = UserRoles.User | UserRoles.Moderator;

            Console.WriteLine($"Роли пользователя: {user}");

            Console.WriteLine($"Пользователь является модератором: {user.HasFlag(UserRoles.Moderator)}");
        }

        // Задание 94: Подсчет установленных флагов в enum
        public static void Task94_CountSetFlags()
        {
            Console.WriteLine("\n=== Задание 94: Подсчет установленных флагов ===");

            FilePermissions permissions = FilePermissions.Read | FilePermissions.Write | FilePermissions.Execute;

            Console.WriteLine($"Права {permissions}: {permissions.CountSetFlags()} флагов");
        }

        // Задание 95: Priority enum с методом сравнения
        public static void Task95_PriorityComparison()
        {
            Console.WriteLine("\n=== Задание 95: Priority enum с сравнением ===");

            Priority low = Priority.Low;
            Priority high = Priority.High;

            Console.WriteLine($"Сравнение приоритетов:");
            Console.WriteLine($"  {low} > {high}: {low.IsHigherThan(high)}");
        }

        // Задание 96: Локализация значений enum
        public static void Task96_EnumLocalization()
        {
            Console.WriteLine("\n=== Задание 96: Локализация значений enum ===");

            Console.WriteLine("Локализованные названия цветов:");
            foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine($"  {color}: {color.GetLocalizedName()}");
            }
        }

        // Задание 97: Enum с методом для получения связанной иконки или цвета
        public static void Task97_EnumWithIcons()
        {
            Console.WriteLine("\n=== Задание 97: Enum с связанными иконками ===");

            Console.WriteLine("Статусы с иконками:");
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                Console.WriteLine($"  {status}: {status.GetIcon()}");
            }
        }

        // Задание 98: State Machine на основе enum
        public static void Task98_EnumStateMachine()
        {
            Console.WriteLine("\n=== Задание 98: State Machine на основе enum ===");

            TrafficLight light = TrafficLight.Red;

            Console.WriteLine($"Текущий свет: {light.GetDescription()}");
            light = light.Next();
            Console.WriteLine($"Следующий свет: {light.GetDescription()}");
        }

        // Задание 99: Получение всех комбинаций флагового enum
        public static void Task99_AllFlagCombinations()
        {
            Console.WriteLine("\n=== Задание 99: Все комбинации флагового enum ===");

            var combinations = FlagCombinations.GetAllCombinations<FilePermissions>();

            Console.WriteLine("Все комбинации FilePermissions:");
            foreach (var combo in combinations)
            {
                if (combo != FilePermissions.None)
                {
                    Console.WriteLine($"  {combo} = {(int)combo}");
                }
            }
        }

        // Задание 100: Enum с бизнес-логикой через extension methods
        public static void Task100_EnumWithBusinessLogic()
        {
            Console.WriteLine("\n=== Задание 100: Enum с бизнес-логикой ===");

            decimal orderAmount = 1000.00m;

            Console.WriteLine($"Стоимость заказа: {orderAmount:C}");
            Console.WriteLine("\nКомиссии по способам оплаты:");

            foreach (PaymentMethod method in Enum.GetValues(typeof(PaymentMethod)))
            {
                decimal fee = method.CalculateProcessingFee(orderAmount);
                Console.WriteLine($"  {method}: комиссия {fee:C}");
            }
        }
    }

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🚀 ВЫПОЛНЕНИЕ ВСЕХ 100 ЗАДАЧ C#\n");

            // Раздел 1: Упаковка и распаковка (1-20)
            Console.WriteLine("========== РАЗДЕЛ 1: УПАКОВКА И РАСПАКОВКА ==========");
            BoxingUnboxingTasks.Task1_BoxingPerformance();
            BoxingUnboxingTasks.Task2_SafeUnboxing();
            BoxingUnboxingTasks.Task3_SafeUnboxToVariousTypes(42);
            BoxingUnboxingTasks.Task3_SafeUnboxToVariousTypes(3.14);
            BoxingUnboxingTasks.Task4_PerformanceComparison();
            BoxingUnboxingTasks.Task5_ArrayListBoxing();
            BoxingUnboxingTasks.Task6_CountBoxingOperations();
            BoxingUnboxingTasks.Task7_ListVsArrayList();
            BoxingUnboxingTasks.Task8_InvalidCastException();
            BoxingUnboxingTasks.Task9_ParamsObject(1, "test", 3.14, true, DateTime.Now);
            BoxingUnboxingTasks.Task10_StructToInterfaceBoxing();
            BoxingUnboxingTasks.Task11_IsBoxedValueType(42);
            BoxingUnboxingTasks.Task12_NullableBoxing();
            BoxingUnboxingTasks.Task13_BoxingProfiler();
            BoxingUnboxingTasks.Task14_GenericsNoBoxing();
            BoxingUnboxingTasks.Task15_CompareBoxedValues();
            BoxingUnboxingTasks.Task16_EnumBoxing();
            BoxingUnboxingTasks.Task17_CloneViaBoxing();
            BoxingUnboxingTasks.Task18_BoxingUnboxingBenchmark();
            BoxingUnboxingTasks.Task19_BoxedValueCaching();
            BoxingUnboxingTasks.Task20_ModifyBoxedValue();

            // Раздел 2: Виды упаковки (21-40)
            Console.WriteLine("\n========== РАЗДЕЛ 2: ВИДЫ УПАКОВКИ ==========");
            BoxingTypesTasks.Task21_ExplicitBoxing();
            BoxingTypesTasks.Task22_ImplicitBoxingInParameters();
            BoxingTypesTasks.Task23_VirtualMethodBoxing();
            BoxingTypesTasks.Task24_InterfaceCastBoxing();
            BoxingTypesTasks.Task25_LinqBoxing();
            BoxingTypesTasks.Task26_UntypedCollectionBoxing();
            BoxingTypesTasks.Task27_ReflectionBoxing();
            BoxingTypesTasks.Task28_DelegateBoxing();
            BoxingTypesTasks.Task29_EventBoxing();
            BoxingTypesTasks.Task30_IsAsBoxing();
            BoxingTypesTasks.Task31_DynamicBoxing();
            BoxingTypesTasks.Task32_SerializationBoxing();
            BoxingTypesTasks.Task33_StringFormatBoxing();
            BoxingTypesTasks.Task34_NullableToObjectBoxing();
            BoxingTypesTasks.Task35_EqualsBoxing();
            BoxingTypesTasks.Task36_AttributeBoxing();
            BoxingTypesTasks.Task37_MethodInfoInvokeBoxing();
            BoxingTypesTasks.Task38_WeakReferenceBoxing();
            BoxingTypesTasks.Task39_ConditionalWeakTableBoxing();
            BoxingTypesTasks.Task40_BoxingTypesPerformance();

            // Раздел 3: DateTime и TimeSpan (41-60)
            Console.WriteLine("\n========== РАЗДЕЛ 3: DATETIME И TIMESPAN ==========");
            DateTimeTimeSpanTasks.Task41_CalculateAge();
            DateTimeTimeSpanTasks.Task42_BusinessDaysCalculator();
            DateTimeTimeSpanTasks.Task43_DaysUntilEndOfYear();
            DateTimeTimeSpanTasks.Task44_DateTimeFormatting();
            DateTimeTimeSpanTasks.Task45_DateDifferenceDetailed();
            DateTimeTimeSpanTasks.Task46_DateTimeParsing();
            DateTimeTimeSpanTasks.Task47_AddBusinessDays();
            DateTimeTimeSpanTasks.Task48_LeapYearCheck();
            DateTimeTimeSpanTasks.Task49_MonthBoundaries();
            DateTimeTimeSpanTasks.Task50_CountdownTimer();
            DateTimeTimeSpanTasks.Task51_TimeZoneConversion();
            DateTimeTimeSpanTasks.Task52_GetQuarter();
            DateTimeTimeSpanTasks.Task53_DateComparisonDayPrecision();
            DateTimeTimeSpanTasks.Task54_DateTimeStopwatch();
            DateTimeTimeSpanTasks.Task55_TimeSpanDuration();
            DateTimeTimeSpanTasks.Task56_DateTimeRounding();
            DateTimeTimeSpanTasks.Task57_IsoWeekNumber();
            DateTimeTimeSpanTasks.Task58_TaskScheduler();
            DateTimeTimeSpanTasks.Task59_TimeZoneInfoDemo();
            DateTimeTimeSpanTasks.Task60_DateRangeClass();

            // Раздел 4: Ковариантность и контрвариантность (61-80)
            Console.WriteLine("\n========== РАЗДЕЛ 4: КОВАРИАНТНОСТЬ И КОНТРАВАРИАНТНОСТЬ ==========");
            VarianceTasks.Task61_CovariantInterface();
            VarianceTasks.Task62_ContravariantInterface();
            VarianceTasks.Task63_IEnumerableCovariance();
            VarianceTasks.Task64_CovariantDelegate();
            VarianceTasks.Task65_ContravariantDelegate();
            VarianceTasks.Task66_ClassHierarchy();
            VarianceTasks.Task67_CovariantExtension();
            VarianceTasks.Task68_ContravariantComparer();
            VarianceTasks.Task69_VarianceViolation();
            VarianceTasks.Task70_CovariantGenericClass();
            VarianceTasks.Task71_ContravariantAction();
            VarianceTasks.Task72_CovariantFunc();
            VarianceTasks.Task73_VariantRepository();
            VarianceTasks.Task74_CovariantFactory();
            VarianceTasks.Task75_VarianceInEvents();
            VarianceTasks.Task76_ContravariantVisitor();
            VarianceTasks.Task77_CovariantReadOnlyCollection();
            VarianceTasks.Task78_SafeCastingWithVariance();
            VarianceTasks.Task79_CombinedVariance();
            VarianceTasks.Task80_GenericMethodWithConstraints();

            // Раздел 5: Перечисления (81-100)
            Console.WriteLine("\n========== РАЗДЕЛ 5: ПЕРЕЧИСЛЕНИЯ ==========");
            EnumTasks.Task81_DaysOfWeek();
            EnumTasks.Task82_EnumWithExplicitValues();
            EnumTasks.Task83_FlagsEnum();
            EnumTasks.Task84_EnumStringConversion();
            EnumTasks.Task85_EnumWithDescription();
            EnumTasks.Task86_EnumValuesExtension();
            EnumTasks.Task87_EnumValidation();
            EnumTasks.Task88_OrderStatusTransitions();
            EnumTasks.Task89_GenericEnumParser();
            EnumTasks.Task90_EnumWithByteBase();
            EnumTasks.Task91_CyclicEnum();
            EnumTasks.Task92_ColorWithRGB();
            EnumTasks.Task93_UserRolesFlags();
            EnumTasks.Task94_CountSetFlags();
            EnumTasks.Task95_PriorityComparison();
            EnumTasks.Task96_EnumLocalization();
            EnumTasks.Task97_EnumWithIcons();
            EnumTasks.Task98_EnumStateMachine();
            EnumTasks.Task99_AllFlagCombinations();
            EnumTasks.Task100_EnumWithBusinessLogic();

            Console.WriteLine("\nВСЕ 100 ЗАДАЧ УСПЕШНО ВЫПОЛНЕНЫ!");
            Console.ReadLine();
        }
    }
}