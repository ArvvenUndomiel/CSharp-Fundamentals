using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari :Icar
    {
        private string model = "488-Spider";
        private string driver;

        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public string Driver
        {
            get { return driver; }
            private set { driver = value; }
        }

        public string HitBrakes()
        {
            return "Brakes!";
        }

        public string PushGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            string brakes = HitBrakes();
            string gas = PushGasPedal();
            return $"{this.model}/{brakes}/{gas}/{this.Driver}";
        }
    }
}
