using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet p1 = new Pet("Lucy", 5, "A golden retriever");
            Pet p2 = new Pet("Elton", 15, "A labrador");
            Pet p3 = new Pet("Bill", 1, "A skeloton");
            Pet p4 = new Pet("Omega", 20000, "A god");

            //Creating a list with five strings
            List<Pet> pets = new List<Pet>() { p1, p2, p3, p4 };
            PrintSpcfOwnerPets(pets);

        }

        private static void PrintSpcfOwnerPets(List<Pet> pets)
        {
            foreach (Pet pet in pets)
            {
                if (pet.owner.Equals("no one"))
                {
                    Console.WriteLine(pet);
                }
            }
        }
    }
}
