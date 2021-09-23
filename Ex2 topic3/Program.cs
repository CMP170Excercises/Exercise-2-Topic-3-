using System;
using System.Collections.Generic;

namespace Ex2_topic3
{
    public interface lAnimal
    {
        void Move();
        DateTime brithdate { get; set; }

        void Speak();
    }

    public abstract class BaseAnimal : lAnimal
    {
        public abstract void Move();
        public abstract DateTime brithdate { get; set; }
        public abstract void Speak();
    }
    public  class Pet : BaseAnimal
    {
        public string Name { get; set; }
        public override DateTime brithdate { get; set; }
        public string color { get; set; }
        public Pet (string name, string color)

        {
            this.Name = name;
            this.color = color;
        }
        public override void Move()
        {

        }
        public override void Speak()
        {

        }
    }
        public class Monkey : BaseAnimal
    {

        public override DateTime brithdate { get ; set ; }

        public override void Move()
        {
            Console.WriteLine("Monkey is jumping, climping ");
        }
        public override void Speak()
        {
            Console.WriteLine("Monkey say hu hu hu ka ka  ");
        }
      
    }
    public  class Dog:Pet
    {
       public Dog (string name, string color) : base (name,color)
        { }
        public override void Move()
        {
            Console.WriteLine(Name+ "(dog) move with 4 legs." + "color : " + color);
        }
        public override void Speak()
        {
            Console.WriteLine(Name+ "(Dog) say  gau gau gau ");
        }
    }
    public  class Cat:Pet
    {
       public Cat(string name, string color): base(name,color)
        { }
        public override void Move()
        {
            Console.WriteLine(Name + " (cat) move with 4 legs." + "color : " + color);
        }
        public override void Speak()
        {
            Console.WriteLine(Name + "Cat say meo meo meo");
        }
        public void jump()
        {
            Console.WriteLine(Name + "(cat) jump beaty");
        }
    }
    class program { 
        static void Main(string[] args)
        {
        List<lAnimal> animals = new List<lAnimal>();
        animals.Add(new Dog("cậu vàng ", "black "));
        animals.Add(new Monkey());
        animals.Add(new Cat("cậu trắng ", "white"));

        foreach (lAnimal animal in animals)
        {
            animal.Move();
            animal.Speak();
        }
        Console.ReadLine();
    }
    }
}
