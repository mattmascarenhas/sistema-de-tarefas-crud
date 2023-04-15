using SistemaDeTarefas.Enums;

namespace SistemaDeTarefas.Models {
    public class TarefaModel {
        public int Id { get; set; }
        public String? Nome { get; set; }
        public String? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
    }
}
