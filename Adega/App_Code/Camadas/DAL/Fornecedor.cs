using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adega.Camadas.DAL
{ 
   public class Fornecedor
{
  
        private string strCon = Conexao.getConexao();

        public List<MODEL.Fornecedor> Select()
        {
            List<MODEL.Fornecedor> lstFornecedor = new List<MODEL.Fornecedor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Fornecedor";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Fornecedor fornecedor = new MODEL.Fornecedor();
                    fornecedor.id = Convert.ToInt32(reader["id"].ToString());
                    fornecedor.nome = reader["nome"].ToString();
                    fornecedor.empresa = reader["empresa"].ToString();
                    fornecedor.cidade = reader["cidade"].ToString();


                    lstFornecedor.Add(fornecedor);
                }
            }
            catch
            {
                Console.WriteLine("Erro na Seleção de Fornecedor...");
            }
            finally
            {
                conexao.Close();
            }
            return lstFornecedor;
        }

        public List<MODEL.Fornecedor> SelectById(int id)
        {
            List<MODEL.Fornecedor> lstFornecedor = new List<MODEL.Fornecedor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from  Fornecedor where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                     MODEL.Fornecedor fornecedor = new MODEL.Fornecedor();
                     fornecedor.id = Convert.ToInt32(reader["id"].ToString());
                     fornecedor.nome = reader["nome"].ToString();
                     fornecedor.empresa = reader["empresa"].ToString();
                     fornecedor.cidade = reader["cidade"].ToString();
                 }
            }
            catch
            {
                Console.WriteLine("Erro na Seleção de Fornecedor por ID");
            }
            finally
            {
                conexao.Close();
            }
            return lstFornecedor;
    }

        public List<MODEL.Fornecedor> SelectByNome(string nome)
        {
            List<MODEL.Fornecedor> lstFornecedor = new List<MODEL.Fornecedor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Veiculo where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                MODEL.Fornecedor fornecedor = new MODEL.Fornecedor();
                fornecedor.id = Convert.ToInt32(reader["id"].ToString());
                fornecedor.nome = reader["nome"].ToString();
                fornecedor.empresa = reader["empresa"].ToString();
                fornecedor.cidade = reader["cidade"].ToString(); ;
                }
            }
            catch
            {
                Console.WriteLine("Erro na Seleção de Motorista por nome");
            }
            finally
            {
                conexao.Close();
            }
            return lstFornecedor;
        }

        public void Insert(MODEL.Fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into fornecedor values (@nome, @empresa,@cidade);";
            SqlCommand cmd = new SqlCommand(sql, conexao); 
            cmd.Parameters.AddWithValue("@nome", fornecedor.nome);
            cmd.Parameters.AddWithValue("@empresa", fornecedor.empresa);
            cmd.Parameters.AddWithValue("@cidade", fornecedor.cidade);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na Inserção.. ");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Update(MODEL.Fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update fornecedor set nome@nome, ";
            sql += "nome=@nome ";
            sql += "where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", fornecedor.id);
                cmd.Parameters.AddWithValue("@nome", fornecedor.nome);
                cmd.Parameters.AddWithValue("@empresa", fornecedor.empresa);
                cmd.Parameters.AddWithValue("@cidade", fornecedor.cidade);
            conexao.Open();
        try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Atualização de Fornecedor..");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Delete(MODEL.Fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Veiculo where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", fornecedor.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de Fornecedor..");
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}
