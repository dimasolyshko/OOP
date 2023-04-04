using System;
using System.Collections.Generic;

namespace Laba2
{
    class Details_List
    {
        protected static List<Detail> list = new List<Detail>();
        static public void Add(Detail Details)
        {
            list.Add(Details);
        }
        static public void ShowList()
        {
            foreach (var item in list)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(item);
                item.Show();
            }
        }
    }
    abstract class Detail
    {
        protected int weight { get; set; }

        public Detail(int w)
        {
            Details_List.Add(this); //Добавление при конструкторе.
            weight = w;
        }
        abstract public void Add(); //Метод для добавления.
        abstract public void Show();
    };

    class Mechanism : Detail
    {
        public string model { get; set; }
        public Mechanism(int w, string m)
                : base(w)
        {
            model = m;
        }
        public override void Add()
        {
            Details_List.Add(this);
        }
        public override void Show()
        {
            Console.WriteLine($"Weight of Mechanism: {weight} and model of mechanism: {model}");
        }
    };

    class Node : Detail
    {
        public int Number { get; set; }
        public Node(int w, int n)
                : base(w)
        {
            Number = n;
        }
        public override void Add()
        {
            Details_List.Add(this);
        }
        public override void Show()
        {
            Console.WriteLine($"Weight of Node: {weight} and Number of Node: {Number}");
        }
    };

    class Product : Detail
    {
        public int cost { get; set; }
        public Product(int w, int c)
                : base(w)
        {
            cost = c;
        }
        public override void Add()
        {
            Details_List.Add(this);
        }
        public override void Show()
        {
            Console.WriteLine($"Weight of Product: {weight} and Cost of Product: {cost}$");
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            Detail test = new Mechanism(21, "Head-2023");
            Detail test1 = new Node(44, 25333);
            Detail test2 = new Product(33, 299);
            Details_List.Add(test);
            Details_List.Add(test1);
            Details_List.Add(test2);
            Details_List.ShowList();
        }
    }
}
