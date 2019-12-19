using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class AlumnoExtension
    {
        public static bool GuardarTxt(this Profesor<Alumno> plan)
    {
      string nombre = plan.Nombre;
      bool aux = false;
      if (plan != null)
      {
        try
        {
          string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
          StreamWriter sw = new StreamWriter(Path.Combine(desktop, $"{nombre}.txt"));
          sw.WriteLine(plan.ToString());
          sw.Close();
          aux = true;
        }
        catch (Exception e)
        {
          throw e;
        }
      }
      return aux;
    }

    public static bool GuardarXML(this Alumno sat)
    {
      if (!(sat is null))
      {
        try
        {
          XmlTextWriter writer;
          XmlSerializer ser;
          string nombre = sat.Nombre;
          writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + nombre +".xml", Encoding.ASCII);
          ser = new XmlSerializer(typeof(Alumno));
          ser.Serialize(writer, sat);
          writer.Close();
          return true;
        }
        catch (Exception e)
        {
          throw e;
        }
      }
      return false;
    }

    public static Alumno LeerXML(string nombreAl)
    {
      Alumno aux;
      XmlTextReader reader;
      XmlSerializer ser;

      reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + nombreAl + ".xml");
      ser = new XmlSerializer(typeof(Alumno));
      aux = (Alumno)ser.Deserialize(reader);
      reader.Close();
      return aux;
    }


    }
}
