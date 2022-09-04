using System;
using System.Collections.Generic;
using System.Linq;

namespace SkiRental
{
    public class SkyRental
    {
        private List<Ski> skis;
        public string Name { get; set; }
        public int Capacity { get; set; }

        public SkyRental()
        {
            skis = new List<Ski>();
        }
        public SkyRental(List<Ski> skis, string name, int capacity)
        {
            this.skis = skis;
            Name = name;
            Capacity = capacity;
        }

        public void Add(Ski ski)
        {
            skis.Add(ski);
        }

        public bool Remove(string manufacturer, string model)
        {
            bool removed = false;

            for (int i = 0; i < skis.Count; i++)
            {
                if (skis[i].Manufacturer == manufacturer && skis[i].Model == model)
                {
                    removed = true;
                    skis.RemoveAt(i);

                    break;
                }
            }

            return removed;
        }

        public Ski GetNewestSki()
        {
            if (skis.Count == 0)
            {
                return null;
            }
            else
            {
                return skis.OrderByDescending(x => x.Year).First();
            }
        }

        public Ski GetSki(string manufacturer, string model)
        {
            if (skis.Count == 0)
            {
                return null;
            }
            else 
            {
                foreach (var item in skis)
                {
                    if (item.Manufacturer == manufacturer && item.Model == model)
                    {
                        return item; // Potential Error
                    }
                }
            }

            return null;
        }

        public int Count()
        {
            return skis.Count;
        }

        public void GetStatistics()
        {
            Console.WriteLine($"The skis stored in {Name}:");

            foreach (var skiPair in skis)
            {
                skiPair.ToString();
            }
        }

    }
}
