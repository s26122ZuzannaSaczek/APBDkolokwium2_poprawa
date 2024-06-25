using Kolokwium2poprawa.Models;

namespace Kolokwium2poprawa.Services;

public interface IDbService
{
    Task<ICollection<Client>> GetClientData(int clientID);
    Task<bool> DoesClientExist(int clientID);
    Task<bool> DoesCarExist(int carID);
    Task AddNewClient(Client client);
    Task AddCarRental(IEnumerable<CarRental> carRentals);
}