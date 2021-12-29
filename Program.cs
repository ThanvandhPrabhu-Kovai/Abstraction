using System;

namespace Abstraction
{
    abstract class AbAnimal
    {
        public abstract void run(int speed);
    }

    class Cheetah : AbAnimal
    {
        public override void run(int speed)
        {
            Console.Write("\n\nRunning at a speed of {0}...", speed);
        }
    }

    abstract class AbCar
    {
        public abstract void move(int speed);

        public void stop()
        {
            Console.Write("\n\n...Stopping!");
        }
    }

    class Car : AbCar
    {
        public override void move(int speed)
        {
            Console.Write("Cruising at a speed of {0}kmph...", speed);
        }

        public void applyBrakes()
        {
            stop();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.move(80);
            car.applyBrakes();

            Cheetah cheetah = new Cheetah();
            cheetah.run(120);

            Console.ReadLine();
        }
    }
}
