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
    public partial class Jatek : Form
    {
        public Jatek()
        {
            InitializeComponent();
            //életkirajzolás
            HealthGameBox.Text = StatNums.jatekos.Health.ToString();

            //Textbox feltöltés


        }
        //választások működtetése
        private void button1_Click(object sender, EventArgs e)
        {
            //Inventory
            Inventory InvForm = new Inventory();
            InvForm.Show();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            //BackToMain
            Fomenu FomenuForm = new Fomenu();
            FomenuForm.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Szabálykönyv
            GameRulesToBut gameRulesToButForm = new GameRulesToBut();
            gameRulesToButForm.Show();
        }
    }
}
