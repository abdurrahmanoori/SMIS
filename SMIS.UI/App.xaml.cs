using SMIS.UI.Middleware;
using SMIS.UI.Services;

namespace SMIS.UI
{
    public partial class App : Microsoft.Maui.Controls.Application
    {
        private readonly DevelopmentAutoLoginService _autoLoginService;

        public App(DevelopmentAutoLoginService autoLoginService)
        {
            InitializeComponent();
            _autoLoginService = autoLoginService;

            AppDomain.CurrentDomain.UnhandledException += (_, e) =>
                GlobalExceptionHandler.HandleException(e.ExceptionObject as Exception ?? new Exception(e.ExceptionObject?.ToString()));

            TaskScheduler.UnobservedTaskException += (_, e) =>
            {
                e.SetObserved();
                GlobalExceptionHandler.HandleException(e.Exception);
            };
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage(_autoLoginService)) { Title = "SMIS.UI" };
        }
    }
}
