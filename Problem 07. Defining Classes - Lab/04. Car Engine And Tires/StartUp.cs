using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tire = new Tire[4]
              {

                new Tire(1, 2.5),
                new Tire(1, 2.5),
                    new Tire(1, 2.5),
                    new Tire(1, 2.5),
               
               };


            Engine engine = new Engine(560,6300);
            
            Car car = new Car("BMW","X6",2010,250,9,engine,tire);
            for (int i = 0; i < car.Tire.Length; i++)
            {
                int currentTire = car.Engine.HoursePower;
                Console.WriteLine(currentTire);
            }
           
        }
    }
}
