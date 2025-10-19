namespace TecnologiaObjetosPracticaFinal;

public class Estudiante
{
    public int EstudianteId { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Matricula { get; set; }
    public Usuario Usuario { get; set; }


    public Estudiante(int estudianteId, string nombre, string apellido, string correo, DateTime fechaNacimiento,
        string telefono, string direccion, string matricula, Usuario usuario)
    {
        EstudianteId = estudianteId;
        Nombre = nombre;
        Apellido = apellido;
        Correo = correo;
        FechaNacimiento = fechaNacimiento;
        Telefono = telefono;
        Direccion = direccion;
        Matricula = matricula;
        Usuario = usuario;
    }


    public string GetNombreCompleto() => $"{Nombre} {Apellido}";


    public void SetTelefono(string telefono) => Telefono = telefono;


    public void SetCorreo(string correo) => Correo = correo;
}

