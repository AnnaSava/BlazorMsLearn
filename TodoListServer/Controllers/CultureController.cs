using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]/[action]")]
public class CultureController : Controller
{
    public IActionResult Set(string culture, string redirectUri)
    {
        if (culture != null)
        {
            HttpContext.Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(
                    new RequestCulture(culture, culture)));
        }


        // Use the LocalRedirect action result to prevent open redirect attacks.
        // For more information, see Prevent open redirect attacks in ASP.NET Core https://learn.microsoft.com/en-us/aspnet/core/security/preventing-open-redirects?view=aspnetcore-6.0.
        return LocalRedirect(redirectUri);
    }
}