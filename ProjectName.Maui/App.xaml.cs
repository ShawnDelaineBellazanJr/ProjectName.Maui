namespace ProjectName.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var telerikTheming = Application.Current.Resources.MergedDictionaries.OfType<TelerikTheming>().Single();
            telerikTheming.Theme = TelerikTheming.Themes.Single(t => t.Theme == "Platform" && t.Swatch == "Dark");

            if (telerikTheming.Theme.Swatch.Contains("Dark"))
            {
                Application.Current.UserAppTheme = AppTheme.Dark;
            }
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
