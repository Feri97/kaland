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
    public partial class Bevezeto : Form
    {
        

        public Bevezeto()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader("Bevezeto.txt");

            BevezetoBox.Text = streamReader.ReadToEnd();
             
        }

        private void NextBev_Click(object sender, EventArgs e)
        {
            Hide();
            Szabalyok SzabalyokForm = new Szabalyok();
            SzabalyokForm.Show();
        }

        private void MainMenuBev_Click(object sender, EventArgs e)
        {
            Fomenu FomenuForm = new Fomenu();
            Close();

            FomenuForm.Show();
        }

        private void Bevezeto_Load(object sender, EventArgs e)
        {
         
        }
    }
}
