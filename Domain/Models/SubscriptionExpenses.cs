using Domain.Models.Base;

namespace Domain.Models
{
    public class SubscriptionExpenses : IMainModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int QuantAlreadyPaid { get; set; }
        public DateTime? NextDueDate { get; set; }
        public string? Notes { get; set; }
    }
}
