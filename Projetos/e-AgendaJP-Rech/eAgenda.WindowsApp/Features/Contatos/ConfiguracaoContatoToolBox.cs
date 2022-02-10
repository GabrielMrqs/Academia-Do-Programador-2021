using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public class ConfiguracaoContatoToolBox : IConfiguracaoToolBox
    {        
        public string TipoCadastro => "Cadastro de Contatos";
        public string ToolTipAdicionar => "Adicionar um novo Contato";
        public string ToolTipEditar => "Editar um Contato existente";
        public string ToolTipExcluir => "Excluir um Contato existente";

    }
}
