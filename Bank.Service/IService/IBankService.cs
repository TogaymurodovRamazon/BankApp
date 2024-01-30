using Bank.Domain.Entity;

namespace Bank.Service.IService;

public interface IBankService
{
    public void Add(BankModel bank);
    public List<BankModel> GetAll();
    public void Delete(int Id);
    public void Update(int Id, BankModel bank);
}