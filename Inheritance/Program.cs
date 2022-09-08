using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Father
    {
        public string FatherName()
        {
            return "Ronaldo";
        }
    }

    public class ChildFirst : Father
    {
        public string ChildDName()
        {
            return "Messi";
        }
    }


    public class ChildSecond : Father
    {
        public string ChildDName()
        {
            return "Dybala";
        }
    

        static public void Main()
        {
            ChildFirst first = new ChildFirst();

            Console.WriteLine("My name is " + first.ChildDName() +
                              ". My father name is " +
                              first.FatherName() + ".");

            ChildSecond second = new ChildSecond();

            Console.WriteLine("My name is " + second.ChildDName() +
                              ". My father name is " +
                              second.FatherName() + ".");
        } 
    }
   
}
