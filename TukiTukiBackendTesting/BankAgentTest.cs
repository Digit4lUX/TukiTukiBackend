using Microsoft.AspNetCore.Mvc;
using TukiTukiBackend.Controllers;
using TukiTukiBackend.Models;
using TukiTukiBackend.Services;

namespace TukiTukiBackendTesting;

public class BankAgentTest
{
    private readonly BankAgentController _bankAgentController;
    private readonly BankAgentService _bankAgentService;
    
    public BankAgentTest()
    {
        _bankAgentService = new BankAgentService();
        _bankAgentController = new BankAgentController(_bankAgentService);
    }
    
    [Fact]
    public void GetBankAgentTest()
    {
        var result = _bankAgentController.getAll();
        Assert.IsType<OkObjectResult>(result.Result);
    }

    [Fact]
    public void RegisterBankAgentTest()
    {
        BankAgent bankAgent = new BankAgent();
        bankAgent.title = "BCP";
        bankAgent.location = "Lima, Surco";
        var result = _bankAgentController.create(bankAgent);
        Assert.IsType<CreatedResult>(result.Result);
    }
}