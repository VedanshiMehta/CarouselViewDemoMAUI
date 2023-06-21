using C9_Exercises.Model;
using C9_Exercises.ViewModel;

namespace C9_Exercises.View.Exercise4;

public partial class Exercise4 : ContentPage
{
	private FastFoodDeliveryViewModel _fastFood;
	public Exercise4()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
		_fastFood =(FastFoodDeliveryViewModel)BindingContext;
        _fastFood.SkipClickedEventHandler += FastFood_SkipClickedEventHandler;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _fastFood.CurrentPageSelected = _fastFood.FastFoodData.FirstOrDefault();
        _fastFood.ColorButton = _fastFood.CurrentPageSelected.Colors;
    }
    private async void FastFood_SkipClickedEventHandler(object sender, bool e)
    {
        if (e)
            await Navigation.PushAsync(new DashboardScreen());
    }
}