using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ExpensesChangeValues : IMainModel
    {
        public decimal OldValue { get; set; }
        public decimal NewValue { get; set; }
        public DateTime DataChange { get; set; }
    }
}
