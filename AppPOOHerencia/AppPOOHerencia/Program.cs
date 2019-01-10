using AppPOOHerencia.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOOHerencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona oPersona = new Persona();
            oPersona.Nombres = "Jonathan";
            oPersona.Apellidos = "Estrada";
            oPersona.Genero = 'M';
            oPersona.Edad = 30;
            oPersona.Identificacion = "76522916";
            Console.WriteLine("");
            Console.WriteLine("Nombres => " + oPersona.Nombres);
            Console.WriteLine("Apellidos => " + oPersona.Apellidos);
            Console.WriteLine("Genero => " + oPersona.Genero);
            Console.WriteLine("Edad => " + oPersona.Edad);
            Console.WriteLine("Identificacion => " + oPersona.Identificacion);
            Console.WriteLine("");
            Estudiante oEstudiante = new Estudiante();
            oEstudiante.Nombres = "Jonathan";
            oEstudiante.Apellidos = "Estrada";
            oEstudiante.Genero = 'M';
            oEstudiante.Edad = 30;
            oEstudiante.Identificacion = "76522916";
            oEstudiante.Programa = "Desarrollo de Software";
            oEstudiante.SemestreActual = "I - 2019";
            Console.WriteLine("");
            Console.WriteLine("Nombres => " + oEstudiante.Nombres);
            Console.WriteLine("Apellidos => " + oEstudiante.Apellidos);
            Console.WriteLine("Genero => " + oEstudiante.Genero);
            Console.WriteLine("Edad => " + oEstudiante.Edad);
            Console.WriteLine("Identificacion => " + oEstudiante.Identificacion);
            Console.WriteLine("Programa => " + oEstudiante.Identificacion);
            Console.WriteLine("SemestreActual => " + oEstudiante.Identificacion);
            Console.WriteLine("");
            Docente oDocente = new Docente();
            oDocente.Nombres = "Jonathan";
            oDocente.Apellidos = "Estrada";
            oDocente.Genero = 'M';
            oDocente.Edad = 30;
            oDocente.Identificacion = "76522916";
            oDocente.MateriasDictadas  = 6;
            oDocente.Contrato  = "100016336";
            Console.WriteLine("");
            Console.WriteLine("Nombres => " + oDocente.Nombres);
            Console.WriteLine("Apellidos => " + oDocente.Apellidos);
            Console.WriteLine("Genero => " + oDocente.Genero);
            Console.WriteLine("Edad => " + oDocente.Edad);
            Console.WriteLine("Identificacion => " + oDocente.Identificacion);
            Console.WriteLine("MateriasDictadas => " + oDocente.Identificacion);
            Console.WriteLine("Contrato => " + oDocente.Identificacion);
            Console.WriteLine("");
            Administrativo oAdministrativo = new Administrativo();
            oAdministrativo.Nombres = "Jonathan";
            oAdministrativo.Apellidos = "Estrada";
            oAdministrativo.Genero = 'M';
            oAdministrativo.Edad = 30;
            oAdministrativo.Identificacion = "76522916";
            oAdministrativo.Nombre = "Silvio Manrique";
            oAdministrativo.Area = "Sistemas";
            Console.WriteLine("");
            Console.WriteLine("Nombres => " + oAdministrativo.Nombres);
            Console.WriteLine("Apellidos => " + oAdministrativo.Apellidos);
            Console.WriteLine("Genero => " + oAdministrativo.Genero);
            Console.WriteLine("Edad => " + oAdministrativo.Edad);
            Console.WriteLine("Identificacion => " + oAdministrativo.Identificacion);
            Console.WriteLine("Nombre => " + oAdministrativo.Identificacion);
            Console.WriteLine("Area => " + oAdministrativo.Identificacion);
            Console.WriteLine("");
            Console.Read();
        }
    }
}

