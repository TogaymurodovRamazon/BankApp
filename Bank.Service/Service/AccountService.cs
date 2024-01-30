using Bank.Data.IRepository;
using Bank.Data.Repository;
using Bank.Domain.Entity;
using Bank.Service.IService;

namespace Bank.Service.Service;

public class AccountService:IAccountService
{
    private readonly IAccountRepository _repository;

    public AccountService()
    {
        _repository = new AccountRepository();
    }

    public void Add(AccountNumber accountNumber)
        =>_repository.Add(accountNumber);

    public List<AccountNumber> GetAll()
        =>_repository.GetAll();

    public void Delete(int Id)
        =>_repository.Delete(Id);

    public void Update(int Id, AccountNumber accountNumber)
        =>_repository.Update(Id, accountNumber);
}