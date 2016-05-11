using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class ReflectionInstantion
    {
        static void Main(string[] args)
        {
            var newObj = CreateType<ObjectA<int>>(3);
            Console.WriteLine(newObj);
            var newObj2 = CreateType<ObjectA<string>>("Created");
            Console.WriteLine(newObj2);
        }
        private static T CreateType<T>(params object[] parameters)
        {
            return (T)Activator.CreateInstance(typeof(T), parameters);
        }
    }
    class ObjectA<T>
    {
        private T _obj;
        public ObjectA(T obj)
        {
            _obj = obj;
        }
        public override string ToString()
        {
            return _obj.ToString();
        }
    }

}
