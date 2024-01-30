using Bank.Data.DBContext;
using Bank.Data.IRepository;
using Bank.Domain.Entity;
using Npgsql;

namespace Bank.Data.Repository;

public class UserRepository:IUserRepositiry
{
    //--------------------Add-------------------------
    public void Add(Users users)
    {
        DBcontext.Connection.Open();
        using (NpgsqlCommand comm=new NpgsqlCommand("insert into userinfo values (@Id,@FirstName,@LastName,@Age,@Password,@PhoneNumber,@AccountId,@BankId)",DBcontext.Connection))
        {
            comm.Parameters.AddWithValue("Id", users.Id);
            comm.Parameters.AddWithValue("FirstName", users.FirstName);
            comm.Parameters.AddWithValue("LastName", users.LastName);
            comm.Parameters.AddWithValue("Age", users.Age);
            comm.Parameters.AddWithValue("Password", users.Password);
            comm.Parameters.AddWithValue("PhoneNumber", users.PhoneNumber);
            comm.Parameters.AddWithValue("AccountId", users.AccountId);
            comm.Parameters.AddWithValue("BankId", users.BankId);
            comm.ExecuteNonQuery();
        }
        DBcontext.Connection.Close();
    }
  //---------------------------GetAll------------------------
    public List<Users> GetAll()
    {
      DBcontext.Connection.Open();
      List<Users> usersList = new List<Users>();
      using (NpgsqlCommand comm=new NpgsqlCommand("select * from userinfo ",DBcontext.Connection))
      {
          var read = comm.ExecuteReader();
          while (read.Read())
          {
              Users users = new Users()
              {
                  Id = read.GetInt32(0),
                  FirstName = read.GetString(1),
                  LastName = read.GetString(2),
                  Age = read.GetInt32(3),
                  Password = read.GetString(4),
                  PhoneNumber = read.GetString(5),
                  AccountId = read.GetInt32(6),
                  BankId = read.GetInt32(7)
              };
              usersList.Add(users);
          }
      }
      DBcontext.Connection.Close();
      return usersList;
    }
  //--------------------------Delete--------------------------
    public void Delete(int Id)
    {
       DBcontext.Connection.Open();
       using (NpgsqlCommand comm=new NpgsqlCommand("delete from userinfo where Id=@Id",DBcontext.Connection))
       {
           comm.Parameters.AddWithValue("Id", Id);
           comm.ExecuteNonQuery();
       }
       DBcontext.Connection.Close();
    }
  //----------------------------Update-----------------------------
    public void Update(int Id, Users users)
    {
        DBcontext.Connection.Open();
        using (NpgsqlCommand com=new NpgsqlCommand("update userinfo Set FirstName=@FirstName,LastName=@Lastname,Age=@Age,Password=@Password,PhoneNumber=@PhoneNumber,AccountId=@AccountId,BankId=@BankId where Id=@Id ",DBcontext.Connection))
        {
            com.Parameters.AddWithValue("Id", Id);
            com.Parameters.AddWithValue("FirstName", users.FirstName);
            com.Parameters.AddWithValue("LastName", users.LastName);
            com.Parameters.AddWithValue("Age", users.Age);
            com.Parameters.AddWithValue("Password", users.Password);
            com.Parameters.AddWithValue("PhoneNumber", users.PhoneNumber);
            com.Parameters.AddWithValue("AccountId", users.AccountId);
            com.Parameters.AddWithValue("BankId", users.BankId);
            com.ExecuteNonQuery();
        }
        DBcontext.Connection.Close();
    }
}