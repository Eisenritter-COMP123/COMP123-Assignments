using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Pet
    {
        public string name { get; private set; }
        public string owner { get; private set; } = "no one";
        public string tricks { get; private set; } = "none";
        public int age { get; private set; }
        public string description { get; private set; }
        public bool isHouseTrained { get; private set; } = false;

        public Pet(string name, int age, string description)
        {
            this.name = name;
            this.age = age;
            this.description = description;
        }

        public override string ToString()
        {
            return $"The pet's name is {name}, {owner} is the owner, the age of the pet is {age}, {description}. This pet is {(isHouseTrained ? "is House Trained" : "isn't House Trained")}. The tricks it can do is {tricks}";
        }

        public void setOwner(string newOwner)
        {
            this.owner = newOwner;
        }

        public void AddTrick(string trick)
        {
            this.tricks = trick;
        }
    }
}
