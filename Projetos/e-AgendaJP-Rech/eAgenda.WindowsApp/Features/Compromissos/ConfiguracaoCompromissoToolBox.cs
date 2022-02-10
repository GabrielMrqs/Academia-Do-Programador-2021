using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WindowsApp.Features.Compromissos
{
    public class ConfiguracaoCompromissoToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar => "Adicionar um novo Compromisso";
        public string TipoCadastro => "Cadastro de Compromissos";
        public string ToolTipEditar => "Editar um Compromisso existente";
        public string ToolTipExcluir => "Excluir um Compromisso existente";
    }
}
