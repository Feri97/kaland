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
    public partial class GameRulesToBut : Form
    {
        public GameRulesToBut()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader("Szabalyok.txt");
            SzabalyText.Text = streamReader.ReadToEnd();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
