using System.ComponentModel.DataAnnotations;
namespace SgbProject.Models
{
    public class Baixa
    {
        //public Baixa(Bovino bovino, string motivo)
        //{
        //    Id = Guid.NewGuid();
        //    IdBovino = bovino.Id;
        //    Motivo = motivo;
        //    DataBaixa = DateTime.Now;
        //    IdUsuario = Guid.Parse("0CD60E1E-DC47-427D-B95C-2B58C4C65ACB"); //meu usuario
        //    Apelido = bovino.Apelido;
        //    AnoNascimento = bovino.AnoNascimento;
        //    Genitora = bovino.Genitora;
        //    IdMaterno = bovino.IdMaterno;
        //    IdPaterno = bovino.IdPaterno;
        //    MesNascimento = bovino.MesNascimento;
        //    QtdCria = bovino.QtdCria;
        //    Raca = bovino.Raca;
        //    Sexo = bovino.Sexo;
        //}

        [Key]
        public Guid Id { get; set; }
        public Guid IdBovino { get; set; }
        public string Motivo { get; set; }
        public Guid IdUsuario { get; set; }
        public DateTime DataBaixa { get; set; }
        public string Apelido { get; set; }
        public string Sexo { get; set; }
        public string Raca { get; set; }
        public string IdMaterno { get; set; }
        public string IdPaterno { get; set; }
        public int MesNascimento { get; set; }
        public int AnoNascimento { get; set; }
        public bool Genitora { get; set; }
        public int QtdCria { get; set; }
    }
}
