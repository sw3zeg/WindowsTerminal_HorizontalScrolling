
namespace WindowsTerminal_HorizontalScrolling;


public static class AppConstants
{

    public static readonly UInt32 WmQuit = 0x0012;
    public static readonly UInt32 WmHotKey = 0x0312;
    
    public static readonly String AppSettingsJsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
    
    public static readonly Int32 MaxPaddingWidth = -14000;

    public static readonly Dictionary<String, UInt32> VirtualKeys = new Dictionary<String, UInt32>
    {
        { "ALT", 0x01 },
        { "CTRL", 0x02 },
        { "SHIFT", 0x04 },
        { "WIN", 0x08 },
        
        { "LEFT", 0x25 },
        { "UP", 0x26 },
        { "RIGHT", 0x27 },
        { "DOWN", 0x28 },
        
        { "PG_UP", 0x21 },
        { "PG_DOWN", 0x22 },
        
        { "A", 0x41 },
        { "B", 0x42 },
        { "C", 0x43 },
        { "D", 0x44 },
        { "E", 0x45 },
        { "F", 0x46 },
        { "G", 0x47 },
        { "H", 0x48 },
        { "I", 0x49 },
        { "J", 0x4A },
        { "K", 0x4B },
        { "L", 0x4C },
        { "M", 0x4D },
        { "N", 0x4E },
        { "O", 0x4F },
        { "P", 0x50 },
        { "Q", 0x51 },
        { "R", 0x52 },
        { "S", 0x53 },
        { "T", 0x54 },
        { "U", 0x55 },
        { "V", 0x56 },
        { "W", 0x57 },
        { "X", 0x58 },
        { "Y", 0x59 },
        { "Z", 0x5A }
    };
    
    
    public static readonly String HotKeysDescription = $"You need write hot keys with one or more modifiers at the beginning (ctrl, shift, alt, win){Environment.NewLine}" +
                                                       $"and one key at the end (left, right, up, down, pg_up, pg_down, a-z) connected using a '+'{Environment.NewLine}" +
                                                       $"Examples of hot keys:{Environment.NewLine}" +
                                                       $"alt+left; ctrl+right; alt+shift+pg_up; win+ctrl+shift+down ...";
    public static readonly String MoveLeftHotKeyDescription = "hot key to scroll to the right.";
    public static readonly String MoveRightHotKeyDescription = "hot key to scroll to the left.";
    public static readonly String ResetHotKeyDescription = "Return to the starting position (to the left side).";
    public static readonly String HideWindowDescription = "Hide the window now and next times.";
    public static readonly String StepDescription = "Determine how much the content will shift horizontally each time you press the hotkey.";
    public static readonly String MinLeftPaddingDescription = "Set the minimum left padding.";
    public static readonly String SettingsJsonFilePathDescription = "Write the path to settings.json file of windows terminal application.";
    public static readonly String EnableAutorunButtonDescription = "Launch the app at PC startup.";
    public static readonly String DisableAutorunButtonDescription = "Remove app from startup.";
    public static readonly String ApplyButtonDescription = "Save the changes and restarts the app.";
}