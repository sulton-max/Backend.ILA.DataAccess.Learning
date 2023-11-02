using Microsoft.AspNetCore.Mvc;

namespace Proxy.Api.Test.Controllers;

[ApiController]
public class ProxyController : ControllerBase
{
    private readonly IHttpClientFactory _clientFactory;

    public ProxyController(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }
    
    public async ValueTask<IActionResult> Proxy()
    {
        var client = _clientFactory.CreateClient();
    }
    
    
}