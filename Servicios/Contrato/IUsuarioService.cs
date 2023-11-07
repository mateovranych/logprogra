using LoginProgramacionFinal.Models;
using Microsoft.EntityFrameworkCore;


namespace LoginProgramacionFinal.Servicios.Contrato

{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuario(string correo, string clave); //Este método devuelve un usuario a travéz de un correo y una clave
        Task<Usuario> SaveUsuario(Usuario modelo); //Sirve para guardar un usuario
    }
}
