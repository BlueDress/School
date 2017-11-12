using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Cache
{
    public class Startup
    {
        public static void Main()
        {
            var dataSets = new List<DataSet>();
            var dataKeys = new Dictionary<string, List<DataKey>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("thetinggoesskrra"))
                {
                    break;
                }

                var args = input.Split(new[] { ' ', '-', '>', '|'}, StringSplitOptions.RemoveEmptyEntries);

                var dataSetName = string.Empty;
                var dataKeyName = string.Empty;
                var dataKeySize = 0L;

                if (args.Length == 1)
                {
                    dataSetName = args[0];

                    if (!dataSets.Any(x => x.Name.Equals(dataSetName)))
                    {
                        dataSets.Add(new DataSet(dataSetName));
                    }

                    if (dataKeys.ContainsKey(dataSetName))
                    {
                        var currentDataSet = dataSets.First(x => x.Name.Equals(dataSetName));
                        currentDataSet.DataKeys.AddRange(dataKeys[dataSetName]);
                        dataKeys.Remove(dataSetName);
                    }
                }
                else
                {
                    dataSetName = args[2];
                    dataKeyName = args[0];
                    dataKeySize = long.Parse(args[1]);

                    if (dataSets.Any(x => x.Name.Equals(dataSetName)))
                    {
                        var currentDataSet = dataSets.First(x => x.Name.Equals(dataSetName));
                        currentDataSet.DataKeys.Add(new DataKey(dataKeyName, dataKeySize));
                    }
                    else
                    {
                        if (!dataKeys.ContainsKey(dataSetName))
                        {
                            dataKeys[dataSetName] = new List<DataKey>();
                        }

                        dataKeys[dataSetName].Add(new DataKey(dataKeyName, dataKeySize));
                    }
                }
            }

            foreach (var dataSet in dataSets.OrderByDescending(x => x.GetDataKeySize()))
            {
                Console.WriteLine($"Data Set: {dataSet.Name}, Total Size: {dataSet.GetDataKeySize()}");
                foreach (var dataKey in dataSet.DataKeys)
                {
                    Console.WriteLine($"$.{dataKey.Name}");
                }
                break;
            }
        }
    }
}
