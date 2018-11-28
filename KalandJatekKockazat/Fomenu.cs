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
    
    public partial class Fomenu : Form
    {
        
        public Fomenu()
        {
            InitializeComponent();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            Hide();

            Bevezeto BevezetoForm = new Bevezeto();
            BevezetoForm.Show();

        }
    }
}
