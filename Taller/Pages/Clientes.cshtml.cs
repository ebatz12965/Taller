using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Taller.Pages;

public class ClienteModel : PageModel
{
    private readonly ILogger<ClienteModel> _logger;
    
    public ClienteModel(ILogger<ClienteModel> logger)
    {
        _logger = logger;
    }
    public void OnGet()
    {
        
    }
}