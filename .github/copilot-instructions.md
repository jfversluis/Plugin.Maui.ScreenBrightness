# Plugin.Maui.ScreenBrightness - Copilot Instructions

## Project Overview

This is a .NET MAUI plugin that provides the ability to get and set the device screen brightness. It targets Android, iOS, and Windows.

## Architecture

Minimal API: `IScreenBrightness` with a single property `float Brightness { get; set; }` (0.0-1.0).

Platform specifics:
- Android: Per-window brightness via `WindowManager`
- iOS: System-wide via `UIScreen`
- Windows: `BrightnessOverride` API

## Code Conventions

### Namespace
All code uses: `Plugin.Maui.ScreenBrightness`

### File Naming
- `*.shared.cs` - Cross-platform code
- `*.android.cs` - Android-specific code
- `*.macios.cs` - iOS/macOS-specific code
- `*.windows.cs` - Windows-specific code
- `*.net.cs` - Generic .NET fallback

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
