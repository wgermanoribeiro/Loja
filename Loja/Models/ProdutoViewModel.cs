using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class ProdutoViewModel
    {
        [Key]
        public int ID { get; set; }
        
        [Required(ErrorMessage ="Preenchimento obrigatório")]
        [StringLength(30, ErrorMessage = "Limite máximo de 30 caracteres"), MinLength(3, ErrorMessage = "Limite minimo de 3 caracteres")]
        [Display(Name ="Nome do Produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(256, ErrorMessage ="Limite máximo de 256 caracteres"), MinLength(10, ErrorMessage = "Limite minimo de 10 caracteres")]
        [Display(Name = "Descrição do Produto")]
        public string Descricao { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name ="Data de Validade do Produto")]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório (zero aceitavel)")]
        [Display(Name = "Valor do Produto")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório (zero aceitavel)")]
        [Display(Name = "Quantidade do Produto no Estoque")]
        public int Estoque { get; set; }
    }
}
