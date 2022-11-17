
using Microsoft.Maui.Storage;
namespace MVVMBaseballPitchCounter.Views;

public partial class Settings : ContentPage
{
	

    void OnTeamChange(object sender, CheckedChangedEventArgs args)
	{
        Color text;
        Color back;
		//Color text = new Color(), back;
		if (sender.Equals(Astros))
		{
			Application.Current.Resources["TeamText"] = Application.Current.Resources["AstrosText"];
            Application.Current.Resources["TeamBack"] = Application.Current.Resources["AstrosBack"];
        }
		else if (sender.Equals(Rockies))
		{
            Application.Current.Resources["TeamText"] = Application.Current.Resources["RockiesText"];
            Application.Current.Resources["TeamBack"] = Application.Current.Resources["RockiesBack"];
            
        }
        else if (sender.Equals(Phillies))
        {
            Application.Current.Resources["TeamText"] = Application.Current.Resources["PhilliesText"];
            Application.Current.Resources["TeamBack"] = Application.Current.Resources["PhilliesBack"];
        }
        else 
        {   //default to Pirates
            Application.Current.Resources["TeamText"] = Application.Current.Resources["PiratesText"];
            Application.Current.Resources["TeamBack"] = Application.Current.Resources["PiratesBack"];
        }

        text = (Color)Application.Current.Resources["TeamText"];
        back = (Color)Application.Current.Resources["TeamBack"];
        Preferences.Default.Set("TeamText", text.ToHex().ToString());
        Preferences.Default.Set("TeamBack", back.ToHex().ToString());

        //https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/storage/preferences?view=net-maui-7.0&tabs=windows

    }
    public Settings()
	{
		InitializeComponent();
	}
}