using ImageStorageTesting.Data;
using ImageStorageTesting.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageStorageTesting.Pages;

public class UploadImgModel : PageModel
{
    private readonly ImgDbContext dbContext;

    public UploadImgModel(ImgDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [BindProperty]
    public Profile ProfileData {  get; set; }

    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task<IActionResult> OnPost()
    {
        byte[]? bytes = null;

        if (ProfileData.ImageFile != null)
        {
            using (Stream fs = ProfileData.ImageFile.OpenReadStream())
            {
                using BinaryReader br = new(fs);
                bytes = br.ReadBytes((int)ProfileData.ImageFile.Length);
            }
            ProfileData.ImgData = Convert.ToBase64String(bytes,0,bytes.Length);

            ProfileData.ImgFileName = ProfileData.ImageFile.FileName;

            await dbContext.AddAsync(ProfileData);
            await dbContext.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
