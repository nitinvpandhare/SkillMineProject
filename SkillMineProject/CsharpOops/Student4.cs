using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject.CsharpOops
{
    class Student4
    {
        private int stdid;
        private string stdname;
        private double persentage;

        public int Stdid
        {
            set { stdid = value; }
            get { return stdid; }
        }
        public string Stdname
        {
            set { stdname = value; }
            get { return stdname; }
        }
        public double Persentage
        {
            set { persentage = value; }
            get { return persentage; }
        }

        public string Display()
        {
            return $"{stdid} ->{stdname} ->{persentage}";

        }
    }
}
