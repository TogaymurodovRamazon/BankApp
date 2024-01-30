using Npgsql;

namespace Bank.Data.DBContext;

public class DBcontext
{
    public static NpgsqlConnection Connection = new NpgsqlConnection("server=localhost;port=5432;username=postgres;password=20000101;database=bankapp");
}