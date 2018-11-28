﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalandJatekKockazat
{
    public partial class Inventory : Form
    {

        public Inventory()
        {
            InitializeComponent();

            HealthInv.Text = StatNums.jatekos.Health.ToString();
            DexterityInv.Text = StatNums.jatekos.Dexterity.ToString();
            LuckInv.Text = StatNums.jatekos.Luck.ToString();
            FoodDb.Text = StatNums.Food.ToString();

            if (StatNums.HealthPot == 1)
            {
                _PotionInv.Text = StatNums.PotType + _PotionInv.Text;
                PotionDb.Text = StatNums.HealthPot.ToString();
            }
            if (StatNums.DexPot == 1)
            {
                _PotionInv.Text = StatNums.PotType + _PotionInv.Text;
                PotionDb.Text = StatNums.DexPot.ToString();
            }
            if (StatNums.LuckPot == 1)
            {
                _PotionInv.Text = StatNums.PotType + _PotionInv.Text;
                PotionDb.Text = StatNums.LuckPot.ToString();
            }


        }

        private void InventoryExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UseFood_Click(object sender, EventArgs e)
        {
            if (StatNums.Food > 0)
            {

                if (StatNums.jatekos.Health + 4 <= StatNums.KezdoErtek.KezdoHP)

                    StatNums.jatekos.Health = StatNums.jatekos.Health + 4;

                if (StatNums.jatekos.Health > StatNums.KezdoErtek.KezdoHP - 4 ||
                    StatNums.jatekos.Health == StatNums.KezdoErtek.KezdoHP)

                    StatNums.jatekos.Health = StatNums.KezdoErtek.KezdoHP;

                StatNums.Food= StatNums.Food-1;
                FoodDb.Text = StatNums.Food.ToString();

            }
            else UseFood.Enabled = false;
        }

        private void UsePotion_Click(object sender, EventArgs e)
        {
            if (StatNums.HealthPot < 0) StatNums.jatekos.Health = StatNums.KezdoErtek.KezdoHP;
            if (StatNums.DexPot < 0) StatNums.jatekos.Dexterity = StatNums.KezdoErtek.KezdoDex;
            if (StatNums.LuckPot < 0) StatNums.jatekos.Luck = StatNums.KezdoErtek.KezdoLuck;

            
        }
    }
}