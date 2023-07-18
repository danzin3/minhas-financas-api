using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class FinancialAssets : IMainModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public TypesValue TypeValue { get; set; }
        public bool IsProjection { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string? BankName { get; set; }
        public string? Notes { get; set; }
    }
}
