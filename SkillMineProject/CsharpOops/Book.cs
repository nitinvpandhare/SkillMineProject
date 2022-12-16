using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.CsharpOops
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id}-{Name}-{Author}-{Price}";
        }

    }
}
