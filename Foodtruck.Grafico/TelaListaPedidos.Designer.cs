namespace Foodtruck.Grafico
{
    partial class TelaListaPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dgPedido = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(21, 11);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(80, 34);
            this.btAdicionar.TabIndex = 2;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(121, 11);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(72, 34);
            this.btAlterar.TabIndex = 4;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dgPedido
            // 
            this.dgPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NomeCliente,
            this.ValorTotales,
            this.DataCompra});
            this.dgPedido.Location = new System.Drawing.Point(21, 49);
            this.dgPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgPedido.Name = "dgPedido";
            this.dgPedido.RowTemplate.Height = 33;
            this.dgPedido.Size = new System.Drawing.Size(543, 247);
            this.dgPedido.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "NomeCliente";
            this.NomeCliente.HeaderText = "Nome Cliente";
            this.NomeCliente.Name = "NomeCliente";
            // 
            // ValorTotales
            // 
            this.ValorTotales.DataPropertyName = "ValorTotales";
            this.ValorTotales.HeaderText = "Valor Total";
            this.ValorTotales.Name = "ValorTotales";
            // 
            // DataCompra
            // 
            this.DataCompra.DataPropertyName = "DataCompra";
            this.DataCompra.HeaderText = "Data Compra";
            this.DataCompra.Name = "DataCompra";
            // 
            // TelaListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 316);
            this.Controls.Add(this.dgPedido);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btAdicionar);
            this.Name = "TelaListaPedidos";
            this.Text = "TelaListaPedidos";
            this.Load += new System.EventHandler(this.TelaListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView dgPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompra;
    }
}