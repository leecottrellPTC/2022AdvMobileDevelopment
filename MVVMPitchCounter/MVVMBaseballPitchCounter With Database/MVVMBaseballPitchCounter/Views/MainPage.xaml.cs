
using Microsoft.Extensions.Configuration;


namespace MVVMBaseballPitchCounter;

public partial class MainPage : ContentPage
{


   
	public MainPage()
	{
		InitializeComponent();
        //Resources["TeamText"] = Color.FromHex("#eb6e1f");
        //Resources["TeamBack"] = Color.FromHex("#002d62");
        //https://www.youtube.com/watch?v=yMhoht9VaTM
        //await DisplayAlert("Hi", "Main pAge", "OK");
        
       Color text, back;
        if (Preferences.Default.ContainsKey("TeamText"))
        {
            text = Color.FromHex(Preferences.Default.Get("TeamText", "#FDB827"));
            back = Color.FromHex(Preferences.Default.Get("TeamBack", "#27251F"));
        }
        else
        {
            text = Color.FromHex("#FDB827");
            back = Color.FromHex("#27251F");
        }
        Application.Current.Resources["TeamText"] = text;
        Application.Current.Resources["TeamBack"] = back;
        




    }


}

