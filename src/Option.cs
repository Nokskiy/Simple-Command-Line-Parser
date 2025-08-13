namespace SCLP;

public class Option<T>(string shortName, string fullName, string? description, T? argument)
{
    public string ShortName => shortName;
    public string FullName => fullName;
    public string? Description => description;
    public T? Argument => argument;
}