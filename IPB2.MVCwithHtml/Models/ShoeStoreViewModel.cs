namespace IPB2.MVCwithHtml.Models;

public class ShoeStoreViewModel
{
    public IReadOnlyList<ShoeProduct> Products { get; init; } = [];

    public OrderRequest Order { get; init; } = new();

    public bool OrderSubmitted { get; init; }
}
