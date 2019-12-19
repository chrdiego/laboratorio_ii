using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FormularioBDD
{
    public static class PersonaDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static PersonaDAO()
        {
            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;InitialCatalog=ejercicio61;Integrated Security=True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static bool Guardar(Persona persona)
        {
            bool retorno = false;
            if (persona is null) return retorno;

            try
            {
                comando.CommandText = String.Format($"INSERT INTO dbo.Persona(nombre, apellido, id)" + " VALUES ('{0}', '{1}', '{2}')", persona.Nombre, persona.Apellido, persona.Id);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool Leer(string consulta)
        {
            string aux = "";
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
                conexion.Open();
            }
        }
    }
}
