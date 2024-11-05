namespace PlacasSolares.Views;

public partial class Detalles : ContentPage
{
	public Detalles()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Devuelve al usuario a la pantalla anterior
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    private async void GoBack(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("//Citas");
    }
}