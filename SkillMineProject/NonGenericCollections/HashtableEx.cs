using System;
using System.Collections;
using System.Text;

namespace SkillMineProject.NonGenericCollections
{
    class HashtableEx
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "thane");
            hashtable.Add(10, "panvel");
            hashtable.Add(2, "pune");
            hashtable.Add(3, "solapur");
            hashtable.Add(8, "sangli");

            hashtable.Remove("sangli");

            Console.WriteLine(hashtable.Count);

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            

            Console.WriteLine("---------------------");

            SortedList sortedList = new SortedList();
            sortedList.Add(1, "thane");
            sortedList.Add(10, "panvel");
            sortedList.Add(2, "pune");
            sortedList.Add(3, "solapur");
            sortedList.Add(8, "sangli");

            Console.WriteLine(sortedList.Count);
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
