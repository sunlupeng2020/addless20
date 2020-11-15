using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace TestReflect
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly[] ass = AppDomain.CurrentDomain.GetAssemblies();
            Person p = new Person();
            p.TestAssembly();

            Console.ReadKey();
        }
    }


    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private int Id;
        public double Sum;

        public void Method1() { }
        private void Method2() { }

        public void TestAssembly()
        {
            Assembly ass = this.GetType().Assembly;
            Console.WriteLine(ass);
            Type[] types = ass.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine(item + "   (types)");
            }
            Type currentType = ass.GetType();
            Console.WriteLine(currentType);
            Type typeByFullName = ass.GetType("ConsoleApp2.Person");
            Console.WriteLine(typeByFullName);

            Type type = this.GetType();
            Console.WriteLine(type);
            MethodInfo[] methods = this.GetType().GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine(item + "    (methods)");
            }
            var members = this.GetType().GetMembers();
            foreach (var item in members)
            {
                Console.WriteLine(item);
            }
            var member = this.GetType().GetMember("Name");
            foreach (var item in member)
            {
                Console.WriteLine(item);
            }
            FieldInfo field = type.GetField("Sum");
            Console.WriteLine(field);
            PropertyInfo prop = type.GetProperty("Name");
            Console.WriteLine(prop);
        }
    }
}
