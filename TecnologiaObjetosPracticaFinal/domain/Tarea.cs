namespace TecnologiaObjetosPracticaFinal;

public class Tarea
{
    public int TareaId { get; set; }
    public Proyecto ProyectoAsignado { get; set; }
    public string Descripcion { get; set; }
    public EstadoTarea EstadoTarea { get; set; }
    public DateTime FechaDeEntrega { get; set; }
    public List<Asignacion> Asignaciones { get; set; } = new List<Asignacion>();

    public Tarea(int tareaId, Proyecto proyectoAsignado, string descripcion, EstadoTarea estado, DateTime fechaEntrega)
    {
        TareaId = tareaId;
        ProyectoAsignado = proyectoAsignado;
        Descripcion = descripcion;
        EstadoTarea = estado;
        FechaDeEntrega = fechaEntrega;
    }


    public void ActualizarDescripcion(string nuevaDescripcion)
    {
        Descripcion = nuevaDescripcion;
    }


    public void SetEstadoTarea(EstadoTarea nuevoEstado)
    {
        EstadoTarea = nuevoEstado;
    }


    public void AgregarAsignacion(Asignacion asignacion)
    {
        if (asignacion != null && !Asignaciones.Contains(asignacion))
        {
            Asignaciones.Add(asignacion);
        }
    }
}
