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
        static void Main(string[] args)
        {
        }
    }
}
