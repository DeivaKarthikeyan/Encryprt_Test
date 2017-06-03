using System;

namespace ConsoleApp2
{

    public class Parent : Object
    {
        public Parent(string s)
        {
            name = s;
            Console.WriteLine("Parent Cons Called" + s);
        }
        public string name;

        public virtual void DoWork()
        {
            Console.WriteLine("Parent is doing work");

        }
    }
    public class Child : Parent
    {
        public Child(string initialName) :base(initialName)
        {

            name = "Karthik";
            Console.WriteLine("Child Cons Called" + initialName);
        }

        public override void DoWork()
        {
            base.DoWork();
            Console.WriteLine("Child is doing work");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child("Karthik-2");

            Console.WriteLine(c.name);
            c.DoWork();
            Console.ReadLine();
        }
    }
}