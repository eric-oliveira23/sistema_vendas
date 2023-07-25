using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace _212045
{
    public class Banco
    {
        //Criando as variáveis publicas para conexão e consulta serão usadas
        //Connection responsável pela conexão com o MySql
        public static MySqlConnection Conexao;
        //Command responsável pelas instruções SQL a serem executadas
        public static MySqlCommand Comando;
        //Adapter responsável por inserir dados em um dataTable
        public static MySqlDataAdapter Adaptador;
        //DataTable responsável por ligar o banco em controles com a propriedade
        public static DataTable datTabela;

        public static void AbrirConexao()
        {
            try
            {
                //Estabelece os parâmetros para a conexão com o banco

                //Etec
                //Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                //Casa
                Conexao = new MySqlConnection("server=localhost;port=3306;uid=root;pwd=etecjau");

                //Abrir conexão com o banco de dados
                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void FecharConexao()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CriarBanco()
        {
            try
            {
                //Chama a função para abertura de conexão com o banco
                AbrirConexao();

                //Informa a instrução SQL
                Comando = new MySqlCommand("create database if not exists Vendas; use vendas;", Conexao);

                //Executa a Query no MySQL (Raio do Workbench)
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS cidades" +
                                            "(id integer auto_increment primary key, " +
                                            "nome char(40), " +
                                            "uf char(02))", Conexao);
                Comando.ExecuteNonQuery();


                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS marcas" +
                                            "(id integer auto_increment primary key, " +
                                            "marca char(20))", Conexao);
                Comando.ExecuteNonQuery();


                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS categorias" +
                                            "(id integer auto_increment primary key, " +
                                            "categoria char(20))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS clientes" +
                    "(id integer auto_increment primary key," +
                    "nome char(40)," +
                    "idCidade integer," +
                    "dataNasc date," +
                    "renda decimal(10,2)," +
                    "cpf char(14)," +
                    "foto varchar(100)," +
                    "venda boolean)", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Produtos " +
                    "(Id integer auto_increment primary key, " +
                    "descricao char(40), " +
                    "idCategoria integer," +
                    "idMarca integer, " +
                    "estoque decimal(10,3), "+
                    "valor decimal(10,2), " +
                    "foto varchar(100))", Conexao);

                Comando.ExecuteNonQuery();
            

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS VendaCab " +
                    "(Id integer auto_increment primary key, " +
                    "idCliente int, " +
                    "data date, " +
                    "total decimal(10,2))", Conexao);

                Comando.ExecuteNonQuery();


                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS VendaDet " +
                       "(Id integer auto_increment primary key, " +
                       "idVendaCab int, " +
                       "idProduto int, " +
                       "qtde decimal(10,3)," +
                       "valorUnitario decimal(10,2))", Conexao);

                Comando.ExecuteNonQuery();

                //Chama a função para fechar a conexão com o banco
                FecharConexao();

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }           

    }

}
