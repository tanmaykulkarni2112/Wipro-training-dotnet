using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine($"...ASsembly name: {assembly.FullName}");
            foreach(var module in assembly.GetModules())
            {
                Console.WriteLine($"...Module Name: {module.Name}");
                foreach (var type in module.GetTypes()) {
                    if (type.IsClass) {
                        Console.WriteLine($"...Class Name: ${type.FullName}");                    
                    }
                    ConstructorInfo[] constructors = type.GetConstructors();
                    foreach (var ctor in constructors) {
                        Console.WriteLine($"... Constructor : ${ctor.Name}");
                        ParameterInfo[] parameters = ctor.GetParameters();

                    }  
                }
            }
        }
    }
}
