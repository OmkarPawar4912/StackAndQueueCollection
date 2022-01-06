using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleCollectionDemo
{
    public class Program
    {

        static void Main(string[] args)
        {
            StackMethod();
            QueueMethod();
        }

        private static void StackMethod()
        {
            Stack<Customer> stack = new Stack<Customer>();

            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Omkar Pawar",
                Address = "Sangli"
            };
            Customer customer1 = new Customer()
            {
                Id = 2,
                Name = "Yas Deshmukh",
                Address = "Solapur"
            };
            Customer customer2 = new Customer()
            {
                Id = 3,
                Name = "Aditya Pawar",
                Address = "Kavathe Piran"
            };
            Customer customer3 = new Customer()
            {
                Id = 4,
                Name = "Shubham Patil",
                Address = "Nagaon"
            };
            Customer customer4 = new Customer()
            {
                Id = 5,
                Name = "Jay Kamble",
                Address = "Satara"
            };

            stack.Push(customer);
            stack.Push(customer1);
            stack.Push(customer2);
            stack.Push(customer3);
            stack.Push(customer4);
           
            Console.WriteLine("************ Stack **************");

            foreach (Customer c in stack)
            {
                Console.WriteLine(c.Id + " - " + c.Name + " - " + c.Address);
                Console.WriteLine("Cout of Customer Left : " + stack.Count);
            }
            
            Console.WriteLine("*********************************");
            
            Console.WriteLine("Using Pop");
            
            Customer cPop = stack.Pop();

            Console.WriteLine(cPop.Id + " - " + cPop.Name);

            Console.WriteLine("Cout of Customer Left : " + stack.Count);
         
            Console.WriteLine("*********************************");

            Console.WriteLine("Using Peek");

            Customer cPeek = stack.Peek();

            Console.WriteLine(cPeek.Id + " - " + cPeek.Name);

            Console.WriteLine("Cout of Customer Left : " + stack.Count);
          
            Console.WriteLine("*********************************");
        }
        private static void QueueMethod()
        {
            Queue<Customer> queue = new Queue<Customer>();
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Omkar Pawar",
                Address = "Sangli"
            };
            Customer customer1 = new Customer()
            {
                Id = 2,
                Name = "Yas Deshmukh",
                Address = "Solapur"
            };
            Customer customer2 = new Customer()
            {
                Id = 3,
                Name = "Aditya Pawar",
                Address = "Kavathe Piran"
            };
            Customer customer3 = new Customer()
            {
                Id = 4,
                Name = "Shubham Patil",
                Address = "Nagaon"
            };
            Customer customer4 = new Customer()
            {
                Id = 5,
                Name = "Jay Kamble",
                Address = "Satara"
            };

            queue.Enqueue(customer);
            queue.Enqueue(customer1);
            queue.Enqueue(customer2);
            queue.Enqueue(customer3);
            queue.Enqueue(customer4);
            
            Console.WriteLine("************ Queue **************");

            foreach (Customer c in queue)
            {
                Console.WriteLine(c.Id + " - " + c.Name + " - " + c.Address);
                Console.WriteLine("Cout of Customer Left : " + queue.Count);
            }

            Console.WriteLine("*********************************");

            Console.WriteLine("Using Dequeue");

            Customer cPop = queue.Dequeue();

            Console.WriteLine(cPop.Id + " - " + cPop.Name);

            Console.WriteLine("Cout of Customer Left : " + queue.Count);

            Console.WriteLine("*********************************");

            Console.WriteLine("Using Peek");

            Customer cPeek = queue.Peek();

            Console.WriteLine(cPeek.Id + " - " + cPeek.Name);

            Console.WriteLine("Cout of Customer Left : " + queue.Count);

            Console.WriteLine("*********************************");
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}