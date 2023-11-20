using ImageStorageTesting.Data;
using ImageStorageTesting.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ImageStorageTesting.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ImgDbContext dbContext;

        public IndexModel(ILogger<IndexModel> logger, ImgDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        [BindProperty]
        public List<Profile> Profiles { get; set; }

        [BindProperty]
        public List<string> Images { get; set; }

        public async Task<IActionResult> OnGet()
        {
            if (dbContext.Profiles != null)
            {
                Profiles = await dbContext.Profiles.ToListAsync();
                Images = new List<string>();

                foreach(var profile in Profiles)
                {
                    string imageData = string.Format("data:image/jpg;base64, {0}", profile.ImgData);
                    Images.Add(imageData);
                }
            }

            return Page();
        }
    }
}
