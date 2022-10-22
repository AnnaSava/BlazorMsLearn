using Microsoft.AspNetCore.Components;

namespace TodoListServer.UIInterfaces
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
