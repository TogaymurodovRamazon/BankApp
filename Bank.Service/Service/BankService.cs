using Bank.Data.IRepository;
using Bank.Data.Repository;
using Bank.Domain.Entity;
using Bank.Service.IService;

namespace Bank.Service.Service;

public class BankService:IBankService
{
   private readonly IBankRepository _repository;

   public BankService()
   {
       _repository = new BankRepository();
   }

   public void Add(BankModel bank)
       => _repository.Add(bank);
  
   public List<BankModel> GetAll()
      =>_repository.GetAll();
  
   public void Delete(int Id)
       =>_repository.Delete(Id); 
   
   public void Update(int Id, BankModel bank)
      =>_repository.Update(Id,bank);
}