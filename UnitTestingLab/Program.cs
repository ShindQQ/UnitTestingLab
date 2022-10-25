using UnitTestingLab;

Bank bank = new Bank();


/// <summary>
/// Add persons
/// </summary>
Console.WriteLine(new String('-', 10) + "Users" + new String('-', 10));
bank.BankUsers.Add(1, new UnitTestingLab.PersonsModels.BankUser("Taras", "Shevchenko", 10000));
bank.BankUsers.Add(2, new UnitTestingLab.PersonsModels.BankUser("Ivan", "Franko", 12000));
bank.BankUsers.Add(3, new UnitTestingLab.PersonsModels.BankUser("Lesia", "Ukrainka", 15000));
bank.BankUsers.Add(4, new UnitTestingLab.PersonsModels.BankUser("Vasyl", "Stus", 10000));
bank.BankUsers.Add(5, new UnitTestingLab.PersonsModels.BankUser("Olena", "Teliha", 11000));

bank.BankWorkers.Add(1, new UnitTestingLab.PersonsModels.BankWorker("Ivan", "Ivanov"));
bank.BankWorkers.Add(2, new UnitTestingLab.PersonsModels.BankWorker("Oleksandr", "Oleksandrov"));


/// <summary>
/// Show list of persons
/// </summary>
bank.BankUsers.ToList().ForEach(
    x => { Console.WriteLine(x.Key + " - " + x.Value.Name + " " + x.Value.Surname + " " + x.Value.AmmountOfMoney); });

Console.WriteLine('\n' + new String('-', 10) + "Workers" + new String('-', 10));

bank.BankWorkers.ToList().ForEach(
    x => { Console.WriteLine(x.Key + " - " + x.Value.Name + " " + x.Value.Surname); });


/// <summary>
/// Show example of deposit
/// </summary>
bank.Deposit(1, 5000, 12);
bank.Deposit(2, 2500, 24);
bank.Deposit(3, 5500, 6);

Console.WriteLine('\n' + new String('-', 10) + "Users after deposits" + new String('-', 10));
foreach (var user in bank.BankUsers)
{
    Console.WriteLine(user.Key + " - " + user.Value.Name + " " + user.Value.Surname);
    Console.WriteLine("History of money:");
    foreach (var money in user.Value.StoryOfMoney)
    {
        Console.WriteLine(money);
    }
    Console.WriteLine();
}

/// <summary>
/// Show example of credits
/// </summary>
bank.Credit(4, 3000);
bank.Credit(5, 60000);

Console.WriteLine('\n' + new String('-', 10) + "Users after credits" + new String('-', 10));
foreach (var user in bank.BankUsers)
{
    Console.WriteLine(user.Key + " - " + user.Value.Name + " " + user.Value.Surname);
    Console.WriteLine("History of money:");
    foreach (var money in user.Value.StoryOfMoney)
    {
        Console.WriteLine(money);
    }
    Console.WriteLine();
}
