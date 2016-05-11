using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class GetObjectType
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Type t = p.GetType();
            Console.WriteLine(t.FullName);
            Console.WriteLine("Is a Class: " +t.IsClass);
        }
    }
}
