namespace SMIS.UI.Models;

public class AppSettings
{
    public string ApiBaseUrl { get; set; } = "http://localhost:5238";
    public int TimeoutSeconds { get; set; } = 30;
}
