![](nuget.png) 

# Plugin.Maui.ScreenBrightness

`Plugin.Maui.ScreenBrightness` provides the ability to get or set the screen brightness inside a .NET MAUI application.

## Install Plugin

[![NuGet](https://img.shields.io/nuget/v/Plugin.Maui.ScreenBrightness.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.Maui.ScreenBrightness/)

Available on [NuGet](http://www.nuget.org/packages/Plugin.Maui.ScreenBrightness).

Install with the dotnet CLI: `dotnet add package Plugin.Maui.ScreenBrightness`, or through the NuGet Package Manager in Visual Studio.

## API Usage

`Plugin.Maui.ScreenBrightness` provides the `ScreenBrightness` class that has a single property `Brightness` that you can get or set.

You can either use it as a static class, e.g.: `ScreenBrightness.Default.Brightness = 1` or with dependency injection: `builder.Services.AddSingleton<IScreenBrightness>(ScreenBrightness.Default);`
