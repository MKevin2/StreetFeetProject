using Microsoft.AspNetCore.Mvc;

namespace Projeto3DS.Models
{
   public class Categoria
        {
        public int categoria_id { get; set; }
        public string categoria_nome { get; set; }
        public string desc { get; set; }
        public List<Tenis> Tenis { get; set; }
        }
}
