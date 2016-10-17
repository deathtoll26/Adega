using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adega.Camadas.DAL
{
   public class Bebida
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Bebida>Select()
        {
            List<MODEL.Bebida> lstBebida = new List<MODEL.Bebida>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Bebida";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
                try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Bebida bebida = new MODEL.Bebida();
                    bebida.id = Convert.ToInt32(reader[0].ToString());
                    bebida.nome = reader["nome"].ToString();
                    bebida.preço = Convert.ToInt32(reader["preco"].ToString());
                    bebida.descricao = reader["descricao"].ToString();
                    bebida.quantidade = Convert.ToInt32(reader["Quantidade"].ToString());
                    lstBebida.Add(bebida);
                }

            }
            catch
            {
                Console.WriteLine("Erro na Seleção de Bebida...");
            }
            finally
            {
                conexao.Close();
            }
            return lstBebida;
        }
        public List<MODEL.Bebida> SelectById(int id)
        {
            List<MODEL.Bebida> lstBebida = new List<MODEL.Bebida>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Bebida where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Bebida bebida = new MODEL.Bebida();
                    bebida.id = Convert.ToInt32(reader[0].ToString());
                    bebida.nome = reader["nome"].ToString();
                    bebida.preço = Convert.ToInt32(reader["preco"].ToString());
                    bebida.descricao = reader["descricao"].ToString();
                    bebida.quantidade = Convert.ToInt32(reader["quantidade"].ToString());
                    lstBebida.Add(bebida);
                }
            }
            catch
            {
                Console.WriteLine("Erro na Seleção de Combustivel por ID");
            }
            finally
            {
                conexao.Close();
            }
            return lstBebida;
        }
        public List<MODEL.Bebida> SelectByNome(string nome)
        {
            List<MODEL.Bebida> lstBebida = new List<MODEL.Bebida>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Bebida (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Bebida bebida = new MODEL.Bebida();
                    bebida.id = Convert.ToInt32(reader[0].ToString());
                    bebida.nome = reader["nome"].ToString();
                    bebida.preço = Convert.ToInt32(reader["preco"].ToString());
                    bebida.descricao = reader["descricao"].ToString();
                    bebida.quantidade = Convert.ToInt32(reader["quantidade"].ToString());
                    lstBebida.Add(bebida);
                }
            }
            catch
            {
                Console.WriteLine("Erro na Seleção de Combustivel por nome");
            }
            finally
            {
                conexao.Close();
            }
            return lstBebida;
        }

        public void Insert(MODEL.Bebida bebida)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Bebida values (@nome,@preco, @descricao, @quantidade);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", bebida.nome);
            cmd.Parameters.AddWithValue("@preco", bebida.preço);
            cmd.Parameters.AddWithValue("@descricao", bebida.descricao);
            cmd.Parameters.AddWithValue("@quantidade", bebida.quantidade);
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
        public void Update(MODEL.Bebida bebida)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Bebida set descricao@descricao, ";
            sql += "quantidade=@quantidade ";
            sql += "where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", bebida.id);
            cmd.Parameters.AddWithValue("@nome", bebida.nome);
            cmd.Parameters.AddWithValue("@preco", bebida.preço);
            cmd.Parameters.AddWithValue("@nome", bebida.descricao);
            cmd.Parameters.AddWithValue("@quantidade", bebida.quantidade);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na Atualização de Combustivel..");
            }
            finally
            {
                conexao.Close();
            }
        }


        public void Delete(MODEL.Bebida bebida)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Bebida where id_bebida=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", bebida.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção de Combustivel..");
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}
