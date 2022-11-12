using ResourceManagement.Api.Entities;

namespace ResourceManagement.Api.Repositories;

public interface IEmployeeRepository
{
    Task<Employee> GetEmployeeById(Guid id);
    Task<IEnumerable<Employee>> GetEmployees();
    Task AddEmployee(Employee emp);
}