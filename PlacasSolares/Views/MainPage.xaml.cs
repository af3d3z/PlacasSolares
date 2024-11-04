namespace PlacasSolares.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLogin(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Citas");
        }
    }

}
