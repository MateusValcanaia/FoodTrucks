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
    public partial class TelaListaPedidos : Form
    {
        public TelaListaPedidos()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AdicionaPedido adicionaPedido = new AdicionaPedido();

        }
        private void CarregaPedidos()
        {
            dgPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedido.MultiSelect = false;
            dgPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedido.AutoGenerateColumns = false;
            List<Pedido> pedido = Program.Gerenciador.TodosOsPedidos();
            dgPedido.DataSource = pedido;
        }
        private void TelaListaPedidos_Load(object sender, EventArgs e)
        {
            CarregaPedidos();
        }
    }
}
