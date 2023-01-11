using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ajedrez.Models;
namespace AjedrezWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo();
            Torre torre = new Torre();
            Peon peon = new Peon();

            MessageBox.Show("Caballo: " + caballo.Mover() + "\nPeon: " + peon.Mover() + "\nTorre: " + torre.Mover());
        }
    }
}
