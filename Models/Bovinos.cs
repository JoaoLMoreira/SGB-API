using System;
using System.ComponentModel.DataAnnotations;

namespace SgbProject.Models
{
    public class RemoveBovinoRequest
    {
        public Guid id { get; set; }
        public int Motivo { get; set; }
    }
    public class Bovino

    {
        [Key]
        public Guid Id { get; set; }
        public string Apelido { get; set; }
        public string Sexo { get; set; }
        public string Raca { get; set; }
        public string Obeservacao { get; set; }
        public string Pasto { get; set; }
        public string IdMaterno { get; set; }
        public string IdPaterno { get; set; }
        public int MesNascimento { get; set; }
        public int AnoNascimento { get; set; }
        public bool Genitora { get; set; }
        public int QtdCria { get; set; }
        public DateTime UltimaCria { get; set; }
    }
}
