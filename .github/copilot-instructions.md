# $ Copilot InstructionsREPO 

## Project Overview

This is a .NET MAUI plugin that provides the ability to get and set the device screen brightness. It targets Android, iOS, Windows.

### Architecture

Minimal API: `IScreenBrightness` with single property `float Brightness { get; set; }` (0.0-1.0).

- Android: per-window brightness via WindowManager
- iOS: system-wide via UIScreen
- Windows: BrightnessOverride API

## Code Conventions

### Namespace
All code uses: `Plugin.Maui.ScreenBrightness`

### File Naming
- `*.shared. Cross-platform codecs` 
- `*.android. Androidcs` 
- `*.macios. iOS/macOScs` 
- `*.windows. Windowscs` 
- `*.net. Generic .NET fallbackcs` 

### Standards
- File-scoped namespaces
- `camelCase` for private fields, `PascalCase` for public
- XML docs required on all public APIs
- Null-conditional operators for platform interop

## Building

```bash
dotnet build src/Plugin.Maui.ScreenBrightness/Plugin.Maui.ScreenBrightness.csproj -c Release
```

## When Making Changes
1. Ensure the plugin builds on all target platforms
2. If adding public API, update the interface
3. Implement on all supported platforms
4. Update sample app and README
