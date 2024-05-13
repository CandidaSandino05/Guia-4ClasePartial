using Guia4ListaAlumnos;
using System.Runtime.InteropServices;

public partial class Program 
{
    private static List<Alumno> listaAlumnosModificada;

    static void Main(string[] args) 
    {
        Console.WriteLine("---Gestion de Alumnos en la Universidad---");

        List<Alumno> ListaAlumnos = new List<Alumno>();

        

        // Mostrar la lista de alumnos registrados
        Console.WriteLine("Lista de alumnos registrados:");
        foreach (Alumno alumno in ListaAlumnos) 
        {
            Console.WriteLine(alumno); // Imprimir la información del alumno
        }

        //Lista para almacenar los alumnos 
       

        ListaAlumnos.Add(new Alumno("Candida Carolina Sandino Gaitán", 19, 2095, CarrerasAlumnos.Ingenieria_de_Sistemas, 60, 58, 79, 98));

        ListaAlumnos.Add(new Alumno("Juan Martin Marenco Lopez", 20, 2096, CarrerasAlumnos.Telecomunicaciones, 70, 82, 90, 63));

        ListaAlumnos.Add(new Alumno("Maria Fernanda Martin Gonzales", 23, 20963, CarrerasAlumnos.Ingenieria_en_computacion, 65, 53, 69, 82));

        ListaAlumnos.Add(new Alumno("Odvin Enrique Condega Rivera", 20, 20220940, CarrerasAlumnos.Ingenieria_electronica, 96, 85, 76, 93));

        ListaAlumnos.Add(new Alumno("Nataly Patricia Laguna Cortez", 21, 20220978, CarrerasAlumnos.Ingenieria_de_Sistemas, 49, 68, 96, 86));

        foreach (var Alumnos in ListaAlumnos)
        {
            Alumnos.MostrarInfoEstudiante();
        }

   

        foreach (var Alumno in ListaAlumnos)
        { 
            
            Alumno.AgregarAlumno();
        }
      


        foreach (var Alumno in ListaAlumnos) 
        {
            Alumno.PromedioDeAlumnos();
        }


        foreach (var Alumnos in ListaAlumnos)
        {
            Alumnos.MostrarInfoEstudiante();
        }


    }

   
    
      
}