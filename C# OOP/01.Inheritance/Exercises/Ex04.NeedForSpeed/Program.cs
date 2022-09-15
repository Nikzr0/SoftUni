namespace Ex04.NeedForSpeed
{
    public class Vehicle
    {
        public double DefaultFuelConsumption { get; set; }
        public virtual double FuelConsumption { get; set; }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public Vehicle()
        {
            DefaultFuelConsumption = 1.25;
        }
        public virtual void Drive(double kilometers)
        {
            Fuel = Fuel - FuelConsumption * kilometers / 100;
        }
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }
        public Motorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }

    public class Car : Vehicle
    {
        public Car()
        {
            DefaultFuelConsumption = 3;
        }

        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }

    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle()
        {
            DefaultFuelConsumption = 8;
        }

        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }

    public class CrossMotorcycle : Motorcycle
    {
        public CrossMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }

    public class FamilyCar : Car
    {
        public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }

    public class SportCar : Car
    {
        public SportCar()
        {
            DefaultFuelConsumption = 10;
        }

        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }

    public class Program
    {
        static void Main()
        {
            
        }
    }
}