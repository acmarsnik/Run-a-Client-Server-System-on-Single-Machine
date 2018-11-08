﻿using Newtonsoft.Json;
using System;

namespace SeDes
{
    class Program
    {
        // Serialize a Rocket array to JSON string
        public static string DoSerialization()
        {
            Rocket[] rockets = {
        new Rocket{ ID = 0, Builder = "NASA", Target = "Moon", Speed=7.8},
        new Rocket{ ID = 1, Builder = "NASA", Target = "Mars", Speed=10.9},
        new Rocket{ ID = 2, Builder = "NASA", Target = "Kepler-452b", Speed=42.1},
        new Rocket{ ID = 3, Builder = "NASA", Target = "N/A", Speed=0}
    };
            var json = JsonConvert.SerializeObject(rockets);
            return json;
        }

        // Deserialize a JSON string back to a Rocket array
        public static void DoDeserialization(string json)
        {
            var ufos = JsonConvert.DeserializeObject<UFO[]>(json);
            foreach (var ufo in ufos)
            {
                System.Console.WriteLine($"Target:{ufo.Target} Speed:{ufo.Speed}");
            }
        }
        static void Main(string[] args)
        {
            var json = DoSerialization();
            System.Console.WriteLine(json);
            System.Console.WriteLine("================");
            DoDeserialization(json);
        }
    }
}
