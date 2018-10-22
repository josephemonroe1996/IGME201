using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonroeJoseph_PE19
{
    class Node
    {
        public int data;

        public Node left;

        public Node right;

        public Node(int data)
        {
            this.data = data;
        }

        public void Display(){
            Console.WriteLine(data);
        }
    }
}
