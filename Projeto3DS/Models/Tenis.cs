using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto3DS.Models
{
    [Table("Tenis")]
    public class Tenis{

        //Alterar os data annotations

        //referencia ao tenis id
        [Key]
        public int tenis_id { get; set; }

        //referencia ao Descrição Curta
        [Required(ErrorMessage = "O nome do tênis deve ser informado")]
        [Display(Name = "Descrição Curta")]
        [MinLength(10)]
        [MaxLength(150)]
        public string desc_curta { get; set; }

        //referencia ao Descrição Detalhada
        [Required(ErrorMessage = "O nome do tênis deve ser informado")]
        [Display(Name = "Descrição Curta")]
        [MinLength(70)]
        [MaxLength(200)]
        public string desc_detalhe { get; set; }

        //referencia ao Em Estoque
        public bool em_estoque { get; set; }


        //referencia ao Nome
        [Required(ErrorMessage = "O nome do tênis deve ser informado")]
        [Display(Name = "Nome do Tênis")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "Tamanho Inválido")]
        public string nome { get; set; }

        //referencia ao Preço
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99)]
        public decimal preco { get; set; }

        //referencia a img_url
        public string img_url { get; set; }
        [NotMapped]

        //referencia ao Tenis favorito
        public string tenis_preferido { get; set; }

        //referencia ao imagem miniatura
        public string img_miniatura { get; set; }

        //referencia ao categoria
        public string Categoria { get; set; }

        //referencia ao Categoria id
        public int categoria_id { get; set; }

        [NotMapped]
        public virtual Categoria categoria { get; set; }
    }
}


