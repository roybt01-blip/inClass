using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace inClass
{
    public abstract class Animal
    {
        public double Weight { get; set; }
        public string? Name { get; set; }
        protected string? description;
        public abstract string SayHello();
        
        public string GetName()
        {
            return Name!;
        }
        public void SetName(string name)
        {
            this.Name = name ;
        }
    }
    public class Dog : Animal
    {
        public static int counter = 0;
        public Dog()
        {
            counter++;
        }
        public static string DoSomething()
        {
            return "static method ready!";
        }
        public override string SayHello()
        {
            return $"woof! I am a dog, my name is {Name} and my description is: {this.description}";
        }
    }
    public class Cat : Animal
    {
        public override string SayHello()
        {
            return $"mew! I am a cat and my name is {Name}";
        }
    }
    public class Duck : Animal
    {
        public override string SayHello()
        {
            return $"quek! I am a duck and my name is {Name}";
        }
    }
    public class Cheata : Animal
    {
        public override string SayHello()
        {
            return $"mew! i am a cheata and my name is {Name}";
        }
    }
    public class Horse : Animal
    {
        public void Jump()
        {
            Console.WriteLine($"{Name}: Jump!");
        }
        public override string SayHello()
        {
            return "igo-go";
        }
    }
}
