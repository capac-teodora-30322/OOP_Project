using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject
{
    class Copil : Person
    {
        public string studii;
        public int nr_siblings;
        public void say_hello()
        {
            Console.WriteLine("The child says hello!");

        }
        public override void say_goodbye()
        {
            Console.WriteLine("The child says goodbye.");
        }
        public void it_exists()
        {
            Console.WriteLine("This child exists.");
        }
        public void doesnt_exist()
        {
            Console.WriteLine("This child doesn't exists.");
        }
    }
} 
