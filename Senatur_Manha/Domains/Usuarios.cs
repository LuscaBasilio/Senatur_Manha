using System;
using System.Collections.Generic;

namespace Senatur_Manha.Domains
{
    public partial class Usuarios
    {
        public int UsuarioId { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool TipoUsuario { get; set; }
    }
}
