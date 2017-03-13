﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class heater
    {

        private double temperature;
        private double humidity;

        public double Temperature
        {
            get { return temperature; }
            set
            {
                if (value <= 120 && value >= 0)
                    { temperature = value; }
                else { temperature = 0; }
            }            
        }

        public double Humidity
        {
            get { return humidity; }
            set
            {
                if (value <= 100 && value >= 0)
                {
                    humidity = value;
                }
                else
                {
                    humidity = 0;
                }
            }
        }
    }
}
