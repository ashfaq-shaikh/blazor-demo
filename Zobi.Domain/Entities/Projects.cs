using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Zobi.Domain.Entities
{
    [Table("Projects")]
    public class Projects
    {
        [Key] public int Id { get; set; }
        public string Ref { get; set; }
        public bool Auth { get; set; }
        public string Stage { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Status_Date { get; set; }
        public string BRAG { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Lead { get; set; }
        public string SRO { get; set; }
        public string FY { get; set; }
        public decimal? Influencable_Spend { get; set; }
        public decimal? Annual_Forecast { get; set; }
        public decimal? In_Year_Forecasr { get; set; }
        public string Lever { get; set; }

    }
}
