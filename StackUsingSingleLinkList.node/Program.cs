using StackUsingSingleLinkList.node;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingSingleLinkList.node
{
    class node
    {
        public int info;
        public node next;
        public node(int i, node n)
        {
            info = i;
            next = n;
        }
    }
}
class stack
{
    node top;
    public stack()


    {
        top = null;
    }
    bool empty()
    {
        if (top == null)
            return (true);
        else
            return (false);
    }
    public void push(int element)
    {
        node fresh;
        fresh = new node(element, null);

        fresh.next = top;
        top = fresh;
        Console.WriteLine("\n" + element + "pushed");
    }
    public void pop()
    {
        Console.WriteLine("\n the poped elements is: " + top.info);
        top = top.next; // make top point to the next node is squencce
    }
    public void display()
    {
        node tmp;
        if (empty())
            Console.WriteLine("\n Stack Empty");
        else
        {
            for (tmp = top; tmp != null; tmp = tmp.next)
            {
                Console.WriteLine(tmp.info);
            }
        }
    }
}


