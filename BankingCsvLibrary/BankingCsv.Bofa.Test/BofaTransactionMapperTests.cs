using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingCsv.Common;

namespace BankingCsv.Bofa.Test
{
    [TestClass]
    public class BofaTransactionMapperTests
    {
        [TestMethod]
        public void ShouldGenerateLineEntryFromString()
        {
            // Arrange
            ITransactionMapper mapper = new BofaTransactionMapper();

            // Act
            var result = mapper.MapTransaction("04/22/2017,24692167222000379509934,\"STARBUCKS STORE \",\"NEW YORK NY \",-3.19");

            // Assert
            Assert.AreEqual(new DateTime(2017, 04, 22).Date, result.PostingDate.Date);
            Assert.AreEqual("24692167222000379509934", result.ReferenceNumber);
            Assert.AreEqual("STARBUCKS STORE", result.Payee);
            Assert.AreEqual("NEW YORK NY", result.Address);
            Assert.AreEqual(3.19m, result.Amount);
            Assert.AreEqual(TransactionType.Debit, result.TransactionType);
        }
    }
}
