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
    public partial class FrmMarcas : Form
    {
        Marca m;
        public FrmMarcas()
        {
            InitializeComponent();
        }
        void limpaControles()
        {
            txtMarca.Clear();
            txtId.Clear();
            txtConsultar.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            m = new Marca()
            {
                marca = pesquisa
            };
            dgvMarcas.DataSource = m.Consultar();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == String.Empty) return;

            m = new Marca()
            {
                marca = txtMarca.Text.ToUpper(),
            };
            m.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void dgvMarcasCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarcas.RowCount > 0)
            {
                txtId.Text = dgvMarcas.CurrentRow.Cells["id"].Value.ToString();
                txtMarca.Text = dgvMarcas.CurrentRow.Cells["marca"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == String.Empty) return;

            m = new Marca()
            {
                Id = int.Parse(txtId.Text),
                marca = txtMarca.Text.ToUpper(),
            };

            m.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            if (MessageBox.Show("Deseja excluir a marca?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                m = new Marca()
                {
                    Id = int.Parse(txtId.Text)
                };
            m.Excluir();
            limpaControles();
            carregarGrid("");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtConsultar.Text);
            carregarGrid("");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtConsultar.Text);
        }
    }
}

