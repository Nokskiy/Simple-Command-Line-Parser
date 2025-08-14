# Simple command line parser

## ℹ️ About
Just **simple command line parser**

## ✨ Features
- Command line parsing
- Activating functions via delegate
- Easy to use

## 📥 Installation
```dotnet add package NeoSimpleCommandLineParser --version 1.0.0```

Add the ```SCLP``` namespace to your project. No external packages required

## 📌 Usage
### Code example
``` C#
using SCLP;

public class Program
{
    private static void Main(string[] args)
    {
        var helpOpt = new Option("h", "help", "Show this list", false, null);
        var echoOpt = new Option("ec","echo","Print your phrase",true, "you phrase");
        var callOpt = new Option("cl","call","Print Calling... + your phrase",true, "you phrase");
        var sayOpt = new Option("s","say",null);

        var optionsList = new OptionsList(new Option[]
        {
            echoOpt,
            callOpt,
            sayOpt,
            helpOpt
        });

        var root = new Root(args, optionsList);

        helpOpt.Action += root.PrintHelp;
        echoOpt.Action += Echo;
        callOpt.Action += Call;
        sayOpt.Action += Say;

        root.ParseOptions();
        root.InvokeActions();
    }
    public static void Echo(string[]? arguments)
    {
        if (arguments == null) return;
        foreach (var arg in arguments)
            Console.WriteLine(arg);
    }

    public static void Call(string[]? arguments)
    {
        if (arguments == null) return;
        foreach (var arg in arguments)
            Console.WriteLine($"Calling... {arg}");
    }
    public static void Say(string[]? arguments) => Console.WriteLine("I just say");
}
```

## 🤝 Contributing
We welcome your contributing
- Issues
- Discussions
- Pull requests
