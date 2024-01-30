using Bank.Domain.Common;

namespace Bank.Domain.Entity;

public class Users:Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public int AccountId { get; set; }
    public int BankId { get; set; }
}