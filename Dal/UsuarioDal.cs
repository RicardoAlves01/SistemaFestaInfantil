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
        public void Incluir(Usuarios usuarios)

        {

            //conexao

            SqlConnection cn = new SqlConnection();

            try

            {
                cn.ConnectionString = Dados.StringDeConexao;

                //command

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into TbUsuarios(nomeUsuario,cpf,telefone,privilegio,endereco) values (@nomeUsuario,@cpf,@telefone,@privilegios,@endereco);";
                cmd.Parameters.AddWithValue("@nomeUsuario", usuarios.Nome);
                cmd.Parameters.AddWithValue("@cpf", usuarios.Cpf);
                cmd.Parameters.AddWithValue("@telefone", usuarios.Telefone);
                cmd.Parameters.AddWithValue("@privilegio", usuarios.Privilegio);
                cmd.Parameters.AddWithValue("@endereco", usuarios.Endereco);

                cn.Open();

                usuarios.Id = Convert.ToInt32(cmd.ExecuteScalar());
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
        public void Alterar(Usuarios usuarios)
        {
            // conexao
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update TbUsuarios set nome = @nomeUsuario, cpf = @cpf, telefone = @telefone, privilegio = @privilegio, endereco = @endereco where idUsuarios = @idUsuarios;";
                cmd.Parameters.AddWithValue("@idUsuarios", usuarios.Id);
                cmd.Parameters.AddWithValue("@nomeUsuario", usuarios.Nome);
                cmd.Parameters.AddWithValue("@cpf", usuarios.Cpf);
                cmd.Parameters.AddWithValue("@telefone", usuarios.Telefone);
                cmd.Parameters.AddWithValue("@privilegio", usuarios.Privilegio);
                cmd.Parameters.AddWithValue("@endereco", usuarios.Endereco);

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
                cmd.CommandText = "delete from TbUsuarios where idUsuarios = " + id;

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
            SqlDataAdapter da = new SqlDataAdapter("select * from TbUsuarios", Dados.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
