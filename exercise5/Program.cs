using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Node
    {
        public string nama;
        public Node next;
    }
    class Queue
    {
        Node Farhan, Ihsan;
        public Queue()
        {
            Farhan = null;
            Ihsan = null;
        }

        public void insert(string nm)
        {
            Console.Write("\nMasukkan nama Mahasiswa");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();
            nodeBaru.nama = nm;
            nodeBaru.next = null;

            if (Farhan == null)
            {
                Farhan = nodeBaru;
                Ihsan = nodeBaru;
                return;
            }
            Ihsan.next = nodeBaru;
            Ihsan = nodeBaru;
        }

        public void delete()
        {
            if (Farhan == null)
            {
                Console.WriteLine("Kosong!!");
                return;
            }
            Farhan = Farhan.next;

            if (Farhan == null)
                Ihsan = null;
        }

        public void display()
        {
            if(Farhan == null)
            {
                Console.WriteLine("Kosong");
                return ;
            }
            Node display;
        }
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {

                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice (1-4):");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                q.insert();
                            }
                            break;
                        case '2':
                            {
                                q.delete();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
