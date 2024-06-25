namespace Kolokwium2poprawa.DTOs;

public class GetClientsDTO
{
    
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}

public class GetCarRentalDTO{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int CarId { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
    public int TotalPrice { get; set; }
    public int Discount { get; set; }
}