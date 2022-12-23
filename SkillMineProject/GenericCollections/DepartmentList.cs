using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.GenericCollections
{
    //Department list

    public enum DepartmentType { Hr, Development, Testing }
    public class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        //public List<Deptments> deptments = new List<Deptments>();
    }
    public class Deptments
    {
        public int Id { get; set; }
      //  public string Name { get; set; }
        public DepartmentType DepartmentType;
        public List<Employe> employes = new List<Employe>();
    }
    class DepartmentList
    {
        static void Main(string[] args)
        {
            List<Deptments> deptments = new List<Deptments>()
            {
                new Deptments
                {
                    Id=0001,
                    DepartmentType=DepartmentType.Development,
                    employes =
                    {
                        new Employe{Id=0043, Name="Suraj", Salary=98765},
                        new Employe{Id=0045, Name="BT", Salary=5454}
                    }
                },
                new Deptments
                {
                    Id=0002,
                    DepartmentType=DepartmentType.Hr,
                    employes =
                    {
                        new Employe{Id=34, Name="Nitin", Salary=6565},
                        new Employe{Id=35, Name="Sagar", Salary=6446},
                    }
                },
                 new Deptments
                {
                    Id=0004,
                    DepartmentType=DepartmentType.Testing,
                    employes =
                    {
                        new Employe{Id=34, Name="Nitin", Salary=6565},
                        new Employe{Id=35, Name="Sagar", Salary=6446},
                    }
                }
            };

            foreach (var d in deptments)
            {
                Console.WriteLine($"{d.Id} {d.DepartmentType} ");
                foreach (var ee in d.employes)
                {
                    Console.WriteLine($" \t {ee.Id} {ee.Name} {ee.Salary}");
                }
            }
        }
    }
}
