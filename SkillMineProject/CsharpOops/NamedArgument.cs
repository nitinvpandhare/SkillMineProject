using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.CsharpOops
{
    class NamedArgument
    {
        //student
        private int rollno;
        private string name;
        private double persentage;
        private string country;
        private static int count = 0;

        public NamedArgument(string name, double persentage, string country = "India")
        {
            count++;
            rollno = count;
            this.name = name;
            this.persentage = persentage;
            this.country = country;
        }

        public override string ToString()
        {
            return $"{rollno} ->{name} ->{persentage} ->{country}";
        }
    }
}
