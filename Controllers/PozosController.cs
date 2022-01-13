using Microsoft.AspNetCore.Mvc;
using WebApp.Model;

namespace WebApp.Controllers;

[ApiController]
[Route("[controller]")]

public class PozosController : ControllerBase
{
    private readonly ILogger<PozosController> _logger;
    public PozosController(ILogger<PozosController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Pozo> Get()
    {
        Pozo pozo1 = new Pozo{
            Produccion = new List<int>{
                100, 95, 90, 85, 80, 75, 70, 65, 60, 55, 50, 45
            },
            Precio = 70,
            Inversion = 100
        };

        Pozo pozo2 = new Pozo{
            Produccion = new List<int>{
                100, 95, 90, 85, 80, 75, 70, 65, 60, 
            },
            Precio = 70,
            Inversion = 1000
        };

        List<Pozo> pozos = new List<Pozo>();
        pozos.Add(pozo1);
        pozos.Add(pozo2);
        
        return pozos;
    }
}
