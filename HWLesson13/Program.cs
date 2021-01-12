using System;

namespace HWLesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer Acer = new Computer()
            {
                model = "Acer's model",
                price = 3890,
                numberOfProcessor = 5,
                screenSize = 14,
                isTurnOn = true
             };

            
            Console.WriteLine(Acer);
            Acer.turnOn();
            Console.WriteLine(Acer.tellMeThePrice());

            Computer Asus = new Computer() {
                model = "Asus's model",
                price = 2979,
                numberOfProcessor = 3,
                screenSize = 15.6f,
                isTurnOn = true,
            };

            Console.WriteLine(Asus);
            Asus.turnOn();
            Console.WriteLine(Asus.tellMeTheScreenSize());

            Computer HP = new Computer() {
                model = "HP's model",
                price = 3474,
                numberOfProcessor = 5,
                screenSize = 14,
                isTurnOn = false
            };

            Console.WriteLine(HP);
            HP.AddProcessor(7);
            HP.turnOff();

        }
    }
}
