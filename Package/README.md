# dein Colorify [ for Win, Mac & Linux ]

**Colorify** was created to simplify and automate tasks related to NET Core console formating. Was born in [HardHat](https://github.com/deinsoftware/hardhat/) project as a Class. Now grew up as library and can be used by other console applications.

Contributions or Beer will be appreciated

> The Code is Dark and Full of Errors!  
> Console is your friend ... don't be afraid!

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install?

* [NET Core SDK](https://www.microsoft.com/net/download)

### Installing

**ToolBox** is available as [project](https://github.com/deinsoftware/toolbox/) or [package](https://www.nuget.org/packages/dein.ToolBox). We strong recommend add as a NuGet package if don't need make modifications directly on source code library.

Follow this instructions to add **ToolBox** in your project.

#### Add As Package

In your project folder, where is located .csproj file run this command on terminal:

```terminal
dotnet add package dein.Colorify
```

If you want to use OS class highly recommend use [ToolBox](https://github.com/deinsoftware/toolbox/) project.

```terminal
dotnet add package dein.ToolBox
dotnet add package Newtonsoft.Json --version 11.0.2
```

Official documentation: [dotnet add package](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-package)

## Usage

Refer to [README](https://github.com/deinsoftware/colorify/blob/master/README.md) file on GItHub.

To understand how this library works, take a look inside [Sample](https://github.com/deinsoftware/colorify/tree/master/Sample) folder. Better easy to use guide than words.

Just go to `Sample` project folder and run this command on terminal:

```terminal
cd Sample
dotnet r