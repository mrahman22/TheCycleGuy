using System;
using System.Collections.Generic;
using TheCycleGuy.Enums;

namespace TheCycleGuy.Models
{
    public class Bike
    {
        public DateTime DateLastMaintained = new DateTime(2021, 12, 10);
        public BikeTypes Type = BikeTypes.road;
        public Dictionary<Components, Condition> Parts = new Dictionary<Components, Condition>();
        
    }
}