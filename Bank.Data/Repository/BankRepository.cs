using Bank.Data.DBContext;
using Bank.Data.IRepository;
using Bank.Domain.Entity;
using Npgsql;

namespace Bank.Data.Repository;

public class BankRepository:IBankRepository
{
    //-------------------Add-----------------------------
    public void Add(BankModel bank)
    {
       DBcontext.Connection.Open();
       using (NpgsqlCommand comm=new NpgsqlCommand("insert into bankinfo values (@Id,@Name)",DBcontext.Connection))
       {
           comm.Parameters.AddWithValue("Id", bank.Id);
           comm.Parameters.AddWithValue("Name", bank.Name);
           // bank Userlari so'raladi
           comm.ExecuteNonQuery();
       }
    }
  //----------------------GetAll-------------------------
    public List<BankModel> GetAll()
    {
    DBcontext.Connection.Open();
    List<BankModel> bankModels = new List<BankModel>();
    using (NpgsqlCommand comm=new NpgsqlCommand("select * from bankinfo",DBcontext.Connection))
    {
        var read = comm.ExecuteReader();
        while (read.Read())
        {
            BankModel bank = new BankModel()
            {
             Id = read.GetInt32(0),
             Name = read.GetString(1),
             //user = read.GetInt32(3)
            };
            bankModels.Add(bank);
        }
    }
    DBcontext.Connection.Close();
    return bankModels;
    }
  //-----------------------Delete-------------------------
    public void Delete(int Id)
    {
       DBcontext.Connection.Open();
       using (NpgsqlCommand comm=new NpgsqlCommand("delete from bankinfo where Id=@Id",DBcontext.Connection))
       {
           comm.Parameters.AddWithValue("Id", Id);
           comm.ExecuteNonQuery();
       }
       DBcontext.Connection.Close();
    }
  //--------------------------Update-------------------------
    public void Update(int Id, BankModel bank)
    {
       DBcontext.Connection.Open();
       using (NpgsqlCommand comm=new NpgsqlCommand("update bankinfo set Name=@Name where Id=@Id",DBcontext.Connection))
       {
           comm.Parameters.AddWithValue("Id", Id);
           comm.Parameters.AddWithValue("Name", bank.Name);
           comm.ExecuteNonQuery();
       }
       DBcontext.Connection.Close();
    }
}