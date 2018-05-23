using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class ManterLanche : Form
    {
        public Lanche lanches { get; set; }
        public ManterLanche()
        {
            InitializeComponent();
        }

        private void ManterLanche_Load(object sender, EventArgs e)
        {

        }
    }
}
