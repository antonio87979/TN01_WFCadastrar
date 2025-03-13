using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFCadastroEndereco;

namespace TN01_WFCadastroEndereco
{
    public partial class FormCadastroEndereco : Form
    {
        public FormCadastroEndereco()
        {
            InitializeComponent();
            cbxUf.SelectedIndex = 0;
        }

        public void alerta(string mensagem)
        {
            MessageBox.Show(mensagem,
                "Alerta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }
        public void erro(string mensagem)
        {
            MessageBox.Show(mensagem,
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }
        public void sucesso(string mensagem)
        {
            MessageBox.Show(mensagem,
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        private void chkSemNumero_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSemNumero.Checked == true)
            {
                txtNumero.Enabled = false;
            }
            else
            {
                txtNumero.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {          

            if (string.IsNullOrEmpty(mtbCep.Text))
            {
                erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txtLogradouro.Text))
            {
                erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(cbxUf.Text))
            {
                erro("Campo Vazio");
                return;
            }
            if (string.IsNullOrEmpty(txtNumero.Text) && chkSemNumero.Checked == false)
            {
                erro("Campo Vazio");
                return;
            }
            Endereco End = new Endereco();
            End.Logradouro = txtLogradouro.Text;
            End.Cep = mtbCep.Text;
            //se o sem numero estiver marcado, netão fica vazio o texto de numero
            End.Numero = chkSemNumero.Checked 
                 ? "S/N" : txtNumero.Text;

            End.Nome = txtNomeCompleto.Text;
            End.Bairro = txtBairro.Text;
            End.Cidade = txtCidade.Text;
            End.UF = cbxUf.SelectedItem?.ToString();
            End.Complemento = txtComplemento.Text;
            End.SemNumero = chkSemNumero.Checked;

            string mensagem = @$"
                Nome: {End.Nome}
                Cep: {End.Cep}
                Logradouro: {End.Logradouro}
                Numero: {End.Numero}
                Bairro: {End.Bairro}
                Cidade: {End.Cidade}
                Estado: {End.UF}
                Complemento: {End.Complemento}               
             ";

            //Adicionando na Lista de Endereços
            Endereco.ListaEnderecos.Add(End);

            sucesso(mensagem);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
