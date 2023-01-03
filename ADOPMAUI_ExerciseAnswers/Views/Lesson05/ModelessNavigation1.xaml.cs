namespace ADOPMAUI_Exercise.Views.Lesson05;

public partial class ModelessNavigation1 : ContentPage
{
	public ModelessNavigation1()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //Here the Navigation stack root is created
        await Navigation.PushAsync(new NavigationPage(new WebViewExercise1()));
    }
}