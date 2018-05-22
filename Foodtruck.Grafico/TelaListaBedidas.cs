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
    public partial class TelaListaBedidas : Form
    {
        
        public TelaListaBedidas()
        {
            InitializeComponent();
        }

        private void TelaListaBedidas_Load(object sender, EventArgs e)
        {

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            abrirTela(null);
        }
        private void abrirTela(Bebida bedida)
        {
            ManterBedidas tela = new ManterBedidas();
            tela.MdiParent = this.MdiParent;
            tela.bebidas = bedida;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }
        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregaBebidas();
        }
        private void CarregaBebidas()
        {
            //Fazer Logica.
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                Bebida bebida = (Bebida)dgBebidas.SelectedRows[0].DataBoundItem;
                abrirTela(bebida);
            }
        }
        private bool ValidaDados()
        {
            if (dgBebidas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Cliente clienteSelecionado = (Cliente)dgBebidas.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverCliente(clienteSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Cliente removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o cliente");
                    }
                    CarregaBebidas();
                }
            }
        }
    }
}
