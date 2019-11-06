using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JeffThings.Domains
{
    public partial class Jogos
    {
        public Jogos()
        {
            JogosPlataformas = new HashSet<JogosPlataformas>();
        }

        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataLancamento { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public decimal Preco { get; set; }
        [Required]
        public bool Coop { get; set; }

        public byte TiposJogosId { get; set; }

        public TiposJogos TiposJogos { get; set; }
        public ICollection<JogosPlataformas> JogosPlataformas { get; set; }
    }
}
