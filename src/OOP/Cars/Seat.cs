using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }

        public Seat(string model, string color )
        {
            this.Model = model;
            this.Color = color;
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
            string carInfo = $"{this.Color} Seat {this.Model}";
            string startLine = Start();
            string stopLine = Stop();

            string result = string.Join(Environment.NewLine, carInfo, startLine, stopLine);
            return result;
        }
    }
}
