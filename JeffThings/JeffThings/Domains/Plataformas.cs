using System;
using System.Collections.Generic;

namespace JeffThings.Domains
{
    public partial class Plataformas
    {
        public Plataformas()
        {
            JogosPlataformas = new HashSet<JogosPlataformas>();
        }

        public byte Id { get; set; }
        public string Nome { get; set; }

        public ICollection<JogosPlataformas> JogosPlataformas { get; set; }
    }
}
