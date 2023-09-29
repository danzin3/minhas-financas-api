using Domain.Models.Base;

namespace Domain.Models
{
    public class ExpensesChangeValues : IMainModel
    {
        public decimal OldValue { get; set; }
        public decimal NewValue { get; set; }
        public DateTime DataChange { get; set; }
    }
}
