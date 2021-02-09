using System;

namespace TarefasBackEnd.Models
{
    public class Tarefa 
    {
        public Guid Id {get;set;}
        public string Nome { get; set; }
        public bool Concluida { get; set; } = false;
        public Guid UsuarioId { get; set; }
    }
}