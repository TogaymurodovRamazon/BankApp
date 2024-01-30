
using Bank.Domain.Entity;
namespace Bank.Data.IRepository;

public interface IBankRepository
{
    public void Add(BankModel bank);
    public List<BankModel> GetAll();
    public void Delete(int Id);
    public void Update(int Id, BankModel bank);
}