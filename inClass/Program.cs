using inClass;
using System.Numerics;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        #region roy
        //TransportShip transportShip = new TransportShip(5);
        //Console.WriteLine(transportShip.Move(5));
        //Console.WriteLine(transportShip.ToString());
        //BaseShip a_ship = new TransportShip(2);
        //BaseShip b_ship = new BaseShip(3);
        //Console.WriteLine(b_ship.Move(100));
        //Console.WriteLine(a_ship.Move(100));
        //TransportShip c_ship = (TransportShip) a_ship;
        //TransportShip? d_ship = a_ship as TransportShip;
        //Dog dog = new Dog() { Weight = 3.5, Name = "Dog Buddy" };
        //Cat cat = new Cat() { Weight = 2.5, Name = "Cat Buddy" };
        //Duck duck = new Duck() { Weight = 4.5, Name = "Duck Buddy" };
        //Cheata cheata = new Cheata() { Weight = 40.5, Name = "Cheata Buddy" };
        //Animal[] animals = new Animal[] { dog, cat, cheata, duck };
        //foreach( Animal animal in animals)
        //{
        //    Console.WriteLine(animal.SayHello());
        //}
        //Dog dog1 = new Dog();
        //Console.WriteLine(Dog.counter);
        //Console.WriteLine(Dog.DoSomething());
        //Student student1 = new Student() { Name= "Dan", Age=20};
        //Student student2 = new Student() { Name = "Yonatan", Age=17};
        //Student student3 = new Student() { Name = "Ido", Age = 17 };
        //Student student4 = new Student() { Name = "Omri", Age = 17 };
        //Student student5 = new Student() { Name = "Amit",Age = 17};
        //Student student6 = new Student() { Name = "Nevo", Age = 17 };

        //Student[] students = {  student1, student2, student3, student4, student5, student6 };

        //Array.Sort(students);

        //foreach(Student student in students)
        //{
        //    Console.WriteLine(student);
        //}
        try
        {
        Console.Write("Enter the number: ");
        int num = int.Parse(Console.ReadLine());
        num = num + 3;
        Console.WriteLine("Result is: " + num);
            Test();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Format Exception " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed");
        }

        static void Test()
        {
            Console.WriteLine("enter your name please:");
            string? name = Console.ReadLine();
            if(name == "roy")
                Console.WriteLine("Hello " + name);
            else
            {
                throw new Exception("Name is not Roy!!!!!!");
            }
        }
        #endregion
    }
}