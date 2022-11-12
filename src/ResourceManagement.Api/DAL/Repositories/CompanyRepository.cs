using Microsoft.EntityFrameworkCore;
using ResourceManagement.Api.Entities;
using ResourceManagement.Api.Repositories;

namespace ResourceManagement.Api.DAL.Repositories;

public class CompanyRepository: ICompanyRepository
{
    private readonly ResourceManagementDbContext _context;
    private readonly DbSet<Company> _companies;

    public CompanyRepository(ResourceManagementDbContext context)
    {
        _context = context;
        _companies = _context.Companies;
    }

    public async Task AddCompany(Company company)
    {
        await _companies.AddAsync(company);
        await _context.SaveChangesAsync();
    }

    public async Task<Company> GetCompanyById(Guid id)
        => await _companies
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == id);

    public async Task<Company> GetCompanyByName(string name)
        => await _companies
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Name == name);

    public async Task<IEnumerable<Company>> GetCompanies()
        => await _companies
            .AsNoTracking()
            .ToListAsync();

    public async Task<IEnumerable<Employee>> GetEmployeesForCompany(Guid companyId)
    {
        var company = await GetCompanyById(companyId);
        return company.Employees;
    }
}