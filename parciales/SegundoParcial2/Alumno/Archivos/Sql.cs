using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {
            SqlConnectionStringBuilder conexionString = new SqlConnectionStringBuilder();
            conexionString.DataSource = ".\\SQLEXPRESS";
            conexionString.InitialCatalog = "patentes-sp-2018";
            conexionString.IntegratedSecurity = true;
            conexion = new SqlConnection(conexionString.ToString());
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            if(datos != null)
            {
                try
                {
                    conexion.Open();
                    foreach(Patente p in datos)
                    {
                        comando.CommandText = String.Format($"INSERT INTO dbo.Patentes(patente,tipo) VALUES('{p.CodigoPatente}','{p.TipoCodigo}')");
                        comando.ExecuteNonQuery();
                    }

                }
                catch(Exception e)
                {
                    throw e;
                }
                finally
                {
                    conexion.Close();
                }
            }

        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            Queue<Patente> r = new Queue<Patente>();
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM {tabla}";
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Patente p = oDr["patente"].ToString().ValidarPatente();
                    if (!(p.CodigoPatente is null))
                        r.Enqueue(p);
                }
            }
            catch (Exception ex)
            {
                datos = default;
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                conexion.Close();
            }
            datos = r;
        }
    }
}
