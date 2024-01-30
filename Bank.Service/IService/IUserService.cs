using Bank.Domain.Entity;

namespace Bank.Service.IService;

public interface IUserService
{
    public void Add(Users users);
    public List<Users> GetAll();
    public void Delete(int Id);
    public void Update(int Id, Users users);
}