using Syncfusion.Blazor.Notifications;

namespace SMIS.UI2.Helpers;

public static class ToastHelper
{
    public static async Task ShowAsync(SfToast toast, string message, string title = "Notification", ToastType type = ToastType.Info)
    {
        var toastModel = new ToastModel
        {
            Title = title,
            Content = message,
            CssClass = GetCssClass(type),
            Icon = GetIcon(type)
        };
        await toast.ShowAsync(toastModel);
    }

    public static async Task ShowSuccessAsync(SfToast toast, string message, string title = "Success")
    {
        await ShowAsync(toast, message, title, ToastType.Success);
    }

    public static async Task ShowErrorAsync(SfToast toast, string message, string title = "Error")
    {
        await ShowAsync(toast, message, title, ToastType.Error);
    }

    public static async Task ShowWarningAsync(SfToast toast, string message, string title = "Warning")
    {
        await ShowAsync(toast, message, title, ToastType.Warning);
    }

    public static async Task ShowInfoAsync(SfToast toast, string message, string title = "Info")
    {
        await ShowAsync(toast, message, title, ToastType.Info);
    }

    private static string GetCssClass(ToastType type)
    {
        return type switch
        {
            ToastType.Success => "e-toast-success",
            ToastType.Error => "e-toast-danger",
            ToastType.Warning => "e-toast-warning",
            ToastType.Info => "e-toast-info",
            _ => "e-toast-info"
        };
    }

    private static string GetIcon(ToastType type)
    {
        return type switch
        {
            ToastType.Success => "e-success toast-icons",
            ToastType.Error => "e-error toast-icons",
            ToastType.Warning => "e-warning toast-icons",
            ToastType.Info => "e-info toast-icons",
            _ => "e-info toast-icons"
        };
    }
}

public enum ToastType
{
    Success,
    Error,
    Warning,
    Info
}
