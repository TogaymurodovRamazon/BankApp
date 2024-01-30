using Bank.Domain.Common;

namespace Bank.Domain.Entity;

public class BankModel:Auditable
{
    public string Name { get; set; }
}