namespace SCLP;

public class Option(string shortName, string fullName, string? description)
{
    public string ShortName => shortName;
    public string FullName => fullName;
    public string? Description => description;
    public string[] Arguments = new string[0];

    public delegate void ActionDelegate(object? argument);

    public ActionDelegate? Action;
}