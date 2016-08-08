using System.ComponentModel.DataAnnotations;

namespace SistemaEstoqueVendas.Models
{
    [MetadataType(typeof(ProdutoModel))]
    public partial class Produto
    {
    }

    public class ProdutoModel
    {
        [Required(ErrorMessage ="O produto deve conter um nome!!!")]
        [StringLength(80, ErrorMessage ="O nome não pode ter mais que 80 caracteres!!!")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Digite a quantidade de produto em uma caixa!!!")]
        public int QuantCaixa{ get; set; }

        [Required(ErrorMessage ="A quantidade deve ser informada!!!")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage ="Digite o valor unitario do produto!!!")]
        public double Valor { get; set; }

        [Required(ErrorMessage ="O Campo fornecedor não pode ficar em branco!!!")]
        public int FornecedorId { get; set; }
    }
}