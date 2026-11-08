using System;

namespace TurboRaceGame
{
    public abstract class Vehicle
    {
        private string name, powerName;
        private double initialSpeed, maxSpeed, powerIncrease;
        protected double currentSpeed;

        protected Vehicle(string name, double initialSpeed, string powerName,
                          double powerIncrease, double maxSpeed)
        {
            this.name = name;
            this.initialSpeed = initialSpeed;
            this.powerName = powerName;
            this.powerIncrease = powerIncrease;
            this.maxSpeed = maxSpeed;
        }

        public string Name { get { return name; } }
        public double InitialSpeed { get { return initialSpeed; } }
        public double MaxSpeed { get { return maxSpeed; } }
        public double PowerIncrease { get { return powerIncrease; } }
        public double CurrentSpeed { get { return currentSpeed; } }
        public string PowerDescription
        {
            get { return powerName + " (+" + powerIncrease + " km/h)"; }
        }

        public string Start()
        {
            currentSpeed = initialSpeed;
            return name + " started at " + initialSpeed + " km/h.";
        }

        // Every vehicle overrides these two
        public abstract string Drive();
        public abstract string UsePower();

        public string Brake()
        {
            double before = currentSpeed;
            currentSpeed = Math.Max(0, currentSpeed - 15);
            return "Braked by " + (before - currentSpeed) + " km/h. Current speed: " + currentSpeed + " km/h.";
        }

        protected double AddSpeed(double amount)
        {
            double before = currentSpeed;
            currentSpeed = Math.Min(maxSpeed, currentSpeed + amount);
            return currentSpeed - before;
        }
    }
}