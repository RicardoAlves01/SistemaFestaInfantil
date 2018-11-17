using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FestaInfantil.Bll;

namespace UIWindows
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            UsuarioBll obj = new UsuarioBll();
            cmbPrivilegio.DataSource = obj.ListaDePrivilegios;
            cmbPrivilegio.DisplayMember = "descricao";
            cmbPrivilegio.ValueMember = "idPrivilegio";

           // UsuarioBll obj = new UsuarioBll();
           // cmbPrivilegio.DataSource = obj.ListaDePrivilegios;

            AtualizaGrid();
            NomeTextBox.Focus();
        }

        public void AtualizaGrid()
        {
            // Comunicação com a Camada BLL
            UsuarioBll obj = new UsuarioBll();
            usuariosDataGridView.DataSource = obj.ListagemUsuarios();

            // Atualizando os objetos TextBox

            UsuarioTextBox.Text = usuariosDataGridView[0, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            NomeTextBox.Text = usuariosDataGridView[1, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            CPFTextBox.Text = usuariosDataGridView[2, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            TelefoneTextBox.Text = usuariosDataGridView[4, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            EnderecoTextBox.Text = usuariosDataGridView[5, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            LoginTextBox.Text = usuariosDataGridView[6, usuariosDataGridView.CurrentRow.Index].Value.ToString();

            SenhaTextBox.Text = usuariosDataGridView[7, usuariosDataGridView.CurrentRow.Index].Value.ToString();
        }
    }
}

