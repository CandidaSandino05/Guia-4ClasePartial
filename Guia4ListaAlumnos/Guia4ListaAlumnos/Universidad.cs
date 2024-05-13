using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4ListaAlumnos
{
    public partial class Universidad
    {

        //Lista de Alumnos 
        private List<Alumno> ListaAlumnos;

        //Constructor para inicializar la lista de alumnos 
        public Universidad() 
        {
        
          ListaAlumnos = new List<Alumno>();

        }


        ///Metodo estatico para agregar un nuevo alumno a la lista
        public void AgregarAlumno(Alumno alumno)
        {
            ListaAlumnos.Add(alumno);
        }

        //Metodo estatico para moestrar la lista de alumnos detallada
        public List<Alumno> ObtemerListaDeAlumnos() 
        {
           return ListaAlumnos;
        }
         



    }
}
