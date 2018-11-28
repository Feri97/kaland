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
    public partial class Szabalyok : Form
    {
        
        public Fomenu FomenuForm = new Fomenu();
        public Szabalyok()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader("Szabalyok.txt");
            SzabalyText.Text = streamReader.ReadToEnd();
            
            
            
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
            
            FomenuForm.Show();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Close();

            Bevezeto BevezetoForm = new Bevezeto();
            BevezetoForm.Show();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            
            Stats StatsForm = new Stats();
            StatsForm.Show();
            Close();
        }
    }
}
