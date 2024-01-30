using Bank.Domain.Entity;

namespace Bank.Service.IService;

public interface IAccountService
{
    public void Add(AccountNumber accountNumber);
    public List<AccountNumber> GetAll();
    public void Delete(int Id);
    public void Update(int Id, AccountNumber accountNumber);
}