var builder = WebApplication.CreateBuilder();
var app = builder.Build();
app.MapGet("/", async context => {
    context.Respone.Redirect("/Home");
    });

app.Run();


catatan 
Home.cshtml di folder Pages.
@page
@model HomeModel
@{
    ViewData["Title"] = "Home";
}

<h1>Welcome to the Home Page</h1>
<p>This page includes a reusable component below:</p>

<!-- Include Component -->
@await Html.PartialAsync("Components/HelloWorld")

...
Home.cshtml.cs di folder Pages:
using Microsoft.AspNetCore.Mvc.RazorPages;

public class HomeModel : PageModel
{
    public void OnGet()
    {
    }
}

...
@* Components/HelloWorld.cshtml *@
<div style="border: 1px solid #ccc; padding: 10px; margin: 10px 0;">
    <h2>Hello, World!</h2>
    <p>This is a reusable component.</p>
</div>
