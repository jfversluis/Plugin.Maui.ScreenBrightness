# Plugin.Maui.ScreenBrightness

`Plugin.Maui.ScreenBrightness` provides the ability to get or set the screen brightness inside a .NET MAUI application.

## Getting Started

* Available on NuGet: <http://www.nuget.org/packages/Plugin.Maui.ScreenBrightness> [![NuGet](https://img.shields.io/nuget/v/Plugin.Maui.ScreenBrightness.svg?label=NuGet)](https://www.nuget.org/packages/Plugin.Maui.ScreenBrightness/)

## API Usage

`Plugin.Maui.ScreenBrightness` provides the `ScreenBrightness` class that has a single property `Brightness` that you can get or set.

You can either use it as a static class, e.g.: `ScreenBrightness.Default.Brightness = 1` or with dependency injection: `builder.Services.AddSingleton<IScreenBrightness>(ScreenBrightness.Default);`