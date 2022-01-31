using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PodcastsWeb.Models
{
    public class Podcast
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name= "Recorded Date")]
        [DataType(DataType.Date)]
        public DateTime RecordedDate { get; set; }
        public string Serie { get; set; }

        [Column(TypeName = "decimal(18,2")]
        public decimal Duration { get; set; }
    }
}
