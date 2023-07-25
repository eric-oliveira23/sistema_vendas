namespace _212045
{
    partial class FrmVendas
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
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblcliente = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.mskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.lblprodutos = new System.Windows.Forms.Label();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpbProdutos = new System.Windows.Forms.GroupBox();
            this.gpbClientes = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.gpbProdutos.SuspendLayout();
            this.gpbClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // picCliente
            // 
            this.picCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCliente.Location = new System.Drawing.Point(756, 21);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(161, 151);
            this.picCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCliente.TabIndex = 97;
            this.picCliente.TabStop = false;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(283, 167);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(243, 20);
            this.txtEstoque.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(279, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 95;
            this.label10.Text = "Estoque";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(83, 62);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(412, 20);
            this.txtCidade.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 23);
            this.label11.TabIndex = 93;
            this.label11.Text = "Cidade";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 92;
            this.label12.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 91;
            this.label9.Text = "Marca";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Produto,
            this.Qtde,
            this.Valor});
            this.dgvProdutos.Location = new System.Drawing.Point(25, 271);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(892, 150);
            this.dgvProdutos.TabIndex = 88;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // Qtde
            // 
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.Name = "Qtde";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 87;
            this.label4.Text = "Total";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(813, 454);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(104, 39);
            this.btnFechar.TabIndex = 84;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(688, 454);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 39);
            this.btnCancelar.TabIndex = 83;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(562, 454);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(98, 39);
            this.btnGravar.TabIndex = 82;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblcliente
            // 
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(6, 21);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(72, 26);
            this.lblcliente.TabIndex = 79;
            this.lblcliente.Text = "Cliente";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(84, 22);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(411, 21);
            this.cboClientes.TabIndex = 100;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.Location = new System.Drawing.Point(127, 94);
            this.mskDataNasc.Mask = "00/00/0000";
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(368, 20);
            this.mskDataNasc.TabIndex = 101;
            this.mskDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 102;
            this.label1.Text = "Nascimento";
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(573, 94);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(138, 20);
            this.mskCpf.TabIndex = 103;
            this.mskCpf.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 104;
            this.label2.Text = "CPF";
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(573, 22);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(138, 20);
            this.txtRenda.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 105;
            this.label3.Text = "Renda";
            // 
            // txtUf
            // 
            this.txtUf.Enabled = false;
            this.txtUf.Location = new System.Drawing.Point(505, 62);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(54, 20);
            this.txtUf.TabIndex = 108;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(573, 132);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(146, 39);
            this.btnConfirmar.TabIndex = 109;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Location = new System.Drawing.Point(16, 132);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(110, 17);
            this.chkVenda.TabIndex = 110;
            this.chkVenda.Text = "Bloqueia a Venda";
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // lblprodutos
            // 
            this.lblprodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodutos.Location = new System.Drawing.Point(21, 43);
            this.lblprodutos.Name = "lblprodutos";
            this.lblprodutos.Size = new System.Drawing.Size(100, 23);
            this.lblprodutos.TabIndex = 89;
            this.lblprodutos.Text = "Produtos";
            // 
            // cboProdutos
            // 
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Location = new System.Drawing.Point(25, 69);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(462, 21);
            this.cboProdutos.TabIndex = 111;
            this.cboProdutos.SelectedIndexChanged += new System.EventHandler(this.cboProdutos_SelectedIndexChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(25, 118);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(462, 20);
            this.txtMarca.TabIndex = 112;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(26, 167);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(243, 20);
            this.txtCategoria.TabIndex = 113;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(26, 225);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(243, 20);
            this.txtQuantidade.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 115;
            this.label5.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 117;
            this.label6.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(283, 225);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(243, 20);
            this.txtPreco.TabIndex = 116;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(583, 157);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(70, 88);
            this.btnInserir.TabIndex = 118;
            this.btnInserir.Text = "Inserir Produto";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // picProduto
            // 
            this.picProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picProduto.Location = new System.Drawing.Point(756, 39);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(161, 151);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduto.TabIndex = 119;
            this.picProduto.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(659, 157);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(70, 88);
            this.btnRemover.TabIndex = 120;
            this.btnRemover.Text = "Remover Produto";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // gpbProdutos
            // 
            this.gpbProdutos.Controls.Add(this.lblTotal);
            this.gpbProdutos.Controls.Add(this.txtEstoque);
            this.gpbProdutos.Controls.Add(this.btnGravar);
            this.gpbProdutos.Controls.Add(this.btnRemover);
            this.gpbProdutos.Controls.Add(this.btnCancelar);
            this.gpbProdutos.Controls.Add(this.picProduto);
            this.gpbProdutos.Controls.Add(this.btnFechar);
            this.gpbProdutos.Controls.Add(this.btnInserir);
            this.gpbProdutos.Controls.Add(this.label4);
            this.gpbProdutos.Controls.Add(this.label6);
            this.gpbProdutos.Controls.Add(this.dgvProdutos);
            this.gpbProdutos.Controls.Add(this.txtPreco);
            this.gpbProdutos.Controls.Add(this.lblprodutos);
            this.gpbProdutos.Controls.Add(this.label5);
            this.gpbProdutos.Controls.Add(this.label9);
            this.gpbProdutos.Controls.Add(this.txtQuantidade);
            this.gpbProdutos.Controls.Add(this.label12);
            this.gpbProdutos.Controls.Add(this.txtCategoria);
            this.gpbProdutos.Controls.Add(this.label10);
            this.gpbProdutos.Controls.Add(this.txtMarca);
            this.gpbProdutos.Controls.Add(this.cboProdutos);
            this.gpbProdutos.Location = new System.Drawing.Point(34, 219);
            this.gpbProdutos.Name = "gpbProdutos";
            this.gpbProdutos.Size = new System.Drawing.Size(971, 516);
            this.gpbProdutos.TabIndex = 122;
            this.gpbProdutos.TabStop = false;
            this.gpbProdutos.Text = "Produtos";
            // 
            // gpbClientes
            // 
            this.gpbClientes.Controls.Add(this.mskDataNasc);
            this.gpbClientes.Controls.Add(this.lblcliente);
            this.gpbClientes.Controls.Add(this.chkVenda);
            this.gpbClientes.Controls.Add(this.label11);
            this.gpbClientes.Controls.Add(this.btnConfirmar);
            this.gpbClientes.Controls.Add(this.txtCidade);
            this.gpbClientes.Controls.Add(this.txtUf);
            this.gpbClientes.Controls.Add(this.picCliente);
            this.gpbClientes.Controls.Add(this.txtRenda);
            this.gpbClientes.Controls.Add(this.cboClientes);
            this.gpbClientes.Controls.Add(this.label3);
            this.gpbClientes.Controls.Add(this.label1);
            this.gpbClientes.Controls.Add(this.label2);
            this.gpbClientes.Controls.Add(this.mskCpf);
            this.gpbClientes.Location = new System.Drawing.Point(34, 35);
            this.gpbClientes.Name = "gpbClientes";
            this.gpbClientes.Size = new System.Drawing.Size(971, 178);
            this.gpbClientes.TabIndex = 123;
            this.gpbClientes.TabStop = false;
            this.gpbClientes.Text = "Clientes";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(97, 454);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 23);
            this.lblTotal.TabIndex = 121;
            this.lblTotal.Text = "0,00";
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 767);
            this.Controls.Add(this.gpbClientes);
            this.Controls.Add(this.gpbProdutos);
            this.Name = "FrmVendas";
            this.Text = "FrmVendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.gpbProdutos.ResumeLayout(false);
            this.gpbProdutos.PerformLayout();
            this.gpbClientes.ResumeLayout(false);
            this.gpbClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.MaskedTextBox mskDataNasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.CheckBox chkVenda;
        private System.Windows.Forms.Label lblprodutos;
        private System.Windows.Forms.ComboBox cboProdutos;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.Button btnRemover;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpbProdutos;
        private System.Windows.Forms.GroupBox gpbClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label lblTotal;
    }
}