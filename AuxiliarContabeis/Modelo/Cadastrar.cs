using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarContabeis.Modelo
{
    class Cadastrar
    {
        #region ATRIBUTOS
        private String nome;
        private int idade;
        private String email;
        private String profissao;
        private String renda;
        private String cpf;
        private String rua;
        private String telefone;
        private int enderecoNumero;
        private String bairro;
        private String comoConheceu;
        private String declarouAnteriormente;
        #endregion

        #region CONSTRUTOR
        public Cadastrar(String nome, int idade, 
            String email, String profissao, String renda,
            String cpf,String telefone, String rua, int enderecoNumero, String bairro,
            String comoConheceu, String declarouAnteriormente)
        {
            this.nome                  = nome;
            this.idade                 = idade;
            this.email                 = email;
            this.profissao             = profissao;
            this.renda                 = renda;
            this.cpf                   = cpf;
            this.telefone              = telefone;
            this.rua                   = rua;
            this.enderecoNumero        = enderecoNumero;
            this.bairro                = bairro;
            this.comoConheceu          = comoConheceu;
            this.declarouAnteriormente = declarouAnteriormente;
        }
        #endregion

        public void efetuarCadastro()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gustavo\source\repos\AuxiliarContabeis\AuxiliarContabeis\db_auxiliar.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO pessoas" +
                " (nome, idade, cpf, telefone, email, profissao, renda, rua, enderecoNumero, bairro, comoConheceu, declarouAnteriormente, avaliacao)" +
                " VALUES(@nome, @idade, @cpf, @telefone, @email, @profissao, @renda, @rua, @enderecoNumero, @bairro, @comoConheceu, @declarouAnteriormente, NULL)",
                connection);
            cmd.Parameters.AddWithValue("@nome", this.nome);
            cmd.Parameters.AddWithValue("@idade", this.idade);
            cmd.Parameters.AddWithValue("@cpf", this.cpf);
            cmd.Parameters.AddWithValue("@telefone", this.telefone);
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@profissao", this.profissao);
            cmd.Parameters.AddWithValue("@renda", this.renda);
            cmd.Parameters.AddWithValue("@rua", this.rua);
            cmd.Parameters.AddWithValue("@enderecoNumero", this.enderecoNumero);
            cmd.Parameters.AddWithValue("@bairro", this.bairro);
            cmd.Parameters.AddWithValue("@comoConheceu", this.comoConheceu);
            cmd.Parameters.AddWithValue("@declarouAnteriormente", this.declarouAnteriormente);
           
            cmd.ExecuteNonQuery();
        }
    }
}
