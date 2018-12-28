using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombAlg_lab3
{
    class GeneticAlgorithm
    {
        private Random rand;
        private Stopwatch stopWatch;
        public long TimeGen { get; set; }

        private int numOfChromosomes; //кол-во хромосом
        private int mutationPercent; //процент мутаций
        private int mutationCount; //кол-во мутаций
        private int cntParentChromes; //кол-во отбираемых хромосом

        private List<Chromosome> firstGeneration;
        private List<Chromosome> currentGeneration;
        public List<Item> bestItems = null;
        private bool detected = false;

        public double needWeigth;
        private double currSumPrice = 0;

        private List<Item> items;


        public GeneticAlgorithm(double need_w, List<Item> it, int mut_per, int num_chr, int mut_cnt, int cnt_par_chr)
        {
            rand = new Random();
            needWeigth = need_w;
            items = it;
            mutationPercent = mut_per;
            numOfChromosomes = num_chr;
            mutationCount = mut_cnt;
            cntParentChromes = cnt_par_chr;
        }

        public void RunGenAlgorithm(int steps)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();

            SetFirstGeneration(); //получаем первое поколение
            CheckAll(firstGeneration);
            currentGeneration = firstGeneration;
            for (int step = 2; step <= steps; step++)
            {
                GetNextGeneration();
                CheckAll(currentGeneration);
            }
            if (bestItems == null)
            {
                bestItems = currentGeneration[0].GetItems();
                currSumPrice = currentGeneration[0].SumPrice;
            }
            stopWatch.Stop();
            TimeGen = stopWatch.ElapsedTicks;
        }

        //поиск наилучшего решения
        private void CheckAll(List<Chromosome> popul)
        {
            for (int i = 0; i < firstGeneration.Count; i++)
            {
                if (popul[i].CheckWeigth(needWeigth) && popul[i].SumPrice > currSumPrice)
                {
                    bestItems = popul[i].GetItems();
                    currSumPrice = popul[i].SumPrice;
                }
            }
        }

        //генерация следующего поколения
        private void GetNextGeneration()
        {
            //SortPopulation(currentGeneration);
            List<Chromosome> nextGen = currentGeneration;
            //скрещивание
            for (int i = 0; i < currentGeneration.Count - 1; i++)
            {
                Chromosome chr = Selection(currentGeneration[i], currentGeneration[i + 1]);
                if (!chr.IsEmpty())
                    nextGen.Add(chr);
            }
            Mutation(nextGen); //мутация
            SortPopulation(nextGen); //сортировка
            currentGeneration.Clear();
            for (int i = 0; i < cntParentChromes; i++)
            {
                currentGeneration.Add(nextGen[i]);
            }
            SortPopulation(currentGeneration);
        }

        //первая генерация потомства
        private void SetFirstGeneration()
        {
            firstGeneration = new List<Chromosome>();
            while (firstGeneration.Count < numOfChromosomes)
            {
                Chromosome chr = new Chromosome(items);
                if (!chr.IsEmpty())
                    firstGeneration.Add(chr);
            }
        }

        //сортировка популяции (по фитнес-функции)
        public void SortPopulation(List<Chromosome> popul)
        {
            int k; //индекс эл-та с наибольшим выживанием
            Chromosome chr;
            for (int i = 0; i < popul.Count; i++)
            {
                k = i;
                chr = popul[i];
                for (int j = i + 1; j < popul.Count; j++)
                    if (popul[j].SumPrice > chr.SumPrice && Math.Abs(popul[j].SumWeigth - needWeigth) < Math.Abs(chr.SumWeigth - needWeigth))
                    {
                        k = j;
                        chr = popul[j];
                    }
                popul[k] = popul[i];
                popul[i] = chr; //меняем местами с popul[i]
            }
        }

        //мутация
        private void Mutation(List<Chromosome> popul)
        {
            for (int i = 0; i < mutationCount; i++)
            {
                int num = rand.Next(0, popul.Count - 1);
                popul[num].Mutate(mutationPercent);
                popul[num].SetPriceAndWeigth();
            }
        }

        //генерация новой хромосомы из двух (скрещивание)
        private Chromosome Selection(Chromosome father, Chromosome mother)
        {
            Chromosome child = new Chromosome(father, mother);
            return child;
        }
    }
}
