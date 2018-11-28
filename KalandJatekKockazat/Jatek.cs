using System;
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
    public partial class Jatek : Form
    {
        public Jatek()
        {
            InitializeComponent();
            HealthGameBox.Text = StatNums.jatekos.Health.ToString();
        }

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
            GameRulesToBut gameRulesToButForm = new GameRulesToBut();
            gameRulesToButForm.Show();
        }
    }
}
