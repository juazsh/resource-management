namespace ResourceManagement.Api.Entities;

public class Company
{
    private Company(){}
    public Company(Guid id, string name, string description, string address1, string city, string state, string country, string email, string phone)
    {
        Id = id;
        Name = name;
        Description = description;
        Address1 = address1;
        City = city;
        State = state;
        Country = country;
        Email = email;
        Phone = phone;
    }

    
    public void AddEmployee(Employee emp)
    {
        _employees.Add(emp);
    }
    public void UpdateAddress(string newAddress)
    {
        Address1 = newAddress;
    }
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string Address1 { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }

    public IEnumerable<Employee> Employees => _employees;
    private HashSet<Employee> _employees { get; set; }

}