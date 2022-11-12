using Microsoft.AspNetCore.Mvc;
using ResourceManagement.Api.DTO;
using ResourceManagement.Api.Entities;
using ResourceManagement.Api.Repositories;

namespace ResourceManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CompaniesController: ControllerBase
{
  private readonly ICompanyRepository _companyRepository;

  public CompaniesController(ICompanyRepository companyRepository)
  {
    _companyRepository = companyRepository;
  }

  [HttpPost]
  public async Task<IActionResult> AddCompany(CompanyDto company)
  {

    await _companyRepository.AddCompany(new Company(company.Id, company.Name, company.Description,
      company.Address1, company.City, company.State, company.Country, company.Email, company.Phone));
    
    return Ok(company.Id);
  }

  [HttpGet("{id:guid}") ]
  public async Task<IActionResult> GetCompany(Guid id)
  {
    var c = await _companyRepository.GetCompanyById(id);
    return Ok(c);
  }
  
  [HttpGet]
  public async Task<IActionResult> GetCompanies()
  {
    var c = await _companyRepository.GetCompanies();
    return Ok(c);
  }
  

}