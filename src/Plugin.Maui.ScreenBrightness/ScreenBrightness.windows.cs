using System.Management;

namespace Plugin.Maui.ScreenBrightness;

partial class ScreenBrightnessImplementation : IScreenBrightness
{
	public float Brightness
	{
		get
		{
			byte num = 0;
			using var managementObjectSearcher = new ManagementObjectSearcher(new ManagementScope("root\\WMI"), new SelectQuery("WmiMonitorBrightness"));
			using var objectCollection = managementObjectSearcher.Get();
			using var enumerator = objectCollection.GetEnumerator();
			if (enumerator.MoveNext())
			{
				num = (byte)enumerator.Current.GetPropertyValue("CurrentBrightness");
			}

			return num / 100.0f;
		}

		set
		{
			using var managementObjectSearcher = new ManagementObjectSearcher(new ManagementScope("root\\WMI"), new SelectQuery("WmiMonitorBrightnessMethods"));
			using var objectCollection = managementObjectSearcher.Get();
			using var enumerator = objectCollection.GetEnumerator();
			if (enumerator.MoveNext())
			{
				((ManagementObject)enumerator.Current).InvokeMethod("WmiSetBrightness", new object[]
				{
						uint.MaxValue,
						value * 100
				});
			}
		}
	}
}