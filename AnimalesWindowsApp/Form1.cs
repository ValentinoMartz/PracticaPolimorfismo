using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animales.Animales;

namespace AnimalesWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearLoro_Click_1(object sender, EventArgs e)
        {
            Loro loro = new Loro(3, 2, 0.32, true);
            MessageBox.Show(loro.ImprimirPropiedades() + loro.ImprimirComida());
        }

        private void btnCrearConejo_Click_1(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo(2, 3, 0.53, "Negro");
            MessageBox.Show(conejo.ImprimirPropiedades() + conejo.ImprimirComida());
        }

        private void btnCrearLeon_Click_1(object sender, EventArgs e)
        {
            Leon leon = new Leon(4, 100, 100, 8);
            MessageBox.Show(leon.ImprimirPropiedades() + leon.ImprimirComida());
        }
    }
}
