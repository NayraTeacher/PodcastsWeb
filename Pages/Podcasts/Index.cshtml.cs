using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PodcastsWeb.Data;
using PodcastsWeb.Models;

namespace PodcastsWeb.Pages.Podcasts
{
    public class IndexModel : PageModel
    {
        private readonly PodcastsWeb.Data.PodcastsWebContext _context;

        public IndexModel(PodcastsWeb.Data.PodcastsWebContext context)
        {
            _context = context;
        }

        public IList<Podcast> Podcast { get;set; }

        public async Task OnGetAsync()
        {
            Podcast = await _context.Podcast.ToListAsync();
        }
    }
}
