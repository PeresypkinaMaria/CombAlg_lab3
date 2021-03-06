﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombAlg_lab3
{
    public partial class MainForm : Form
    {
        private List<Item> items;

        public MainForm()
        {
            InitializeComponent();
            AddItems();
            ShowItems(items);
        }

        private void AddItems()
        {
            items = new List<Item>();

            items.Add(new Item("Вода", 1, 500));
            items.Add(new Item("Книга", 2, 1000));
            items.Add(new Item("Ноутбук", 4, 5000));
            items.Add(new Item("Зарядка", 1, 300));
            items.Add(new Item("Конфеты", 2, 700));
            items.Add(new Item("Аптечка", 3, 1500));
        }

        private void ShowItems(List<Item> it)
        {
            OrigLV.Items.Clear();
            LVPermut.Items.Clear();
            foreach (Item i in it)
            {
                OrigLV.Items.Add(new ListViewItem(new string[] { i.name, i.weigth.ToString(), i.price.ToString() }));
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Backpack bp = new Backpack(Convert.ToDouble(tbMaxW.Text));
            bp.MakeAllSets(items);
            List<Item> solve = bp.GetBestSet();
            if (solve == null)
                MessageBox.Show("Нет решения простым перебором!");
            else
            {
                LVPermut.Items.Clear();
                foreach (Item i in solve)
                {
                    LVPermut.Items.Add(new ListViewItem(new string[] { i.name, i.weigth.ToString(), i.price.ToString() }));
                }
                tbTimePerm.Text = bp.CurrTime.ToString();
            }
            GeneticAlgorithm ga = new GeneticAlgorithm(Convert.ToDouble(tbMaxW.Text), items, (int)nudMutProc.Value, (int)nudCntChr.Value, (int)nudCnrMutChr.Value, (int)nudCntParChr.Value);
            ga.RunGenAlgorithm((int)nudCntSteps.Value);
            List<Item> gen_solve = ga.bestItems;
            if (gen_solve == null)
                MessageBox.Show("Нет решения генетическим алгоритмом!");
            else
            {
                LVGen.Items.Clear();
                foreach (Item i in gen_solve)
                {
                    LVGen.Items.Add(new ListViewItem(new string[] { i.name, i.weigth.ToString(), i.price.ToString() }));
                }
                tbTimeGen.Text = ga.TimeGen.ToString();
            }
        }
    }
}
