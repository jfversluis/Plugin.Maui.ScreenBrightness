using Android.Provider;
using Android.Views;
using Microsoft.Maui.ApplicationModel;

namespace Plugin.Maui.ScreenBrightness;

partial class ScreenBrightnessImplementation : IScreenBrightness
{
	public float Brightness
	{
		get
		{
			var activity = Platform.CurrentActivity;
			if (activity is null) {
				return 0;
			}

			var window = activity.Window;
			if (window is null) {
				return 0;
			}
			
			var windowBrightness = window.Attributes?.ScreenBrightness ?? 0;
			if (windowBrightness < 0) {
				return Settings.System.GetInt(activity.ContentResolver, Settings.System.ScreenBrightness) / 255f;
			}

			return windowBrightness;
		}

		set
		{
			var window = Platform.CurrentActivity?.Window;

			if (window is null)
			{
				return;
			}

			var attributesWindow = new WindowManagerLayoutParams();

			attributesWindow.CopyFrom(window.Attributes);
			attributesWindow.ScreenBrightness = value;

			window.Attributes = attributesWindow;
		}
	}
}