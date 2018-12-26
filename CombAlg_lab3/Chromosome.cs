using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombAlg_lab3
{
    //сгенерированая выборка предметов
    class Chromosome
    {
        private Random rand = new Random();
        private Dictionary<Item, int> chromosome;
        private List<Item> items;

        public double SumPrice{ get; private set; }
        public double SumWeigth { get; private set; }

        public Chromosome(int len, List<Item> it)
        {
            items = it;
            chromosome = new Dictionary<Item, int>(len);
            for (int i = 0; i < chromosome.Count; i++)
            {
                chromosome.Add(items[i], rand.Next(0, 1));
            }
            GetPriceAndWeigth();
        }

        public void GetPriceAndWeigth()
        {
            foreach (KeyValuePair<Item, int> kv in chromosome)
            {
                if (kv.Value == 1)
                {
                    SumPrice += kv.Key.price;
                    SumWeigth += kv.Key.weigth;
                }
            }
        }
    }
}
