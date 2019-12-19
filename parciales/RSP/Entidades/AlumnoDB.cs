using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnoDB
    {
    SqlCommand comando;
    SqlConnection conexion;

    public AlumnoDB()
    {
      this.conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=utn;Integrated Security=True");
      this.comando = new SqlCommand();
      this.comando.CommandType = System.Data.CommandType.Text;
      this.comando.Connection = this.conexion;
    }

    public List<Alumno> Leer()
        {
      List<Alumno> datos = new List<Alumno>();
      try
      {
        this.comando.CommandText = "SELECT nombre,legajo FROM " + "Estudiantes";
        this.conexion.Open();
        SqlDataReader reader = this.comando.ExecuteReader();
        while (reader.Read())
        {
          datos.Add(new Alumno((int)reader["legajo"], reader["nombre"].ToString()));
        }
        reader.Close();
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        if (this.conexion.State == System.Data.ConnectionState.Open)
          this.conexion.Close();
      }
      return datos;
    }

    public bool Guardar(Alumno alumno)
    {
      bool retorno = false;
      try
      {
        this.comando.CommandText = String.Format($"INSERT INTO dbo.Estudiantes(nombre, legajo) VALUES('{alumno.Nombre}', '{alumno.Legajo}'");
        this.conexion.Open();
        this.comando.ExecuteNonQuery();
        retorno = true;
      }
      catch (Exception ex)
      {
        retorno = false;
        throw ex;
      }
      finally
      {
        if (this.conexion.State == System.Data.ConnectionState.Open)
          this.conexion.Close();
      }
      return retorno;
    }
  }
}
