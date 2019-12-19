using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        public static bool Insertar(Paquete p)
        {
            bool retorno = false;
            try
            {
                string comando = string.Format("INSERT INTO [correo-sp-2017].[dbo].[Paquetes]" + "(direccionEntrega, trackingID, alumno)" + " VALUES ('{0}', '{1}', 'Chirdo.Romano.Diego.Ezequiel')", p.DireccionEntrega, p.TrackingID);
                PaqueteDAO.comando.CommandText = comando;
                PaqueteDAO.conexion.Open();
                PaqueteDAO.comando.ExecuteNonQuery();
                PaqueteDAO.conexion.Close();
                retorno = true;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if(conexion.State == System.Data.ConnectionState.Open)
                {
                    PaqueteDAO.conexion.Close();
                    retorno = true;
                }
            }
            return retorno;
        }

        static PaqueteDAO()
        {
            SqlConnectionStringBuilder stringSql;
            stringSql = new SqlConnectionStringBuilder();
            stringSql.IntegratedSecurity = true;
            stringSql.InitialCatalog = "correo-sp-2017";
            stringSql.DataSource = ".\\SQLEXPRESS";
            PaqueteDAO.conexion = new SqlConnection(stringSql.ToString());
            PaqueteDAO.comando = new SqlCommand();
            PaqueteDAO.comando.CommandType = System.Data.CommandType.Text;
            PaqueteDAO.comando.Connection = PaqueteDAO.conexion;
        }
    }
}
