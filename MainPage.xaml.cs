namespace TTHK_projekt_final



{
    public partial class MainPage : ContentPage
    {
        const int WindowWidth = 540;
        const int WindowHeight = 1200;
        public MainPage()
        {
            InitializeComponent();
        }
        private void testButton_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("test");
        }
        private void baboonButton_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("baboon");
        }
        private void chapukinButton_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("chapukin");
        }
        private void blueButton_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("blue");
        }
        private void squirrelButton_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("squirrel");
        }
        private void tamarinButton_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("tamarin");
        }
    }
}
