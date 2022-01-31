using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PodcastsWeb.Data;
using PodcastsWeb.Models;

namespace PodcastsWeb.Pages.Podcasts
{
    public class EditModel : PageModel
    {
        private readonly PodcastsWeb.Data.PodcastsWebContext _context;

        public EditModel(PodcastsWeb.Data.PodcastsWebContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Podcast).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PodcastExists(Podcast.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PodcastExists(int id)
        {
            return _context.Podcast.Any(e => e.ID == id);
        }
    }
}
