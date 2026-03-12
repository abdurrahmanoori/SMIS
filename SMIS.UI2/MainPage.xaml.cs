using SMIS.UI2.Services;

namespace SMIS.UI2
{
    public partial class MainPage : ContentPage
    {
        private readonly DevelopmentAutoLoginService _autoLoginService;

        public MainPage(DevelopmentAutoLoginService autoLoginService)
        {
            InitializeComponent();
            _autoLoginService = autoLoginService;
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            await _autoLoginService.TryAutoLoginAsync();
        }
    }
}
