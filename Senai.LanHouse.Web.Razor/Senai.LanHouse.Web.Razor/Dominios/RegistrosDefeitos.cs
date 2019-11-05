using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.LanHouse.Web.Razor.Dominios
{
    public partial class RegistrosDefeitos
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data do Defeito")]
        [Required]
        public DateTime DataDefeito { get; set; }

        [Display(Name = "Tipo de Equipamento")]
        public int TiposEquipamentosId { get; set; }

        [Display(Name = "Tipo de Defeito")]
        public int TiposDefeitosId { get; set; }
        public string Observação { get; set; }

        [Display(Name = "Tipo de Defeito")]
        public TiposDefeitos TiposDefeitos { get; set; }
        [Display(Name = "Tipo de Equipamento")]
        public TiposEquipamentos TiposEquipamentos { get; set; }
    }
}
