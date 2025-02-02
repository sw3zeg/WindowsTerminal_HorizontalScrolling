
using System.Runtime.InteropServices;


namespace WindowsTerminal_HorizontalScrolling;


public class HotKeysController
{

    private readonly Configuration _configuration;
    private const Int32 HotkeyMoveLeft = 1;
    private const Int32 HotkeyMoveRight = 2;
    private const Int32 HotkeyReset = 3;
    
    private UInt32[] _moveLeftHotKeyArray;
    private UInt32[] _moveRightHotKeyArray;
    private UInt32[] _resetHotKeyArray;
    
    public Int32 ThreadId { get; private set; }
    
    public event Action MoveLeftAction;
    public event Action MoveRightAction;
    public event Action ResetAction;
    
    
    public HotKeysController(Configuration configuration)
    {
        _configuration = configuration;
    }
    
    
    [StructLayout(LayoutKind.Sequential)]
    private struct MSG
    {
        public IntPtr hwnd;
        public uint message;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public POINT pt;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct POINT
    {
        public int x;
        public int y;
    }
    
    [DllImport("user32.dll")]
    private static extern bool GetMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

    [DllImport("user32.dll")]
    private static extern IntPtr RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

    [DllImport("user32.dll")]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    
    [DllImport("kernel32.dll")]
    private static extern int GetCurrentThreadId();
    
    
    public async Task Initialize()
    {
        InitialHotKeys();

        await StartMonitoringHotKeys();
    }
    

    private async Task StartMonitoringHotKeys()
    {
        
        await Task.Run(() =>
        {
            ThreadId = GetCurrentThreadId();
            try
            {
                RegisterHotKey(IntPtr.Zero, HotkeyMoveLeft, GetModifierFromHotKey(_moveLeftHotKeyArray),
                    GetKeyFromHotKey(_moveLeftHotKeyArray));
                RegisterHotKey(IntPtr.Zero, HotkeyMoveRight, GetModifierFromHotKey(_moveRightHotKeyArray),
                    GetKeyFromHotKey(_moveRightHotKeyArray));
                RegisterHotKey(IntPtr.Zero, HotkeyReset, GetModifierFromHotKey(_resetHotKeyArray),
                    GetKeyFromHotKey(_resetHotKeyArray));

                    
                MSG msg;
                while (GetMessage(out msg, IntPtr.Zero, 0, 0))
                {

                    if (msg.message == AppConstants.WmHotKey)
                    {
                            
                        switch ((int)msg.wParam)
                        {
                            case HotkeyMoveLeft:
                                MoveLeftAction?.Invoke();
                                break;
                            case HotkeyMoveRight:
                                MoveRightAction?.Invoke();
                                break;
                            case HotkeyReset:
                                ResetAction?.Invoke();
                                break;
                        }
                    }
                    else if (msg.message == AppConstants.WmQuit)
                    {
                        break;
                    }
                }
            }
            finally
            {
                UnregisterHotKey(IntPtr.Zero, HotkeyMoveLeft);
                UnregisterHotKey(IntPtr.Zero, HotkeyMoveRight);
                UnregisterHotKey(IntPtr.Zero, HotkeyReset);
            }    
        });
    }
    
    // 0x0001 | 0x0002 ~ alt + ctrl
    private UInt32 GetModifierFromHotKey(UInt32[] hotkey)
    {
        UInt32 modifier = hotkey[0];
        
        for (int i = 1; i < hotkey.Length - 1; i++)
        {
            modifier |= hotkey[i];
        }
        
        return modifier;
    }

    private UInt32 GetKeyFromHotKey(UInt32[] hotkey)
        => hotkey[^1];
    
    
    private void InitialHotKeys()
    {
        _moveLeftHotKeyArray = SplitStringToHotKeyArray(_configuration.MoveLeftHotKey);
        _moveRightHotKeyArray = SplitStringToHotKeyArray(_configuration.MoveRightHotKey);
        _resetHotKeyArray = SplitStringToHotKeyArray(_configuration.ResetHotKey);
    }
    
    private UInt32[] SplitStringToHotKeyArray(String hotkey)
        => hotkey.Split('+').Select(key => Convert.ToUInt32(AppConstants.VirtualKeys[key.ToUpper()])).ToArray();
    
}