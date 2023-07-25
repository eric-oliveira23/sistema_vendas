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
using MySql.Data.MySqlClient;

namespace _212045.Views
{
    public partial class FrmCidades : Form
    {
        Cidade c;
        public FrmCidades()
        {
            InitializeComponent();
        }

        private void FrmCidades_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        void limpaControles()
        {
            txtCidade.Clear();
            txtId.Clear();
            txtConsultar.Clear();
            txtUf.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            c = new Cidade()
            {
                nome = pesquisa
            };
            dgvCidades.DataSource = c.Consultar();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtCidade.Text == String.Empty) return;

            c = new Cidade()
            {
                nome = txtCidade.Text.ToUpper(),
                uf = txtUf.Text.ToUpper()
            };
            c.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void dgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCidades.RowCount > 0)
            {
                txtId.Text = dgvCidades.CurrentRow.Cells["id"].Value.ToString();
                txtCidade.Text = dgvCidades.CurrentRow.Cells["nome"].Value.ToString();
                txtUf.Text = dgvCidades.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == String.Empty) return;

            c = new Cidade()
            {
                Id = int.Parse(txtId.Text),
                nome = txtCidade.Text.ToUpper(),
                uf = txtUf.Text.ToUpper()
            };

            c.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (MessageBox.Show("Deseja excluir a cidade?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            c = new Cidade()
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtConsultar.Text);
        }
    }
}
