
using System.Runtime.InteropServices;

namespace WindowsTerminal_HorizontalScrolling;


class Program : IDisposable
{
    
    private HotKeysController _hotKeysController;
    private JsonTools _jsonTools;
    private Configuration _configuration;
    
    private Int32 _currentLeftPadding;
    private Int32 _step;
    private Int32 _minLeftPadding;
    private Int32 _maxPaddingWidth;
    
    private bool _hideWindow;
    
    
    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool PostThreadMessage(int idThread, uint msg, IntPtr wParam, IntPtr lParam);
    
    
    [STAThread]
    static async Task Main()
    {
        using (var program = new Program())
        {
            await program.Initialize();
        }
    }

    
    private async Task Initialize()
    {
        _configuration = new Configuration();
        
        await _configuration.LoadConfigurationAsync();
        
        _hideWindow = Convert.ToBoolean(_configuration.HideWindow);
        _maxPaddingWidth = Convert.ToInt32(AppConstants.MaxPaddingWidth);
        
        ApplicationConfiguration.Initialize();
        if (!_hideWindow)
        {
            _configuration.SettingsAppliedAction += RestartExecution;
        
            Application.Run(new MainForm(_configuration));
        }
        else
        {
            StartExecution();
            
            Application.Run(new MainForm());
        }
    }

    
    public void Dispose()
    {
        _configuration.SettingsAppliedAction -= RestartExecution;

        StopExecution();
    }

    
    private async Task RestartExecution()
    {
        if (_hotKeysController != null)
            await StopExecution();
        
        await StartExecution();
    }

    private async Task StartExecution()
    {
        _hotKeysController = new HotKeysController(_configuration);
        _jsonTools = new JsonTools(_configuration);
        
        _minLeftPadding = Convert.ToInt32(_configuration.MinLeftPadding);
        _step = Convert.ToInt32(_configuration.Step);
        _currentLeftPadding = _minLeftPadding;
        
        _hotKeysController.MoveLeftAction += MoveScrollLeft;
        _hotKeysController.MoveRightAction += MoveScrollRight;
        _hotKeysController.ResetAction += ResetScroll;
        
        
        await _jsonTools.DisableTextWrapping();
        
        await _hotKeysController.Initialize();
    }
    
    private async Task StopExecution()
    {
        
        PostThreadMessage(_hotKeysController.ThreadId, AppConstants.WmQuit, IntPtr.Zero, IntPtr.Zero);
        
        _hotKeysController.MoveLeftAction -= MoveScrollLeft;
        _hotKeysController.MoveRightAction -= MoveScrollRight;
        _hotKeysController.ResetAction -= ResetScroll;
    }
    
    
    private void MoveScrollLeft()
    {
        
        _currentLeftPadding += _step;
        
        if (_currentLeftPadding > _minLeftPadding)
            _currentLeftPadding = _minLeftPadding;
        
        _jsonTools.SetLeftPadding(_currentLeftPadding);
    }
    
    private void MoveScrollRight()
    {

        _currentLeftPadding -= _step;
        
        if (_currentLeftPadding < _maxPaddingWidth)
            _currentLeftPadding = _maxPaddingWidth;
        
        _jsonTools.SetLeftPadding(_currentLeftPadding);
    }
    
    private void ResetScroll()
    {
        
        _currentLeftPadding = _minLeftPadding;
        
        _jsonTools.SetLeftPadding(_minLeftPadding);
    }
}