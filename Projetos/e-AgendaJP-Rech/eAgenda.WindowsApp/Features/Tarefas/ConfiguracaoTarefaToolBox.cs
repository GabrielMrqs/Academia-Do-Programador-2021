using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WindowsApp.Features.Tarefas
{
    public class ConfiguracaoTarefaToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro => "Cadastro de Tarefas";
        public string ToolTipAdicionar => "Adicionar uma nova Tarefa";
        public string ToolTipEditar => "Editar uma Tarefa existente";
        public string ToolTipExcluir => "Excluir uma Tarefa existente";
    }
}
