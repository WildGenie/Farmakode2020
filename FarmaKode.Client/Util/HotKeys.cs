using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaKode.Client.Properties;

namespace FarmaKode.Client.Util
{
    public class Hotkeys
    {
         
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public const int MYACTION_HOTKEY_ID = 1;

        public static void SetHotKeys(IntPtr handle)
        {
            if (!Settings.Default.IsManuelMode)
                return;
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            int combinationValue = 0;
            if (Settings.Default.ManuelKeysALT) combinationValue += 1;
            if (Settings.Default.ManuelKeysCTRL) combinationValue += 2;
            if (Settings.Default.ManuelKeysSHIFT) combinationValue += 4;

            Keys key = (Keys)Enum.Parse(typeof(Keys), Settings.Default.ManuelKeysCustom);

            RegisterHotKey(handle, MYACTION_HOTKEY_ID,combinationValue, (int)key);
        }

        public static void UnsetHotKeys(IntPtr handle)
        {
            // loop through each hotkey id and
            // disable it
            for (int i = 0; i < MYACTION_HOTKEY_ID; i++)
            {
                UnregisterHotKey(handle, i);
            }
        }



    }
}
