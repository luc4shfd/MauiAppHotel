namespace MauiAppHotel.Views;

public partial class SobreDesenvolvedor : ContentPage
{
	public SobreDesenvolvedor()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Contato());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}