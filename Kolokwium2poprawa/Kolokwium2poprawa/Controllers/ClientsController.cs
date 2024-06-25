using System.Transactions;
using Kolokwium2poprawa.DTOs;
using Kolokwium2poprawa.Models;
using Kolokwium2poprawa.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2poprawa.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase
{
    private readonly IDbService _dbService;
    public ClientsController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    [HttpPost("{clientID}/carRentals")]
    public async Task<IActionResult> AddNewOrder(int clientID, AddNewCarRentalDTO newCarRental)
    {
        if (!await _dbService.DoesClientExist(clientID))
            return NotFound($"Client with given ID - {clientID} doesn't exist");

        var carRental = new CarRental()
        {
                ClientId = clientID;
                
   
        };
    
        var carRentals = new List<CarRental>();
        
    
        using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
        {
            await _dbService.AddCarRental();
            await _dbService.AddNewClient(Client new Client())
    
            scope.Complete();
        }
    
        
    }
}