using Domain.Enums;
using Domain.Models.Base;

namespace Domain.Models
{
    public class FinancialAssets : IMainModel
    {
        public FinancialAssets(string _Name)
        {
            Name = _Name;
        }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal CurrentValue { get; set; }
        public TypesValue TypeValue { get; set; }
        public bool IsProjection { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string? BankName { get; set; }
        public string? Notes { get; set; }
    }
}
