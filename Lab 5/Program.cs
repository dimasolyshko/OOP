using System;

namespace Lab_5
{
    class Vector
    {
        private double[] array;

        // Конструктор класса
        public Vector(int size)
        {
            array = new double[size];
        }

        // Перегрузка оператора cуммы
        public static Vector operator +(Vector vector, double value)
        {
            for (int i = 0; i < vector.array.Length; ++i)
            {
                vector.array[i] += value;
            }
            return vector;
        }

        // Перегрузка оператора доступа по индексу
        public double this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        // Перегрузка оператора проверки на равенство
        public static bool operator ==(Vector v1, Vector v2)
        {
            if (v1.array.Length != v2.array.Length)
            {
                return false;
            }
            for (int i = 0; i < v1.array.Length; ++i)
            {
                if (v1.array[i] != v2.array[i])
                {
                    return false;
                }
            }
            return true;
        }

        // Перегрузка оператора проверки на неравенство
        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }
        public void show()
        {
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write(this[i]);
                Console.Write(", ");

            }
            Console.WriteLine($"<-- Значения вектора.");
        }
    }

    class Program
    {
        static void Main()
        {
            Vector v1 = new Vector(3);
            Vector v2 = new Vector(3);

            // добавляем ко всем элементам вектора 2.34
            v1 = v1 + 2.34;
            v1.show();

            // Задаем значения элементов второго вектора
            v2[0] = 1;
            v2[1] = 2;
            v2[2] = 3;
            v2.show();

            // Проверяем равенство векторов
            if (v1 == v2)
            {
                Console.WriteLine("Векторы равны");
            }
            else
            {
                Console.WriteLine("Векторы не равны");
            }
            Console.WriteLine("Специально приравниваем новый вектор v3, и делаем теперь сравнение");
            Vector v3 = v2;
            v3.show();
            // Проверяем неравенство векторов
            if (v2 != v3)
            {
                Console.WriteLine("Векторы не равны");
            }
            else
            {
                Console.WriteLine("Векторы равны");
            }
        }
    }
}
