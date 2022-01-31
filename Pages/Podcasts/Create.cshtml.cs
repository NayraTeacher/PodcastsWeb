using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PodcastsWeb.Data;
using PodcastsWeb.Models;

namespace PodcastsWeb.Pages.Podcasts
{
    public class CreateModel : PageModel
    {
        private readonly PodcastsWeb.Data.PodcastsWebContext _context;

        public CreateModel(PodcastsWeb.Data.PodcastsWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Podcast Podcast { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Podcast.Add(Podcast);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
