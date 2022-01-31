using System;
using System.ComponentModel.DataAnnotations;

namespace PodcastsWeb.Models
{
    public class Podcast
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime RecordedDate { get; set; }
        public string Serie { get; set; }
        public decimal Duration { get; set; }
    }
}
