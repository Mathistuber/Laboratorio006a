using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratorio006.LabCalculos;

namespace Laboratorio006.LabCalculos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            Lab006.TelaPrincipal maior = new Lab006.TelaPrincipal();
            maior.Show();

        }

        private void btnFrete_Click(object sender, EventArgs e)
        {
            Lab007.TelaPrincipal frete = new Lab007.TelaPrincipal();
            frete.Show();
        }
    }
}
