using Composite.Composite;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Composite example");
            Console.WriteLine("Composite is a structural design pattern that allows composing objects into a tree-like structure and work with the it as if it was a singular object.");
            Console.WriteLine();

            Client client = new Client();

            // this way the client code can support the simple leaf components.
            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);

            // as well as the complex composites.
            Composite.Composite tree = new Composite.Composite();
            Composite.Composite branch1 = new Composite.Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite.Composite branch2 = new Composite.Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);
        }
    }
}