using System;
using System.Collections.Generic;

namespace JeffThings.Domains
{
    public partial class Testes
    {
        //tirei os ? DateTime? e TimeSpan?
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
    }
}
