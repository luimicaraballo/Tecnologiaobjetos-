using System.Text;

namespace TecnologiaObjetosPracticaFinal;

public class Usuario
{
    public int UsuarioId { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public DateTime? UltimoLogin { get; set; }
    public int IntentosFallidos { get; set; }
    public string Token { get; set; }

    public Usuario(int usuarioId, string email, string passwordHash)
    {
        UsuarioId = usuarioId;
        Email = email;
        PasswordHash = passwordHash;
        UltimoLogin = null;
        IntentosFallidos = 0;
        Token = string.Empty;
    }


    public void SetPassword(string password)
    {
        PasswordHash = Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
    }


    public bool ValidarPassword(string password)
    {
        var hashed = Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        return hashed == PasswordHash;
    }


    public bool Login(string password)
    {
        if (ValidarPassword(password))
        {
            UltimoLogin = DateTime.Now;
            IntentosFallidos = 0;
            Token = Guid.NewGuid().ToString();
            return true;
        }


        IntentosFallidos++;
        return false;
    }


    public void Logout()
    {
        Token = string.Empty;
    }


    public bool EsTokenValido(string token)
    {
        return !string.IsNullOrEmpty(Token) && Token == token;
    }
}