using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuxiliarContabeis.Modelo;
namespace AuxiliarContabeis
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblProfissao_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void lblDeclaracao_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Cadastrar cadastrar = new Cadastrar(
                        txbNome.Text.ToString(),
                        int.Parse(txbIdade.Text),
                        txbEmail.Text.ToString(),
                        txbProfissao.Text.ToString(),
                        boxRenda.SelectedItem.ToString(),
                        txbCpf.Text.ToString(),
                        mTxbDD.Text.ToString() + mTxbNumero.Text.ToString(),
                        txbRua.Text.ToString(),
                        int.Parse(txbNumEndereco.Text),
                        txbBairro.Text.ToString(),
                        txbComo.Text.ToString(),
                        boxDeclarou.SelectedItem.ToString()
                );
            cadastrar.efetuarCadastro();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txbCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void boxDeclarou_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
