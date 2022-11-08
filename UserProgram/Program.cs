namespace User;
internal static class Program
{
    static void Main(string[] args)
    {
        const string userName = "Ivan";
        const string surName = "Ivanov";
        const string login = "IvanovI";
        DateTime age = new(2002, 02, 02);
        User user = new(login, userName, surName, DateTime.Now.Year - age.Year);
        Console.WriteLine(user.ToString());
    }
}
