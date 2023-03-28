namespace Plugin.Maui.ScreenBrightness;

public static class ScreenBrightness
{
	static IScreenBrightness? defaultImplementation;

	/// <summary>
	/// Provides the default implementation for static usage of this API.
	/// </summary>
	public static IScreenBrightness Default =>
		defaultImplementation ??= new ScreenBrightnessImplementation();

	internal static void SetDefault(IScreenBrightness? implementation) =>
		defaultImplementation = implementation;
}
