using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = "{";
            Person p = new Person();
            FieldInfo[] fi = p.GetType().GetFields();
            foreach (var field in fi)
            {
                json = json + "\"" + field.Name + "\": \"" + field.GetValue(p) + "\",";
            }
            json = json.Substring(0, json.Length - 1) + "}";
            Console.WriteLine(json);
        }
    }
    
}
