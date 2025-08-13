namespace SCLP;

public class Option(string shortName, string fullName, string? description, object? argument)
{
    public string ShortName => shortName;
    public string FullName => fullName;
    public string? Description => description;
    public object? Argument => argument;
}