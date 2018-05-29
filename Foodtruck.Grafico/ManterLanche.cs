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

        private void btSalvar_Click(object sender, EventArgs e)
        {

            Lanche lanche = new Lanche();
            if (Int64.TryParse(textCodigo.Text, out long value))
            {
                lanche.Id = value;
            }
            else
            {
                lanche.Id = -1;
            }
            lanche.Nome = textNome.Text;
            if (Decimal.TryParse(textValor.Text, out decimal valor))
            {
                lanche.Valor = valor;
            }
            else{
                lanche.Valor = 0;
            }
           
            Validacao validacao;
            if (lanches == null)
            {
                validacao = Program.Gerenciador.CadastraLanche(lanche);
            }
            else
            {
                validacao = Program.Gerenciador.AlteraLanche(lanche);
            }
            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach (var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Bebida foi salva com sucesso");
            }
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterLanche_Load_1(object sender, EventArgs e)
        {
            if (lanches != null)
            {
                this.textNome.Text = lanches.Nome.ToString();
                this.textCodigo.Text = lanches.Id.ToString();
                this.textValor.Text = lanches.Valor.ToString();
            }
        }
    }
}
