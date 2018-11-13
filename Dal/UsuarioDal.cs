using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestaInfantil.Models;
using System.Data.SqlClient;
using System.Data;

namespace FestaInfantil.Dal
{
    public class UsuarioDal
    {
        public void Incluir(Usuario usuario)

        {

            //conexao

            SqlConnection cn = new SqlConnection();

            try

            {
                cn.ConnectionString = Dados.StringDeConexao;

                //command

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into TbUsuario(nomeUsuario,cpf,telefone,privilegio,endereco) values (@nomeUsuario,@cpf,@telefone,@privilegios,@endereco);";
                cmd.Parameters.AddWithValue("@nomeUsuario", usuario.Nome);
                cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                cmd.Parameters.AddWithValue("@privilegio", usuario.Privilegio);
                cmd.Parameters.AddWithValue("@endereco", usuario.Endereco);

                cn.Open();

                usuario.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Usuario usuario)
        {
            // conexao
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update TbUsuario set nome = @nomeUsuario, cpf = @cpf, telefone = @telefone, privilegio = @privilegio, endereco = @endereco where idUsuario = @idUsuario;";
                cmd.Parameters.AddWithValue("@idUsuario", usuario.Id);
                cmd.Parameters.AddWithValue("@nomeUsuario", usuario.Nome);
                cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                cmd.Parameters.AddWithValue("@privilegio", usuario.Privilegio);
                cmd.Parameters.AddWithValue("@endereco", usuario.Endereco);

                cn.Open();

                cmd.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int id)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try

            {
                cn.ConnectionString = Dados.StringDeConexao;

                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from TbUsuario where idUsuario = " + id;

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o usuario " + id);
                }
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable Listagem()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TbUsuario", Dados.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
