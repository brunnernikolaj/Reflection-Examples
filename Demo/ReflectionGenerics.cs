using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class ReflectionGenerics
    {
        static void Main(string[] args)
        {
            PrintType(1);
            PrintType("hey");
            PrintType(false);
        }

        private static void PrintType<T>(T obj)
        {
            Console.WriteLine(obj.GetType());
        }
    }
}
