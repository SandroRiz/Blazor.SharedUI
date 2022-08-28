﻿using Blazor.SharedUI.Shared;


namespace Blazor.SharedUI.MAUI.Services;

public class PlatformService : IPlatformService
{
    public string GetPlatformInfo()
    {
        return "Blazor SERVER";
    }

    public bool IsWeb()
    {
        return true;
    }
}
