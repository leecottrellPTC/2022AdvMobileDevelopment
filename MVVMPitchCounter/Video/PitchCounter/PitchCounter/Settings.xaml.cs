namespace PitchCounter;

public partial class Settings : ContentPage
{

    void OnTeamChange(object sender, CheckedChangedEventArgs args)
    {
        if (sender.Equals(Astros))
        {
            Application.Current.Resources["TeamText"] = Application.Current.Resources["AstrosText"];
            Application.Current.Resources["TeamBack"] = Application.Current.Resources["AstrosBack"];
        }
        else if (sender.Equals(Phillies))
        {
            Application.Current.Resources["TeamText"] = Application.Current.Resources["PhilliesText"];
            Application.Current.Resources["TeamBack"] = Application.Current.Resources["PhilliesBack"];
        }
        else if (sender.Equals(Rockies))
        {
            Application.Current.Resources["TeamText"] = Application.Current.Resources["RockiesText"];
            Application.Current.Resources["TeamBack"] = Application.Current.Resources["RockiesBack"];
        }
        else
        {
            Application.Current.Resources["TeamText"] = Application.Current.Resources["PiratesText"];
            Application.Current.Resources["TeamBack"] = Application.Current.Resources["PiratesBack"];
        }

        Color text = (Color)Application.Current.Resources["TeamText"];
        Color back = (Color)Application.Current.Resources["TeamBack"];

        Preferences.Default.Set("TeamText", text.ToHex().ToString());
        Preferences.Default.Set("TeamBack", back.ToHex().ToString());




    }
    public Settings()
	{
		InitializeComponent();
	}
}