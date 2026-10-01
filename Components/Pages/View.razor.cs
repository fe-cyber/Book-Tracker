using BookTracker.Data;
using BookTracker.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace BookTracker.Components.Pages;

public partial class View
{
    [Inject]
    private AppDbContext Db { get; set; } = default!;

    private List<Book>? books;

    protected override async Task OnInitializedAsync()
    {
        books = await Db.Books.ToListAsync();
    }
}