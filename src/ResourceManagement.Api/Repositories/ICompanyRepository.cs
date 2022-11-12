using ResourceManagement.Api.Entities;

namespace ResourceManagement.Api.Repositories;

public interface ICompanyRepository
{
    Task AddCompany(Company company);
    Task<Company> GetCompanyById(Guid id);
    Task<Company> GetCompanyByName(string id);
    Task<IEnumerable<Company>> GetCompanies();
    Task<IEnumerable<Employee>> GetEmployeesForCompany(Guid companyId);
}