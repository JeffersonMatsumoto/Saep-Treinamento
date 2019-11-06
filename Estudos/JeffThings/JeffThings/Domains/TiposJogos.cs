using System;
using System.Collections.Generic;

namespace JeffThings.Domains
{
    public partial class TiposJogos
    {
        public TiposJogos()
        {
            Jogos = new HashSet<Jogos>();
        }

        public byte Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Jogos> Jogos { get; set; }
    }
}
