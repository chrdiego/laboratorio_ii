using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPseudoCodigoSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            // GENERO LISTA
            List<Alumno> lista = new List<Alumno>();
            Alumno a1 = new Alumno("Juan", "Perez", 5);
            Alumno a2 = new Alumno("Julio", "Cesar", 10);
            Alumno a3 = new Alumno("Carlos", "Judio", 10);
            Alumno a4 = new Alumno("Matias", "Pija", 10);
            Alumno a5 = new Alumno("Roberto", "Caca", 3);
            Alumno a6 = new Alumno("Sergio", "Poronga", 2);
            Alumno a7 = new Alumno("Cristian", "Vergara", 1);
            Alumno a8 = new Alumno("Jesus", "Dios", 10);

            lista.Add(a1);
            lista.Add(a2);
            lista.Add(a3);
            lista.Add(a4);
            lista.Add(a5);
            lista.Add(a6);
            lista.Add(a7);
            lista.Add(a8);

            //IMPRIMO DATOS
            Console.WriteLine("ALUMNOS MOSTRADOS CON FOREACH: ");
            foreach (Alumno a in lista)
            {
                Console.WriteLine("NOMBRE: " + a.Nombre + " - APELLIDO: " + a.Apellido + " - NOTA: " + a.Nota);
            }

            Console.WriteLine("\nALUMNOS MOSTRADOS CON FOR:");
            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Nombre: " + lista.ElementAt(i).Nombre + " - Apellido: " + lista.ElementAt(i).Apellido + " - NOTA: " + lista.ElementAt(i).Nota);
            }

            //ORDENO DE MAYOR A MENOR
            void OrdenarNota(List<Alumno> l)
            {
                Alumno aux;
                for (int i = 0; i < l.Count; i++)
                {
                    for (int j = 0; j < l.Count - 1; j++)
                    {
                        if (l[j].Nota < l[j + 1].Nota)
                        {
                            aux = l[j];
                            l[j] = l[j + 1];
                            l[j + 1] = aux;
                        }
                    }
                }
            }
            OrdenarNota(lista);

            //IMPRIMO POR MAYOR A MENOR
            Console.WriteLine("\nALUMNOS ORDENADOS POR NOTA:");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Nombre: " + lista.ElementAt(i).Nombre + " - Apellido: " + lista.ElementAt(i).Apellido + " - NOTA: " + lista.ElementAt(i).Nota);
            }

            //ARMO LISTA CON PERSONAS POR DEBAJO DEL PROMEDIO
            int prom = 0;
            for(int i = 0;  i < lista.Count; i++)
            {
                prom += lista[i].Nota;
            }
            prom = prom / lista.Count;
            
            List<Alumno> alumnosConNotaInferiorALaMedia = new List<Alumno>();
            for(int i = 0; i < lista.Count; i++)
            {
                if(lista[i].Nota < prom)
                {
                    alumnosConNotaInferiorALaMedia.Add(lista[i]);
                }
            }
            //IMPRIMO ESTOS ALUMNOS
            Console.WriteLine("\nALUMNOS CON NOTA POR DEBAJO DEL PROMEDIO ({0})", prom);
            for (int i = 0; i < alumnosConNotaInferiorALaMedia.Count; i++)
            {
                Console.WriteLine("Nombre: " + alumnosConNotaInferiorALaMedia.ElementAt(i).Nombre + " - Apellido: " + alumnosConNotaInferiorALaMedia.ElementAt(i).Apellido + " - NOTA: " + alumnosConNotaInferiorALaMedia.ElementAt(i).Nota);
            }

            //PARA DEVOLVER LA MEDIANA DE LAS NOTAS
            int Mediana(List<Alumno> l)
            {
                int mediana;
                int pos = l.Count / 2;
                if ((l.Count % 2) == 0)
                    mediana = (l[pos].Nota + l[pos - 1].Nota) / 2;
                else
                    mediana = l[pos].Nota;
                return mediana;
            }
            Console.WriteLine("MEDIANA DE LAS NOTAS: " + Mediana(lista));
            Console.ReadKey();
        }
    }
}
