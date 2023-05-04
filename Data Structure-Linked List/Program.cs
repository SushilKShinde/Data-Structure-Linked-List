using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data structure Linked list");
            Console.WriteLine("Please select option from below\n");
            Console.WriteLine("1.BuiltIn linked list\n2. ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    LinkedList<int> list = new LinkedList<int>();
                    list.AddLast(10);
                    list.AddLast(20);
                    list.AddLast(30);
                    //to print linked list
                    Console.WriteLine("List items are");
                    foreach (int i in list)
                    {
                        Console.Write(i + " ");
                    }
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
        }
    }
}
