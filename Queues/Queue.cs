
using System.Collections.Generic;
using System.Collections;
using LinkedList;
class Queues : IEnumerable<int>
{
    private int size;

    private Node? head;
    private Node? tail;

    public Queues()
    {
        size = 0;
        head = null;
        tail = null;
    }

    public void Enqueue(int data)
    {
        if(head == null)
        {
            head = new Node(data);
            tail = head;
            ++size;
        }
        else{
            tail.next = new Node(data);
            tail = tail.next;
            ++size;
        }
        
    }

    public int Dequeue()
    {
        if(head == null)
        {
            return -1;
        }
        else{
            int data = head.data;
            head = head.next;
            --size;
            return data;
        }
    }

    public int peek()
    {
        if(head == null)
        {
            return -1;
        }
        else{
            return head.data;
        }
        
    }

    public int Size()
    {
        return size;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public IEnumerator<int> GetEnumerator()
    {
        Node? temp = head;
        while(temp != null)
        {
            yield return temp.data;
            temp = temp.next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
}

