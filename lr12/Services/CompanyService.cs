using Microsoft.EntityFrameworkCore;

namespace lr12.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly CompanyDbContext _dbContext;

        public CompanyService(CompanyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Company> AddCompanyAsync(Company company)
        {
            if (company == null)
                throw new ArgumentNullException(nameof(company));

            await _dbContext.Companies.AddAsync(company);
            await _dbContext.SaveChangesAsync();
            return company;
        }

        public async Task<IEnumerable<Company>> GetCompaniesAsync()
        {
            return await _dbContext.Companies.ToListAsync();
        }

        public async Task<Company> GetCompanyByIdAsync(int companyId)
        {
            return await _dbContext.Companies.FindAsync(companyId);
        }

        public async Task UpdateCompanyAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCompanyAsync(int companyId)
        {
            var companyToDelete = await _dbContext.Companies.FindAsync(companyId);
            if (companyToDelete != null)
            {
                _dbContext.Companies.Remove(companyToDelete);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
