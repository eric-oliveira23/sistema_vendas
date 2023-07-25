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
    public partial class FrmCategorias : Form
    {
        Categoria c;
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void limpaControles()
        {
            txtCategoria.Clear();
            txtId.Clear();
            txtConsultar.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            c = new Categoria()
            {
                categoria = pesquisa
            };
            dgvCategorias.DataSource = c.Consultar();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }
      
        private void dgvCategoriasCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.RowCount > 0)
            {
                txtId.Text = dgvCategorias.CurrentRow.Cells["id"].Value.ToString();
                txtCategoria.Text = dgvCategorias.CurrentRow.Cells["categoria"].Value.ToString();
            }
        }

               
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == String.Empty) return;

            c = new Categoria()
            {
                categoria = txtCategoria.Text.ToUpper(),
            };
            c.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (MessageBox.Show("Deseja excluir a marca?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                c = new Categoria()
                {
                    Id = int.Parse(txtId.Text)
                };
            c.Excluir();
            limpaControles();
            carregarGrid("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == String.Empty) return;

            c = new Categoria()
            {
                Id = int.Parse(txtId.Text),
                categoria = txtCategoria.Text.ToUpper(),
            };

            c.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtConsultar.Text);
        }
    }
}
