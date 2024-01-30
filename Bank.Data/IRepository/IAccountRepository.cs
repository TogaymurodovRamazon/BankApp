using Bank.Domain.Entity;

namespace Bank.Data.IRepository;

public interface IAccountRepository
{
    public void Add(AccountNumber accountNumber);
    public List<AccountNumber> GetAll();
    public void Delete(int Id);
    public void Update(int Id, AccountNumber accountNumber);
}