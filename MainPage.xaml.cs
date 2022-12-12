namespace NicolasHidalgo_ExamenP2;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnAlertYesNoClicked(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Confirmacion", "Desea recargar?", "Si", "No");
        await DisplayAlert("Finalizado", "Recarga exitosa", "OK");
    }
}


