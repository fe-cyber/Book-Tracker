using BookTracker.Data;
using BookTracker.Models;
using Microsoft.AspNetCore.Components;

namespace BookTracker.Components.Pages;

public partial class Add
{
    [Inject]
    private AppDbContext Db { get; set; } = default!;

    [Inject]
    private NavigationManager Navigation { get; set; } = default!;

    private Book book = new();

    private async Task HandleSubmit()
    {
        Db.Books.Add(book);
        await Db.SaveChangesAsync();

        Navigation.NavigateTo("/");
    }
}