using SMIS.UI.Services.Interfaces;

namespace SMIS.UI.Services;

public class ThemeService : IThemeService
{
    public bool IsDarkMode { get; private set; }

    public event Action? OnThemeChanged;

    public void SetTheme(bool isDark)
    {
        IsDarkMode = isDark;
        OnThemeChanged?.Invoke();
    }

    public void Toggle() => SetTheme(!IsDarkMode);
}
