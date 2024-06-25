using Kolokwium2poprawa.Data;
using Kolokwium2poprawa.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2poprawa.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public Task<ICollection<Client>> GetClientData(int clientID)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DoesClientExist(int clientID)
    {
        return await _context.Clients.AnyAsync(e => e.Id == clientID);
    }

    public Task<bool> DoesCarExist(int carID)
    {
        throw new NotImplementedException();
    }

    public Task AddNewClient(Client client)
    {
        throw new NotImplementedException();
    }

    public Task AddCarRental(IEnumerable<CarRental> carRentals)
    {
        throw new NotImplementedException();
    }
}