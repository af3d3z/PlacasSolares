using Microsoft.Maui.Controls.Platform.Compatibility;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace PlacasSolares.Views;

public partial class Citas : ContentPage
{
    public Citas()
    {
        InitializeComponent();
    }


    // Direcciona al usuario a la pantalla de detalles
    private async void verDetalles(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Detalles");
    }

    /// <summary>
    /// Abre la aplicaci�n de mapas que tenga el usuario
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void abrirMapa(object sender, EventArgs e)
    {
        Location location = new Location(37.374114489725144, -5.969046087514576);
        MapLaunchOptions options = new MapLaunchOptions { Name = "IES Nervi�n" };

        try
        {
            await Map.Default.OpenAsync(location, options);
        }
        catch (Exception ex) {
            Console.WriteLine(ex.ToString);
            Console.WriteLine("Instalate una aplicaci�n de mapas o algo �no?");
        }
    }

    // Devuelve al usuario a la pantalla anterior
    private async void GoBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}