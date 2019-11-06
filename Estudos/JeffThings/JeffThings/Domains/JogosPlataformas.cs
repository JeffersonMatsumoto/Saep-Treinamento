using System;
using System.Collections.Generic;

namespace JeffThings.Domains
{
    public partial class JogosPlataformas
    {
        public int Id { get; set; }
        public int IdJogo { get; set; }
        public byte IdPlataforma { get; set; }

        public Jogos IdJogoNavigation { get; set; }
        public Plataformas IdPlataformaNavigation { get; set; }
    }
}
