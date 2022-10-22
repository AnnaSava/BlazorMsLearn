using Microsoft.AspNetCore.Components;

namespace TodoListServer
{
    // https://learn.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-6.0
    // Section Specify a base class
    public class BlazorRocksBase : ComponentBase
    {
        public string BlazorRocksText { get; set; } =
            "Blazor rocks the browser!";
    }
}
