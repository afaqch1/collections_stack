using System;
using System.Collections.Generic;


namespace collections_stack
{
    class Program
    {
        static void display(Stack<string> stack)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\t\tToys Bucket\t\t");
            Console.WriteLine("----------------------------------------------------");
            int i = 1;
            foreach(var v in stack)
            {
                Console.WriteLine(i + "\t" + v);
                i++;
            }


        }
        static void Main(string[] args)
        {
            Stack<string> toys = new Stack<string>();
            toys.Push("Truck");
            toys.Push("Ball");
            toys.Push("Aeroplane");
            toys.Push("Minnions");
            toys.Push("Penguins Set");
            toys.Push("PingPong");
            toys.Push("Doll");

            display(toys);

            Console.WriteLine("Number of toys in the bucket= " + toys.Count);

            Console.WriteLine("////////New stack created using array///////////////////");
            string[] arr = new string[] { "Animal Zoo","Army set","Bablades" };
            Stack<string> toys2 = new Stack<string>(arr);
            display(toys2);

            Console.WriteLine("////////Pop first three items from stack///////////////////");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i+toys.Pop());
            }

            display(toys);

            Console.WriteLine("Top Toy in bucket: " + toys.Peek());
            Console.WriteLine("/////////////After peek item is not removed from bucket//////////////////");
            display(toys);

            Console.WriteLine("Enter Any item name to check it is in bucket or not..:");
            string item = Console.ReadLine();
            if (toys.Contains(item))
            {
                Console.WriteLine("Yes it is present in bucket :)");
            }
            else
                Console.WriteLine("Sorry it is not present in bucket :(");
        }
    }
}
