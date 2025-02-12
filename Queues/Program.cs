// See https://aka.ms/new-console-template for more information

Queues queue = new Queues();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

Console.WriteLine(queue.Size());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.peek());
Console.WriteLine(queue.Size());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.IsEmpty());

foreach(int i in queue)
{
    Console.WriteLine(i);
}

