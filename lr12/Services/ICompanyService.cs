using Microsoft.EntityFrameworkCore;

namespace lr12.Services
{
    public interface ICompanyService
    {
        Task<Company> AddCompanyAsync(Company company);
        Task<IEnumerable<Company>> GetCompaniesAsync();
        Task<Company> GetCompanyByIdAsync(int companyId);
        Task UpdateCompanyAsync();
        Task DeleteCompanyAsync(int companyId);
    }
}
