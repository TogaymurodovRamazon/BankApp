using Bank.Domain.Entity;
using Bank.Service.IService;
using Bank.Service.Service;

IAccountService accountService=new AccountService();
IBankService bankService=new BankService();
IUserService userService=new UserService();

while (true)
{
    Console.WriteLine(" 1- User");
    Console.WriteLine(" 2- Bank");
    Console.WriteLine(" 3- AccountNumber");

    int a = int.Parse(Console.ReadLine());
    switch (a)
    {
        case 1:   // User
        {
            while (true)
            {
                Console.WriteLine("1-Add User");
                Console.WriteLine("2-GetAll User");
                Console.WriteLine("3-Delete User");
                Console.WriteLine("4-Update User");
                Console.WriteLine("5-GetById");
                Console.WriteLine("0-Back");
                int b = int.Parse(Console.ReadLine());
                if (b==0)
                    break;
                switch (b)
                {
                    case 1:
                    {
                        Console.Write("Id:  ");
                        int id = int.Parse(Console.ReadLine());
                        
                        Console.Write("FirstName:  ");
                        string firstname = Console.ReadLine();
                        
                        Console.Write("LastName:  ");
                        string lastname = Console.ReadLine();
                        
                        Console.Write("Age:  ");
                        int age = int.Parse(Console.ReadLine());
                        
                        Console.Write("Password:  ");
                        string password = Console.ReadLine();
                        
                        Console.Write("PhoneNumber:  ");
                        string phonenumber = Console.ReadLine();
                        
                        Console.Write("AccountId:  ");
                        int accountid = int.Parse(Console.ReadLine());
                        
                        Console.Write("BankId:  ");
                        int bankid = int.Parse(Console.ReadLine());

                        Users users = new Users()
                        {
                            Id = id,
                            FirstName = firstname,
                            LastName = lastname,
                            Age = age,
                            Password = password,
                            PhoneNumber = phonenumber,
                            AccountId = accountid,
                            BankId = bankid
                        };
                        userService.Add(users);
                        Console.Clear();
                        Console.WriteLine("Add Bo'ldi.");
                        Console.ReadKey();
                        
                        break;
                    }

                    case 2:
                    {
                        var res = userService.GetAll();
                        Console.Clear();
                        foreach (var i in res )
                        {
                            Console.WriteLine(
                                $"{i.Id}  {i.FirstName}  {i.LastName}  {i.Age}  {i.Password}  {i.PhoneNumber}  {i.AccountId}  {i.BankId}");
                        }

                        Console.ReadKey();
                        break;
                    }

                    case 3:
                    {
                        var res = userService.GetAll();
                        foreach (var i in res )
                        {
                            Console.WriteLine(
                                $"{i.Id}  {i.FirstName}  {i.LastName}  {i.Age}  {i.Password}  {i.PhoneNumber}  {i.AccountId}  {i.BankId}");
                        }
                        Console.Write("Qaysi Id ni o'chirasiz:  ");
                        int id = int.Parse(Console.ReadLine());
                        
                        userService.Delete(id);
                        Console.Clear();
                        Console.WriteLine("Delete Bo'ldi. ");
                        Console.ReadKey();

                        break;
                    }

                    case 4:
                    {
                        var res = userService.GetAll();
                        Console.Clear();
                        foreach (var i in res )
                        {
                            Console.WriteLine(
                                $"{i.Id}  {i.FirstName}  {i.LastName}  {i.Age}  {i.Password}  {i.PhoneNumber}  {i.AccountId}  {i.BankId}");
                        }
                        Console.Write("Qaysi Id ni yangilaysiz:  ");
                        int ID = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Yangilaydigan malumotlarizni kiriting. ");
                        Console.Write("FirstName:  ");
                        string firstname = Console.ReadLine();
                        
                        Console.Write("LastName:  ");
                        string lastname = Console.ReadLine();
                        
                        Console.Write("Age:  ");
                        int age = int.Parse(Console.ReadLine());
                        
                        Console.Write("Password:  ");
                        string password = Console.ReadLine();
                        
                        Console.Write("PhoneNumber:  ");
                        string phonenumber = Console.ReadLine();
                        
                        Console.Write("AccountId:  ");
                        int accountid = int.Parse(Console.ReadLine());
                        
                        Console.Write("BankId:  ");
                        int bankid = int.Parse(Console.ReadLine());

                        Users user = new Users()
                        {
                            
                            FirstName = firstname,
                            LastName = lastname,
                            Age = age,
                            Password = password,
                            PhoneNumber = phonenumber,
                            AccountId = accountid,
                            BankId = bankid
                        };
                        userService.Update(ID,user);
                        Console.Clear();
                        Console.WriteLine("Update Bo'ldi. ");
                        Console.ReadKey();
                        break;
                    }
                    case 5:
                    {
                       Console.Write("Qaysi Id kerak: ");
                       int id = int.Parse(Console.ReadLine());
                       var res = userService.GetAll();
                       Users users = new Users();
                       foreach (var i in res)
                       {
                           if (id == i.Id)
                           {
                               users.Id = i.Id;
                               users.FirstName = i.FirstName;
                               users.LastName = i.LastName;
                               users.Age = i.Age;
                               users.Password = i.Password;
                               users.PhoneNumber = i.PhoneNumber;
                               users.AccountId = i.AccountId;
                               users.BankId = i.BankId;
                           }
                       }
                       Console.Clear();
                       Console.WriteLine(
                           $"{users.Id}  {users.FirstName}  {users.LastName}  {users.Age}  {users.Password}  {users.PhoneNumber}  {users.AccountId}  {users.BankId}");
                       Console.ReadKey();
                       break;
                    }
                }
            }
            break;
        }
        // User tugadi.
        
        case 2:   // Bank
        {
            while (true)
            {
                Console.WriteLine("1-Add Bank");
            Console.WriteLine("2-GetAll Bank");
            Console.WriteLine("3-Delete Bank");
            Console.WriteLine("4-Update Bank");
            Console.WriteLine("5-GetById");
            Console.WriteLine("0-Back");

            int c = int.Parse(Console.ReadLine());
            if (c==0)
                break;
            switch (c)
            {
                case 1:
                {
                    Console.Write("Id:  ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Name:  ");
                    string name = Console.ReadLine();
                    BankModel bankModel = new BankModel()
                    {
                        Id = id,
                        Name = name
                    };
                    bankService.Add(bankModel);
                    Console.Clear();
                    Console.WriteLine("Add Bo'ldi. ");
                    Console.ReadKey();
                    break;
                }

                case 2:
                {
                    var res = bankService.GetAll();
                    Console.Clear();
                    foreach (var j in res)
                    {
                        Console.WriteLine($"{j.Id}  {j.Name}");
                    }

                    Console.ReadKey();
                    
                    break;
                }

                case 3:
                {
                    Console.WriteLine("Qaysi Id ni o'chirasiz:  ");
                    int id = int.Parse(Console.ReadLine());
                    bankService.Delete(id);
                    Console.Clear();
                    Console.WriteLine("Deleted Bo'ldi. ");
                    Console.ReadKey();
                    break;
                }

                case 4:
                {
                    Console.Write("Qaysi Id malumotlarini yangilaysiz:  ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Name:  ");
                    string name = Console.ReadLine();
                    BankModel bank = new BankModel()
                    {
                        Name = name
                    };
                    bankService.Update(id,bank);
                    Console.Clear();
                    Console.WriteLine("Update Bo'ldi. ");
                    Console.ReadKey();
                    break;
                }

                case 5:
                {
                   Console.Write("Qaysi Id malumotlari kerak:  ");
                   int id = int.Parse(Console.ReadLine());
                   var res = bankService.GetAll();
                   BankModel bank = new BankModel();
                   foreach (var i in res)
                   {
                       if (id==i.Id)
                       {
                           bank.Id = i.Id;
                           bank.Name = i.Name;
                       }
                   }
                   Console.Clear();
                   Console.WriteLine($"{bank.Id}  {bank.Name}");
                   Console.ReadKey();
                   break;
                }
            }
            }
            break;
        }
        // Bank tugadi.

        case 3:   // AccountNumber
        {
            while (true)
            {
                Console.WriteLine("1-Add AccountNumber");
            Console.WriteLine("2-GetAll AccountNumber");
            Console.WriteLine("3-Delete AccountNumber");
            Console.WriteLine("4-Update AccountNumber");
            Console.WriteLine("5-GetById");
            Console.WriteLine("0-Back");

            int d = int.Parse(Console.ReadLine());
            if (d==0)
               break;
            switch (d)
            {
                case 1:
                {
                   Console.Write("Id:  ");
                   int id = int.Parse(Console.ReadLine());
                   Console.Write("Number:  ");
                   int number = int.Parse(Console.ReadLine());
                   Console.Write("Many:  ");
                   int many = int.Parse(Console.ReadLine());
                   AccountNumber accountNumber = new AccountNumber()
                   {
                       Id = id,
                       Number = number,
                       Many = many
                   };
                   accountService.Add(accountNumber);
                   Console.Clear();
                   Console.WriteLine("Add Bo'ldi. ");
                   Console.ReadKey();
                   break;
                }

                case 2:
                {
                    Console.Clear();
                    var res = accountService.GetAll();
                    foreach (var i in res)
                    {
                        Console.WriteLine($"{i.Id}  {i.Number}  {i.Many}");
                    }

                    Console.ReadKey();
                    break;
                }

                case 3:
                {
                    Console.Write("Qaysi Id dagi malumotlarni o'chirasiz:  ");
                    int id = int.Parse(Console.ReadLine());
                    accountService.Delete(id);
                    Console.Clear();
                    Console.WriteLine("Delete Bo'ldi. ");
                    Console.ReadKey();
                    break;
                }

                case 4:
                {
                    Console.Clear();
                    Console.Write("Qaysi Id malumotlarini yangilaysiz:  ");
                    int ID = int.Parse(Console.ReadLine());
                    Console.Write("Number:  ");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("Many:  ");
                    int many = int.Parse(Console.ReadLine());
                    AccountNumber accountNumber = new AccountNumber()
                    {
                        Number = number,
                        Many = many
                    };
                    accountService.Update(ID,accountNumber);
                    Console.WriteLine("Update Bo'ldi. ");
                    Console.ReadKey();
                    break;
                }

                case 5:
                {
                    Console.Clear();
                    var res = accountService.GetAll();
                    AccountNumber accountNumber = new AccountNumber();
                    Console.Write("Qaysi Id malumotlari kerak:  ");
                    int id = int.Parse(Console.ReadLine());
                    foreach (var i in res)
                    {
                        if (id == i.Id)
                        {
                            accountNumber.Id = i.Id;
                            accountNumber.Number = i.Number;
                            accountNumber.Many = i.Many;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine($"{accountNumber.Id}  {accountNumber.Number}  {accountNumber.Many}");
                    Console.ReadKey();
                    break;
                }
            }

            }
            break;
        }
       // AccountNumber tugadi.

    }

}