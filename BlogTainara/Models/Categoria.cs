using System.ComponentModel.DataAnnotations;

namespace BlogTainara.Models;

    public class Categoria
    {
     public int Id { get; set; }
     
     [Required]
     [StringLength(30)]
     public string Nome { get; set; }   

     public Categoria (){

     }

     public Categoria (int id, string nome){
        Id = id;
        Nome = nome;
        // não pode ter outro id e string, não pode ser igual.
     }
    }
