using Foodtruck.Negocio;
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
    public partial class AdicionaPedido : Form
    {
        Pedido pedido = new Pedido();
        public Pedido pedidos { get; set; }

        public AdicionaPedido()
        {
            InitializeComponent();
        }

        private void AdicionaPedido_Load(object sender, EventArgs e)
        {
            if(pedidos != null)
            {

            }
            CarregaComboBoxes();
            CarregaDatagrids();
            CarregaTotal();
        }

        private void CarregaTotal()
        {
            if (pedidos != null)
            {
                lbTotal.Text = pedidos.ValorTotal().ToString();
                pedidos.ValorTotales = pedidos.ValorTotal().ToString();
            }
            else
            {
                lbTotal.Text = pedido.ValorTotal().ToString();
                pedido.ValorTotales = pedido.ValorTotal().ToString();
            }
        }

        private void CarregaComboBoxes()
        {
            cbClientes.DisplayMember = "Descricao";
            cbClientes.ValueMember = "Id";
            cbClientes.DataSource = Program.Gerenciador.TodosOsClientes();

            cbLanches.DisplayMember = "Nome";
            cbLanches.ValueMember = "Id";
            cbLanches.DataSource = Program.Gerenciador.TodosOsLanches();

            cbBebidas.DisplayMember = "Nome";
            cbBebidas.ValueMember = "Id";
            cbBebidas.DataSource = Program.Gerenciador.TodasAsBebidas();
        }
        
        private void CarregaDatagrids()
        {
            if (pedidos != null)
            {
                dgBebidas.AutoGenerateColumns = false;
                dgBebidas.DataSource = pedidos.Bebidas.ToList();

                dgLanches.AutoGenerateColumns = false;
                dgLanches.DataSource = pedidos.Lanches.ToList();

            }
            else
            {
                dgBebidas.AutoGenerateColumns = false;
                dgBebidas.DataSource = pedido.Bebidas.ToList();

                dgLanches.AutoGenerateColumns = false;
                dgLanches.DataSource = pedido.Lanches.ToList();

            }

            CarregaTotal();
        }

        private void btAdicionaBebida_Click(object sender, EventArgs e)
        {
            if (pedidos !=null)
            {
                Bebida bebidaSelecionadas = (Bebida)cbBebidas.SelectedItem;
                pedidos.Bebidas.Add(bebidaSelecionadas);
                CarregaDatagrids();
            }
            else { 
            Bebida bebidaSelecionada = (Bebida)cbBebidas.SelectedItem;
            pedido.Bebidas.Add(bebidaSelecionada);
            CarregaDatagrids();
            }
        }

        private void btAdicionaLanche_Click(object sender, EventArgs e)
        {
            if(pedidos != null)
            { 
            Lanche lancheSelecionado = cbLanches.SelectedItem as Lanche;
            pedidos.Lanches.Add(lancheSelecionado);
            CarregaDatagrids();
            }
            else
            {
                Lanche lancheSelecionado = cbLanches.SelectedItem as Lanche;
                pedido.Lanches.Add(lancheSelecionado);
                CarregaDatagrids();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pedido.Cliente = cbClientes.SelectedItem as Cliente;
                pedido.DataCompra = DateTime.Now;
                Validacao validacao;
                if (pedidos != null)
                {
                    validacao = Program.Gerenciador.AlteraPedido(pedidos);
                }
                else
                {
                    validacao = Program.Gerenciador.CadastraPedido(pedido);
                }
               
                if (validacao.Valido)
                {
                    MessageBox.Show("Pedido cadastrado com sucesso!");
                    this.Close();
                }
                else
                {
                    String msg = "";
                    foreach (var mensagem in validacao.Mensagens)
                    {
                        msg += mensagem + Environment.NewLine;
                    }
                    MessageBox.Show(msg, "Erro");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro grave, fale com o administrador");
            }
            
        }
    }
}
