using SMIS.UI2.Services;

namespace SMIS.UI2
{
    public partial class App : Microsoft.Maui.Controls.Application
    {
        private readonly DevelopmentAutoLoginService _autoLoginService;

        public App(DevelopmentAutoLoginService autoLoginService)
        {
            InitializeComponent();
            _autoLoginService = autoLoginService;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage(_autoLoginService)) { Title = "SMIS.UI2" };
        }
    }
}
