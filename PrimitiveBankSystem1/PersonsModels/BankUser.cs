using System.Collections.Generic;

namespace UnitTestingLab.PersonsModels
{

    /// <summary>
    ///     Class for testing inheritance, collection and decimal value
    /// </summary>
    public sealed class BankUser : Person
    {
        /// <summary>
        ///     Ammount of money for user
        /// </summary>
        public decimal AmmountOfMoney { get; set; }

        /// <summary>
        ///     List with story of money ammount
        /// </summary>
        public List<decimal> StoryOfMoney { get; set; }

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="name">Name of bank user</param>
        /// <param name="surname">Surname of bank user</param>
        /// <param name="ammountOfMoney">Ammount of money for user</param>
        public BankUser(string name, string surname, decimal ammountOfMoney) : base(name, surname, false)
        {
            AmmountOfMoney = ammountOfMoney;
            StoryOfMoney = new List<decimal>
            {
                ammountOfMoney
            };
        }
    }
}