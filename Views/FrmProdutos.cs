using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _212045.Models;

namespace _212045.Views
{
    public partial class FrmProdutos : Form
    {
        Produto p;
        Marca m;
        Categoria c;

        public FrmProdutos()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtConsultar.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            txtEstoque.Text = String.Empty;
            txtId.Text = String.Empty;
            picFoto.ImageLocation = "";
            txtValor.Text = String.Empty;
        }

        void carregarGrid(string pesquisa)
        {
            p = new Produto()
            {
                descricao = pesquisa
            };
            dgvProdutos.DataSource = p.Consultar();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            //cria um objeto do tipo cidade e alimenta o combobox
            //Objeto Categoria
            c = new Categoria();
            cboCategoria.DataSource = c.Consultar();
            cboCategoria.DisplayMember = "categoria";
            cboCategoria.ValueMember = "id";

            //Objeto Marca
            m = new Marca();
            cboMarca.DataSource = m.Consultar();
            cboMarca.DisplayMember = "marca";
            cboMarca.ValueMember = "id";

            limpaControles();
            carregarGrid("");

            //Deixa invisível colunas do grid
            dgvProdutos.Columns["idMarca"].Visible = false;
            dgvProdutos.Columns["idCategoria"].Visible = false;
            dgvProdutos.Columns["foto"].Visible = false;
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCategoria.SelectedItem;
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMarca.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboMarca.SelectedItem;
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:/fotos/produtos/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescricao.Text == String.Empty) return;

                p = new Produto()
                {
                    descricao = txtDescricao.Text.ToUpper(),
                    idCategoria = (int)cboCategoria.SelectedValue,
                    idMarca = (int)cboMarca.SelectedValue,
                    valor = double.Parse(txtValor.Text),
                    estoque = double.Parse(txtEstoque.Text),
                    foto = picFoto.ImageLocation,
                };
                p.Incluir();

                limpaControles();
                carregarGrid("");
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha o campo corretamente");
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.Rows.Count > 0)
            {
                txtId.Text = dgvProdutos.CurrentRow.Cells["id"].Value.ToString();
                txtDescricao.Text = dgvProdutos.CurrentRow.Cells["descricao"].Value.ToString();
                cboCategoria.Text = dgvProdutos.CurrentRow.Cells["categoria"].Value.ToString();
                cboMarca.Text = dgvProdutos.CurrentRow.Cells["marca"].Value.ToString();
                txtValor.Text = dgvProdutos.CurrentRow.Cells["valor"].Value.ToString();
                txtEstoque.Text = dgvProdutos.CurrentRow.Cells["estoque"].Value.ToString();
                picFoto.ImageLocation = dgvProdutos.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (MessageBox.Show("Deseja excluir a cidade?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                p = new Produto()
                {
                    Id = int.Parse(txtId.Text)
                };
            p.Excluir();
            limpaControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            p = new Produto()
            {
                Id = int.Parse(txtId.Text),
                descricao = txtDescricao.Text,
                idCategoria = (int)cboCategoria.SelectedValue,
                idMarca = (int)cboMarca.SelectedValue,
                valor = double.Parse(txtValor.Text),             
                estoque = double.Parse(txtValor.Text),             
                foto = picFoto.ImageLocation,
            };

            p.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtConsultar.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
