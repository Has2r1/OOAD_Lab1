using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab1_Test.Form1;

namespace Lab1_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public List<Stone> inputStones = new List<Stone>();
        int inputBaseDamage = 200;
        int inputBaseCapacity = 100;
        int inputDurability = 70;
        string inputRarity = "Normal";
        bool inputVeiled = false;
        public class Stone
        {
            public int Weight { get; set; }
            public double DamageMultiplier { get; set; }
            public int Quality { get; set; }
            public Stone(int weight, double damageMultiplier, int quality)
            {
                Weight = weight;
                DamageMultiplier = damageMultiplier;
                Quality = quality;
            }

        }

        public class GameItem
        {
            public List<Stone> Stones { get; set; }
            public int BaseDamage { get; set; }
            public int Capacity { get; set; }
            public string Rarity { get; set; }
            public bool Veiled { get; set; }
            public int Durabilitry {  get; set; }

            public GameItem(List<Stone> stones, int baseDamage, int capacity, bool veiled, int durabilitry, string rarity)
            {
                Stones = stones;
                BaseDamage = baseDamage;
                Capacity = capacity;
                Veiled = veiled;
                Durabilitry = durabilitry;
                Rarity = rarity;
            }


        }

        public void displayGameItem(GameItem item)
        {
            double damage = item.BaseDamage;
            int weight = 0;
            string itemData = "";

            foreach (var stone in item.Stones)
            {
                weight += stone.Weight;
                damage += item.BaseDamage * stone.DamageMultiplier * (1 + (double)stone.Quality / 100);
            }
            itemData += $"Durability: {item.Durabilitry} \nRarity: {item.Rarity} \nEnchanted: {item.Veiled} \n";

            itemData += $"Capacity: {weight}/{item.Capacity} \nTotal Damage: {damage} \n";
            if (weight > item.Capacity)
            {
                itemData += "Warning! Out of capacity";
            }
            itemDataOutput.Text += itemData;
        }

        interface IGameItemBuilder
        {
            IGameItemBuilder AddStones(List<Stone> stones);
            IGameItemBuilder SetBaseDamage(int baseDamage);
            IGameItemBuilder SetCapacity(int capacity);
            IGameItemBuilder SetDurability(int durability);
            IGameItemBuilder SetRarity(string rarity);
            IGameItemBuilder SetVeiled(bool veiled);
            IGameItemBuilder Clear();
            GameItem GetResult();
        }

        class GameItemBuilder : IGameItemBuilder
        {
            private List<Stone> stones = new List<Stone>();
            private int baseDamage;
            private int capacity;
            private int durability;
            private string rarity;
            private bool veiled;

            public IGameItemBuilder AddStones(List<Stone> stones)
            {
                this.stones = stones;
                return this;
            }

            public IGameItemBuilder SetBaseDamage(int baseDamage)
            {
                this.baseDamage = baseDamage;
                return this;
            }

            public IGameItemBuilder SetCapacity(int capacity)
            {
                this.capacity = capacity;
                return this;
            }

            public IGameItemBuilder SetDurability(int durability)
            {
                this.durability = durability;
                return this;
            }

            public IGameItemBuilder SetRarity(string rarity)
            {
                this.rarity = rarity;
                return this;
            }

            public IGameItemBuilder SetVeiled(bool veiled)
            {
                this.veiled = veiled;
                return this;
            }

            public IGameItemBuilder Clear()
            {
                stones = new List<Stone>();
                baseDamage = 0;
                capacity = 0;
                durability = 0;
                rarity = null;
                veiled = false;
                return this;
            }

            public GameItem GetResult()
            {
                return new GameItem(stones, baseDamage, capacity, veiled, durability, rarity);
            }
        }
        private void btAddGem_Click(object sender, EventArgs e)
        {
            int weight = (int)edGemWeight.Value;
            double damageMultiplier = (double)edGemMult.Value;
            //double.TryParse(edGemMult.Text, out double var);
            int quality = (int)edQuality.Value;
            inputStones.Add(new Stone(weight, damageMultiplier, quality));
            currentGemsOutput.Text += $"\n - Weight / Damage Mult / Quality: {weight} / {damageMultiplier} / {quality}";
        }


        private void clearGemsList_Click(object sender, EventArgs e)
        {
            inputStones = new List<Stone>();
            currentGemsOutput.Text = "Текущие камни: ";
        }

        private void edBaseDamage_ValueChanged(object sender, EventArgs e)
        {
            inputBaseDamage = (int)edBaseDamage.Value;
            inputBaseCapacity = (int)edBaseCapacity.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameItem gameItem = new GameItem(inputStones, inputBaseDamage, inputBaseCapacity, inputVeiled, inputDurability, inputRarity);
            itemDataOutput.Text = "Характеристики предмета: \n";
            displayGameItem(gameItem);
        }

        private void btBuildItem_Click(object sender, EventArgs e)
        {
            IGameItemBuilder builder = new GameItemBuilder();
            GameItem gameItem = builder
                .AddStones(inputStones)
                .SetBaseDamage(inputBaseDamage)
                .SetCapacity(inputBaseCapacity)
                .SetDurability(inputDurability)
                .SetRarity(inputRarity)
                .SetVeiled(inputVeiled)
                .GetResult();
            itemDataOutput.Text = "Характеристики предмета: \n";
            displayGameItem(gameItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(inputStones.Count != 0)
            {
                inputStones.RemoveAt(inputStones.Count - 1);
                currentGemsOutput.Text = "Текущие камни: ";
                foreach (var stone in inputStones)
                {
                    currentGemsOutput.Text += $"\n - Weight / Damage Mult / Quality: {stone.Weight} / {stone.DamageMultiplier} / {stone.Quality}";
                }
            }
        }

        private void edRarity_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputRarity = edRarity.Text;
        }

        private void edDurability_ValueChanged(object sender, EventArgs e)
        {
            inputDurability = (int)edDurability.Value;
        }

        private void edVeiled_CheckedChanged(object sender, EventArgs e)
        {
            inputVeiled = edVeiled.Checked;
        }
    }
}
