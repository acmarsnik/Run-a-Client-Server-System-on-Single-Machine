using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class City
    {
        [Key, Column("ID")]
        public int ID { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("CountryCode")]
        public string CountryCode { get; set; }
        [Column("District")]
        public string District { get; set; }
        [Column("Population")]
        public int Population { get; set; }
    }
}
