using Blazor.SharedUI.Shared;


namespace Blazor.SharedUI.MAUI.Services;

public class PlatformService : IPlatformService
{
    public string GetPlatformInfo()
    {
        return DeviceInfo.Current.Platform.ToString();
    }

    public bool IsWeb()
    {
        return false;
    }
}
