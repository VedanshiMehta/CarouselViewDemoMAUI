using C9_Exercises.View;
using C9_Exercises.View.Exercise1;
using C9_Exercises.View.Exercise2;
using C9_Exercises.View.Exercise3;
using C9_Exercises.View.Exercise4;
using C9_Exercises.View.Exercise5;
using C9_Exercises.View.Exercise6;

namespace C9_Exercises;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new Exercise6())
		{
			BarBackgroundColor = Colors.WhiteSmoke,
		};
		
		
	}
}
