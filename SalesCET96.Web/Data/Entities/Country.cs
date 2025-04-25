using System.ComponentModel.DataAnnotations;

namespace SalesCET96.Web.Data.Entities
{
    public class Country
    {

        //[Key] não é necessário, pois o EF Core já considera a propriedade Id como chave primária por padrão
        public int Id { get; set; }

        [Display(Name="País")]
        [MaxLength(50,ErrorMessage ="O campo {0} deve ter no máximo {1} caracteres!")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Name { get; set; }


    }
}
