namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Linked List Program.");
            Console.WriteLine("Please choose any one program from below options");
            Console.WriteLine("1.Builtin Linked list\n2.Custom Linked List (Append)");
            Console.WriteLine(" ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    LinkedList<int> linkedList = new LinkedList<int>();
                    linkedList.AddFirst(70);
                    linkedList.AddFirst(30);

                    Console.WriteLine("\nDisplaying nodes");
                    foreach (int element in linkedList)
                    {
                        Console.WriteLine(element);
                    }
                    linkedList.AddFirst(56);

                    Console.WriteLine("\nDisplaying nodes");
                    foreach (int element in linkedList)
                    {
                        Console.WriteLine(element);
                    }
                    linkedList.RemoveLast();

                    Console.WriteLine("\nDisplaying nodes");
                    foreach (int element in linkedList)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case 2:
                    CustomLinkedList customLinkedList = new CustomLinkedList();
                    customLinkedList.Append(56);
                    customLinkedList.Append(30);
                    customLinkedList.Append(70);
                    customLinkedList.Display();
                    break;
                
            }
            
        }
    }
}