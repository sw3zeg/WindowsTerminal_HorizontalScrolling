
using System.Text;
using Newtonsoft.Json.Linq;


namespace WindowsTerminal_HorizontalScrolling;


public class JsonTools
{
    
    private readonly String _settingsJsonFilePath;
    private readonly Int32 _maxPaddingWidth;
    private readonly Int32 _minLeftPadding;
    private const String PaddingKey = "\"padding\":";
    
    private Int32 _indexOfPadding;
    
    
    public JsonTools(Configuration configuration)
    {

        _settingsJsonFilePath = configuration.SettingsJsonFilePath;
        
        _maxPaddingWidth = Convert.ToInt32(AppConstants.MaxPaddingWidth);
        _minLeftPadding = Convert.ToInt32(configuration.MinLeftPadding);
    }
    
    
    //to speed up the recording, I memorize the padding key index and change a fixed number of characters.
    public void SetLeftPadding(Int32 value)
    {
        
        string replaceText = $"{PaddingKey} \"{GetSixDigitsNum(value)}, 000000, " +
                             $"{GetSixDigitsNum(_maxPaddingWidth-value)}, 000000\"";

        byte[] replaceBytes = Encoding.UTF8.GetBytes(replaceText);
        
         using (FileStream fs = new FileStream(_settingsJsonFilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
         {
             var buffer = new byte[fs.Length];
             fs.Read(buffer, 0, buffer.Length);
             string content = Encoding.UTF8.GetString(buffer);
             
             if (!content.Substring(_indexOfPadding, PaddingKey.Length).Equals(PaddingKey))
             {
                 _indexOfPadding = content.IndexOf(PaddingKey);
             }

             fs.Seek(_indexOfPadding, SeekOrigin.Begin);
             fs.Write(replaceBytes, 0, replaceBytes.Length);
         }
    }
    
    public async Task DisableTextWrapping()
    {
        string json = await File.ReadAllTextAsync(_settingsJsonFilePath);
        
        var jsonObject = JObject.Parse(json);
        
        jsonObject["profiles"]!["defaults"]!["padding"] = 
            $"{GetSixDigitsNum(_minLeftPadding)}, 000000, {GetSixDigitsNum(_maxPaddingWidth)}, 000000";

        await File.WriteAllTextAsync(_settingsJsonFilePath, jsonObject.ToString());
    }

    private String GetSixDigitsNum(Int32 num)
    {
        if (num < 0) 
            return num.ToString("D5");
        return num.ToString("D6");
    }
}