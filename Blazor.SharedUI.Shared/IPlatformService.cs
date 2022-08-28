using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.SharedUI.Shared
{
    public interface IPlatformService
    {
        string GetPlatformInfo();

        bool IsWeb();
    }
}
