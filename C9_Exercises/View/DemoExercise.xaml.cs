using C9_Exercises.ViewModel;

namespace C9_Exercises.View;

public partial class DemoExercise : ContentPage
{
    private DemoViewModel _foodDeliveryViewModel;
    public DemoExercise()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this,false);
        _foodDeliveryViewModel = (DemoViewModel)BindingContext;
        _foodDeliveryViewModel.SkipClickedEventHandler += FoodDeliveryViewModel_SkipClickedEventHandler;
    }
    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
    //    _foodDeliveryViewModel.CurrentPageSelected = _foodDeliveryViewModel.FoodData.FirstOrDefault();
    //}
    private async void FoodDeliveryViewModel_SkipClickedEventHandler(object sender, bool e)
    {
        if (e)
            await Navigation.PushAsync(new DashboardScreen());
    }
}