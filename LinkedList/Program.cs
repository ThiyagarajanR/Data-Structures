// See https://aka.ms/new-console-template for more information
namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node? node = null;

            GetNewLinkedList(out node);

            node = GetReverseNode(node);

        }

        public static void GetNewLinkedList(out Node? node)
        {
            char cont = 'y';
            Node? temp = null;
            Node? head = null;
            while (cont == 'y')
            {
                Console.WriteLine("Enter the data for the node");

                int data = Convert.ToInt32(Console.ReadLine());

                if (temp == null)
                {
                    temp = new Node(data);
                    head = temp;
                }
                else
                {
                    temp.next = new Node(data);
                    temp = temp.next;
                }

                Console.WriteLine("Do you want to continue? (y/n)");

                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    cont = Convert.ToChar(input);
                }
                else
                {
                    cont = 'n';
                }
            }
            if (head == null)
            {
                node = null;
            }
            else
                node = head;
        }

        public static Node? GetReverseNode(Node? node)
        {
            if (node == null)
            {
                return node;
            }

            Node? temp = node;
            Node? prev = null;

            while (temp != null)
            {
                // 1->2->3->4->5
                // 1 <- 2 
                // temp 1
                // next  = 2
                // temp.next = prev = null
                // prev = 1
                // temp = 2
                Node? next = temp.next;
                temp.next = prev;
                prev = temp;
                temp = next;
            }
            return prev;
        }

        public static void PrintLinkedList(Node? node)
        {
            Node? temp = node;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
