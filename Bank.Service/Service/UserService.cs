using Bank.Data.IRepository;
using Bank.Data.Repository;
using Bank.Domain.Entity;
using Bank.Service.IService;

namespace Bank.Service.Service;

public class UserService:IUserService
{
    private readonly IUserRepositiry _repositiry;

    public UserService()
    {
        _repositiry = new UserRepository();
    }

    public void Add(Users users)
        =>_repositiry.Add(users);

    public List<Users> GetAll()
        => _repositiry.GetAll();

    public void Delete(int Id)
        => _repositiry.Delete(Id);

    public void Update(int Id, Users users)
        => _repositiry.Update(Id, users);
}