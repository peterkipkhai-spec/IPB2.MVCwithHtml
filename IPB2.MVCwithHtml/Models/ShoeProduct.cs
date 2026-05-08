namespace IPB2.MVCwithHtml.Models;

public class ShoeProduct
{
    public required string Name { get; init; }

    public required string Category { get; init; }

    public required string Description { get; init; }

    public required string Color { get; init; }

    public required string AccentColor { get; init; }

    public decimal Price { get; init; }

    public bool IsFeatured { get; init; }
}
