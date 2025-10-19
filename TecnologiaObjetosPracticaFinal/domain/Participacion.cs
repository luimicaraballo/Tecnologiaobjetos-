namespace TecnologiaObjetosPracticaFinal;

public class Participacion
{
    public int ParticipacionId { get; set; }
    public Proyecto Proyecto { get; set; }
    public Estudiante Estudiante { get; set; }
    public RolEnProyecto Rol { get; set; }
    public DateTime FechaInicio { get; set; }


    public Participacion(int participacionId, Proyecto proyecto, Estudiante estudiante, RolEnProyecto rol)
    {
        ParticipacionId = participacionId;
        Proyecto = proyecto;
        Estudiante = estudiante;
        Rol = rol;
        FechaInicio = DateTime.Now;
    }


    public void CambiarRol(RolEnProyecto nuevoRol)
    {
        Rol = nuevoRol;
    }
}