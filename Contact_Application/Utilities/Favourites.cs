namespace Contact_Application.Utilities;

public class Favourite : Contact
{
    private string _name;
    private string _lastName;
    private string _mail;
    private int _number;

    public Favourite(string name, string lastName, string mail, int number)
    : base(name, lastName, mail, number) {
        _name = name;
        _lastName = lastName;
        _mail = mail;
        _number = number;
    }
}