using System;
using System.Collections.Generic;

namespace JeffThings.Domains
{
    public partial class Jogos
    {
        public Jogos()
        {
            JogosPlataformas = new HashSet<JogosPlataformas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Descricao { get; set; }
        public bool Coop { get; set; }
        public byte TiposJogosId { get; set; }
        public decimal? Preco { get; set; }

        public TiposJogos TiposJogos { get; set; }
        public ICollection<JogosPlataformas> JogosPlataformas { get; set; }
    }
}
