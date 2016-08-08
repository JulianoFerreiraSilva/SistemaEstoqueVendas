using System.ComponentModel.DataAnnotations;

namespace SistemaEstoqueVendas.Models
{
    [MetadataType(typeof(FornecedorModel))]
    public partial class Fonecedor
    {
    }

    public class FornecedorModel
    {
        public int Id { get; set; }        
   
        [Required(ErrorMessage = "O nome do fornecedor deve ser preenchido!!!")]
        [StringLength(80,ErrorMessage = "O tamanho maximo do nome é de 80 cacteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O endereço do fornecedor não pode ficar em branco!!!")]
        [StringLength(80, ErrorMessage = "A descrição do endereço esta muito grande. Abrevie um pouco!!!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O fornecedor não pode estar sem numero de telefone!!!")]
        [StringLength(14, ErrorMessage = "Digite o numero corretamente, contendo não mais que 14 numeros!!!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Digite o Email do fornecedor!!!")]
        [StringLength(60, ErrorMessage = "O email não pode conter mais que 60 caracteres!!!")]
        [EmailAddress(ErrorMessage = "Email esta digitado em formato errado, verifique!!!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O fornecedor deve conter CPF ou CNPJ!!!")]
        [StringLength(14, ErrorMessage = "O numero do documento não pode conter mais que 14 caracteres!!!")]
        public string CNPJ { get; set; }
    }
}