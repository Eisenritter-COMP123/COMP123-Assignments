using System;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IntListDemo();
        }
        static void IntListDemo()
        {
            List<int> numbers = new List<int>();
            //loop to add 5,10,15...20 to the listf
            for (int i = 5; i <= 500; i += 5;)
            {
                numbers.Add(i);
            }
            //print all the item in the collection
            foreach (int item in numbers)
            {
                Console.Write(item+" ");
            }
        }
    }
}
