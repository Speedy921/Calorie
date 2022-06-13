using System;

namespace Calorie
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("красное яблоко", 100, 100);
            Apple apple2 = new Apple("Зеленое яблоко", 90, 110);

            var sumApple = Apple.Add(apple, apple2);
            var sumapple2 = apple + apple2;

            Console.WriteLine(apple);
            Console.WriteLine(apple2);
            Console.WriteLine(sumApple);
            Console.WriteLine(sumapple2);

            Console.ReadLine();
        } 
    }
}
