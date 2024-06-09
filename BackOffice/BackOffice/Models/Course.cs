using BackOffice.Client.Pages;
using System.Diagnostics;

namespace BackOffice.Models;

public class Course
{
    public string? Id { get; set; }
    public string? ImageUri { get; set; }
    public string? ImageHeaderUri { get; set; }
    public bool IsBestseller { get; set; }
    public bool IsDigital { get; set; }
    public string[]? Categories { get; set; }
    public string? Title { get; set; }
    public string? Ingress { get; set; }
    public decimal StarRating { get; set; }
    public string? Reviews { get; set; }
    public string? Likes { get; set; }
    public string? LikesInProcent { get; set; }
    public string? Hours { get; set; }
    public virtual List<Author>? Authors { get; set; } = new List<Author>();
    public virtual Prices? Prices { get; set; } = new Prices();
    public virtual Content? Content { get; set; } = new Content();
}
