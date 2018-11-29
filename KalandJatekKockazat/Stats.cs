using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KalandJatekKockazat
{
    public partial class Stats : Form
    {
        public Fomenu FomenuForm = new Fomenu();
        
        public Szabalyok SzabalyokForm = new Szabalyok();


        public Stats()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader("StatmenuErtesito.txt");

            StatmenuErtesito.Text = streamReader.ReadToEnd();

            Next.Enabled = false;
            HealthPotBut.Enabled = false;
            DexPotBut.Enabled = false;
            LuckPotBut.Enabled = false;
            //feltétel kattinthatóságra
            

        }

        private void BackToMain_Click(object sender, EventArgs e)
        {
            Close();
            FomenuForm.Show();
        }

        private void PreviousStat_Click(object sender, EventArgs e)
        {
            Close();
            SzabalyokForm.Show();
        }

        public void ThrowBut_Click(object sender, EventArgs e)
        {
            
            StatNums.jatekos.Health= StatNums.rnd.Next(2, 13)+12;
            HealthBox.Text = StatNums.jatekos.Health.ToString();
            StatNums.jatekos.Dexterity = StatNums.rnd.Next(1, 7) + 6;
            DexBox.Text = StatNums.jatekos.Dexterity.ToString();
            StatNums.jatekos.Luck = StatNums.rnd.Next(1, 7) + 6;
            LuckBox.Text = StatNums.jatekos.Luck.ToString();

            StatNums.KezdoErtek.KezdoHP = StatNums.jatekos.Health;
            StatNums.KezdoErtek.KezdoDex = StatNums.jatekos.Dexterity;
            StatNums.KezdoErtek.KezdoLuck = StatNums.jatekos.Luck;

            HealthPotBut.Enabled = true;
            DexPotBut.Enabled = true;
            LuckPotBut.Enabled = true;
            ThrowBut.Enabled = false;

            //Item kard = new Item();
            //kard.Name = "Iszonyatosan nagy kard";
            //kard.BonusDexterity = 2;
            //StatNums.Items.Add("kard", kard);
            //StatNums.jatekos.ChoseItem = StatNums.Items["kard"];

            //Dictionary<string, Item> dic = new Dictionary<string, Item>();
            //dic.Add("kard", kard);
            //StatNums.jatekos.ChoseItem = dic["kard"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory InvForm = new Inventory();
            InvForm.Show();
        }

        private void HealthPotBut_Click(object sender, EventArgs e)
        {
            StatNums.HealthPot = 1;
            StatNums.PotType = "Health ";

            HealthPotBut.Enabled = false;
            DexPotBut.Enabled = false;
            LuckPotBut.Enabled = false;
            Next.Enabled = true;
        }

        private void DexPotBut_Click(object sender, EventArgs e)
        {
            StatNums.DexPot = 1;
            StatNums.PotType = "Dexterity ";

            HealthPotBut.Enabled = false;
            DexPotBut.Enabled = false;
            LuckPotBut.Enabled = false;
            Next.Enabled = true;
        }

        private void LuckPotBut_Click(object sender, EventArgs e)
        {
            StatNums.LuckPot = 1;
            StatNums.PotType = "Luck ";
            
            HealthPotBut.Enabled= false;
            DexPotBut.Enabled= false;
            LuckPotBut.Enabled=false;
            Next.Enabled = true;
            
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Jatek jatek = new Jatek();
            jatek.Show();
            Close();
        }

        private void HealthBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
