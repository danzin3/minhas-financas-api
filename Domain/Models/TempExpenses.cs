﻿namespace Domain.Models
{
    public class TempExpenses
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int QuantAlreadyPaid { get; set; }
        public int Splits { get; set; }
        public DateTime? NextDueDate { get; set; }
        public bool Status { get; set; }
        public string? Notes { get; set; }
    }
}
