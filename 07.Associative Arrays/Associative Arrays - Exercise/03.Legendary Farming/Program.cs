using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimunQuantity = 250;

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"motes", 0},
                {"fragments", 0}

            };
            Dictionary<string, string> craftingTable = new Dictionary<string, string>()
            {
                {"shards", "Shadowmourne"},
                {"fragments", "Valanyr"},
                {"motes", "Dragonwrath"}
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string obtainItem = string.Empty;

            while (String.IsNullOrEmpty(obtainItem))
            {
                string materialsLine = Console.ReadLine().ToLower();
                string[] materials = materialsLine.Split().ToArray();

                for (int i = 0; i < materials.Length; i+= 2)
                {
                    int quantity = int.Parse(materials[i]);
                    string material = materials[i+1];

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= minimunQuantity)
                        {
                            obtainItem = craftingTable[material];
                            keyMaterials[material] -= quantity;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk[material] = 0;
                        }
                        junk[material] += quantity;
                    }
                }
            }
            Console.WriteLine($"{obtainItem} obtained!");

            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
