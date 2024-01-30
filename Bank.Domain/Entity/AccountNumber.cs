using Bank.Domain.Common;

namespace Bank.Domain.Entity;

public class AccountNumber:Auditable
{
    public int Number { get; set; }
    public int Many { get; set; }
}