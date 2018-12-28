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
        public Availability(int len, Random r)
        {
            rand = r;
            available = new int[len];
            for (int i = 0; i < len; i++)
            {
                if (rand.Next(1, 100) > 50)
                    available[i] = 1;
                else
                    available[i] = 0;
            }
        }
    }

    //сгенерированая выборка предметов
    class Chromosome
    {
        private Random rand;
        private List<Item> items;
        private Availability avail;
        private int Size { get; set; }

        public double SumPrice{ get; private set; }
        public double SumWeigth { get; private set; }

        public Chromosome(List<Item> it, Random r)
        {
            rand = r;
            Size = it.Count;
            items = it;
            avail = new Availability(Size, rand);
            SetPriceAndWeigth();
        }

        //получение цены и веса предметов в выборке (фитнес функция)
        public void SetPriceAndWeigth()
        {
            for (int i = 0; i < Size; i++)
            { 
                if (avail.available[i] == 1)
                {
                    SumPrice += items[i].price;
                    SumWeigth += items[i].weigth;
                }
            }
        }

        //скрещивание
        public Chromosome(Chromosome f, Chromosome m)
        {
            rand = new Random();
            items = f.items;
            avail = new Availability(f.Size, rand);
            Size = f.Size;
            int b = rand.Next(1, Size - 1); //выбор рандомной точки, по к-ой будем делить
            int[] father = f.avail.available;
            int[] mother = m.avail.available;
            for (int i = 0; i < Size - 1; i++)
            {
                if (father[i] == mother[i])
                {
                    avail.available[i] = father[i];
                }
                else
                {
                    int k = rand.Next(0, 1);
                    avail.available[i] = k;
                }
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
            for (int i = 0; i < Size - 1; i++)
            {
                if (avail.available[i] == 1)
                    return false;
            }
            return true;
        }
    }
}
