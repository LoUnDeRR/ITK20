using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_4._Anonymous_Cache
{
    class Program
    {
        static void Main()
        {
            // <dataSet, List<dataKey, dataSize>>
            Dictionary<string, List<KeyValuePair<string, int>>> dataSets = new Dictionary<string, List<KeyValuePair<string, int>>>();
            // <dataSet, List<dataKey, dataSize>>
            Dictionary<string, List<KeyValuePair<string, int>>> cache = new Dictionary<string, List<KeyValuePair<string, int>>>();

            string[] input = Console.ReadLine().Split(); // {dataKey}[0] / / / {dataKey}[0] ->[1] {dataSize}[2] |[3] {dataSet}[4]
            while (input[0] != "thetinggoesskrra")
            {
                if (input.Length == 1) // {dataKey}[0]
                {
                    dataSets.Add(input[0], new List<KeyValuePair<string, int>>()); // adds an empty dataSet to dataSets
                    if (cache.ContainsKey(input[0])) // Migrates cache to dataSets' dataSet
                    {
                        dataSets[input[0]] = cache[input[0]]; // Potential error - doesn't copy/merge cached dataSet; it addresses it
                    }
                }
                else // {dataKey}[0] ->[1] {dataSize}[2] |[3] {dataSet}[4]
                {
                    if (dataSets.ContainsKey(input[4])) // Checks if dataSet exists -> adds to dataSets
                    {
                        dataSets[input[4]].Add(new KeyValuePair<string, int>(input[0], int.Parse(input[2])));
                    }
                    else // adds to cache
                    {
                        if (cache.ContainsKey(input[4]))
                        {
                            cache[input[4]].Add(new KeyValuePair<string, int>(input[0], int.Parse(input[2]))); //  System.Collections.Generic.KeyNotFoundException: 'The given key 'Buildings' was not present in the dictionary.'
                        }
                        else
                        {
                            cache[input[4]] = new List<KeyValuePair<string, int>>();
                            cache[input[4]].Add(new KeyValuePair<string, int>(input[0], int.Parse(input[2])));
                        }
                    }
                }
                input = Console.ReadLine().Split();
            }


            // OUTPUT
            // <DataSetName, sumDataSizes>
            Dictionary<string, long> dataSetsSums = new Dictionary<string, long>(); // needs optimization

            foreach (var dataSet in dataSets)
            {
                foreach (var item in dataSet.Value)
                {
                    if (dataSetsSums.ContainsKey(dataSet.Key))
                    {
                        dataSetsSums[dataSet.Key] += item.Value;
                    }
                    else
                    {
                        dataSetsSums[dataSet.Key] = item.Value;
                    }

                }
            }


            var max = from x in dataSetsSums where x.Value == dataSetsSums.Max(v => v.Value) select x.Key; // ??
            Console.WriteLine($"Data Set: {max.First()}, Total Size: {dataSetsSums.Values.Max()}");


            foreach (var item in dataSets[max.First()])
                Console.WriteLine($"$.{item.Key}");
            }
        }
    }
