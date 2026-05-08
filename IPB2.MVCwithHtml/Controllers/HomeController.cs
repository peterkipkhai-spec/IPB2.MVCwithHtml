using System.Diagnostics;
using IPB2.MVCwithHtml.Models;
using Microsoft.AspNetCore.Mvc;

namespace IPB2.MVCwithHtml.Controllers;

public class HomeController : Controller
{
    private static readonly IReadOnlyList<ShoeProduct> Products =
    [
        new ShoeProduct
        {
            Name = "Slice Runner Pro",
            Category = "Running",
            Description = "Lightweight daily trainers with breathable mesh and responsive foam for morning miles.",
            Color = "#f97316",
            AccentColor = "#111827",
            Price = 89.99m,
            IsFeatured = true
        },
        new ShoeProduct
        {
            Name = "Slice Street Court",
            Category = "Lifestyle",
            Description = "Clean court-inspired sneakers made for campus, workdays, and weekend outfits.",
            Color = "#2563eb",
            AccentColor = "#f8fafc",
            Price = 74.99m,
            IsFeatured = true
        },
        new ShoeProduct
        {
            Name = "Slice Trail Grip",
            Category = "Outdoor",
            Description = "Durable trail shoes with rugged traction, toe protection, and all-day comfort.",
            Color = "#16a34a",
            AccentColor = "#1f2937",
            Price = 109.99m,
            IsFeatured = false
        },
        new ShoeProduct
        {
            Name = "Slice Flex Knit",
            Category = "Training",
            Description = "Flexible workout shoes with a sock-like knit upper for gym sessions and active days.",
            Color = "#7c3aed",
            AccentColor = "#fef3c7",
            Price = 64.99m,
            IsFeatured = false
        }
    ];

    public IActionResult Index()
    {
        return View(CreateViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Order([Bind(Prefix = "Order")] OrderRequest order)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", CreateViewModel(order));
        }

        ModelState.Clear();
        return View("Index", CreateViewModel(new OrderRequest(), orderSubmitted: true));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private static ShoeStoreViewModel CreateViewModel(OrderRequest? order = null, bool orderSubmitted = false)
    {
        return new ShoeStoreViewModel
        {
            Products = Products,
            Order = order ?? new OrderRequest(),
            OrderSubmitted = orderSubmitted
        };
    }
}
