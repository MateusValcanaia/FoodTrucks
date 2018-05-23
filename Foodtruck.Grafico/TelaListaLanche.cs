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
    public partial class TelaListaLanche : Form
    {
        public TelaListaLanche()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            abrirTela(null);
        }
        private void abrirTela(Lanche lanche)
        {
            ManterLanche tela = new ManterLanche();
            tela.MdiParent = this.MdiParent;
            tela.lanches = lanche;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }
        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregaLanches();
        }
        private void CarregaLanches()
        {
            //Desenvolver;
        }
        private bool ValidaDados()
        {
            if (dgLanche.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
   
        private void btAlterar_Click_1(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                Lanche lanche = (Lanche)dgLanche.SelectedRows[0].DataBoundItem;
                abrirTela(lanche);
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    //Lanche lanche = (Lanche)dgLanche.SelectedRows[0].DataBoundItem;
                    //var validacao = Program.Gerenciador.RemoverCliente(lanche);
                    //if (validacao.Valido)
                    //{
                    //    MessageBox.Show("Cliente removido com sucesso");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Ocorreu um problema ao remover o cliente");
                    //}
                    CarregaLanches();
                }
            }
        }
    }
}
