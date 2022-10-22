namespace UnitTestingLab.PersonsModels;

/// <summary>
/// Class for testing strings and bool values
/// </summary>
public abstract class Person
{
    /// <summary>
    ///     Name of person
    /// </summary>
    public readonly string Name;

    /// <summary>
    ///     Surname of person
    /// </summary>
    public readonly string Surname;

    /// <summary>
    ///     Is person worker of bank
    /// </summary>
    public readonly bool IsWorker;

    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="name">Name of person</param>
    /// <param name="surname">Surname of person</param>
    /// <param name="isWorker">Is person a worker of the bak or not</param>
    public Person(string name, string surname, bool isWorker)
    {
        Name = name;
        Surname = surname;
        IsWorker = isWorker;
    }

    /// <summary>
    ///     Overriden ToString method
    /// </summary>
    /// <returns>Returns concatenated name and surname</returns>
    public override string ToString()
    {
        return Name + " " + Surname;
    }
}
