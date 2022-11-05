using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

public static class JsInteropExtentions
{
    public static async Task TriggerClickEvent(this ElementReference elementRef, IJSRuntime js)
    {
        await js.InvokeVoidAsync("interopFunctions.clickElement", elementRef);
    }

    public static ValueTask<T> GenericMethod<T>(this ElementReference elementRef, IJSRuntime js)
    {
        return js.InvokeAsync<T>("interopFunctions.clickElement", elementRef);
    }
}

