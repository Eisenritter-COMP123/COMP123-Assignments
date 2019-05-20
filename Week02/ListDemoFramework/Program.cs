using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemoFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            IntListDemo();
        }
        static void StringListDemo()
        {
            //Creating a list with five strings
            List<string> pms = new List<string>() { "Trudeau", "Harper", "Martin", "Chretien", "MacDonald" };
            pms.Insert(3, "King");
            for (int i = 0; i<pms.Count; i++)
            {
                if (pms[i].StartsWith("C"))
                {
                    pms.RemoveAt(i);
                }
            }
            foreach (string pm in pms)
            {
                Console.Write(pm + ", ");
            }
        }
        static void IntListDemo()
        {
            List<int> numbers = new List<int>();
            //loop to add 5,10,15...20 to the listf
            for (int i = 5; i <= 500; i += 5)
            {
                numbers.Add(i);
            }
            //print all the item in the collection
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
