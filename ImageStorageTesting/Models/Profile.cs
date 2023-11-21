using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImageStorageTesting.Models;

public class Profile
{
    [Key]
    public int Id { get; set; }

    public string ImgFileName { get; set; }

    public string ImgData { get; set; }

    [NotMapped]
    [Display(Name = "Upload File")]
    public IFormFile ImageFile { get; set; }
}
