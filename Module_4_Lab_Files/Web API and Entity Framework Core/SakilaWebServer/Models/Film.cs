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
        public int Release_Year { get; set; }
        public int Language_ID { get; set; }
        public string Original_Language_ID { get; set; }
        public int Rental_Duration { get; set; }
        public double Rental_Rate { get; set; }
        public int Length { get; set; }
        public double Replacement_Cost { get; set; }
        public string Rating { get; set; }
        public string Special_Features { get; set; }
        public DateTime Last_Update { get; set; }
    }
}