using Interfaces;
using Entidades;
namespace Negosio
{
    public class Secretaria
    {
        public IPersistencia Persistencia { get; set; }
        public Secretaria(IPersistencia persistencia)
        {

            this.Persistencia = persistencia;
        }
         // creamos una propiedad 

        public string Matricular(Estudiante estudiante, Curso curso)
        {

            Persistencia.Grabar(estudiante);
            Persistencia.Grabar(curso);
            Persistencia.Grabar(new EstudiantePorCurso { EstudianteId = estudiante.Id, CursoId = curso.Id });
            return string.Format("el estudiante {0}{1} se matriculo en el curso {2}"
                , estudiante.Nombre
                , estudiante.Apellido
                , curso.Nombre);
        }

    }

}
