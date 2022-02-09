using System;
using System.ComponentModel;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cat cat = new Cat();
            Cat.SayMew("I'm a cute cat!!");
            
        }
    }
    
    class Cat
    { 
        [Localizable(true)]
        public static void SayMew(string message)
        {
            Console.WriteLine(message);
        }
    }
    
    public class Person
    {
        internal string Name { get; set; } // Auto-property can be made get-only

        public Person(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public override string ToString()
        {
            return $"NAME: {Name.ToUpper()}";
        }
    }
}