using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimatema;

public class Person : IEntity
{
    public float height { get; set; }
    public float weight { get; set; }
    public string first_name { get; set; }
    public int age { get; set; }
    public char gender { get; set; }
    public string last_name { get; set; }


    public void say_hello()
    {
        Console.WriteLine("The person says hello!");
    }
    public virtual void say_goodbye()
    {
         Console.WriteLine("The person says goodbye.");
    }
   public void it_exists()
    {
        Console.WriteLine("This person exists.");
    }
    public void doesnt_exist()
    {
        Console.WriteLine("This person doesn't exists.");
    }

}
