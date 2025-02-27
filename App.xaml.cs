
namespace TTHK_projekt_final
{
    public partial class App : Application
    {
        const int WindowWidth = 540;
        const int WindowHeight = 1200;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            Routing.RegisterRoute("blue", typeof(blue));
            Routing.RegisterRoute("baboon", typeof(baboon));
            Routing.RegisterRoute("chapukin", typeof(chapukin));
            Routing.RegisterRoute("squirrel", typeof(squirrel));
            Routing.RegisterRoute("tamarin", typeof(tamarin));
        }
        protected override Window CreateWindow(IActivationState activationState)
        {
            Window window = base.CreateWindow(activationState);
            window.Activated += Window_Activated;

            return window;
        }

        private async void Window_Activated(object sender, EventArgs e)
        {
#if WINDOWS
            const int DefaultWidth = 400;
            const int DefaultHeight = 800;

            var window = sender as Window;

            // change window size.
            window.Width = DefaultWidth;
            window.Height = DefaultHeight;

            // give it some time to complete window resizing task.
            await window.Dispatcher.DispatchAsync(() => { });

            var disp = DeviceDisplay.Current.MainDisplayInfo;

            // move to screen center
            window.X = (disp.Width / disp.Density - window.Width) / 2;
            window.Y = (disp.Height / disp.Density - window.Height) / 2;
#endif
        }
    }
}
