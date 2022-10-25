using UnitTestingLab.PersonsModels;

namespace UnitTestingLab;

/// <summary>
///     Class for testing deposit and credit methods
/// </summary>
public sealed class Bank
{
    /// <summary>
    ///     Dictionary with id of worker and worker
    /// </summary>
    public Dictionary<int, BankWorker> BankWorkers { get; set; } = new Dictionary<int, BankWorker>();

    /// <summary>
    ///     Dictionary with id of user and user
    /// </summary>
    public Dictionary<int, BankUser> BankUsers { get; set; } = new Dictionary<int, BankUser>();

    /// <summary>
    ///     Percent for bank
    /// </summary>
    private const decimal bankPercent = 1.2m;

    /// <summary>
    ///     Empty constructor
    /// </summary>
    public Bank()
    {
    }

    /// <summary>
    ///     Deposit method with selected user, his ammount of money he selected and time in months
    /// </summary>
    /// <param name="idOfUser">Selected user id</param>
    /// <param name="ammountOfMoney">Ammount of money user selected</param>
    /// <param name="timeInMonths">Time in months for deposit</param>
    /// <returns>True if everythind is ok and false if checks were wrong</returns>
    public bool Deposit(int idOfUser, decimal ammountOfMoney, int timeInMonths)
    {
        var selectedUser = BankUsers[idOfUser];

        if (idOfUser < 0 || ammountOfMoney < 0 || selectedUser.AmmountOfMoney > ammountOfMoney || timeInMonths < 0)
        {
            return false;
        }

        selectedUser.StoryOfMoney.Add(selectedUser.AmmountOfMoney - ammountOfMoney);

        var moneyAfterDeposit = ammountOfMoney;

        for (int i = 0; i < timeInMonths; i++)
        {
            moneyAfterDeposit += moneyAfterDeposit * bankPercent;
        }

        selectedUser.StoryOfMoney.Add(moneyAfterDeposit);

        return true;
    }

    /// <summary>
    ///     Credit method with selected user, his ammount of money he selected and time in months
    /// </summary>
    /// <param name="idOfUser">Selected user id</param>
    /// <param name="ammountOfMoney">Ammount of money user selected</param>
    /// <returns>True if everythind is ok and false if checks were wrong</returns>
    public bool Credit(int idOfUser, decimal ammountOfMoney)
    {
        var selectedUser = BankUsers[idOfUser];

        if (idOfUser < 0 || ammountOfMoney < 0 || selectedUser.AmmountOfMoney > ammountOfMoney)
        {
            return false;
        }

        selectedUser.StoryOfMoney.Add(selectedUser.AmmountOfMoney + ammountOfMoney);
        selectedUser.StoryOfMoney.Add(-ammountOfMoney * bankPercent);

        return true;
    }
}