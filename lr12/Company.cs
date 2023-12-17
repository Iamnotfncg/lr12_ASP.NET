using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace lr12
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        [Phone]
        public string? CompanyPhone { get; set; }
        [EmailAddress]
        public string? CompanyEmail { get; set; }

        public override string ToString()
        {
            return $"CompanyId: {CompanyId}, CompanyName: {CompanyName}, CompanyDescription: {CompanyDescription}, CompanyPhone: {CompanyPhone}, CompanyEmail: {CompanyEmail}\n";
        }
    }
}
