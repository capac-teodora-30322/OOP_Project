using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ultimatema;

namespace Program
{
    public class ultimatema
    {
        static void Main(string[] args)
        {
        //static
            Person Mara = new Person();
            Mara.say_hello();
            Person Teo = new Adult();
            Teo.say_hello();
            Person Stefan = new Copil();
            Stefan.say_hello();
            Person Vlad = new Angajat();
            Vlad.say_hello();

            Console.WriteLine("\n");

            //dinamic
            Person Andrei = new Person();
            Andrei.say_goodbye();
            Person David = new Adult();
            David.say_goodbye();
            Person Angi = new Copil();
            Angi.say_goodbye();
            Person Stefania = new Angajat();
            Stefania.say_goodbye();

            Console.WriteLine("\n");

            //interfata
            Person Mihai = new Person();
            Mihai.it_exists();
            Mihai.doesnt_exist();
            Adult Claudia = new Adult();
            Claudia.it_exists();
            Claudia.doesnt_exist();
            Copil Cecilia = new Copil();
            Cecilia.it_exists();
            Cecilia.doesnt_exist();
            Angajat Ramona = new Angajat(); 
            Ramona.it_exists();
            Ramona.doesnt_exist();            
        }
    }
}	