using System;
namespace LinkedList
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lisked List Problem \n")
            Linkedlist list = new Linkedlist();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
        }
    }
}