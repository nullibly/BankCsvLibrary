namespace BankingCsv.Common
{
    public interface ITransactionMapper
    {
        Transaction MapTransaction(string line);
    }
}
