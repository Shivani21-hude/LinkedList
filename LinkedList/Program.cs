﻿using System;
namespace LinkedList
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lisked List Problem \n");
            Linkedlist list = new Linkedlist();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.InsertAtParticularPosition(2, 52);
            list.Display();
            list.RemoveFirstNode();
            list.Display();
            list.RemoveLastNode();
            list.Display();
            list.Search(30);
            list.InsertAtParticularPosition(3, 40);
            list.Display();

        }
    }
}