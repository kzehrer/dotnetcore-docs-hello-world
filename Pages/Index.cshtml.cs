using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;

namespace dotnetcoresample.Pages;

public class IndexModel : PageModel
{

    public string OSVersion { get { return RuntimeInformation.OSDescription; }  }

    public IReadOnlyDictionary<string, string> RequestHeaders { get { return Request.Headers.ToDictionary(h => h.Key, h => h.Value.ToString()); } }

    public IReadOnlyDictionary<string, string> UserClaims { get { return User.Claims.ToDictionary(c => c.Type, c => c.Value); } }

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {        
    }
}
