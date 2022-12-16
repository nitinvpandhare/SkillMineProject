using System;
using System.Collections;
using System.Text;

namespace SkillMineProject.NonGenericCollections
{
    class QueueEx
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("hello");
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);

            queue.Dequeue();
            Console.WriteLine("peek element ="+queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
