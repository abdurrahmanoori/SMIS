namespace SMIS.Domain.Enums
{
    public enum TransactionType
    {
        // Invoice types
        Sale = 1,
        Purchase = 2,
        Return = 3,
        
        // Payment types
        CashPayment = 4,
        CreditPayment = 5,
        
        // Credit operations
        CreditIssued = 6,
        CreditAdjustment = 7
    }
}
