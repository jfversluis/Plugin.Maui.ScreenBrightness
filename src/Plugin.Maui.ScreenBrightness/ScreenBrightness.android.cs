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
			if (Platform.CurrentActivity is null)
			{
				return 0;
			}

			return Settings.System.GetInt(Platform.CurrentActivity.ContentResolver,
				Settings.System.ScreenBrightness);
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