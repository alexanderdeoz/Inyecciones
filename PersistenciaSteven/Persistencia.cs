using System.Collections.Generic;
using System.IO;
using Interfaces;
using Entidades;
namespace PersistenciaSteven
{
    class Persistencia:IPersistencia
    {
        public bool Grabar(Estudiante estudiante)
        {
            // to do 
            // creacion de archivos 
            File.AppendAllLines("Estudiante.txt",new List<string> {estudiante.ToString()});
                // creacion de archivos 
            return true;
        }
        public bool Grabar(Curso curso)
        {
            // to do 
            // creacion de archivos 
            File.AppendAllLines("Curso.txt", new List<string> { curso.ToString() });
            // creacion de archivos 
            return true;
        }
        public bool Grabar(EstudiantePorCurso estudiantePorCurso)
        {
            // to do 
            // creacion de archivos 
            File.AppendAllLines("EstudiantePorCurso.txt", new List<string> {estudiantePorCurso.ToString() });
            // creacion de archivos 
            return true;
        }
    }
}
