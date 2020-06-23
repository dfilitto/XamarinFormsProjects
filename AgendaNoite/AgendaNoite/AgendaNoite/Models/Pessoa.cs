using SQLite;

namespace AgendaNoite.Models
{
    [Table("Contato")]
    public class Pessoa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250), Unique]
        public string Nome { get; set; }
        [MaxLength(250), Unique]
        public string Email { get; set; }
        [MaxLength(250), Unique]
        public string Celular { get; set; }
    }
}