using SMIS.UI.Services;

namespace SMIS.UI
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
            try
            {
#if DEBUG
                //throw new InvalidOperationException("[TEST] Intentional CLR exception to verify GlobalExceptionHandler.");
#endif
                await _autoLoginService.TryAutoLoginAsync();
            }
            catch (Exception ex)
            {
                Middleware.GlobalExceptionHandler.HandleException(ex);
            }
        }
    }
}
