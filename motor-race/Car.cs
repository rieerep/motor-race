using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motor_race
{
	internal class Car
	{
        public int carId { get; set; }
        public string name { get; set; }
        public decimal distanceTraveled { get; set; } = 0;
        public decimal time { get; set; }
        public int speed { get; set; } = 120;

    }
}
