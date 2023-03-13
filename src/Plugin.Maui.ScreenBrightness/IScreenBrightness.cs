namespace Plugin.Maui.ScreenBrightness;

/// <summary>
/// Provides the ability to get and set the device's screen brightness.
/// </summary>
public interface IScreenBrightness
{
	/// <summary>
	/// Gets or sets the desired screen brightness
	/// </summary>
	float Brightness { get; set; }

	// TODO event for brightness changing?
}