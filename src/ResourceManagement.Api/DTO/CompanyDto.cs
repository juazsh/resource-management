namespace ResourceManagement.Api.DTO;

public record CompanyDto(
    string Name,
    string Description,
    string Address1,
    string City,
    string State,
    string Country,
    string Email,
    string Phone)
{
    public Guid Id = Guid.NewGuid();
}