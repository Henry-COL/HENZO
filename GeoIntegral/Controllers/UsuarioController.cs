using GeoIntegral.Data;
using GeoIntegral.Models;
using System.Linq;

namespace GeoIntegral.Controllers
{
    public class UsuarioController
    {
        private readonly UsuarioRepository _repo = new UsuarioRepository();

        // Para registrar: Primero busca si el usuario existe
        public string RegistrarNuevoUsuario(string user, string pass)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
                return "Campos vacíos";

            var existentes = _repo.ObtenerTodos();

            // Buscamos si el nombre ya está en el .csv
            if (existentes.Any(u => u.Username.Equals(user.Trim(), System.StringComparison.OrdinalIgnoreCase)))
            {
                return "El usuario ya existe en la base de datos";
            }

            // Si no existe, lo agregamos
            _repo.Agregar(new Usuario { Username = user, Password = pass });
            return "Ok";
        }

        // Para el Login: Busca coincidencia exacta
        public bool ValidarLogin(string user, string pass)
        {
            var existentes = _repo.ObtenerTodos();
            return existentes.Any(u => u.Username == user && u.Password == pass);
        }
    }
}