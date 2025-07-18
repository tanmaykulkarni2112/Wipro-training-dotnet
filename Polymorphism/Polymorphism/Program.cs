using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// BASE AND DERIVED

// COMPILE TIME CHANGES BY PARAMS
// RUNTIME POLY IS METHOD OVERRIDING

// VIRTUAL KEYWORD and OVERRIDE

namespace Polymorphism
{
    public class Calc
    {
        // Compile time polymorphism
        public String adder()
        {
            return "This is the adder method";
        }

        public int adder(int a, int b)
        {
            return a + b;
        }


    }
    // Runtime polymorphism

    public class Employee
    {
        public virtual void printer()
        {
            Console.WriteLine(".....");
        }
    }

    class partTimeEmployee : Employee
    {
        public override void printer()
        //public  void printer()
        {
            Console.WriteLine("HELLO WORLD");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine(calc.adder());
            Console.WriteLine(calc.adder(2, 3));


            partTimeEmployee pt = new partTimeEmployee();
            pt.printer();
        }
    }
}