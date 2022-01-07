using System;
using System.Collections.Generic;
using TheCycleGuy.Enums;
using TheCycleGuy.Models;

namespace TheCycleGuy
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating Bike 1
            DateTime dateTime = new DateTime(2021, 10, 5);
            Dictionary<Components, Condition> parts = new Dictionary<Components, Condition>();
            parts.Add(Components.tyres, Condition.fine);
            parts.Add(Components.gears, Condition.fine);
            parts.Add(Components.frame, Condition.pristine);
            parts.Add(Components.breaks, Condition.broken);
            var bike1 = new Bike(dateTime, BikeTypes.road, parts);
            
            Console.WriteLine(bike1.TestRide(parts));

        }
    }
}