using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla :ICar, IElectricCar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Batteries { get; private set; }

        public Tesla(string model, string color, int batteries)
        {
            this.Model = model;
            this.Color = color;
            this.Batteries = batteries;
        }

        public string Start()
        {
            return "Engine Start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            string carInfo = $"{this.Color} Seat {this.Model} with {this.Batteries} Batteries";
            string startLine = Start();
            string stopLine = Stop();

            string result = string.Join(Environment.NewLine, carInfo, startLine, stopLine);
            return result;
        }
    }
}
