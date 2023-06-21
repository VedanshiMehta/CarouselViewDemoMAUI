using C9_Exercises.ViewModel;

namespace C9_Exercises.View.Exercise3;

public partial class Exercise3 : ContentPage
{
	private FoodDeliveryViewModel _foodDeliveryViewModel;
	public Exercise3()
	{
		InitializeComponent();
		_foodDeliveryViewModel = (FoodDeliveryViewModel)BindingContext;
        _foodDeliveryViewModel.SkipClickedEventHandler += FoodDeliveryViewModel_SkipClickedEventHandler;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _foodDeliveryViewModel.CurrentPageSelected = _foodDeliveryViewModel.FoodData.FirstOrDefault();
    }
    private async void FoodDeliveryViewModel_SkipClickedEventHandler(object sender, bool e)
    {
		if (e)
			await Navigation.PushAsync(new DashboardScreen());
    }
}