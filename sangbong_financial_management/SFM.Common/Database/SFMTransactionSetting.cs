using System.Transactions;

namespace sangbong_financial_management.SFM.Common.Database
{
    public static class SFMTransactionSetting
    {
        public static TransactionScope BeginTran()
        {
            var options = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TransactionManager.DefaultTimeout
            };
            return new TransactionScope(TransactionScopeOption.Required, options); ;
        }
    }
}
