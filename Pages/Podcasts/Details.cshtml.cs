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
    public class DetailsModel : PageModel
    {
        private readonly PodcastsWeb.Data.PodcastsWebContext _context;

        public DetailsModel(PodcastsWeb.Data.PodcastsWebContext context)
        {
            _context = context;
        }

        public Podcast Podcast { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Podcast = await _context.Podcast.FirstOrDefaultAsync(m => m.ID == id);

            if (Podcast == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
