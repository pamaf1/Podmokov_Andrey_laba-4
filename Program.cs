using System;

namespace Лаба_4_2._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird b = new Bird();
            b.DisplayInfo();
            b.HightFly();

            Owl o = new Owl();
            o.DisplayInfo();

            Dog d = new Dog();
            d.DisplayInfo();
        }
    }
    public abstract class Animal
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public string Sound { get; set; }

        public int Speed { get; set; }

        public abstract void HightFly();

        public Animal(string name, int age, string sound, int speed)
        {
            Name = name;
            Age = age;
            Sound = sound;
            Speed = speed;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}\nВозраст: {Age}\nЗвук: {Sound}\nСкорость: {Speed}\n");
        }

    }
    public class Bird : Animal
    {

        public Bird() : base("Bird", 7, "Кря", 50) { }

        public override void HightFly()
        {
            Console.WriteLine("Висота польоту птаха: 70");
        }



    }
    public class Dog : Animal
    {

        public Dog() : base("Dog", 10, "Гаф", 30) { }

        public override void HightFly()
        {
            Console.WriteLine("Только бегает");
        }

    }
    public class Owl : Animal
    {

        public Owl() : base("Owl", 20, "Угу", 40) { }

        public override void HightFly()
        {
            Console.WriteLine("30");
        }

    }
}
