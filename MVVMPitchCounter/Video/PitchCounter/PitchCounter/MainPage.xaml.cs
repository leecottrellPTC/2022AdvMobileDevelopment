namespace PitchCounter;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

		Color text, back;
		if (Preferences.Default.ContainsKey("TeamText"))
		{
			text = Color.FromHex(Preferences.Default.Get("TeamText", "#fdb827"));
            back = Color.FromHex(Preferences.Default.Get("TeamBack", "#272f1f"));
        }
		else{
			text = Color.FromHex("#fdb827");
            back = Color.FromHex("#272f1f");
        }

		Application.Current.Resources["TeamText"] = text;
        Application.Current.Resources["TeamBack"] = back;
    }


}

