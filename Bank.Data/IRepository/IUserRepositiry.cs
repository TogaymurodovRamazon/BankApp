using Bank.Domain.Entity;

namespace Bank.Data.IRepository;

public interface IUserRepositiry
{
    public void Add(Users users);
    public List<Users> GetAll();
    public void Delete(int Id);
    public void Update(int Id, Users users);
}