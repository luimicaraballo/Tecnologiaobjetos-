namespace TecnologiaObjetosPracticaFinal;

public class ArchivoProyecto : Archivo
{
    public int ArchivoProyectoId { get; set; }
    public Proyecto Proyecto { get; set; }


    public ArchivoProyecto()
    {
    }


    public ArchivoProyecto(int archivoProyectoId, Proyecto proyecto, byte[] contenido, string nombre, string formato,
        DateTime fechaSubida, Estudiante estudiante)
        : base(archivoProyectoId, nombre, contenido, formato, fechaSubida, estudiante)
    {
        ArchivoProyectoId = archivoProyectoId;
        Proyecto = proyecto;
    }


    public override int ObtenerTamañoArchivo() => base.ObtenerTamañoArchivo();


    public override byte[] DescargarArchivo() => base.DescargarArchivo();


    public override bool SubirArchivo(byte[] contenido) => base.SubirArchivo(contenido);
}