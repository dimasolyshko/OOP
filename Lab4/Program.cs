using System;

namespace Lab4
{
    public class MyArray<T>
    {
        private T[] arr;

        public MyArray(T[] arr)
        {
            this.arr = arr;
        }

        public int Length
        {
            get { return arr.Length; }
        }

        public T this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        public static MyArray<T> operator +(MyArray<T> a, MyArray<T> b)
        {
            if (a.Length != b.Length)
            {
                throw new ArgumentException("Массивы должны иметь одинаковое количество данных");
            }

            T[] result = new T[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                dynamic x = a[i];
                dynamic y = b[i];
                result[i] = x + y;
            }

            return new MyArray<T>(result);
        }

        public static MyArray<T> operator +(T a, MyArray<T> b)
        {
            T[] result = new T[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                dynamic x = a;
                dynamic y = b[i];
                result[i] = x + y;
            }

            return new MyArray<T>(result);
        }
        public void Show()
        {
            Console.Write("{ ");
            for (int i = 0; i < Length; i++)
            {
                Console.Write(this[i]);
                if (i != Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" }");
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} ({Age} years old)";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тест со стандартным типом данных:");
            MyArray<int> a = new MyArray<int>(new int[] { 1, 2, 3 });
            MyArray<int> b = new MyArray<int>(new int[] { 4, 5, 6 });

            MyArray<int> c = a + b + a;
            c.Show();

            MyArray<int> d = c[1] + b; 
            d.Show();

            Console.WriteLine("Тест с пользовательским типом данных Person:");
            Person[] people = new Person[]
            {
               new Person("Alice", 20),
               new Person("Bob", 25),
               new Person("Charlie", 30),
            };

            MyArray<Person> k = new MyArray<Person>(people);
            k.Show();
            Console.Write("Обращение по индексу: ");
            Console.WriteLine(k[1]);
        }
    }
}
