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
        private void Button_Clicked5(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("test");
        }
        private void Button_Clicked6(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("test");
        }
    }
}
