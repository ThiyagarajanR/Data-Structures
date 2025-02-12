namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<Task, int> taskQueue = new PriorityQueue<Task, int>(new PriorityComparer());

            taskQueue.Enqueue(new Task("Task 1", Priority.Low), (int)Priority.Low);
            taskQueue.Enqueue(new Task("Task 2", Priority.Medium), (int)Priority.Medium);
            taskQueue.Enqueue(new Task("Task 3", Priority.High), (int)Priority.High);
            taskQueue.Enqueue(new Task("Task 4", Priority.Low), (int)Priority.Low);
            taskQueue.Enqueue(new Task("Task 5", Priority.Medium), (int)Priority.Medium);
            taskQueue.Enqueue(new Task("Task 6", Priority.High), (int)Priority.High);
            taskQueue.Enqueue(new Task("Task 7", Priority.Low), (int)Priority.Low);
            taskQueue.Enqueue(new Task("Task 8", Priority.Medium), (int)Priority.Medium);
            taskQueue.Enqueue(new Task("Task 9", Priority.High), (int)Priority.High);
            taskQueue.Enqueue(new Task("Task 10", Priority.Low), (int)Priority.Low);
            taskQueue.Enqueue(new Task("Task 11", Priority.Medium), (int)Priority.Medium);

            while (taskQueue.Count > 0)
            {
                Task task = taskQueue.Dequeue();
                Console.WriteLine($"{task.Description} {task.Priority}");
            }
        }
    }

    class PriorityComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }

    enum Priority
    {
        Low = 1,
        Medium,
        High
    }

    class Task
    {
        /// <summary>
        /// Gets the description of the task.
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Task"/> class.
        /// </summary>
        /// <param name="description">The description of the task.</param>
        /// <param name="priority">The priority of the task.</param>
        
         /// <summary>
        /// Gets the priority of the task.
        /// </summary>
        public Priority Priority { get; }
        public Task(string description, Priority priority)
        {
            Description = description;
            Priority = priority;
        }
       

        
    }
}
