using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombAlg_lab3
{
    //класс наличия конкретного предмета в выборке
    class Availability
    {
        private Random rand;
        public int[] available;
        //public int Size { get; private set; }
        public Availability(int len)
        {
            rand = new Random();
            available = new int[len];
            for (int i = 0; i < len; i++)
                available[i] = rand.Next(0, 1);
        }
    }

    //сгенерированая выборка предметов
    class Chromosome
    {
        private Random rand;
        private Dictionary<Item, int> chromosome;
        private List<Item> items;
        private Availability avail;
        private int Size { get; set; }

        public double SumPrice{ get; private set; }
        public double SumWeigth { get; private set; }

        public Chromosome(List<Item> it)
        {
            rand = new Random();
            Size = it.Count;
            items = it;
            avail = new Availability(Size);
            chromosome = new Dictionary<Item, int>(Size);
            for (int i = 0; i < Size; i++)
            {
                chromosome.Add(items[i], avail.available[i]);
            }
            SetPriceAndWeigth();
        }

        //получение цены и веса предметов в выборке (фитнес функция)
        public void SetPriceAndWeigth()
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

        //скрещивание
        public Chromosome(Chromosome f, Chromosome m)
        {
            rand = new Random();
            Size = f.Size;
            int b = rand.Next(1, Size - 1); //выбор рандомной точки, по к-ой будем делить
            chromosome = new Dictionary<Item, int>(Size);
            int[] father = f.avail.available;
            int[] mother = m.avail.available;
            for (int i = 0; i < Size; i++)
            {
                if (father[i] == mother[i])
                    chromosome.Add(f.items[i], father[i]);
                else
                    chromosome.Add(f.items[i], rand.Next(0, 1));
            }
            SetPriceAndWeigth();
        }

        //мутация
        public void Mutate(int proc)
        {
            if (rand.Next(1, 100) <= proc)
            {
                int i = rand.Next(0, Size - 1);
                avail.available[i] = 1;
            }
        }

        //проверка, удовлетворяет вес выборки весу, к-ый задал пользователь
        public bool CheckWeigth(double w)
        {
            return w == SumWeigth;
        }

        public List<Item> GetItems()
        {
            List<Item> res = new List<Item>();
            for (int i = 0; i < Size; i++)
            {
                if (avail.available[i] == 1)
                    res.Add(items[i]);
            }
            return res;
        }

        public bool IsEmpty()
        {
            for (int i = 0; i < Size; i++)
            {
                if (avail.available[i] == 1)
                    return true;
            }
            return false;
        }
    }
}
