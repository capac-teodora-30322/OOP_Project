using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject
{
    class Angajat : Adult
    {
        public float salariu;
        public int ani_vechime;
        public string loc_munca;
        public void say_hello()
        {
            Console.WriteLine("The employee says hello!");

        }
        public override void say_goodbye()
        {
            Console.WriteLine("The employee says goodbye.");
        }
        public void it_exists()
        {
            Console.WriteLine("This employee exists.");
        }
        public void doesnt_exist()
        {
            Console.WriteLine("This employee doesn't exists.");
        }
    }
}
