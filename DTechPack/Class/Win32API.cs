using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DTechPack
{
    class Win32API
    {
        [System.Runtime.InteropServices.DllImport("winmm")]
         public static extern long mciSendString(string lpstrCommand, string lpstrReturnString, long uReturnLength, long hwndCallback);
    }
}
