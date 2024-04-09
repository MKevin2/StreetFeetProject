namespace Projeto3DS.Models
{
    public class Tenis{ 
        public string desc_curta { get; set; }
        public string desc_detalhe { get; set; }
        public bool em_estoque { get; set; }
        public int tenis_id { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }
        public string img_url { get; set; }
        public string tenis_preferido { get; set; }
        public string img_miniatura { get; set; }
        public int categoria_id { get; set; }
        public virtual Categoria categoria { get; set; }
    }
}


