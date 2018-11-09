using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class CountryLanguage
    {
        [Column("CountryCode")]
        public int CountryCode { get; set; }
        [Column("Language")]
        public string Language { get; set; }
        [Column("IsOfficial")]
        public string IsOfficial { get; set; }
        [Column("Percentage")]
        public string Percentage { get; set; }
    }
}
