using Senatur_Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senatur_Manha.Interfaces
{
    interface IPacoteRepository
    {
        List<Pacotes> Listar();

        List<Pacotes> BuscarPorId(Pacotes Id);

        void AlterarPacote();

        void CadastrarPacote();
    }
}
