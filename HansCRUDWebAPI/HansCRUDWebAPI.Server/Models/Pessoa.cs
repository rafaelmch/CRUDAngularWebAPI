// Rafael Hassegawa - 20/02/2024
// First step - class Pessoa (Person)

namespace HansCRUDWebAPI.Server.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; } // ID (primary key)
        public string Nome { get; set; } // first name
        public string Sobrenome { get; set; } // last name
        public int Idade { get; set; } // age
        public string Profissao { get; set; } // profession
    }
}
