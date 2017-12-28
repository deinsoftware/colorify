# Colorify [ for Win & Mac ]


**Colorify** was created to simplify and automate tasks related to NET Core console formating. Was born in 
[HardHat](https://github.com/equiman/hardhat/) project as a Class. Now grew up as library and can be used by other console applications.

Contributions or Beer :beers: will be appreciated :thumbsup:

> The Code is Dark and Full of Errors!  
> Console is your friend ... don't be afraid!

## Menu

* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Installing](#installing)
  * [Add Reference](#add-reference)
  * [Instantiate Library](#instantiate-library)
* [Usage](#usage)
  * [Colors](#colors)
  * [Write](#write)
  * [WriteLine](#writeline)
  * [Align](#align)
  * [BlankLines](#blanklines)
  * [DivisionLine](#divisionline)
* [About](#about)
  * [Built With](#built-with)
  * [Contributing](#contributing)
  * [Versioning](#versioning)
  * [Authors](#authors)
  * [License](#license)
  * [Acknowledgments](#acknowledgments)

---

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install?

* [NET Core SDK](https://www.microsoft.com/net/download)
* [ToolBox](https://github.com/equiman/toolbox/)

### Installing

Follow this steps to install on your local machine

Clone **Colorify** from GitHub on *recommended* path. Using this command on terminal:

| OS | Command |
| --- | --- |
| win | `git clone https://github.com/equiman/colorify.git "D:\Developer\DEIN\Projects\_devCC"` |
| mac | `git clone https://github.com/equiman/colorify.git ~/Developer/DEIN/Projects/_devCC` |

## Add Reference

In **your project folder**, where is located `.csproj` file run this command on terminal:

| OS | Command |
| --- | --- |
| win | `dotnet add reference "D:\Developer\DEIN\Projects\_devCC\Colorify\Colorify.csproj"` |
| mac | `dotnet add reference ~/Developer/DEIN/Projects/_devCC/Colorify/Colorify.csproj` |

Take a look on official documentation: [dotnet-add reference](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-reference)

Keep calm, you are almost done. Review this final steps and enjoy the life, no more tedious and repetitive tasks stealing your precious time.

### Instantiate Library

On the main class Program, add an static property Format and inside Main method create an instance of the  library according the Operative System.

```csharp
class Program
{
    public static Format _colorify {get; set;}

    static void Main(string[] args)
    {
        switch (OS.GetCurrent())
        {
            case "win":
                _colorify = new Format(Theme.Win);
                break;
            case "mac":
                _colorify = new Format(Theme.Mac);
                break;
        }
        //Foo()
        //Bar()
        _colorify.ResetColor();
    }
}
```

Take note that `_colorify.ResetColor();` command is important in order to reset default terminal colors when programs finish.

If you want to use `_colorify` in other class, add an static using to `Program` class:

```csharp
using static Namesapace.Program;
```
replace Namespace with defined namespace in your project.

## Usage

I'll try explain the usage, but I think the best way is take a look in [Sample](https://github.com/equiman/colorify/tree/master/Sample) folder, better easy to use guide that words.

In Colorify solution folder, where is located `Colorify.sln` file run this command on terminal:

```terminal
cd Sample
dotnet run
```

### Colors

**Colorify** colors was created inspired on [Bootstrap colors](https://getbootstrap.com/docs/4.0/utilities/colors/) a list whit a meaning easy to remember.

```csharp
_colorify.WriteLine("Text Default", Colors.txtDefault);
_colorify.WriteLine("Text Muted", Colors.txtMuted);
_colorify.WriteLine("Text Primary", Colors.txtPrimary);
_colorify.WriteLine("Text Success", Colors.txtSuccess);
_colorify.WriteLine("Text Info", Colors.txtInfo);
_colorify.WriteLine("Text Warning", Colors.txtWarning);
_colorify.WriteLine("Text Danger", Colors.txtDanger);
_colorify.WriteLine("Background Default", Colors.bgDefault);
_colorify.WriteLine("Background Muted", Colors.bgMuted);
_colorify.WriteLine("Background Primary", Colors.bgPrimary);
_colorify.WriteLine("Background Success", Colors.bgSuccess);
_colorify.WriteLine("Background Info", Colors.bgInfo);
_colorify.WriteLine("Background Warning", Colors.bgWarning);
_colorify.WriteLine("Background Danger", Colors.bgDanger);
```

**Theme for MacOS (Light):**  
![Colors for MacOS](Sample/images/colors-mac.png "Colors for MacOS")

**Theme for Windows (Dark):**  
![Colors for Windows](Sample/images/colors-win.png "Colors for Window")

Colors are defined on [Theme](https://github.com/equiman/colorify/tree/master/Colorify/Theme) folder. There is two themes for MacOs and Windows. You can edit the `ThemeMac.cs` or `ThemeWin.cs` files or create a new one implementing the `ITheme` interface.

Take a look on official documentation: [ConsoleColor Enumeration](https://msdn.microsoft.com/en-us/library/system.consolecolor)

### Write

`_colorify.Write` work like `Console.Write` but wrapped with colors. If you don't specify a color will use the `Colors.txtDefault` by default.

```csharp
_colorify.Write("Text");
```

```csharp
_colorify.Write("Text", Colors.bgDefault);
```

You can stack a multiple `_colorify.Write`, just remember define the last one as WriteLine.

```csharp
_colorify.Write(" Default ", Colors.bgDefault);
_colorify.Write(" Muted   ", Colors.bgMuted);
_colorify.Write(" Primary ", Colors.bgPrimary);
_colorify.Write(" Success ", Colors.bgSuccess);
_colorify.Write(" Info    ", Colors.bgInfo);
_colorify.Write(" Warning ", Colors.bgWarning);
_colorify.WriteLine(" Danger  ", Colors.bgDanger);
```

![Write](Sample/images/write.png "Write")

### WriteLine

`_colorify.WriteLine` work like `Console.WriteLine` with a line terminator after the text but wrapped with colors. If you don't specify a color will use the `Colors.txtDefault` by default.

```csharp
_colorify.WriteLine("Text with line terminator");
```

```csharp
_colorify.WriteLine("Text with line terminator", Colors.bgDefault);
```

Automatic line wrap with long text:

```csharp
_colorify.Write("Short Text at First Preceded with a ", Colorify.Colors.bgInfo);
_colorify.WriteLine(" Long Multilinetext with Line Wrap that bring a new line", Colorify.Colors.bgSuccess);
```

![WriteLine](Sample/images/writeline.png "WriteLine")

### Align

All the align methods (Center/Left/Right) works like `Console.WriteLine` but with align operation and wrapped with colors. If you don't specify a color will use the `Colors.txtDefault` by default.

```csharp
_colorify.AlignCenter("Text Aligned to Center");
_colorify.AlignRight("Text Aligned to Right");
_colorify.AlignLeft("Text Aligned to Left");
```

```csharp
_colorify.AlignCenter("Text Aligned to Center", Colorify.Colors.bgInfo);
_colorify.AlignRight("Text Aligned to Right", Colorify.Colors.txtDefault);
_colorify.AlignLeft("Text Aligned to Left", Colorify.Colors.txtDanger);
```

`AlignSplit` is the way to show two values on the same line. Text will be split with pipe `|` character, the first element will be aligned to left and second aligned to right.

```csharp
_colorify.AlignSplit("<-Text to Left| Text to Right->");
```

```csharp
_colorify.AlignSplit("<-Text to Left| Text to Right->", Colorify.Colors.bgSuccess);
```

![Align](Sample/images/align.png "Align")

### BlankLines

`_colorify.BlankLines` works like `Console.WriteLine` but without text. You can combine the amount of lines and color. Default values will be `1` line and `Colors.txtDefault`.

```csharp
_colorify.BlankLines();
_colorify.BlankLines(Colorify.Colors.bgDanger);
```

![BlankLines](Sample/images/lines.png "BlankLines")

```csharp
_colorify.BlankLines(3);
_colorify.BlankLines(3, Colorify.Colors.bgSuccess);
```

![BlankLines x 3](Sample/images/linesx3.png "BlankLines x 3")

### DivisionLine

`_colorify.DivisionLine` works like `Console.WriteLine` but without the same character as full width text. . If you don't specify a color will use the `Colors.txtDefault` by default.

```csharp
_colorify.DivisionLine('-', Colorify.Colors.bgDefault);
_colorify.DivisionLine('+', Colorify.Colors.bgMuted);
_colorify.DivisionLine('~', Colorify.Colors.bgPrimary);
_colorify.DivisionLine('=', Colorify.Colors.bgSuccess);
_colorify.DivisionLine('-', Colorify.Colors.bgInfo);
_colorify.DivisionLine('*', Colorify.Colors.bgWarning);
_colorify.DivisionLine('.', Colorify.Colors.bgDanger);
```

![DivisionLine](Sample/images/division.png "DivisionLine")

⇧ [Back to menu](#menu)

---

## About

### Built With

* [VS Code](https://code.visualstudio.com/) - Code editing redefined.

### Contributing

Please read [CONTRIBUTING](CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

### Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [Colorify](https://github.com/equiman/colorify/tags) on GitHub.

### Authors

* **Camilo Martinez** [[Equiman](http://stackoverflow.com/story/equiman)]

See also the list of [contributors](https://github.com/equiman/colorify/contributors) who participated in this project.

### License

This project is licensed under the GNU GPLv3 License - see the [LICENSE](LICENSE) file for details.

### Acknowledgments

* [StackOverflow](http://stackoverflow.com): The largest online community for programmers.
* [Dot Net Perls](https://www.dotnetperls.com/console-color): C# Console Color, Text and BackgroundColor.

⇧ [Back to menu](#menu)
