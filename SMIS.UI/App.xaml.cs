using SMIS.UI.Middleware;

namespace SMIS.UI
{
    public partial class App : Microsoft.Maui.Controls.Application
    {
        public App()
        {
            InitializeComponent();
            
            //GlobalExceptionHandler.Initialize();
            
            AppDomain.CurrentDomain.FirstChanceException += (sender, e) =>
            {
                GlobalExceptionHandler.HandleException(e.Exception);
            };
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "SMIS.UI" };
        }
    }
}
