using System.ComponentModel.DataAnnotations;

namespace IPB2.MVCwithHtml.Models;

public class OrderRequest
{
    [Required]
    [StringLength(80)]
    public string? CustomerName { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    public string? ShoeStyle { get; set; }

    [Required]
    public string? Size { get; set; }

    [StringLength(300)]
    public string? Notes { get; set; }
}
