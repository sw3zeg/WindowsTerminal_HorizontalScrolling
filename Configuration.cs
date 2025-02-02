
using Newtonsoft.Json.Linq;


namespace WindowsTerminal_HorizontalScrolling;


public class Configuration
{
    
    private readonly String _appSettingJsonFilePath; 
        
    public String MoveLeftHotKey { get; set; }
    public String MoveRightHotKey { get; set; }
    public String ResetHotKey { get; set; }
    public String SettingsJsonFilePath { get; set; }
    public Boolean HideWindow { get; set; }
    public Int32 Step { get; set; }
    public Int32 MinLeftPadding { get; set; }
        
    public Func<Task> SettingsAppliedAction;
    // public event Action SettingsAppliedAction;
    

    public Configuration()
    {
        _appSettingJsonFilePath = AppConstants.AppSettingsJsonFilePath;
    }
    
    
    public async Task SaveConfigurationAsync()
    {
        var json = await File.ReadAllTextAsync(_appSettingJsonFilePath);
        
        var jsonObject = JObject.Parse(json);

        jsonObject["MoveLeftHotKey"] = MoveLeftHotKey;
        jsonObject["MoveRightHotKey"] = MoveRightHotKey;
        jsonObject["ResetHotKey"] = ResetHotKey;
        jsonObject["SettingsJsonFilePath"] = SettingsJsonFilePath;
        jsonObject["HideWindow"] = HideWindow;
        jsonObject["Step"] = Step;
        jsonObject["MinLeftPadding"] = MinLeftPadding;
            
        await File.WriteAllTextAsync(_appSettingJsonFilePath, jsonObject.ToString());

        SettingsAppliedAction?.Invoke();
    }

    public async Task LoadConfigurationAsync()
    {
        var json = await File.ReadAllTextAsync(_appSettingJsonFilePath);
            
        var jsonObject = JObject.Parse(json);
            
        MoveLeftHotKey = jsonObject["MoveLeftHotKey"]!.ToString();
        MoveRightHotKey = jsonObject["MoveRightHotKey"]!.ToString();
        ResetHotKey = jsonObject["ResetHotKey"]!.ToString();
        SettingsJsonFilePath = jsonObject["SettingsJsonFilePath"]!.ToString();
        HideWindow = Convert.ToBoolean(jsonObject["HideWindow"]);
        Step = Convert.ToInt32(jsonObject["Step"]);
        MinLeftPadding = Convert.ToInt32(jsonObject["MinLeftPadding"]);
    }
}