namespace C9_Exercises.View.Exercise5;

public partial class Exercise5 : ContentPage
{
	public Exercise5()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new DashboardScreen());
    }
}