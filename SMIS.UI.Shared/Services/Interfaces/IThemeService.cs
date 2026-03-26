namespace SMIS.UI.Shared.Services.Interfaces;

public interface IThemeService
{
    bool IsDarkMode { get; }
    event Action? OnThemeChanged;
    void SetTheme(bool isDark);
    void Toggle();
}
