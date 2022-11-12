namespace ResourceManagement.Api.Entities;

public class Employee 
{
    private Employee(){}
    public Employee(Guid id, string firstName, string lastName, string address1, string city, string state, string country, string email, string phone, 
        string role, string position, Guid companyId)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Address1 = address1;
        City = city;
        State = state;
        Country = country;
        Email = email;
        Phone = phone;
        Role = role;
        Position = position;
        CompanyId = companyId;
    }

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address1 { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public string Role { get; private set; }
    public string Position { get; private set; }
    public Guid CompanyId { get; private set; }
    
    public Company Company { get; }
}