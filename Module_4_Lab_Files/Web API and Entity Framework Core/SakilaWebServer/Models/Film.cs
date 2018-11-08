using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SakilaWebServer.Models
{
    public class Film
    {
        [Key]
        public int Film_ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Release_Year { get; set; }
        public string Language_ID { get; set; }
        public string Original_Language_ID { get; set; }
        public string Rental_Duration { get; set; }
        public string Rental_Rate { get; set; }
        public string Length { get; set; }
        public string Replacement_Cost { get; set; }
        public string Rating { get; set; }
        public string Special_Features { get; set; }
        public string Last_Update { get; set; }
    }
}