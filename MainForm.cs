
using System.Runtime.InteropServices;
using Microsoft.Win32;


namespace WindowsTerminal_HorizontalScrolling;


public partial class MainForm : Form
{
    
    private readonly Configuration _configuration;
    private readonly ToolTip _toolTip;

    private const String CheckMark = "\u2713";
    
    
    [DllImport("user32.dll")]
    private static extern void ReleaseCapture();

    [DllImport("user32.dll")]
    private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

    private const int WM_NCLBUTTONDOWN = 0xA1;
    private const int HTCAPTION = 0x2;
    
    
    public MainForm(Configuration configuration)
    {
        _configuration = configuration;
        
        _toolTip = new ToolTip();
        
        
        InitializeComponent();

        InsertDataFromConfiguration();
        
        SetUpToolTip();
    }
    
    //The Windows API requires some kind of application to listen for hot keys.
    public MainForm()
    {
        this.Opacity = 0;
        this.Shown += (sender, e) => this.Hide();
    }
    
    
    private void SetUpToolTip()
    {
        
        _toolTip.AutoPopDelay = Int16.MaxValue;
        _toolTip.InitialDelay = 500;
        _toolTip.ReshowDelay = 200;
        _toolTip.ShowAlways = true;
        _toolTip.BackColor =  Color.FromArgb(96, 125, 126);
        _toolTip.ForeColor = Color.FromArgb(230, 214, 193);
        
        _toolTip.SetToolTip(HotKeys_label, AppConstants.HotKeysDescription);
        _toolTip.SetToolTip(MoveLeftHotKey_label, AppConstants.MoveLeftHotKeyDescription);
        _toolTip.SetToolTip(MoveRightHotKey_label, AppConstants.MoveRightHotKeyDescription);
        _toolTip.SetToolTip(ResetHotKey_label, AppConstants.ResetHotKeyDescription);
        _toolTip.SetToolTip(HideWindow_label, AppConstants.HideWindowDescription);
        _toolTip.SetToolTip(Step_label, AppConstants.StepDescription);
        _toolTip.SetToolTip(MinLeftPadding_label, AppConstants.MinLeftPaddingDescription);
        _toolTip.SetToolTip(SettingsJsonFilePath_label, AppConstants.SettingsJsonFilePathDescription);
        
        _toolTip.SetToolTip(AddToStartup_button, AppConstants.EnableAutorunButtonDescription);
        _toolTip.SetToolTip(RemoveFromStartup_button, AppConstants.DisableAutorunButtonDescription);
        _toolTip.SetToolTip(Apply_button, AppConstants.ApplyButtonDescription);
    }

    private void InsertDataFromConfiguration()
    {
        MoveLeftHotKey_input.Text = _configuration.MoveLeftHotKey;
        MoveRightHotKey_input.Text = _configuration.MoveRightHotKey;
        ResetHotKey_input.Text = _configuration.ResetHotKey;
        SettingsJsonFilePath_input.Text = _configuration.SettingsJsonFilePath;
        Step_input.Text = _configuration.Step.ToString();
        MinLeftPadding_input.Text = _configuration.MinLeftPadding.ToString();
    }


    private void MainForm_MouseDown(object sender, MouseEventArgs e)
    {
        this.ActiveControl = null;
    }

    private void Apply_button_Click(object sender, EventArgs e)
    {
        _configuration.MoveLeftHotKey = MoveLeftHotKey_input.Text;
        _configuration.MoveRightHotKey = MoveRightHotKey_input.Text;
        _configuration.ResetHotKey = ResetHotKey_input.Text;
        _configuration.SettingsJsonFilePath = SettingsJsonFilePath_input.Text;
        _configuration.Step = Convert.ToInt32(Step_input.Text);
        _configuration.MinLeftPadding = Convert.ToInt32(MinLeftPadding_input.Text);
        _configuration.HideWindow = HideWindow_input.Text.Equals(CheckMark);
            
        _configuration.SaveConfigurationAsync();

        if (_configuration.HideWindow)
            this.Hide();
    }
    
    private void AddToStartup_button_Click(object sender, EventArgs e)
    {
        var appName = Application.ProductName;
        var appPath = Application.ExecutablePath;
        
        RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
        regKey.SetValue(appName, appPath);
    }

    private void RemoveFromStartup_button_Click(object sender, EventArgs e)
    {
        var appName = Application.ProductName;
        
        RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
        regKey.DeleteValue(appName, false);
    }

    private void HideWindow_input_Click(object sender, EventArgs e)
    {
        if (HideWindow_input.Text.Equals(CheckMark))
        {
            HideWindow_input.Text = String.Empty;
            HideWindow_input.BackColor = Color.FromArgb(230, 214, 193);
        }
        else
        {
            HideWindow_input.Text = CheckMark;
            HideWindow_input.BackColor = Color.FromArgb(126, 105, 92);
        }
    }


    private void Header_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }

    private void Exit_button_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void Minimize_button_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }
    
}