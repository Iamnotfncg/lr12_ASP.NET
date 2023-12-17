using lr12.Services;
using Microsoft.AspNetCore.Mvc;

namespace lr12.Controllers
{

    public class HomeController
    {
        private readonly ICompanyService _companyService;

        public HomeController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [Route("/")]

        public async Task<IActionResult> Index()
        {
            var companies = new List<Company>
            {
                new Company
                {
                    CompanyName = "Company1",
                    CompanyDescription = "Description1",
                    CompanyPhone = "123-456-7890",
                    CompanyEmail = "company1@example.com"
                },
                new Company
                {
                    CompanyName = "Company2",
                    CompanyDescription = "Description2",
                    CompanyPhone = "987-654-3210",
                    CompanyEmail = "company2@example.com"
                },
                new Company
                {
                    CompanyName = "Company3",
                    CompanyDescription = "Description3",
                    CompanyPhone = "555-123-4567",
                    CompanyEmail = "company3@example.com"
                },
                new Company
                {
                    CompanyName = "Company4",
                    CompanyDescription = "Description4",
                    CompanyPhone = "444-789-0123",
                    CompanyEmail = "company4@example.com"
                },
                new Company
                {
                    CompanyName = "Company5",
                    CompanyDescription = "Description5",
                    CompanyPhone = "999-000-1111",
                    CompanyEmail = "company5@example.com"
                }
            };
            foreach (var company in companies)
            {
                await _companyService.AddCompanyAsync(company);
            }

            var companiesFromDb = await _companyService.GetCompaniesAsync();

            var result = companiesFromDb.Aggregate(string.Empty, (current, company) => current + company.ToString());

            return new ContentResult()
            {
                Content = result
            };
        }
    }
}
