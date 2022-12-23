using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.GenericCollections
{


    //Bank
    public enum AccountType { Saving, Current }

    public class Customers
    {
        public int AccNo { get; set; }
        public string Name { get; set; }
        public AccountType AccountType;
        public List<Loan> Loanlist = new List<Loan>();
    }
    public class Loan
    {
        public int Id { get; set; }
        public string LoanName { get; set; }
    }

    

    class ClassWork
    {
        static void Main(string[] args)
        {
            //Bank details
            List<Customers> Customerlist = new List<Customers>()
            {
                 new Customers
                 {
                     AccNo = 11,
                     Name = "Suraj Mohite",
                        AccountType = AccountType.Current,
                        Loanlist = {
                           new Loan { Id = 134, LoanName = "PersonalLoan" },
                             new Loan { Id = 114, LoanName = "CarLoan" },
                            new Loan { Id = 135, LoanName = "HomeLoan" },
                        }
                 },
                 new Customers
                 {
                        AccNo = 12,
                        Name = "Kajol",
                        AccountType = AccountType.Saving,
                        Loanlist = {
                            new Loan { Id = 136, LoanName = "FarmingLoan" },
                            new Loan { Id = 137, LoanName = "GoldLoan" },
                            new Loan { Id = 138, LoanName = "CarLoan" },
                        }
                 },
                 new Customers
                 {
                        AccNo = 12,
                        Name = "Kajol",
                        AccountType = AccountType.Saving,
                        Loanlist = {
                            new Loan { Id = 136, LoanName = "FarmingLoan" },
                            new Loan { Id = 137, LoanName = "GoldLoan" },
                            new Loan { Id = 138, LoanName = "CarLoan" },
                        }
                 },

            };
            foreach (Customers c in Customerlist)
            {
                Console.WriteLine($" AccNo-> {c.AccNo} Name-> {c.Name} AccountType-> {c.AccountType}");
                foreach (Loan cl in c.Loanlist)
                {
                    Console.WriteLine($" \t Id-> {cl.Id} LoanName-> {cl.LoanName}");
                }
            }
        }
            
        
        
    }
}
