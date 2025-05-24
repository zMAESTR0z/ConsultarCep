using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarCEP
{
    internal class CEPController
    {
        public string connectionString;
        public CEPController(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<ViaCEP> GetCEP()
        {
            List<ViaCEP> cep = new List<ViaCEP>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Logradouro, Bairro, Cidade, Estado FROM BD_CEP";
                    SqlCommand command = new SqlCommand(query, conn);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cep.Add(new ViaCEP
                            {
                                logradouro = reader.GetString(0),
                                bairro = reader.GetString(1),
                                cidade = reader.GetString(2),
                                estado = reader.GetString(3)

                            });
                        }
                    }
                    return cep;
                }
                catch (Exception e)
                {
                    throw new Exception($"Erro ao adicionar o CEP: {e.Message}");
                }
            }
        }

        public void SetCEP(ViaCEP cep)
        {
            using (SqlConnection conn =
                new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO BD_CEP" +
                        " (Logradouro, Bairro, Cidade, Estado ) " +
                        "VALUES ( @logradouro, @bairro, @cidade, @estado)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@logradouro", cep.logradouro);
                    cmd.Parameters.AddWithValue("@bairro", cep.bairro);
                    cmd.Parameters.AddWithValue("@cidade", cep.cidade);
                    cmd.Parameters.AddWithValue("@estado", cep.estado);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Erro ao adicionar o CEP: {e.Message}");
                }
            }
        }

        //filta cidade
        public List<ViaCEP> GetCEPByCidade(string cidade)
        {
            List<ViaCEP> cepList = new List<ViaCEP>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Logradouro, Bairro, Cidade, Estado FROM BD_CEP WHERE Cidade = @cidade";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cidade", cidade);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cepList.Add(new ViaCEP
                            {
                                logradouro = reader.GetString(0),
                                bairro = reader.GetString(1),
                                cidade = reader.GetString(2),
                                estado = reader.GetString(3)
                            });
                        }
                    }
                    return cepList;
                }
                catch (Exception e)
                {
                    throw new Exception($"Erro ao filtrar por cidade: {e.Message}");
                }
            }
        }

        // Filtrar por Estado
        public List<ViaCEP> GetCEPByEstado(string estado)
        {
            List<ViaCEP> cepList = new List<ViaCEP>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Logradouro, Bairro, Cidade, Estado FROM BD_CEP WHERE Estado = @estado";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@estado", estado);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cepList.Add(new ViaCEP
                            {
                                logradouro = reader.GetString(0),
                                bairro = reader.GetString(1),
                                cidade = reader.GetString(2),
                                estado = reader.GetString(3)
                            });
                        }
                    }
                    return cepList;
                }
                catch (Exception e)
                {
                    throw new Exception($"Erro ao filtrar por estado: {e.Message}");
                }
            }
        }
    }
    

}
