namespace SCLP;

public class OptionsList(Option[] options)
{
    public List<Option> Options { get; private set; } = options != null ? options.ToList() : new List<Option>();

    public void AddOption(ref Option option) => Options.Add(option);
}