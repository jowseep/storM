﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorM.API.Models
{
    public class PaidTransactionWithoutPaidDebts
    {
        public int Id { get; set; }
        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; } = new Borrower();
        [Column(TypeName = "decimal(7,2)")]
        public decimal AmountPaid { get; set; }
        public DateTime DatePaid { get; set; }
    }
}
