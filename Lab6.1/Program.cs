using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа №1");
        // Создание объекта-контейнера и заполнение его данными типа char
        SortedSet<char> set = new SortedSet<char>();
        set.Add('a');
        set.Add('b');
        set.Add('c');
        set.Add('c');
        set.Add('d');

        // Просмотр контейнера
        Console.WriteLine("Элементы контейнера:");
        foreach (char element in set)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
        // Изменение контейнера, удаление и замена элементов
        set.Remove('b');
        set.Remove('d');
        set.Add('e');
        set.Add('f');
        // Просмотр контейнера с использованием итераторов
        Console.WriteLine("Элементы контейнера после изменения:");
        IEnumerator<char> iterator = set.GetEnumerator();
        while (iterator.MoveNext())
        {
            Console.Write($"{iterator.Current} ");
        }
        Console.WriteLine();
        // Создание второго контейнера и заполнение его данными того же типа, что и первый контейнер
        SortedSet<char> secondSet = new SortedSet<char>();
        secondSet.Add('g');
        secondSet.Add('h');
        secondSet.Add('i');

        // Изменение первого контейнера, удаление n элементов после заданного и добавление в него всех элементов из второго контейнера
        char target = 'c';
        int n = 1;
        bool foundTarget = false;
        SortedSet<char> toRemove = new SortedSet<char>();
        foreach (char element in set)
        {
            if (foundTarget && n > 0) // Добавляем n элементов, которые находятся после заданного, в новый контейнер для удалённых элементов
            {
                toRemove.Add(element);
                n--;
            }
            if (element == target) // Находим элемент
            {
                foundTarget = true;
            }
        }
        foreach (char element in toRemove)
        {
            set.Remove(element); // Удаляем элементы первого контейнер, которые совпадают с элементами контейнера с удалёнными элементами
        }
        set.UnionWith(secondSet);

        // Просмотр первого и второго контейнеров
        Console.WriteLine("Элементы первого контейнера после изменения:");
        foreach (char element in set)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine("Элементы второго контейнера:");
        foreach (char element in secondSet)
        {
            Console.Write($"{element} ");
        }
    }
}

