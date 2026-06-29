using System.ComponentModel.DataAnnotations;

namespace TesteDevCSharp.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string NomeUsuario { get; set; }

        [Required]
        public string Senha { get; set; }

        public List<Endereco> Enderecos { get; set; } = new();
    }
}