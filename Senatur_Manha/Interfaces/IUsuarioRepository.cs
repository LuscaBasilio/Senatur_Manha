using Senatur_Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senatur_Manha.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuarios> Listar();

        Login();
    }
}
