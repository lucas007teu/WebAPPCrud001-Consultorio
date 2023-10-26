using System.ComponentModel.DataAnnotations;

namespace WebAPPCrud001.Models
{
    public class Consultas
    {
        [Key]
        public int idCli { get; set; }
        public string Nome { get; set; }
        public string Horario { get; set; }
        public string Sexo { get; set; }
        public string Nascimento { get; set; }
        public string Observacoes { get; set; }
    }
}
