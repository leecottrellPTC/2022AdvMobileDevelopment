

namespace MVVMBaseballPitchCounter.Views;

public partial class Settings : ContentPage
{
	

    void OnTeamChange(object sender, CheckedChangedEventArgs args)
	{
		
		if (sender.Equals(Astros))
		{
			//DisplayAlert("Team", "Astros picked", "OK");
			Resources["TeamText"] = Color.FromHex(Resources["AstrosText"].ToString());
            Resources["TeamBack"] = Color.FromHex(Resources["AstrosBack"].ToString());
            
        }
	}
	public Settings()
	{
		InitializeComponent();
	}
}