using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_2
{
    internal class Overload
    {

        private string Name;

        public Overload(string name)
        {
            Name = name;
        }

        public Overload()
        {
            
        }



        public void PrintWelcomeMsg()
        {
            
            Console.WriteLine("Hello and Welcome" + Name);
            

        }

        public void PrintWelcomeMsg(string Kompliment)
        {
            Console.WriteLine("Hello and Welcome" + Name + Kompliment);


        }

        public void ShowWelcome()
        {
            var Person = new Overload(" Trine, ");
            Person.PrintWelcomeMsg("You are so kind and sweet!");
        }

    }
}
