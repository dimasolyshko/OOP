using System;
using System.Collections.Generic;

class People
{
    public string Name { get; set; }
    public int Age { get; set; }

    public People(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа №2:");
        // Создание объекта-контейнера и заполнение его данными типа People
        SortedDictionary<string, People> map = new SortedDictionary<string, People>();
        map.Add("Alice", new People("Alice", 25));
        map.Add("Bob", new People("Bob", 30));
        map.Add("Dasha", new People("Dasha", 20));
        map.Add("Katya", new People("Katya", 35));
        map.Add("Dave", new People("Dave", 40));
        // Просмотр контейнера
        Console.WriteLine("Элементы контейнера:");
        foreach (KeyValuePair<string, People> elements in map)
        {
            Console.WriteLine($"{elements.Key}: {elements.Value.Name}, {elements.Value.Age}");
        }

        // Изменение контейнера, удаление и замена элементов
        map.Remove("Bob");
        map.Remove("Dave");
        map.Add("Eve", new People("Eve", 45));
        map["Charlie"] = new People("Carl", 32);

        // Просмотр контейнера с использованием итераторов
        Console.WriteLine("Элементы контейнера после изменения:");
        foreach (KeyValuePair<string, People> elements in map)
        {
            Console.WriteLine($"{elements.Key}: {elements.Value.Name}, {elements.Value.Age}");
        }

        // Создание второго контейнера и заполнение его данными того же типа, что и первый контейнер
        SortedDictionary<string, People> secondMap = new SortedDictionary<string, People>();
        secondMap.Add("Grace", new People("Grace", 55));
        secondMap.Add("Harry", new People("Harry", 60));
        secondMap.Add("Disoland", new People("Disoland", 65));

        // Изменение первого контейнера, удаление элементов и добавление в него всех элементов из второго контейнера
        string target = "Eve";
        int n = 1;
        bool foundTarget = false;
        SortedDictionary<string, People> toRemove = new SortedDictionary<string, People>();
        foreach (KeyValuePair<string, People> elements in map)
        {
            if (foundTarget && n > 0) // Добавляем n элементов, которые находятся после заданного, в новый контейнер для удалённых элементов
            {
                toRemove.Add(elements.Key, elements.Value);
                n--;
            }
            if (elements.Key == target) // Находим элемент
            {
                foundTarget = true;
            }
        }
        foreach (KeyValuePair<string, People> elements in toRemove)
        {
            map.Remove(elements.Key); // Удаляем элементы первого контейнер, которые совпадают с элементами контейнера с удалёнными элементами
        }

        foreach (KeyValuePair<string, People> elements in secondMap)
        {
            map.Add(elements.Key, elements.Value);
        }

        // Просмотр первого и второго контейнеров
        Console.WriteLine("Элементы первого контейнера после изменения:");
        foreach (KeyValuePair<string, People> elements in map)
        {
            Console.WriteLine($"{elements.Key}: {elements.Value.Name}, {elements.Value.Age}");
        }
        Console.WriteLine("Элементы второго контейнера:");
        foreach (KeyValuePair<string, People> elements in secondMap)
        {
            Console.WriteLine($"{elements.Key}: {elements.Value.Name}, {elements.Value.Age}");
        }
    }
}



