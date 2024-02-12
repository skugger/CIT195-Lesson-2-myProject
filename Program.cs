using System;
using System.Net.NetworkInformation;

namespace myProject
{
    class locomotive
    {
        private string _wheels;
        private string _name;
        private string _manufacturer;

        public locomotive()
        {
            _wheels = "";
            _name = "";
            _manufacturer = "";
        }
        public locomotive(string wheels, string name, string manufacturer)
        {
            _wheels = wheels;
            _name = name;
            _manufacturer = manufacturer;
        }
        public string getWheels()
        {
            return _wheels;
        }
        public string getName()
        {
            return _name;
        }
        public string getManufacturer()
        {
            return _manufacturer;
        }
        public void setWheels(string wheels)
        {
            _wheels = wheels;
        }
        public void setName(string name)
        {
            _name = name;
        }
        public void setManufacturer(string manufacturer)
        {
            _manufacturer = manufacturer;
        }
    }

    class myRoundhouse
    {
        static void Main(string[] args)
        {
            locomotive engine01 = new locomotive();
            engine01.setWheels("4-6-4");
            engine01.setName("Hudson");
            engine01.setManufacturer("Alco");

            locomotive engine02 = new locomotive();
            engine02.setWheels("4-6-2");
            engine02.setName("Pacific");
            engine02.setManufacturer("Baldwin");

            locomotive engine03 = new locomotive("4-8-4", "Northern", "Lima");
            locomotive engine04 = new locomotive("2-8-2", "Mikado", "Baldwin");

            displayengine(engine01);
            displayengine(engine02);
            displayengine(engine03);
            displayengine(engine04);
        }
        static void displayengine(locomotive locomotive)
        {
            Console.WriteLine();
            Console.WriteLine("Here's your steam engine information:");
            Console.WriteLine($"engine name: {locomotive.getName()}");
            Console.WriteLine($"engine wheel arrangement: {locomotive.getWheels()}");
            Console.WriteLine($"engine manufacturer: {locomotive.getManufacturer()}");
        }
    }
}