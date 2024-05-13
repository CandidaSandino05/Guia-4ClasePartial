using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Guia4ListaAlumnos
{
    public partial class Alumno
    {
        //Propiedades principales del alumno

        public string nombrecompleto { get; set; }
        public int edad { get; set; }
        public int carnet { get; set; }
        public CarrerasAlumnos carrera { get; set; }
        public List<double> Calificacion { get; set; }

        int Nota1, Nota2, Nota3, Nota4;
        
        


        //constructor para inicializar las propiedades del alumno  calificacion

        public Alumno(string NombreCompleto, int Edad, int Carnet, CarrerasAlumnos Carrera,   int v1, int v2, int v3, int v4)
        {
            this.nombrecompleto = NombreCompleto;
            this.edad = Edad;
            this.carnet = Carnet;
            this.carrera = Carrera;
            this.Nota1 = v1;
            this.Nota2 = v2;
            this.Nota3 = v3;
            this.Nota4 = v4;
        }


       
              

       
        //generamos un metodo para calcular el promedio de calificaciones de alumno 
        public double PromedioDeAlumnos()
        {

            if (Calificacion.Count == 0)
            {
                return 0;  //SI no hay calificaciones , el pronedio es cero 

            }
            double Promedio = 0;
            foreach (double Calificacion in Calificacion)
            {
                Promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            }

            return Promedio;

        }
       

        //generamos un metodo para revelar el estado del alumno segun sea aprobado o reprobado

        public string EstadoDeAlumno()
        {
            double Promedio = PromedioDeAlumnos();
            return Promedio >= 60 ? "Aprobado" : "Reprobado";
        }


        //Metodo para mostrar la informacion del estudiante 
        public void MostrarInfoEstudiante()
        {
            Console.WriteLine($"Nombres Completos: {nombrecompleto}, Edad Del Estudiante: {edad}, Carrera Del Estudiante: {carrera}, Numero De Carnet Del Estudiante: {carnet}");

        }

        internal void AgregarAlumno()
        {
            Console.WriteLine("Ingrese el nombre completo del alumno: ");
            string nombrecompleto = Console.ReadLine();

            Console.WriteLine("Ingrese la Edad del alumno: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Carrera del alumno: (Ingenieria_de_Sistemas, Telecomunicaciones, Ingenieria_en_computacion, Ingenieria_electronica.)");
            CarrerasAlumnos carrera = (CarrerasAlumnos)Enum.Parse(typeof(CarrerasAlumnos), Console.ReadLine());

            Console.WriteLine("Ingrese las calificaciones del alumno: ");
            string[] CalificacionesString = Console.ReadLine().Split(',');
            List<double> Calificaciones = new List<double>();
            foreach (string calificacionString in CalificacionesString)
            {
                Calificaciones.Add(double.Parse(calificacionString));
            }

            Console.WriteLine("Ingrese el número de carnet del alumno:");
            string numeroCarnet = Console.ReadLine();

            Console.WriteLine($"Nombres Completos: {nombrecompleto}, Edad Del Estudiante: {edad}, Carrera Del Estudiante: {carrera}, Numero De Carnet Del Estudiante: {numeroCarnet}, Estado de Promedio: {Calificaciones}");

        }
    }
}


