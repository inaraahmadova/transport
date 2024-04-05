namespace transport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("audio", "a3", "white", 5.5, 250, 4, false);
            Car car2 = new Car("audio", "a3", "black", 7.2, 30, 4, false);


            Bicycle bicycle1 = new Bicycle("bmw", "f10", "black", 2.0, 20, "sedan");
            Bicycle bicycle2 = new Bicycle("bmw", "f10", "red", 2.0, 20, "sedan");


            //Console.WriteLine("Car Information:");
            //car1.GetInfo();
            //car2.GetInfo();

            //Console.WriteLine("\nBicycle Information:");
            //bicycle1.GetInfo();
            //bicycle2.GetInfo();


            Car[] cars = { car1, car2 };
            Bicycle[] bicycles = { bicycle1, bicycle2 };

            foreach (var vehicle in cars)
            {
                vehicle.GetInfo();
            }

            foreach (var vehicle in bicycles)
            {
                vehicle.GetInfo();
            }
        }
    }
}
