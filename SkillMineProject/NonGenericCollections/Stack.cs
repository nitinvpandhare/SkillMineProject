using System;
using System.Collections;
using System.Text;

namespace SkillMineProject.NonGenericCollections
{
    class StackEx
    {
        class StackEmp
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }

            public override string ToString()
            {
                return $"{Id}  {Name}  {Salary}";
            }
        }
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("spit");
            stack.Push(19);
            stack.Push(new StackEmp{ Id=1,Name="nitin",Salary=2000});
            stack.Push(20);
            stack.Pop();

            Console.WriteLine("peek value ="+stack.Peek());

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
