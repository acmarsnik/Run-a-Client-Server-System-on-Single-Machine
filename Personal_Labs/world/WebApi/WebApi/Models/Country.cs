using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Country
    {
        [Key, Column("code")]
        public string Code { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("Continent")]
        public string Continent { get; set; }
        [Column("Region")]
        public string Region { get; set; }
        [Column("SurfaceArea")]
        public double SurfaceArea { get; set; }
        [Column("IndepYear")]
        public int? IndepYear { get; set; }
        [Column("Population")]
        public int Population { get; set; }
        [Column("LifeExpectancy")]
        public double? LifeExpectancy { get; set; }
        [Column("GNP")]
        public double? GNP { get; set; }
        [Column("GNPOld")]
        public double? GNPOld { get; set; }
        [Column("LocalName")]
        public string LocalName { get; set; }
        [Column("GovernmentForm")]
        public string GovernmentForm { get; set; }
        [Column("HeadOfState")]
        public string HeadOfState { get; set; }
        [Column("Capital")]
        public int? Capital { get; set; }
        [Column("Code2")]
        public string Code2 { get; set; }
    }
}
