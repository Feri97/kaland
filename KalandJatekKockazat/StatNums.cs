using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalandJatekKockazat
{
    static class StatNums
    {
        static public Jatekos jatekos = new Jatekos();
        static public Dictionary<string, Item> Items = new Dictionary<string, Item>();
        static public Random rnd = new Random();
        static public int Food = 10;
        static public int HealthPot;
        static public int DexPot;
        static public int LuckPot;
        static public string PotType;
        static public KezdoErtek KezdoErtek = new KezdoErtek();
    }
    public class KezdoErtek
    {
        public int KezdoHP;
        public int KezdoDex;
        public int KezdoLuck;
    }
    public class Jatekos
    {
        public int Health = 0;
        private int _Dexterity;
        public int Dexterity
        {
            get
            {
                if (ChoseItem != null)
                {
                    return _Dexterity + ChoseItem.BonusDexterity;
                }
                else
                {
                    return _Dexterity;
                }
            }
            set
            {
                _Dexterity = value;
            }
        }

        public Item ChoseItem = new Item();
        public int Luck;
    }


    public class Item
    {
        public string Name;
        public int BonusDexterity;

        
    }
}
