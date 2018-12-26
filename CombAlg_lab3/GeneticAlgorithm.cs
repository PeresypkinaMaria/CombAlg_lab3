using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombAlg_lab3
{
    class GeneticAlgorithm
    {
        private int numOfChromosomes;
        private int mutationPercent;
        private int mutationCount;
        private int cntParentChromes;

        private long curTimeGen = 0;

        public long GetTimeGen()
        {
            return curTimeGen;
        }

        //возможный набор предметов
        class Item_Set
        {
            public int[] it_set;

            public Item_Set(int len)
            {
                it_set = new int[len];
                Random rand = new Random();
                for (int j = 0; j < it_set.Length; j++)
                {
                    it_set[j] = rand.Next(0, 1);
                }
            }
        }

        private double maxW; //максимальный вес
        private int num_progeny; //кол-во потомков
        //List<Genotype> progeny; //потомство
        private int cnt_items;
        private List<Item> items;

        public GeneticAlgorithm(double _maxw, int _len, int num_chr, List<Item> it)
        {
            maxW = _maxw;
            cnt_items = _len;          
            num_progeny = num_chr;
            items = it;
            chromosome = new Dictionary<Item, bool>(items.Count);
            for (int i = 0; i < chromosome.Count; i++)
            {
                chromosome.Add(items[i], )
            }
        }

        private void GetDict()
        {

        }

        //генерация потомства
        public void GenerationProgeny()
        {
            for (int i = 0; i < num_progeny; i++)
            {
                genotype.Add(items, new Item_Set(cnt_items));
            }
        }

        public KeyValuePair<double, double> FitnessFunc()
        {
            KeyValuePair<double, double> pw;
            double sumP = 0;
            double sumW = 0;
            foreach (Item_Set itset in genotype.Values)
            {
                for (int i = 0; i < cnt_items; i++)
                {
                    if (itset.it_set[i] == 1)
                    {
                        foreach (List<Item> it in genotype.Keys)
                        {
                            pw.Key += it[i].price;
                            sumW += it[i].weigth;
                        }
                    }
                }
            }            
            return KeyValuePair
        }
    }
}
