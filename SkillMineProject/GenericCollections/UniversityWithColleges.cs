using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.GenericCollections
{
    class UniversityWithColleges
    { 
        public class University
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gread { get; set; }
           public List<Clg> clgLists = new List<Clg>();
        }
        public enum Depart { ENTC, MEch, IT, }
        public class Clg
        {
            public int ClgId { get; set; }
            public string ClgName { get; set; }
            public string ClgGread { get; set; }
            public Depart Depart;
            public List<Faculties> faculties = new List<Faculties>();
        }
        public class Faculties
        {
            public int FacId { get; set; }
            public string FacName { get; set; }
            public string Subject { get; set; }
            public string Experience { get; set; }
            public double Salary { get; set; }
        }
        static void Main(string[] args)
        {
            List<University> universities = new List<University>()
            {
                new University
                {
                    Id=44,
                    Name="Solapur University",
                    Gread="A++",
                    clgLists =
                    {
                        new Clg
                        {
                            ClgId=2345,
                            ClgName="SVERIS College of Engineering Pandharpur",
                            ClgGread="A++",
                            Depart=Depart.ENTC,
                            faculties =
                            {
                                new Faculties{FacId=77,FacName="Manoj Deshmukh", Experience="9 Years",Subject="Micro",Salary=67900},
                                new Faculties{FacId=77,FacName="Pawar Meenakshi", Experience="9 Years",Subject="Micro",Salary=67900},
                                new Faculties{FacId=77,FacName="Shinde jyoti", Experience="9 Years",Subject="Micro",Salary=67900},
                            }
                        },
                        new Clg
                        {
                            ClgId=2345,
                            ClgName="SVERIS College of Engineering Pandharpur",
                            ClgGread="A++",
                            Depart=Depart.ENTC,
                            faculties =
                            {
                                new Faculties{FacId=77,FacName="Manoj Deshmukh", Experience="9 Years",Subject="Micro",Salary=67900},
                                new Faculties{FacId=77,FacName="Pawar Meenakshi", Experience="9 Years",Subject="Micro",Salary=67900},
                                new Faculties{FacId=77,FacName="Shinde jyoti", Experience="9 Years",Subject="Micro",Salary=67900},
                            }
                        }
                    }
                }
            };
            foreach (var u in universities)
            {

            }
        }
    }
}
