using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombAlg_lab3
{
    class Backpack
    {
        private List<Item> bestItems = null;
        private double maxW; //максимальный вес
        private double bestPrice;
        private long curTime = 0; //время работы

        public long GetTime()
        {
            return curTime;
        }

        public Backpack(double _maxW)
        {
            maxW = _maxW;
        }

        //вычисляет общий вес набора предметов
        private double CalcWeigth(List<Item> items)
        {
            double sumW = 0;
            foreach(Item it in items)
            {
                sumW += it.weigth;
            }
            return sumW;
        }

        //вычисляет общую стоимость набора предметов
        private double CalcPrice(List<Item> items)
        {
            double sumP = 0;
            foreach(Item it in items)
            {
                sumP += it.price;
            }
            return sumP;
        }

        //проверка на лучшее решение
        private void CheckSet(List<Item> items)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            if (bestItems == null)
            {
                if (CalcWeigth(items) <= maxW)
                {
                    bestItems = items;
                    bestPrice = CalcPrice(items);
                }
            }
            else
            {
                if (CalcWeigth(items) <= maxW && CalcPrice(items) > bestPrice)
                {
                    bestItems = items;
                    bestPrice = CalcPrice(items);
                }
            }

            sw.Stop();
            curTime = sw.ElapsedTicks;
        }

        //создание всех наборов перестановок значений (рекурсивный метод)
        public void MakeAllSets(List<Item> items)
        {
            if (items.Count > 0)
                CheckSet(items);
            for (int i = 0; i < items.Count; i++)
            {
                List<Item> newSet = new List<Item>(items);
                newSet.RemoveAt(i);
                MakeAllSets(newSet);
            }
        }

        //возвращает наилучшее решение
        public List<Item> GetBestSet()
        {
            return bestItems;
        }
    }
}
