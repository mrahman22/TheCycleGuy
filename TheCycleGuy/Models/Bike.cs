using System;
using System.Collections.Generic;
using TheCycleGuy.Enums;

namespace TheCycleGuy.Models
{
    public class Bike
    {
        public DateTime DateLastMaintained = new DateTime();
        public BikeTypes Type = BikeTypes.road;
        public Dictionary<Components, Condition> Parts = new Dictionary<Components, Condition>();



        public string TestRide(Dictionary<Components, Condition> parts)
        {
            int count = 0;
            
            foreach (KeyValuePair<Components, Condition> value in parts)
            {

                if (value.Value == Condition.broken)
                {
                    return "This bike is broken, I can't ride it like this!";
                }
                
                if (value.Value == Condition.fine || value.Value == Condition.pristine)
                {
                    count++;
                    if (count == 4)
                    {
                        return "The bike rides beautifully!";
                    }
                }

                if (value.Value == Condition.fragile)
                {
                    count++;
                    if (count == 4)
                    {
                        return  "It's a comfy ride!";
                    }
                }

            }

            return "";
        }

        public Bike(DateTime dateTime, BikeTypes type, Dictionary<Components, Condition>parts)
        {
            DateLastMaintained = dateTime;
            Type = type;
            Parts = parts;
        }
        
        
    }
    
    
}