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
    public partial class ManterBedidas : Form
    {
        public Bebida bebidas { get; set; }
        public ManterBedidas()
        {
            InitializeComponent();
        }

        private void ManterBedidas_Load(object sender, EventArgs e)
        {
            if(bebidas != null)
            {
                this.textName.Text = bebidas.Nome.ToString();
                this.textCodigo.Text = bebidas.Id.ToString();
                this.textTamanho.Text = bebidas.Tamanho.ToString();
                this.textValor.Text = bebidas.Valor.ToString();

            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Bebida bebs = new Bebida();
            if (Int64.TryParse(textCodigo.Text, out long value))
            {
                bebs.Id = value;
            }
            else
            {
                bebs.Id = -1;
            }
            bebs.Nome = textName.Text;
            if (float.TryParse(textTamanho.Text, out float tamanho))
            {
                bebs.Tamanho = tamanho;
            }
            else
            {
                bebs.Tamanho = 0;
            }
            if(Decimal.TryParse(textValor.Text, out decimal valor))
            {
                bebs.Valor = valor;
            }
            else
            {
                bebs.Valor = 0;
            }
            
            Validacao validacao;
            if (bebidas == null)
            {
                validacao = Program.Gerenciador.CadastraBebida(bebs);
            }
            else
            {
                validacao = Program.Gerenciador.AlteraBebida(bebs);
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

        private void textTamanho_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
