using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFastfoodDemo
{
    class Server
    {
        protected List<string> duties;
        protected double wages;
        public string Name { get; }
        public Server(string name)
        {
            Name = name;
            wages = 14;
            duties = new List<string>();
            duties.Add("Clean Floor");
        }
        public override string ToString()
        {
            return $"The Server's name is {Name} the wages is {wages:C} the duties are {string.Join(", ",duties)}";
        }
    }

    class Supervisor:Server
    {
        public Supervisor(string name):base(name)
        {
            wages = 20;
            duties.Add("Fire server");
        }

        public override string ToString()
        {
            return $"The Supervisor's name is {Name} the wages is {wages:C} the duties are {string.Join(", ", duties)}";
        }
    }

    class Manager:Supervisor
    {
        public Manager(string name) : base(name)
        {
            wages = 30;
            duties.Add("Fire manager");
        }


        public override string ToString()
        {
            return $"The Manager's name is {Name} the wages is {wages:C} the duties are {string.Join(", ", duties)}";
        }
    }
}
