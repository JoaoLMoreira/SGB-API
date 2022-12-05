using System.ComponentModel.DataAnnotations;
namespace SgbProject.Models

{
    public class Vacina
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdBonivo { get; set; }
        public string Doenca { get; set; }
        public string Marca { get; set; }
        public string nLote { get; set; }
        public int mesVencimento { get; set; }
        public int anoVenciomento { get; set; }
        public int mesFabricacao { get; set; }
        public int anoFabrcacao { get; set; }
        public DateTime dataVacinacao { get; set; }


    }
}
