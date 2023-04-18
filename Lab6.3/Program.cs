using System;
using System.Collections.Generic;
using System.Linq;

class People : IComparable<People>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public People(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int CompareTo(People other)
    {
        return this.Age.CompareTo(other.Age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа №3:");
        // Создание объекта-контейнера и заполнение его данными типа People
        int count = 0;
        SortedSet<People> set = new SortedSet<People>();
        set.Add(new People("Alice", 25));
        set.Add(new People("Dasha", 20));
        set.Add(new People("Katya", 35));
        set.Add(new People("Dave", 40));
        set.Add(new People("Dasha", 21));
        set.Add(new People("Dasha", 28));

        // Просмотр контейнера
        Console.WriteLine("Элементы контейнера:");
        foreach (People element in set)
        {
            Console.WriteLine($"{element.Name} {element.Age} ");
        }
        Console.WriteLine("Элементы контейнера по убыванию возраста:");
        foreach (People element in set.OrderByDescending(x => x.Age))
        {
            Console.WriteLine($"{element.Name} {element.Age}");
        }
        Console.WriteLine("Найти в контейнере элемент, удовлетворяющий условию Name = Dasha :");
        var foundElement = "Dasha";
        SortedDictionary<int, People> map = new SortedDictionary<int, People>();
        foreach (People element in set)
        {
            if (foundElement == element.Name)
            {
                Console.WriteLine($"{element.Name} {element.Age} ");
                map.Add(count++, new People(element.Name, element.Age));
            }
        }
        // Просмотр контейнера
        Console.WriteLine("Элементы контейнера map по возрастанию:");
        foreach (KeyValuePair<int, People> elements in map)
        {
            Console.WriteLine($"{elements.Key}: {elements.Value.Name}, {elements.Value.Age}");
        }
        Console.WriteLine("Элементы контейнера set по возрастанию:");
        foreach (People element in set)
        {
            Console.WriteLine($"{element.Name} {element.Age} ");
        }
        // Создание третьего контейнера путем слияния set и map
        var thirdSet = set.Concat(map.Values);

        // Просмотр третьего контейнера
        bool havingDasha = false;
        int CountOfDasha = 0;
        Console.WriteLine("Третий контейнер, полученный путём обьединения двух прошлых контейнеров:");
        foreach (var element in thirdSet)
        {
            Console.WriteLine($"{element.Name} {element.Age} ");
            if (foundElement == element.Name)
            {
                CountOfDasha++;
                havingDasha = true;
            }
        }
        Console.WriteLine($"Количество элементов с именем Dasha: {CountOfDasha}");
        if (havingDasha)
        {
            Console.WriteLine("Данные элементы с именем Dasha существуют");
        }
        else
        {
            Console.WriteLine("Данные элементы с именем Dasha не существуют");
        }
    }
}

