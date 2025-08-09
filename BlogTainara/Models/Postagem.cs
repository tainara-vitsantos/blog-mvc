using System.ComponentModel.DataAnnotations;

namespace BlogTainara.Models;

public class Postagem
{
    public int Id { get; set; }

    [Required]
    [StringLength (100)]
    public String Nome { get; set; } 

    public int CategoriaId { get; set; }

    public Categoria Categoria { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataPostagem { get; set; }

    public string Descricao { get; set; }

    public string Texto { get; set; }

    public string Foto { get; set; }

    public string Thumbnail { get; set; }
}
