using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject
{
    public class Adult : Person
    {
        public string statut;
        public string nationalitate;

        public void say_hello()
        {
            Console.WriteLine("The adult says hello!");

        }
        public override void say_goodbye()
        {
            Console.WriteLine("The adult says goodbye.");
        }
        public void it_exists()
        {
            Console.WriteLine("This adult exists.");
        }
        public void doesnt_exist()
        {
            Console.WriteLine("This adult doesn't exists.");
        }
    }
}
