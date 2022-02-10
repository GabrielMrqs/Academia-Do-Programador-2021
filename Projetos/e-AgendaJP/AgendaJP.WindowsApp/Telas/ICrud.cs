using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaJP.WindowsApp.Telas
{
    interface ICrud
    {
        void CarregarTodosOsRegistros();
        void PegarDadosDaTabela(int id);
        void ApagarCampos();
        void AdicionarRegistro();
        void EditarRegistro();
        void ExcluirRegistro();
        void ConcluirAcao();
    }
}
