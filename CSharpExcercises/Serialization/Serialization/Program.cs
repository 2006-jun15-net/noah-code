using Newtonsoft.Json;
using Serialization.DataModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../data.json";
            List<PlayerStats> data;

            try
            {
                string initialJson = File.ReadAllText(filePath);
                data = JsonConvert.DeserializeObject<List<PlayerStats>>(initialJson);
            }
            catch(FileNotFoundException)
            {
                data = GetInitialData();
            }

            data[0].Name += "+";

            string json = ConvertToJson(data);

            WriteStringToFile(filePath, json);
        }
       
        
        private static void WriteStringToFile(string filePath, string json)
        {
            File.WriteAllText(filePath, json);
            //WriteAllTextAsync method exists as well
            //await File.WriteAllTextAsync(filePath, json);
            //you would need "async" modifier for this method
            //
        }

        //serialize the objects into a string in JSON Format
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public static string ConvertToJson(List<PlayerStats> data)
        {
            //in .NET Core, we use a program called NuGet
            // to resolve dependencies and download them from registries (usually NuGet.org)

            return JsonConvert.SerializeObject(data, Formatting.Indented);
        }

        private static List<PlayerStats> GetInitialData()
        {
            var thePlayerStatistics = new PlayerStats
            {
                ArcLocations = null,
                FreeThrowPercentage = 100,
                PointsPerGame = 12
            };

            return new List<PlayerStats>
            {
                new PlayerStats()
                {
                    Name = "Lebron James",
                    FreeThrowPercentage = 65,
                    PointsPerGame = 25,
                    ArcLocations = new Dictionary<int, double>
                    {
                       [-150] = 30,
                       [-120] = 30,
                       [-90] = 30
                    }
                },
                new PlayerStats()
                {
                    Name = "Lebron James",
                    FreeThrowPercentage = 65,
                    PointsPerGame = 25,
                    ArcLocations = new Dictionary<int, double>
                    {
                       [-150] = 30,
                       [-120] = 30,
                       [-90] = 30
                    }
                },
               new PlayerStats()
                {
                    Name = "Lebron James",
                    FreeThrowPercentage = 65,
                    PointsPerGame = 25,
                    ArcLocations = new Dictionary<int, double>
                    {
                       [-150] = 30,
                       [-120] = 30,
                       [-90] = 30
                    }
                }
            };
        }
    }
}
