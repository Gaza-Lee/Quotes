namespace Quotes.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void btnToCreateQuotePage_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CreateQuotePage());
    }

    private void lblDownload_Tapped(object sender, TappedEventArgs e)
    {

    }
}