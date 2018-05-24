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
            adicionaPedido.Show();

        }
        private void abrirTela(Pedido pedido)
        {
            AdicionaPedido adiciona = new AdicionaPedido();
            adiciona.MdiParent = this.MdiParent;
            adiciona.pedidos = pedido;
            adiciona.FormClosed += Tela_FormClosed;
            adiciona.Show();
        }
        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregaPedidos();
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                Pedido pedido = (Pedido)dgPedido.SelectedRows[0].DataBoundItem;
                abrirTela(pedido);
            }
        }
        private bool ValidaDados()
        {
            if (dgPedido.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
    }
}
