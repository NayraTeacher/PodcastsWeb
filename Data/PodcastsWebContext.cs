using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PodcastsWeb.Models;

namespace PodcastsWeb.Data
{
    public class PodcastsWebContext : DbContext
    {
        public PodcastsWebContext (DbContextOptions<PodcastsWebContext> options)
            : base(options)
        {
        }

        public DbSet<PodcastsWeb.Models.Podcast> Podcast { get; set; }
    }
}
