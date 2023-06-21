using C9_Exercises.ViewModel;

namespace C9_Exercises.View.Exercise2;

public partial class Exercise2 : ContentPage
{
	private LibraryViewModel _libraryViewModel;
	public Exercise2()
	{
		InitializeComponent();
		_libraryViewModel = (LibraryViewModel)BindingContext;
        _libraryViewModel.SkipClickedEventHandler += LibraryViewModel_SkipClickedEventHandler;

	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _libraryViewModel.ButtonText = "Next";
        _libraryViewModel.CurrentPageSelected = _libraryViewModel.LibraryData.FirstOrDefault();
    }

    private async void LibraryViewModel_SkipClickedEventHandler(object sender, bool e)
    {
		if (e)
			await Navigation.PushAsync(new DashboardScreen());
    }
}