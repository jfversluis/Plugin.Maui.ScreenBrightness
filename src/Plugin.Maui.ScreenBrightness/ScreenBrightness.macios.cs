using System.Runtime.InteropServices;

namespace Plugin.Maui.ScreenBrightness;

partial class ScreenBrightnessImplementation : IScreenBrightness
{
	public float Brightness
	{
		get => (float)UIScreen.MainScreen.Brightness;
		set => UIScreen.MainScreen.Brightness = (NFloat)value;
	}
}