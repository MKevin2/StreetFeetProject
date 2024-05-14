using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Projeto3DS.Models
{
   public class Categoria
        {
        //Alterar os data annotations

        //referencia ao categoria id
        [Key]
        public int categoria_id { get; set; }

        //referencia ao categoria_nome
        [StringLength(100, MinimumLength = 10)]
        [Required(ErrorMessage = "Tamanho Inválido")]
        [Display(Name = "Nome da categoria")]
        public string categoria_nome { get; set; }

        //referencia ao descrição
        [StringLength(100, MinimumLength = 10)]
        [Required(ErrorMessage = "Tamanho inválido")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public List<Tenis> Tenis { get; set; }
        }
}
