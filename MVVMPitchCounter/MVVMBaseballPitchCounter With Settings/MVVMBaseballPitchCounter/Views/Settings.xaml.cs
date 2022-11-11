

namespace MVVMBaseballPitchCounter.Views;

public partial class Settings : ContentPage
{
	

    void OnTeamChange(object sender, CheckedChangedEventArgs args)
	{
		Color text, back;
		if (sender.Equals(Astros))
		{
			//DisplayAlert("Team", "Astros picked", "OK");

			text = (Color)Application.Current.Resources["AstrosText"];
            back = (Color)Application.Current.Resources["AstrosBack"];
            Resources["TeamText"] = text;
            Resources["TeamBack"] = back;
        }
        
    }
	public Settings()
	{
		InitializeComponent();
	}
}