using System.Collections.Generic;

namespace NativoApi.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public List<Pessoa> ObtenhaPessoas()
        {
            var pessoas = new List<Pessoa>
            {
                new Pessoa { Nome = "João", Idade = 25 },
                new Pessoa { Nome = "Maria", Idade = 18 },
                new Pessoa { Nome = "Cláudio", Idade = 30 },
                new Pessoa { Nome = "Fernando", Idade = 48 },
                new Pessoa { Nome = "Fernanda", Idade = 50 },
            };

            return pessoas;
        }
    }
}
