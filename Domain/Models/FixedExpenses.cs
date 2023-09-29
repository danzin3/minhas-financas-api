using Domain.Models.Base;

namespace Domain.Models
{
    public class FixedExpenses : IMainModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal EstimatedValue { get; set; }
        public int QuantAlreadyPaid { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Status { get; set; }
        public string? Notes { get; set; }
        public ICollection<ExpensesChangeValues> ValueChanges { get; set; }
    }
}
