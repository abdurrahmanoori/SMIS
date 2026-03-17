namespace SMIS.UI.Services;

public class ThemeService
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
