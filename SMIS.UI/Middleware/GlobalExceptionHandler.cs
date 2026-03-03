using SMIS.Application.Common.Exceptions;
using System.Diagnostics;

namespace SMIS.UI.Middleware
{
    public class GlobalExceptionHandler
    {
        //public static void Initialize()
        //{
        //    AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
        //    TaskScheduler.UnobservedTaskException += OnUnobservedTaskException;
        //}

        //private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        //{
        //    if (e.ExceptionObject is Exception exception)
        //    {
        //        HandleException(exception);
        //    }
        //}

        //private static void OnUnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
        //{
        //    HandleException(e.Exception);
        //    e.SetObserved();
        //}

        public static void HandleException(Exception exception)
        {
            // Filter out framework/system exceptions
            if (ShouldIgnoreException(exception))
                return;

            var log = ExceptionLog.CreateLog(exception);

#if DEBUG
            WriteToDebugWindow(log);
#endif

            MainThread.BeginInvokeOnMainThread(async ( ) =>
            {
                var message = $"An unexpected error occurred.\nError ID: {log.Id}\n\n{log.Message}";

#if DEBUG
                message += $"\n\nStack Trace:\n{log.StackTrace}";
#endif

                if (Microsoft.Maui.Controls.Application.Current?.Windows.Any() == true)
                {
                    var mainPage = Microsoft.Maui.Controls.Application.Current.Windows[0].Page;
                    if (mainPage != null)
                    {
                        var result = await mainPage.DisplayAlert(
                            "Error",
                            message,
                            "Copy",
                            "Close");

                        if (result)
                        {
                            await Clipboard.SetTextAsync(message);
                            await mainPage.DisplayAlert(
                                "Copied",
                                "Error details copied to clipboard",
                                "OK");
                        }
                    }
                }
            });
        }

        private static bool ShouldIgnoreException(Exception exception)
        {
            var exceptionType = exception.GetType().FullName ?? string.Empty;
            var stackTrace = exception.StackTrace ?? string.Empty;

            // Ignore common framework exceptions
            if (exceptionType.Contains("TaskCanceledException") ||
                exceptionType.Contains("OperationCanceledException") ||
                exceptionType.Contains("ObjectDisposedException"))
                return true;

            // Ignore if exception is from framework only (not from SMIS code)
            if (!stackTrace.Contains("SMIS."))
                return true;

            return false;
        }

        public static void WriteToDebugWindow(ExceptionLog log)
        {
            Debug.WriteLine($"[EXCEPTION] Id: {log.Id}");
            Debug.WriteLine($"[EXCEPTION] Message: {log.Message}");
            Debug.WriteLine($"[EXCEPTION] StackTrace: {log.StackTrace}");
            if (log.InnerException != null)
            {
                Debug.WriteLine($"[EXCEPTION] InnerException: {log.InnerException.Message}");
            }
        }
    }
}