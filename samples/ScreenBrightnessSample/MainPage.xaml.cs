using Plugin.Maui.ScreenBrightness;

namespace ScreenBrightnessSample;

public partial class MainPage : ContentPage
{
	IScreenBrightness _screenBrightness;

	public MainPage(IScreenBrightness screenBrightness)
	{
		InitializeComponent();
		_screenBrightness = screenBrightness;

		brightnessSlider.Value = _screenBrightness.Brightness;
	}

	void Slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
	{
		_screenBrightness.Brightness = (float)e.NewValue;
	}
}
