using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class FornecedorViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(200), MaxLength(200, ErrorMessage = "Limite máximo de 200 caracteres"), MinLength(2, ErrorMessage = "Limite minimo de 2 caracteres")]
        [Display(Name = "Nome Fantasia do Fornecedor")]
        public string NomeFantasia { get; set; }
        
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(200), MaxLength(200, ErrorMessage = "Limite máximo de 200 caracteres"), MinLength(2, ErrorMessage = "Limite minimo de 2 caracteres")]
        [Display(Name = "Razão Social do Fornecedor")]
        public string RazaoSocial { get; set; }
        
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(14), MaxLength(14, ErrorMessage = "Limite máximo de 200 caracteres"), MinLength(11, ErrorMessage = "Limite minimo de 11 caracteres")]
        [Display(Name = "CNPJ / CPF do Fornecedor")]
        public string CnpjCpf { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(200), MaxLength(200, ErrorMessage = "Limite máximo de 200 caracteres"), MinLength(2, ErrorMessage = "Limite minimo de 2 caracteres")]
        [Display(Name = "Endereço do Fornecedor")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(10), MaxLength(10, ErrorMessage = "Limite máximo de 10 caracteres"), MinLength(1, ErrorMessage = "Limite minimo de 1 caracteres")]
        [Display(Name = "Numero Endereço")]
        public string NumeroEndereco { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(200), MaxLength(200, ErrorMessage = "Limite máximo de 200 caracteres"), MinLength(2, ErrorMessage = "Limite minimo de 2 caracteres")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(200), MaxLength(200, ErrorMessage = "Limite máximo de 200 caracteres"), MinLength(2, ErrorMessage = "Limite minimo de 2 caracteres")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(200), MaxLength(200, ErrorMessage = "Limite máximo de 200 caracteres"), MinLength(2, ErrorMessage = "Limite minimo de 2 caracteres")]
        [Display(Name = "Estado")]
        public string EstadoUf { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(200), MaxLength(200, ErrorMessage = "Limite máximo de 200 caracteres"), MinLength(2, ErrorMessage = "Limite minimo de 2 caracteres")]
        [Display(Name = "País")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(200), MaxLength(200, ErrorMessage = "Limite máximo de 200 caracteres"), MinLength(2, ErrorMessage = "Limite minimo de 2 caracteres")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(200), MaxLength(200, ErrorMessage = "Limite máximo de 200 caracteres"), MinLength(2, ErrorMessage = "Limite minimo de 2 caracteres")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [StringLength(200), MaxLength(200, ErrorMessage = "Limite máximo de 200 caracteres"), MinLength(2, ErrorMessage = "Limite minimo de 2 caracteres")]
        [Display(Name = "Nome Contato do Fornecedor")]
        public string NomeContatoFornecedor { get; set; }

        [StringLength(200), MaxLength(200, ErrorMessage = "Limite máximo de 200 caracteres"), MinLength(2, ErrorMessage = "Limite minimo de 2 caracteres")]
        [Display(Name = "Marca Relacionada ao Fornecedor")]
        public string MarcaRelacionada { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Cadastro do Fornecedor")]
        public DateTime DataCadastro { get; set; }

    }
}
