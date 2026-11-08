namespace TurboRaceGame
{
    public class SportsCar : Vehicle
    {
        public SportsCar() : base("Sports Car", 40, "Nitro Boost", 30, 180) { }
        public override string Drive()
        {
            double a = AddSpeed(10);
            return "Accelerated by " + a + " km/h. Current speed: " + currentSpeed + " km/h.";
        }
        public override string UsePower()
        {
            AddSpeed(PowerIncrease);
            return "Nitro Boost activated! Current speed: " + currentSpeed + " km/h.";
        }
    }

    public class Motorbike : Vehicle
    {
        public Motorbike() : base("Motorbike", 35, "Wheelie Boost", 20, 140) { }
        public override string Drive()
        {
            double a = AddSpeed(8);
            return "Motorbike zips forward by " + a + " km/h. Current speed: " + currentSpeed + " km/h.";
        }
        public override string UsePower()
        {
            AddSpeed(PowerIncrease);
            return "Wheelie Boost activated! Current speed: " + currentSpeed + " km/h.";
        }
    }

    public class MonsterTruck : Vehicle
    {
        public MonsterTruck() : base("Monster Truck", 25, "Crush Power", 15, 100) { }
        public override string Drive()
        {
            double a = AddSpeed(5);
            return "Monster Truck rumbles ahead by " + a + " km/h. Current speed: " + currentSpeed + " km/h.";
        }
        public override string UsePower()
        {
            AddSpeed(PowerIncrease);
            return "Crush Power activated! Current speed: " + currentSpeed + " km/h.";
        }
    }

    public class ElectricCar : Vehicle
    {
        public ElectricCar() : base("Electric Car", 30, "Battery Boost", 25, 160) { }
        public override string Drive()
        {
            double a = AddSpeed(7);
            return "Electric Car glides forward by " + a + " km/h. Current speed: " + currentSpeed + " km/h.";
        }
        public override string UsePower()
        {
            AddSpeed(PowerIncrease);
            return "Battery Boost activated! Current speed: " + currentSpeed + " km/h.";
        }
    }
}