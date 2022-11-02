using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class DbController : ControllerBase
{
    private IBoxService _boxService;

    public DbController(IBoxService boxService)
    {
        _boxService = boxService;
    }

    [HttpPost]
    public void CreateDatabase()
    {
        _boxService.CreateDatabase();
    }
}