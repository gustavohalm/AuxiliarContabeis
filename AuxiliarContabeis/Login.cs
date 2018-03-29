using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AuxiliarContabeis
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gustavo\source\repos\AuxiliarContabeis\AuxiliarContabeis\db_auxiliar.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * From admin Where Login = '"+txbLogin.Text.Trim() + "' and senha = '" + txbSenha.Text.Trim() + "'" ;
            SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();

            sqlData.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                Cadastro cadastro = new Cadastro();
                this.Hide();
                cadastro.Show();
            }
            else
            {
                MessageBox.Show("Login ou Senha inválidos!");
            }
        }
    }
}
