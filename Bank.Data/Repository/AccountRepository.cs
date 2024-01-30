using Bank.Data.DBContext;
using Bank.Data.IRepository;
using Bank.Domain.Entity;
using Npgsql;

namespace Bank.Data.Repository;

public class AccountRepository:IAccountRepository
{
    //------------------------Add------------------------
    public void Add(AccountNumber accountNumber)
    {
     DBcontext.Connection.Open();
     using (NpgsqlCommand comm =
            new NpgsqlCommand("insert into accountnumber values(@Id,@Number,@Many)", DBcontext.Connection))
     {
         comm.Parameters.AddWithValue("Id", accountNumber.Id);
         comm.Parameters.AddWithValue("Number", accountNumber.Number);
         comm.Parameters.AddWithValue("Many", accountNumber.Many);
         comm.ExecuteNonQuery();
     }
     DBcontext.Connection.Close();
    }
   //-------------------------GetAll------------------------------
    public List<AccountNumber> GetAll()
    {
       DBcontext.Connection.Open();
       List<AccountNumber> accountNumbers = new List<AccountNumber>();
       using (NpgsqlCommand comm=new NpgsqlCommand("select*from accountnumber",DBcontext.Connection))
       {
           var read = comm.ExecuteReader();
           while (read.Read())
           {
               AccountNumber accountNumber = new AccountNumber()
               {
                   Id = read.GetInt32(0),
                   Number = read.GetInt32(1),
                   Many = read.GetInt32(2)
               };
               accountNumbers.Add(accountNumber);
           }
       }
       DBcontext.Connection.Close();
       return accountNumbers;
    }
  //--------------------------Delete-----------------------------
    public void Delete(int Id)
    {
        DBcontext.Connection.Open();
        using (NpgsqlCommand comm=new NpgsqlCommand("delete from accountnumber where id=@Id",DBcontext.Connection))
        {
            comm.Parameters.AddWithValue("Id", Id);
            comm.ExecuteNonQuery();
        }
        DBcontext.Connection.Close();
    }
   //---------------------------Update-----------------------------
    public void Update(int Id, AccountNumber accountNumber)
    {
       DBcontext.Connection.Open();
       using (NpgsqlCommand comm=new NpgsqlCommand("update accountnumber set Number=@Number,Many=@Many where Id=@Id ",DBcontext.Connection))
       {
           comm.Parameters.AddWithValue("Id", Id);
           comm.Parameters.AddWithValue("Number", accountNumber.Number);
           comm.Parameters.AddWithValue("Many", accountNumber.Many);
           comm.ExecuteNonQuery();
       }
       DBcontext.Connection.Close();
    }
}