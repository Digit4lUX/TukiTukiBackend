using Microsoft.AspNetCore.Mvc;
using TukiTukiBackend.Models;
using TukiTukiBackend.Services;

namespace TukiTukiBackend.Controllers;
[Route("api/[controller]")]
[ApiController]

public class BankAgentController : ControllerBase
{
    private readonly BankAgentService _bankAgentService;

    public BankAgentController(BankAgentService bankAgentService)
    {
        _bankAgentService = bankAgentService;
    }


    [HttpGet]
    public ActionResult<BankAgent> getAll()
    {
        var result = _bankAgentService.getAll();
        return Ok(result);
    }
    
    [HttpPost]
    public ActionResult<BankAgent> create(BankAgent bankAgent)
    {
        var result = _bankAgentService.create(bankAgent);
        return Created("api/agents", result);
    }
}