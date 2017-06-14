using System;

namespace BankingCsv.Common
{
    public class Transaction
    {
        public DateTime PostingDate { get; set; }
        public string ReferenceNumber { get; set; }
        public string Payee { get; set; }
        public string Address { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
