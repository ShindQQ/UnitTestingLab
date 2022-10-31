namespace UnitTestingLab.PersonsModels
{

    /// <summary>
    ///     Class for testing inheritance, collection and int value
    /// </summary>
    public sealed class BankWorker : Person
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="name">Name of bank worker</param>
        /// <param name="surname">Surname of bank worker</param>
        public BankWorker(string name, string surname) : base(name, surname, true)
        {
        }
    }
}