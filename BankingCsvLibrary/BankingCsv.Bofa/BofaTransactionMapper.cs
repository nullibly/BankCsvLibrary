using BankingCsv.Common;
using System;

namespace BankingCsv.Bofa
{
    public class BofaTransactionMapper : ITransactionMapper
    {
        public Transaction MapTransaction(string line)
        {
            string[] entryItems = line.Split(new[] { ',' });
            var transaction = new Transaction();
            transaction.PostingDate = DateTime.Parse(entryItems[0]);
            transaction.ReferenceNumber = entryItems[1]?.Trim();
            transaction.Payee = entryItems[2]?.Trim().StripQuotes().Trim();
            transaction.Address = entryItems[3]?.Trim().StripQuotes().Trim();
            var amount = decimal.Parse(entryItems[4]);

            transaction.Amount = Math.Abs(amount);
            transaction.TransactionType = amount < 0 ? TransactionType.Debit : TransactionType.Credit;

            return transaction;
        }
    }
}
