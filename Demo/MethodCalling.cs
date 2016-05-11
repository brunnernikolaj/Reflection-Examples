using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class MethodCalling
    {
        static void Main(string[] args)
        {
            //The object to call the method on
            var testObject = new TestObject();
            //Typeinfo for our TestObject class 
            Type type = typeof(TestObject);
            //MethodInfo for our Add method
            MethodInfo method = type.GetMethod("Add");
            //Result after calling out Add method on our newly created TestObject
            var result = (int)method.Invoke(testObject, new object[] { 2, 3 });
            Console.WriteLine(result);
        }
    }
}
